namespace Argix {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://Argix.Activity",@"Activity")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Activity"})]
    public sealed class ActivitySchema : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://Argix.Activity"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://Argix.Activity"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""Activity"">
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""1"" maxOccurs=""1"" name=""Location"" type=""xs:string"" />
        <xs:element minOccurs=""1"" maxOccurs=""1"" name=""Timestamp"" type=""xs:dateTime"" />
        <xs:element minOccurs=""1"" maxOccurs=""1"" name=""Notes"" nillable=""true"" type=""xs:string"" />
      </xs:sequence>
      <xs:attribute name=""type"" use=""required"">
        <xs:simpleType>
          <xs:restriction base=""xs:nonNegativeInteger"">
            <xs:maxInclusive value=""10"" />
            <xs:minInclusive value=""1"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:attribute>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public ActivitySchema() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "Activity";
                return _RootElements;
            }
        }
        
        protected override object RawSchema {
            get {
                return _rawSchema;
            }
            set {
                _rawSchema = value;
            }
        }
    }
}
