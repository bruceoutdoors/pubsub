﻿// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: loadtest.proto
#pragma warning disable 1591
#region Designer generated code

using System;
using System.Threading;
using System.Threading.Tasks;
using grpc = global::Grpc.Core;

namespace Google.Pubsub.Loadtest
{
    public static partial class Loadtest
    {
        static readonly string __ServiceName = "google.pubsub.loadtest.Loadtest";

        static readonly grpc::Marshaller<global::Google.Pubsub.Loadtest.StartRequest> __Marshaller_StartRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Pubsub.Loadtest.StartRequest.Parser.ParseFrom);
        static readonly grpc::Marshaller<global::Google.Pubsub.Loadtest.StartResponse> __Marshaller_StartResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Pubsub.Loadtest.StartResponse.Parser.ParseFrom);
        static readonly grpc::Marshaller<global::Google.Pubsub.Loadtest.CheckRequest> __Marshaller_CheckRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Pubsub.Loadtest.CheckRequest.Parser.ParseFrom);
        static readonly grpc::Marshaller<global::Google.Pubsub.Loadtest.CheckResponse> __Marshaller_CheckResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Pubsub.Loadtest.CheckResponse.Parser.ParseFrom);

        static readonly grpc::Method<global::Google.Pubsub.Loadtest.StartRequest, global::Google.Pubsub.Loadtest.StartResponse> __Method_Start = new grpc::Method<global::Google.Pubsub.Loadtest.StartRequest, global::Google.Pubsub.Loadtest.StartResponse>(
            grpc::MethodType.Unary,
            __ServiceName,
            "Start",
            __Marshaller_StartRequest,
            __Marshaller_StartResponse);

        static readonly grpc::Method<global::Google.Pubsub.Loadtest.CheckRequest, global::Google.Pubsub.Loadtest.CheckResponse> __Method_Check = new grpc::Method<global::Google.Pubsub.Loadtest.CheckRequest, global::Google.Pubsub.Loadtest.CheckResponse>(
            grpc::MethodType.Unary,
            __ServiceName,
            "Check",
            __Marshaller_CheckRequest,
            __Marshaller_CheckResponse);

        /// <summary>Service descriptor</summary>
        public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
        {
            get { return global::Google.Pubsub.Loadtest.LoadtestReflection.Descriptor.Services[0]; }
        }

        /// <summary>Base class for server-side implementations of Loadtest</summary>
        public abstract partial class LoadtestBase
        {
            /// <summary>
            /// Starts a load test
            /// </summary>
            /// <param name="request">The request received from the client.</param>
            /// <param name="context">The context of the server-side call handler being invoked.</param>
            /// <returns>The response to send back to the client (wrapped by a task).</returns>
            public virtual global::System.Threading.Tasks.Task<global::Google.Pubsub.Loadtest.StartResponse> Start(global::Google.Pubsub.Loadtest.StartRequest request, grpc::ServerCallContext context)
            {
                throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
            }

            /// <summary>
            /// Checks the status of a load test
            /// </summary>
            /// <param name="request">The request received from the client.</param>
            /// <param name="context">The context of the server-side call handler being invoked.</param>
            /// <returns>The response to send back to the client (wrapped by a task).</returns>
            public virtual global::System.Threading.Tasks.Task<global::Google.Pubsub.Loadtest.CheckResponse> Check(global::Google.Pubsub.Loadtest.CheckRequest request, grpc::ServerCallContext context)
            {
                throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
            }

        }

        /// <summary>Client for Loadtest</summary>
        public partial class LoadtestClient : grpc::ClientBase<LoadtestClient>
        {
            /// <summary>Creates a new client for Loadtest</summary>
            /// <param name="channel">The channel to use to make remote calls.</param>
            public LoadtestClient(grpc::Channel channel) : base(channel)
            {
            }
            /// <summary>Creates a new client for Loadtest that uses a custom <c>CallInvoker</c>.</summary>
            /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
            public LoadtestClient(grpc::CallInvoker callInvoker) : base(callInvoker)
            {
            }
            /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
            protected LoadtestClient() : base()
            {
            }
            /// <summary>Protected constructor to allow creation of configured clients.</summary>
            /// <param name="configuration">The client configuration.</param>
            protected LoadtestClient(ClientBaseConfiguration configuration) : base(configuration)
            {
            }

            /// <summary>
            /// Starts a load test
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual global::Google.Pubsub.Loadtest.StartResponse Start(global::Google.Pubsub.Loadtest.StartRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
            {
                return Start(request, new grpc::CallOptions(headers, deadline, cancellationToken));
            }
            /// <summary>
            /// Starts a load test
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual global::Google.Pubsub.Loadtest.StartResponse Start(global::Google.Pubsub.Loadtest.StartRequest request, grpc::CallOptions options)
            {
                return CallInvoker.BlockingUnaryCall(__Method_Start, null, options, request);
            }
            /// <summary>
            /// Starts a load test
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual grpc::AsyncUnaryCall<global::Google.Pubsub.Loadtest.StartResponse> StartAsync(global::Google.Pubsub.Loadtest.StartRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
            {
                return StartAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
            }
            /// <summary>
            /// Starts a load test
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual grpc::AsyncUnaryCall<global::Google.Pubsub.Loadtest.StartResponse> StartAsync(global::Google.Pubsub.Loadtest.StartRequest request, grpc::CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_Start, null, options, request);
            }
            /// <summary>
            /// Checks the status of a load test
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual global::Google.Pubsub.Loadtest.CheckResponse Check(global::Google.Pubsub.Loadtest.CheckRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
            {
                return Check(request, new grpc::CallOptions(headers, deadline, cancellationToken));
            }
            /// <summary>
            /// Checks the status of a load test
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual global::Google.Pubsub.Loadtest.CheckResponse Check(global::Google.Pubsub.Loadtest.CheckRequest request, grpc::CallOptions options)
            {
                return CallInvoker.BlockingUnaryCall(__Method_Check, null, options, request);
            }
            /// <summary>
            /// Checks the status of a load test
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual grpc::AsyncUnaryCall<global::Google.Pubsub.Loadtest.CheckResponse> CheckAsync(global::Google.Pubsub.Loadtest.CheckRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
            {
                return CheckAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
            }
            /// <summary>
            /// Checks the status of a load test
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual grpc::AsyncUnaryCall<global::Google.Pubsub.Loadtest.CheckResponse> CheckAsync(global::Google.Pubsub.Loadtest.CheckRequest request, grpc::CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_Check, null, options, request);
            }
            /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
            protected override LoadtestClient NewInstance(ClientBaseConfiguration configuration)
            {
                return new LoadtestClient(configuration);
            }
        }

        /// <summary>Creates service definition that can be registered with a server</summary>
        /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
        public static grpc::ServerServiceDefinition BindService(LoadtestBase serviceImpl)
        {
            return grpc::ServerServiceDefinition.CreateBuilder()
                .AddMethod(__Method_Start, serviceImpl.Start)
                .AddMethod(__Method_Check, serviceImpl.Check).Build();
        }

    }
    public static partial class LoadtestWorker
    {
        static readonly string __ServiceName = "google.pubsub.loadtest.LoadtestWorker";

        static readonly grpc::Marshaller<global::Google.Pubsub.Loadtest.StartRequest> __Marshaller_StartRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Pubsub.Loadtest.StartRequest.Parser.ParseFrom);
        static readonly grpc::Marshaller<global::Google.Pubsub.Loadtest.StartResponse> __Marshaller_StartResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Pubsub.Loadtest.StartResponse.Parser.ParseFrom);
        static readonly grpc::Marshaller<global::Google.Pubsub.Loadtest.ExecuteRequest> __Marshaller_ExecuteRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Pubsub.Loadtest.ExecuteRequest.Parser.ParseFrom);
        static readonly grpc::Marshaller<global::Google.Pubsub.Loadtest.ExecuteResponse> __Marshaller_ExecuteResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Pubsub.Loadtest.ExecuteResponse.Parser.ParseFrom);

        static readonly grpc::Method<global::Google.Pubsub.Loadtest.StartRequest, global::Google.Pubsub.Loadtest.StartResponse> __Method_Start = new grpc::Method<global::Google.Pubsub.Loadtest.StartRequest, global::Google.Pubsub.Loadtest.StartResponse>(
            grpc::MethodType.Unary,
            __ServiceName,
            "Start",
            __Marshaller_StartRequest,
            __Marshaller_StartResponse);

        static readonly grpc::Method<global::Google.Pubsub.Loadtest.ExecuteRequest, global::Google.Pubsub.Loadtest.ExecuteResponse> __Method_Execute = new grpc::Method<global::Google.Pubsub.Loadtest.ExecuteRequest, global::Google.Pubsub.Loadtest.ExecuteResponse>(
            grpc::MethodType.Unary,
            __ServiceName,
            "Execute",
            __Marshaller_ExecuteRequest,
            __Marshaller_ExecuteResponse);

        /// <summary>Service descriptor</summary>
        public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
        {
            get { return global::Google.Pubsub.Loadtest.LoadtestReflection.Descriptor.Services[1]; }
        }

        /// <summary>Base class for server-side implementations of LoadtestWorker</summary>
        public abstract partial class LoadtestWorkerBase
        {
            /// <summary>
            /// Starts a worker
            /// </summary>
            /// <param name="request">The request received from the client.</param>
            /// <param name="context">The context of the server-side call handler being invoked.</param>
            /// <returns>The response to send back to the client (wrapped by a task).</returns>
            public virtual global::System.Threading.Tasks.Task<global::Google.Pubsub.Loadtest.StartResponse> Start(global::Google.Pubsub.Loadtest.StartRequest request, grpc::ServerCallContext context)
            {
                throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
            }

            /// <summary>
            /// Executes a command on the worker, returning the latencies of the operations. Since some
            /// commands consist of multiple operations (i.e. pulls contain many received messages with
            /// different end to end latencies) a single command can have multiple latencies returned.
            /// </summary>
            /// <param name="request">The request received from the client.</param>
            /// <param name="context">The context of the server-side call handler being invoked.</param>
            /// <returns>The response to send back to the client (wrapped by a task).</returns>
            public virtual global::System.Threading.Tasks.Task<global::Google.Pubsub.Loadtest.ExecuteResponse> Execute(global::Google.Pubsub.Loadtest.ExecuteRequest request, grpc::ServerCallContext context)
            {
                throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
            }

        }

        /// <summary>Client for LoadtestWorker</summary>
        public partial class LoadtestWorkerClient : grpc::ClientBase<LoadtestWorkerClient>
        {
            /// <summary>Creates a new client for LoadtestWorker</summary>
            /// <param name="channel">The channel to use to make remote calls.</param>
            public LoadtestWorkerClient(grpc::Channel channel) : base(channel)
            {
            }
            /// <summary>Creates a new client for LoadtestWorker that uses a custom <c>CallInvoker</c>.</summary>
            /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
            public LoadtestWorkerClient(grpc::CallInvoker callInvoker) : base(callInvoker)
            {
            }
            /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
            protected LoadtestWorkerClient() : base()
            {
            }
            /// <summary>Protected constructor to allow creation of configured clients.</summary>
            /// <param name="configuration">The client configuration.</param>
            protected LoadtestWorkerClient(ClientBaseConfiguration configuration) : base(configuration)
            {
            }

            /// <summary>
            /// Starts a worker
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual global::Google.Pubsub.Loadtest.StartResponse Start(global::Google.Pubsub.Loadtest.StartRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
            {
                return Start(request, new grpc::CallOptions(headers, deadline, cancellationToken));
            }
            /// <summary>
            /// Starts a worker
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual global::Google.Pubsub.Loadtest.StartResponse Start(global::Google.Pubsub.Loadtest.StartRequest request, grpc::CallOptions options)
            {
                return CallInvoker.BlockingUnaryCall(__Method_Start, null, options, request);
            }
            /// <summary>
            /// Starts a worker
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual grpc::AsyncUnaryCall<global::Google.Pubsub.Loadtest.StartResponse> StartAsync(global::Google.Pubsub.Loadtest.StartRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
            {
                return StartAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
            }
            /// <summary>
            /// Starts a worker
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual grpc::AsyncUnaryCall<global::Google.Pubsub.Loadtest.StartResponse> StartAsync(global::Google.Pubsub.Loadtest.StartRequest request, grpc::CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_Start, null, options, request);
            }
            /// <summary>
            /// Executes a command on the worker, returning the latencies of the operations. Since some
            /// commands consist of multiple operations (i.e. pulls contain many received messages with
            /// different end to end latencies) a single command can have multiple latencies returned.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual global::Google.Pubsub.Loadtest.ExecuteResponse Execute(global::Google.Pubsub.Loadtest.ExecuteRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
            {
                return Execute(request, new grpc::CallOptions(headers, deadline, cancellationToken));
            }
            /// <summary>
            /// Executes a command on the worker, returning the latencies of the operations. Since some
            /// commands consist of multiple operations (i.e. pulls contain many received messages with
            /// different end to end latencies) a single command can have multiple latencies returned.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The response received from the server.</returns>
            public virtual global::Google.Pubsub.Loadtest.ExecuteResponse Execute(global::Google.Pubsub.Loadtest.ExecuteRequest request, grpc::CallOptions options)
            {
                return CallInvoker.BlockingUnaryCall(__Method_Execute, null, options, request);
            }
            /// <summary>
            /// Executes a command on the worker, returning the latencies of the operations. Since some
            /// commands consist of multiple operations (i.e. pulls contain many received messages with
            /// different end to end latencies) a single command can have multiple latencies returned.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
            /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>The call object.</returns>
            public virtual grpc::AsyncUnaryCall<global::Google.Pubsub.Loadtest.ExecuteResponse> ExecuteAsync(global::Google.Pubsub.Loadtest.ExecuteRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
            {
                return ExecuteAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
            }
            /// <summary>
            /// Executes a command on the worker, returning the latencies of the operations. Since some
            /// commands consist of multiple operations (i.e. pulls contain many received messages with
            /// different end to end latencies) a single command can have multiple latencies returned.
            /// </summary>
            /// <param name="request">The request to send to the server.</param>
            /// <param name="options">The options for the call.</param>
            /// <returns>The call object.</returns>
            public virtual grpc::AsyncUnaryCall<global::Google.Pubsub.Loadtest.ExecuteResponse> ExecuteAsync(global::Google.Pubsub.Loadtest.ExecuteRequest request, grpc::CallOptions options)
            {
                return CallInvoker.AsyncUnaryCall(__Method_Execute, null, options, request);
            }
            /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
            protected override LoadtestWorkerClient NewInstance(ClientBaseConfiguration configuration)
            {
                return new LoadtestWorkerClient(configuration);
            }
        }

        /// <summary>Creates service definition that can be registered with a server</summary>
        /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
        public static grpc::ServerServiceDefinition BindService(LoadtestWorkerBase serviceImpl)
        {
            return grpc::ServerServiceDefinition.CreateBuilder()
                .AddMethod(__Method_Start, serviceImpl.Start)
                .AddMethod(__Method_Execute, serviceImpl.Execute).Build();
        }

    }
}
#endregion