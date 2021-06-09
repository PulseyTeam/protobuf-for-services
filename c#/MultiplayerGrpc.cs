// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: multiplayer.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace MultiplayerService {
  public static partial class MultiplayerService
  {
    static readonly string __ServiceName = "MultiplayerService";

    static readonly grpc::Marshaller<global::MultiplayerService.RoomConnectRequest> __Marshaller_RoomConnectRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::MultiplayerService.RoomConnectRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::MultiplayerService.RoomConnectResponse> __Marshaller_RoomConnectResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::MultiplayerService.RoomConnectResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::MultiplayerService.RoomStreamRequest> __Marshaller_RoomStreamRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::MultiplayerService.RoomStreamRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::MultiplayerService.RoomStreamResponse> __Marshaller_RoomStreamResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::MultiplayerService.RoomStreamResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::MultiplayerService.RoomConnectRequest, global::MultiplayerService.RoomConnectResponse> __Method_RoomConnect = new grpc::Method<global::MultiplayerService.RoomConnectRequest, global::MultiplayerService.RoomConnectResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "RoomConnect",
        __Marshaller_RoomConnectRequest,
        __Marshaller_RoomConnectResponse);

    static readonly grpc::Method<global::MultiplayerService.RoomStreamRequest, global::MultiplayerService.RoomStreamResponse> __Method_RoomStream = new grpc::Method<global::MultiplayerService.RoomStreamRequest, global::MultiplayerService.RoomStreamResponse>(
        grpc::MethodType.DuplexStreaming,
        __ServiceName,
        "RoomStream",
        __Marshaller_RoomStreamRequest,
        __Marshaller_RoomStreamResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::MultiplayerService.MultiplayerReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of MultiplayerService</summary>
    [grpc::BindServiceMethod(typeof(MultiplayerService), "BindService")]
    public abstract partial class MultiplayerServiceBase
    {
      public virtual global::System.Threading.Tasks.Task<global::MultiplayerService.RoomConnectResponse> RoomConnect(global::MultiplayerService.RoomConnectRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task RoomStream(grpc::IAsyncStreamReader<global::MultiplayerService.RoomStreamRequest> requestStream, grpc::IServerStreamWriter<global::MultiplayerService.RoomStreamResponse> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for MultiplayerService</summary>
    public partial class MultiplayerServiceClient : grpc::ClientBase<MultiplayerServiceClient>
    {
      /// <summary>Creates a new client for MultiplayerService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public MultiplayerServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for MultiplayerService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public MultiplayerServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected MultiplayerServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected MultiplayerServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::MultiplayerService.RoomConnectResponse RoomConnect(global::MultiplayerService.RoomConnectRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return RoomConnect(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::MultiplayerService.RoomConnectResponse RoomConnect(global::MultiplayerService.RoomConnectRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_RoomConnect, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::MultiplayerService.RoomConnectResponse> RoomConnectAsync(global::MultiplayerService.RoomConnectRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return RoomConnectAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::MultiplayerService.RoomConnectResponse> RoomConnectAsync(global::MultiplayerService.RoomConnectRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_RoomConnect, null, options, request);
      }
      public virtual grpc::AsyncDuplexStreamingCall<global::MultiplayerService.RoomStreamRequest, global::MultiplayerService.RoomStreamResponse> RoomStream(grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return RoomStream(new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncDuplexStreamingCall<global::MultiplayerService.RoomStreamRequest, global::MultiplayerService.RoomStreamResponse> RoomStream(grpc::CallOptions options)
      {
        return CallInvoker.AsyncDuplexStreamingCall(__Method_RoomStream, null, options);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override MultiplayerServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new MultiplayerServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(MultiplayerServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_RoomConnect, serviceImpl.RoomConnect)
          .AddMethod(__Method_RoomStream, serviceImpl.RoomStream).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, MultiplayerServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_RoomConnect, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::MultiplayerService.RoomConnectRequest, global::MultiplayerService.RoomConnectResponse>(serviceImpl.RoomConnect));
      serviceBinder.AddMethod(__Method_RoomStream, serviceImpl == null ? null : new grpc::DuplexStreamingServerMethod<global::MultiplayerService.RoomStreamRequest, global::MultiplayerService.RoomStreamResponse>(serviceImpl.RoomStream));
    }

  }
}
#endregion
