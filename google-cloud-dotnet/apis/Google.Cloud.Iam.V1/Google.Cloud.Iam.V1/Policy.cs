// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/iam/v1/policy.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.Iam.V1 {

  /// <summary>Holder for reflection information generated from google/iam/v1/policy.proto</summary>
  public static partial class PolicyReflection {

    #region Descriptor
    /// <summary>File descriptor for google/iam/v1/policy.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PolicyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Chpnb29nbGUvaWFtL3YxL3BvbGljeS5wcm90bxINZ29vZ2xlLmlhbS52MRoc",
            "Z29vZ2xlL2FwaS9hbm5vdGF0aW9ucy5wcm90byJRCgZQb2xpY3kSDwoHdmVy",
            "c2lvbhgBIAEoBRIoCghiaW5kaW5ncxgEIAMoCzIWLmdvb2dsZS5pYW0udjEu",
            "QmluZGluZxIMCgRldGFnGAMgASgMIigKB0JpbmRpbmcSDAoEcm9sZRgBIAEo",
            "CRIPCgdtZW1iZXJzGAIgAygJIkIKC1BvbGljeURlbHRhEjMKDmJpbmRpbmdf",
            "ZGVsdGFzGAEgAygLMhsuZ29vZ2xlLmlhbS52MS5CaW5kaW5nRGVsdGEilwEK",
            "DEJpbmRpbmdEZWx0YRIyCgZhY3Rpb24YASABKA4yIi5nb29nbGUuaWFtLnYx",
            "LkJpbmRpbmdEZWx0YS5BY3Rpb24SDAoEcm9sZRgCIAEoCRIOCgZtZW1iZXIY",
            "AyABKAkiNQoGQWN0aW9uEhYKEkFDVElPTl9VTlNQRUNJRklFRBAAEgcKA0FE",
            "RBABEgoKBlJFTU9WRRACQm0KEWNvbS5nb29nbGUuaWFtLnYxQgtQb2xpY3lQ",
            "cm90b1ABWjBnb29nbGUuZ29sYW5nLm9yZy9nZW5wcm90by9nb29nbGVhcGlz",
            "L2lhbS92MTtpYW34AQGqAhNHb29nbGUuQ2xvdWQuSWFtLlYxYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Iam.V1.Policy), global::Google.Cloud.Iam.V1.Policy.Parser, new[]{ "Version", "Bindings", "Etag" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Iam.V1.Binding), global::Google.Cloud.Iam.V1.Binding.Parser, new[]{ "Role", "Members" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Iam.V1.PolicyDelta), global::Google.Cloud.Iam.V1.PolicyDelta.Parser, new[]{ "BindingDeltas" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Iam.V1.BindingDelta), global::Google.Cloud.Iam.V1.BindingDelta.Parser, new[]{ "Action", "Role", "Member" }, null, new[]{ typeof(global::Google.Cloud.Iam.V1.BindingDelta.Types.Action) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Defines an Identity and Access Management (IAM) policy. It is used to
  /// specify access control policies for Cloud Platform resources.
  ///
  /// A `Policy` consists of a list of `bindings`. A `Binding` binds a list of
  /// `members` to a `role`, where the members can be user accounts, Google groups,
  /// Google domains, and service accounts. A `role` is a named list of permissions
  /// defined by IAM.
  ///
  /// **Example**
  ///
  ///     {
  ///       "bindings": [
  ///         {
  ///           "role": "roles/owner",
  ///           "members": [
  ///             "user:mike@example.com",
  ///             "group:admins@example.com",
  ///             "domain:google.com",
  ///             "serviceAccount:my-other-app@appspot.gserviceaccount.com",
  ///           ]
  ///         },
  ///         {
  ///           "role": "roles/viewer",
  ///           "members": ["user:sean@example.com"]
  ///         }
  ///       ]
  ///     }
  ///
  /// For a description of IAM and its features, see the
  /// [IAM developer's guide](https://cloud.google.com/iam).
  /// </summary>
  public sealed partial class Policy : pb::IMessage<Policy> {
    private static readonly pb::MessageParser<Policy> _parser = new pb::MessageParser<Policy>(() => new Policy());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Policy> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.Iam.V1.PolicyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Policy() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Policy(Policy other) : this() {
      version_ = other.version_;
      bindings_ = other.bindings_.Clone();
      etag_ = other.etag_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Policy Clone() {
      return new Policy(this);
    }

    /// <summary>Field number for the "version" field.</summary>
    public const int VersionFieldNumber = 1;
    private int version_;
    /// <summary>
    /// Version of the `Policy`. The default version is 0.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Version {
      get { return version_; }
      set {
        version_ = value;
      }
    }

    /// <summary>Field number for the "bindings" field.</summary>
    public const int BindingsFieldNumber = 4;
    private static readonly pb::FieldCodec<global::Google.Cloud.Iam.V1.Binding> _repeated_bindings_codec
        = pb::FieldCodec.ForMessage(34, global::Google.Cloud.Iam.V1.Binding.Parser);
    private readonly pbc::RepeatedField<global::Google.Cloud.Iam.V1.Binding> bindings_ = new pbc::RepeatedField<global::Google.Cloud.Iam.V1.Binding>();
    /// <summary>
    /// Associates a list of `members` to a `role`.
    /// Multiple `bindings` must not be specified for the same `role`.
    /// `bindings` with no members will result in an error.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Google.Cloud.Iam.V1.Binding> Bindings {
      get { return bindings_; }
    }

    /// <summary>Field number for the "etag" field.</summary>
    public const int EtagFieldNumber = 3;
    private pb::ByteString etag_ = pb::ByteString.Empty;
    /// <summary>
    /// `etag` is used for optimistic concurrency control as a way to help
    /// prevent simultaneous updates of a policy from overwriting each other.
    /// It is strongly suggested that systems make use of the `etag` in the
    /// read-modify-write cycle to perform policy updates in order to avoid race
    /// conditions: An `etag` is returned in the response to `getIamPolicy`, and
    /// systems are expected to put that etag in the request to `setIamPolicy` to
    /// ensure that their change will be applied to the same version of the policy.
    ///
    /// If no `etag` is provided in the call to `setIamPolicy`, then the existing
    /// policy is overwritten blindly.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pb::ByteString Etag {
      get { return etag_; }
      set {
        etag_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Policy);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Policy other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Version != other.Version) return false;
      if(!bindings_.Equals(other.bindings_)) return false;
      if (Etag != other.Etag) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Version != 0) hash ^= Version.GetHashCode();
      hash ^= bindings_.GetHashCode();
      if (Etag.Length != 0) hash ^= Etag.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Version != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Version);
      }
      if (Etag.Length != 0) {
        output.WriteRawTag(26);
        output.WriteBytes(Etag);
      }
      bindings_.WriteTo(output, _repeated_bindings_codec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Version != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Version);
      }
      size += bindings_.CalculateSize(_repeated_bindings_codec);
      if (Etag.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(Etag);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Policy other) {
      if (other == null) {
        return;
      }
      if (other.Version != 0) {
        Version = other.Version;
      }
      bindings_.Add(other.bindings_);
      if (other.Etag.Length != 0) {
        Etag = other.Etag;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            Version = input.ReadInt32();
            break;
          }
          case 26: {
            Etag = input.ReadBytes();
            break;
          }
          case 34: {
            bindings_.AddEntriesFrom(input, _repeated_bindings_codec);
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// Associates `members` with a `role`.
  /// </summary>
  public sealed partial class Binding : pb::IMessage<Binding> {
    private static readonly pb::MessageParser<Binding> _parser = new pb::MessageParser<Binding>(() => new Binding());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Binding> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.Iam.V1.PolicyReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Binding() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Binding(Binding other) : this() {
      role_ = other.role_;
      members_ = other.members_.Clone();
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Binding Clone() {
      return new Binding(this);
    }

    /// <summary>Field number for the "role" field.</summary>
    public const int RoleFieldNumber = 1;
    private string role_ = "";
    /// <summary>
    /// Role that is assigned to `members`.
    /// For example, `roles/viewer`, `roles/editor`, or `roles/owner`.
    /// Required
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Role {
      get { return role_; }
      set {
        role_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "members" field.</summary>
    public const int MembersFieldNumber = 2;
    private static readonly pb::FieldCodec<string> _repeated_members_codec
        = pb::FieldCodec.ForString(18);
    private readonly pbc::RepeatedField<string> members_ = new pbc::RepeatedField<string>();
    /// <summary>
    /// Specifies the identities requesting access for a Cloud Platform resource.
    /// `members` can have the following values:
    ///
    /// * `allUsers`: A special identifier that represents anyone who is
    ///    on the internet; with or without a Google account.
    ///
    /// * `allAuthenticatedUsers`: A special identifier that represents anyone
    ///    who is authenticated with a Google account or a service account.
    ///
    /// * `user:{emailid}`: An email address that represents a specific Google
    ///    account. For example, `alice@gmail.com` or `joe@example.com`.
    ///
    /// * `serviceAccount:{emailid}`: An email address that represents a service
    ///    account. For example, `my-other-app@appspot.gserviceaccount.com`.
    ///
    /// * `group:{emailid}`: An email address that represents a Google group.
    ///    For example, `admins@example.com`.
    ///
    /// * `domain:{domain}`: A Google Apps domain name that represents all the
    ///    users of that domain. For example, `google.com` or `example.com`.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<string> Members {
      get { return members_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Binding);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Binding other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Role != other.Role) return false;
      if(!members_.Equals(other.members_)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Role.Length != 0) hash ^= Role.GetHashCode();
      hash ^= members_.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Role.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Role);
      }
      members_.WriteTo(output, _repeated_members_codec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Role.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Role);
      }
      size += members_.CalculateSize(_repeated_members_codec);
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Binding other) {
      if (other == null) {
        return;
      }
      if (other.Role.Length != 0) {
        Role = other.Role;
      }
      members_.Add(other.members_);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            Role = input.ReadString();
            break;
          }
          case 18: {
            members_.AddEntriesFrom(input, _repeated_members_codec);
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// The difference delta between two policies.
  /// </summary>
  public sealed partial class PolicyDelta : pb::IMessage<PolicyDelta> {
    private static readonly pb::MessageParser<PolicyDelta> _parser = new pb::MessageParser<PolicyDelta>(() => new PolicyDelta());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PolicyDelta> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.Iam.V1.PolicyReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PolicyDelta() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PolicyDelta(PolicyDelta other) : this() {
      bindingDeltas_ = other.bindingDeltas_.Clone();
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PolicyDelta Clone() {
      return new PolicyDelta(this);
    }

    /// <summary>Field number for the "binding_deltas" field.</summary>
    public const int BindingDeltasFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Google.Cloud.Iam.V1.BindingDelta> _repeated_bindingDeltas_codec
        = pb::FieldCodec.ForMessage(10, global::Google.Cloud.Iam.V1.BindingDelta.Parser);
    private readonly pbc::RepeatedField<global::Google.Cloud.Iam.V1.BindingDelta> bindingDeltas_ = new pbc::RepeatedField<global::Google.Cloud.Iam.V1.BindingDelta>();
    /// <summary>
    /// The delta for Bindings between two policies.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Google.Cloud.Iam.V1.BindingDelta> BindingDeltas {
      get { return bindingDeltas_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PolicyDelta);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PolicyDelta other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!bindingDeltas_.Equals(other.bindingDeltas_)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= bindingDeltas_.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      bindingDeltas_.WriteTo(output, _repeated_bindingDeltas_codec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += bindingDeltas_.CalculateSize(_repeated_bindingDeltas_codec);
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PolicyDelta other) {
      if (other == null) {
        return;
      }
      bindingDeltas_.Add(other.bindingDeltas_);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            bindingDeltas_.AddEntriesFrom(input, _repeated_bindingDeltas_codec);
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// One delta entry for Binding. Each individual change (only one member in each
  /// entry) to a binding will be a separate entry.
  /// </summary>
  public sealed partial class BindingDelta : pb::IMessage<BindingDelta> {
    private static readonly pb::MessageParser<BindingDelta> _parser = new pb::MessageParser<BindingDelta>(() => new BindingDelta());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<BindingDelta> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.Iam.V1.PolicyReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BindingDelta() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BindingDelta(BindingDelta other) : this() {
      action_ = other.action_;
      role_ = other.role_;
      member_ = other.member_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BindingDelta Clone() {
      return new BindingDelta(this);
    }

    /// <summary>Field number for the "action" field.</summary>
    public const int ActionFieldNumber = 1;
    private global::Google.Cloud.Iam.V1.BindingDelta.Types.Action action_ = 0;
    /// <summary>
    /// The action that was performed on a Binding.
    /// Required
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Cloud.Iam.V1.BindingDelta.Types.Action Action {
      get { return action_; }
      set {
        action_ = value;
      }
    }

    /// <summary>Field number for the "role" field.</summary>
    public const int RoleFieldNumber = 2;
    private string role_ = "";
    /// <summary>
    /// Role that is assigned to `members`.
    /// For example, `roles/viewer`, `roles/editor`, or `roles/owner`.
    /// Required
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Role {
      get { return role_; }
      set {
        role_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "member" field.</summary>
    public const int MemberFieldNumber = 3;
    private string member_ = "";
    /// <summary>
    /// A single identity requesting access for a Cloud Platform resource.
    /// Follows the same format of Binding.members.
    /// Required
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Member {
      get { return member_; }
      set {
        member_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as BindingDelta);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(BindingDelta other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Action != other.Action) return false;
      if (Role != other.Role) return false;
      if (Member != other.Member) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Action != 0) hash ^= Action.GetHashCode();
      if (Role.Length != 0) hash ^= Role.GetHashCode();
      if (Member.Length != 0) hash ^= Member.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Action != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Action);
      }
      if (Role.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Role);
      }
      if (Member.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Member);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Action != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Action);
      }
      if (Role.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Role);
      }
      if (Member.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Member);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(BindingDelta other) {
      if (other == null) {
        return;
      }
      if (other.Action != 0) {
        Action = other.Action;
      }
      if (other.Role.Length != 0) {
        Role = other.Role;
      }
      if (other.Member.Length != 0) {
        Member = other.Member;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            action_ = (global::Google.Cloud.Iam.V1.BindingDelta.Types.Action) input.ReadEnum();
            break;
          }
          case 18: {
            Role = input.ReadString();
            break;
          }
          case 26: {
            Member = input.ReadString();
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the BindingDelta message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// The type of action performed on a Binding in a policy.
      /// </summary>
      public enum Action {
        /// <summary>
        /// Unspecified.
        /// </summary>
        [pbr::OriginalName("ACTION_UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Addition of a Binding.
        /// </summary>
        [pbr::OriginalName("ADD")] Add = 1,
        /// <summary>
        /// Removal of a Binding.
        /// </summary>
        [pbr::OriginalName("REMOVE")] Remove = 2,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
