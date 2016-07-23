// Copyright 2016 Google Inc.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//      http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
////////////////////////////////////////////////////////////////////////////////
package com.google.pubsub.kafka.source;

import com.google.common.annotations.VisibleForTesting;
import com.google.common.util.concurrent.FutureCallback;
import com.google.common.util.concurrent.Futures;
import com.google.common.util.concurrent.ListenableFuture;
import com.google.protobuf.ByteString;
import com.google.protobuf.Empty;
import com.google.pubsub.kafka.common.ConnectorUtils;
import com.google.pubsub.kafka.source.CloudPubSubSourceConnector.PartitionScheme;
import com.google.pubsub.v1.AcknowledgeRequest;
import com.google.pubsub.v1.PubsubMessage;
import com.google.pubsub.v1.PullRequest;
import com.google.pubsub.v1.PullResponse;
import com.google.pubsub.v1.ReceivedMessage;
import java.util.ArrayList;
import java.util.Collections;
import java.util.HashSet;
import java.util.List;
import java.util.Map;
import java.util.Set;
import org.apache.kafka.connect.data.SchemaBuilder;
import org.apache.kafka.connect.source.SourceRecord;
import org.apache.kafka.connect.source.SourceTask;
import org.slf4j.Logger;
import org.slf4j.LoggerFactory;

/**
 * A {@link SourceTask} used by a {@link CloudPubSubSourceConnector} to write messages to <a
 * href="http://kafka.apache.org/">Apache Kafka</a>.
 */
public class CloudPubSubSourceTask extends SourceTask {

  private static final Logger log = LoggerFactory.getLogger(CloudPubSubSourceTask.class);
  private static final int NUM_SUBSCRIBERS = 10;

  private String keyAttribute;
  private String kafkaTopic;
  private String cpsTopic;
  private String cpsSubscription;
  private int maxBatchSize;
  private int partitions;
  private PartitionScheme partitionScheme;
  private CloudPubSubSubscriber subscriber;
  private Set<String> ackIds = Collections.synchronizedSet(new HashSet<>());
  private int currentRoundRobinPartition = 0;

  @Override
  public String version() {
    return new CloudPubSubSourceConnector().version();
  }

  @Override
  public void start(Map<String, String> props) {
    cpsTopic =
        String.format(
            ConnectorUtils.CPS_TOPIC_FORMAT,
            props.get(ConnectorUtils.CPS_PROJECT_CONFIG),
            props.get(ConnectorUtils.CPS_TOPIC_CONFIG));
    maxBatchSize =
        Integer.parseInt(props.get(CloudPubSubSourceConnector.CPS_MAX_BATCH_SIZE_CONFIG));
    partitions = Integer.parseInt(props.get(CloudPubSubSourceConnector.KAFKA_PARTITIONS_CONFIG));
    subscriber = new CloudPubSubRoundRobinSubscriber(NUM_SUBSCRIBERS);
    cpsSubscription = props.get(CloudPubSubSourceConnector.CPS_SUBSCRIPTION_CONFIG);
    kafkaTopic = props.get(CloudPubSubSourceConnector.KAFKA_TOPIC_CONFIG);
    keyAttribute = props.get(CloudPubSubSourceConnector.KAFKA_MESSAGE_KEY_CONFIG);
    partitionScheme =
        PartitionScheme.valueOf(
            props.get(CloudPubSubSourceConnector.KAFKA_PARTITION_SCHEME_CONFIG));
    log.info("Start connector task for topic " + cpsTopic + " max batch size = " + maxBatchSize);
  }

  @Override
  public List<SourceRecord> poll() throws InterruptedException {
    ackMessages();
    PullRequest request =
        PullRequest.newBuilder()
            .setSubscription(cpsSubscription)
            .setReturnImmediately(false)
            .setMaxMessages(maxBatchSize)
            .build();
    try {
      PullResponse response = subscriber.pull(request).get();
      // Stores ackIds for all received messages.
      List<SourceRecord> sourceRecords = new ArrayList<>();
      for (ReceivedMessage rm : response.getReceivedMessagesList()) {
        PubsubMessage message = rm.getMessage();
        String ackId = rm.getAckId();
        // If we are receiving this message a second (or more) times because the ack for it failed
        // then do not create a SourceRecord for this message.
        if (ackIds.contains(ackId)) {
          continue;
        }
        // Get the message attributes and parse out the relevant ones.
        Map<String, String> messageAttributes = message.getAttributes();
        String key = null;
        if (messageAttributes.get(keyAttribute) != null) {
          key = messageAttributes.get(keyAttribute);
        }
        ByteString value = message.getData();
        // We don't need to check that the message data is a byte string because we know the
        // data is coming from CPS so it must be of that type.
        SourceRecord record =
            new SourceRecord(
                null,
                null,
                kafkaTopic,
                selectPartition(key, value),
                SchemaBuilder.string().build(),
                key,
                SchemaBuilder.bytes().name(ConnectorUtils.SCHEMA_NAME).build(),
                value);
        sourceRecords.add(record);
      }
      return sourceRecords;
    } catch (Exception e) {
      throw new InterruptedException(e.getMessage());
    }
  }

  private void ackMessages() {
    if (ackIds.size() != 0) {
      AcknowledgeRequest request =
          AcknowledgeRequest.newBuilder()
              .setSubscription(cpsSubscription)
              .addAllAckIds(ackIds)
              .build();
      ListenableFuture<Empty> response = subscriber.ackMessages(request);
      Futures.addCallback(
          response,
          new FutureCallback<Empty>() {
            @Override
            public void onSuccess(Empty result) {
              ackIds.clear();
            }

            @Override
            public void onFailure(Throwable t) {
              log.error("An exception occurred acking messages. Will try to ack messages again.");
            }
          });
    }
  }

  private int selectPartition(Object key, Object value) {
    if (partitionScheme.equals(PartitionScheme.HASH_KEY)) {
      return key == null ? 0 : key.hashCode() % partitions;
    } else if (partitionScheme.equals(PartitionScheme.HASH_VALUE)) {
      return value.hashCode() % partitions;
    } else {
      return currentRoundRobinPartition++ % partitions;
    }
  }

  @Override
  public void stop() {}
}