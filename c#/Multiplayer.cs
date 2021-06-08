// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: multiplayer.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MultiplayerService {

  /// <summary>Holder for reflection information generated from multiplayer.proto</summary>
  public static partial class MultiplayerReflection {

    #region Descriptor
    /// <summary>File descriptor for multiplayer.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MultiplayerReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFtdWx0aXBsYXllci5wcm90bxIPcHVsc2V5LnByb3RvYnVmIoABCgZQbGF5",
            "ZXISCgoCaWQYASABKAkSDAoEbmFtZRgCIAEoCRItCghwb3NpdGlvbhgDIAEo",
            "CzIbLnB1bHNleS5wcm90b2J1Zi5Db29yZGluYXRlEi0KCWRpcmVjdGlvbhgF",
            "IAEoDjIaLnB1bHNleS5wcm90b2J1Zi5EaXJlY3Rpb24iIgoKQ29vcmRpbmF0",
            "ZRIJCgF4GAEgASgCEgkKAXkYAiABKAIiJAoSUm9vbUNvbm5lY3RSZXF1ZXN0",
            "Eg4KBm1hcF9pZBgBIAEoCSImChNSb29tQ29ubmVjdFJlc3BvbnNlEg8KB3Jv",
            "b21faWQYASABKAkiTQoRUm9vbVN0cmVhbVJlcXVlc3QSJwoGcGxheWVyGAEg",
            "ASgLMhcucHVsc2V5LnByb3RvYnVmLlBsYXllchIPCgdyb29tX2lkGAIgASgJ",
            "Ij4KElJvb21TdHJlYW1SZXNwb25zZRIoCgdwbGF5ZXJzGAEgAygLMhcucHVs",
            "c2V5LnByb3RvYnVmLlBsYXllcio8CglEaXJlY3Rpb24SBgoCVVAQABIICgRE",
            "T1dOEAESCAoETEVGVBACEgkKBVJJR0hUEAMSCAoEU1RPUBAEMskBChJNdWx0",
            "aXBsYXllclNlcnZpY2USWAoLUm9vbUNvbm5lY3QSIy5wdWxzZXkucHJvdG9i",
            "dWYuUm9vbUNvbm5lY3RSZXF1ZXN0GiQucHVsc2V5LnByb3RvYnVmLlJvb21D",
            "b25uZWN0UmVzcG9uc2USWQoKUm9vbVN0cmVhbRIiLnB1bHNleS5wcm90b2J1",
            "Zi5Sb29tU3RyZWFtUmVxdWVzdBojLnB1bHNleS5wcm90b2J1Zi5Sb29tU3Ry",
            "ZWFtUmVzcG9uc2UoATABQh9aCC4vO3Byb3RvqgISTXVsdGlwbGF5ZXJTZXJ2",
            "aWNlYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::MultiplayerService.Direction), }, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MultiplayerService.Player), global::MultiplayerService.Player.Parser, new[]{ "Id", "Name", "Position", "Direction" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::MultiplayerService.Coordinate), global::MultiplayerService.Coordinate.Parser, new[]{ "X", "Y" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::MultiplayerService.RoomConnectRequest), global::MultiplayerService.RoomConnectRequest.Parser, new[]{ "MapId" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::MultiplayerService.RoomConnectResponse), global::MultiplayerService.RoomConnectResponse.Parser, new[]{ "RoomId" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::MultiplayerService.RoomStreamRequest), global::MultiplayerService.RoomStreamRequest.Parser, new[]{ "Player", "RoomId" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::MultiplayerService.RoomStreamResponse), global::MultiplayerService.RoomStreamResponse.Parser, new[]{ "Players" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Enums
  public enum Direction {
    [pbr::OriginalName("UP")] Up = 0,
    [pbr::OriginalName("DOWN")] Down = 1,
    [pbr::OriginalName("LEFT")] Left = 2,
    [pbr::OriginalName("RIGHT")] Right = 3,
    [pbr::OriginalName("STOP")] Stop = 4,
  }

  #endregion

  #region Messages
  public sealed partial class Player : pb::IMessage<Player> {
    private static readonly pb::MessageParser<Player> _parser = new pb::MessageParser<Player>(() => new Player());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Player> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MultiplayerService.MultiplayerReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Player() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Player(Player other) : this() {
      id_ = other.id_;
      name_ = other.name_;
      position_ = other.position_ != null ? other.position_.Clone() : null;
      direction_ = other.direction_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Player Clone() {
      return new Player(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private string id_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Id {
      get { return id_; }
      set {
        id_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 2;
    private string name_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "position" field.</summary>
    public const int PositionFieldNumber = 3;
    private global::MultiplayerService.Coordinate position_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::MultiplayerService.Coordinate Position {
      get { return position_; }
      set {
        position_ = value;
      }
    }

    /// <summary>Field number for the "direction" field.</summary>
    public const int DirectionFieldNumber = 5;
    private global::MultiplayerService.Direction direction_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::MultiplayerService.Direction Direction {
      get { return direction_; }
      set {
        direction_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Player);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Player other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (Name != other.Name) return false;
      if (!object.Equals(Position, other.Position)) return false;
      if (Direction != other.Direction) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id.Length != 0) hash ^= Id.GetHashCode();
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (position_ != null) hash ^= Position.GetHashCode();
      if (Direction != 0) hash ^= Direction.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Id.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Id);
      }
      if (Name.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Name);
      }
      if (position_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Position);
      }
      if (Direction != 0) {
        output.WriteRawTag(40);
        output.WriteEnum((int) Direction);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Id.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Id);
      }
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (position_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Position);
      }
      if (Direction != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Direction);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Player other) {
      if (other == null) {
        return;
      }
      if (other.Id.Length != 0) {
        Id = other.Id;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.position_ != null) {
        if (position_ == null) {
          Position = new global::MultiplayerService.Coordinate();
        }
        Position.MergeFrom(other.Position);
      }
      if (other.Direction != 0) {
        Direction = other.Direction;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Id = input.ReadString();
            break;
          }
          case 18: {
            Name = input.ReadString();
            break;
          }
          case 26: {
            if (position_ == null) {
              Position = new global::MultiplayerService.Coordinate();
            }
            input.ReadMessage(Position);
            break;
          }
          case 40: {
            Direction = (global::MultiplayerService.Direction) input.ReadEnum();
            break;
          }
        }
      }
    }

  }

  public sealed partial class Coordinate : pb::IMessage<Coordinate> {
    private static readonly pb::MessageParser<Coordinate> _parser = new pb::MessageParser<Coordinate>(() => new Coordinate());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Coordinate> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MultiplayerService.MultiplayerReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Coordinate() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Coordinate(Coordinate other) : this() {
      x_ = other.x_;
      y_ = other.y_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Coordinate Clone() {
      return new Coordinate(this);
    }

    /// <summary>Field number for the "x" field.</summary>
    public const int XFieldNumber = 1;
    private float x_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float X {
      get { return x_; }
      set {
        x_ = value;
      }
    }

    /// <summary>Field number for the "y" field.</summary>
    public const int YFieldNumber = 2;
    private float y_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float Y {
      get { return y_; }
      set {
        y_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Coordinate);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Coordinate other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(X, other.X)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Y, other.Y)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (X != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(X);
      if (Y != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Y);
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (X != 0F) {
        output.WriteRawTag(13);
        output.WriteFloat(X);
      }
      if (Y != 0F) {
        output.WriteRawTag(21);
        output.WriteFloat(Y);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (X != 0F) {
        size += 1 + 4;
      }
      if (Y != 0F) {
        size += 1 + 4;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Coordinate other) {
      if (other == null) {
        return;
      }
      if (other.X != 0F) {
        X = other.X;
      }
      if (other.Y != 0F) {
        Y = other.Y;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 13: {
            X = input.ReadFloat();
            break;
          }
          case 21: {
            Y = input.ReadFloat();
            break;
          }
        }
      }
    }

  }

  public sealed partial class RoomConnectRequest : pb::IMessage<RoomConnectRequest> {
    private static readonly pb::MessageParser<RoomConnectRequest> _parser = new pb::MessageParser<RoomConnectRequest>(() => new RoomConnectRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<RoomConnectRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MultiplayerService.MultiplayerReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RoomConnectRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RoomConnectRequest(RoomConnectRequest other) : this() {
      mapId_ = other.mapId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RoomConnectRequest Clone() {
      return new RoomConnectRequest(this);
    }

    /// <summary>Field number for the "map_id" field.</summary>
    public const int MapIdFieldNumber = 1;
    private string mapId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string MapId {
      get { return mapId_; }
      set {
        mapId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as RoomConnectRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(RoomConnectRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (MapId != other.MapId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (MapId.Length != 0) hash ^= MapId.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (MapId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(MapId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (MapId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(MapId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(RoomConnectRequest other) {
      if (other == null) {
        return;
      }
      if (other.MapId.Length != 0) {
        MapId = other.MapId;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            MapId = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class RoomConnectResponse : pb::IMessage<RoomConnectResponse> {
    private static readonly pb::MessageParser<RoomConnectResponse> _parser = new pb::MessageParser<RoomConnectResponse>(() => new RoomConnectResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<RoomConnectResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MultiplayerService.MultiplayerReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RoomConnectResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RoomConnectResponse(RoomConnectResponse other) : this() {
      roomId_ = other.roomId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RoomConnectResponse Clone() {
      return new RoomConnectResponse(this);
    }

    /// <summary>Field number for the "room_id" field.</summary>
    public const int RoomIdFieldNumber = 1;
    private string roomId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string RoomId {
      get { return roomId_; }
      set {
        roomId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as RoomConnectResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(RoomConnectResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (RoomId != other.RoomId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (RoomId.Length != 0) hash ^= RoomId.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (RoomId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(RoomId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (RoomId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(RoomId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(RoomConnectResponse other) {
      if (other == null) {
        return;
      }
      if (other.RoomId.Length != 0) {
        RoomId = other.RoomId;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            RoomId = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class RoomStreamRequest : pb::IMessage<RoomStreamRequest> {
    private static readonly pb::MessageParser<RoomStreamRequest> _parser = new pb::MessageParser<RoomStreamRequest>(() => new RoomStreamRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<RoomStreamRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MultiplayerService.MultiplayerReflection.Descriptor.MessageTypes[4]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RoomStreamRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RoomStreamRequest(RoomStreamRequest other) : this() {
      player_ = other.player_ != null ? other.player_.Clone() : null;
      roomId_ = other.roomId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RoomStreamRequest Clone() {
      return new RoomStreamRequest(this);
    }

    /// <summary>Field number for the "player" field.</summary>
    public const int PlayerFieldNumber = 1;
    private global::MultiplayerService.Player player_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::MultiplayerService.Player Player {
      get { return player_; }
      set {
        player_ = value;
      }
    }

    /// <summary>Field number for the "room_id" field.</summary>
    public const int RoomIdFieldNumber = 2;
    private string roomId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string RoomId {
      get { return roomId_; }
      set {
        roomId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as RoomStreamRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(RoomStreamRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Player, other.Player)) return false;
      if (RoomId != other.RoomId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (player_ != null) hash ^= Player.GetHashCode();
      if (RoomId.Length != 0) hash ^= RoomId.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (player_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Player);
      }
      if (RoomId.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(RoomId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (player_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Player);
      }
      if (RoomId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(RoomId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(RoomStreamRequest other) {
      if (other == null) {
        return;
      }
      if (other.player_ != null) {
        if (player_ == null) {
          Player = new global::MultiplayerService.Player();
        }
        Player.MergeFrom(other.Player);
      }
      if (other.RoomId.Length != 0) {
        RoomId = other.RoomId;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            if (player_ == null) {
              Player = new global::MultiplayerService.Player();
            }
            input.ReadMessage(Player);
            break;
          }
          case 18: {
            RoomId = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class RoomStreamResponse : pb::IMessage<RoomStreamResponse> {
    private static readonly pb::MessageParser<RoomStreamResponse> _parser = new pb::MessageParser<RoomStreamResponse>(() => new RoomStreamResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<RoomStreamResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MultiplayerService.MultiplayerReflection.Descriptor.MessageTypes[5]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RoomStreamResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RoomStreamResponse(RoomStreamResponse other) : this() {
      players_ = other.players_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RoomStreamResponse Clone() {
      return new RoomStreamResponse(this);
    }

    /// <summary>Field number for the "players" field.</summary>
    public const int PlayersFieldNumber = 1;
    private static readonly pb::FieldCodec<global::MultiplayerService.Player> _repeated_players_codec
        = pb::FieldCodec.ForMessage(10, global::MultiplayerService.Player.Parser);
    private readonly pbc::RepeatedField<global::MultiplayerService.Player> players_ = new pbc::RepeatedField<global::MultiplayerService.Player>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::MultiplayerService.Player> Players {
      get { return players_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as RoomStreamResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(RoomStreamResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!players_.Equals(other.players_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= players_.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      players_.WriteTo(output, _repeated_players_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += players_.CalculateSize(_repeated_players_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(RoomStreamResponse other) {
      if (other == null) {
        return;
      }
      players_.Add(other.players_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            players_.AddEntriesFrom(input, _repeated_players_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code