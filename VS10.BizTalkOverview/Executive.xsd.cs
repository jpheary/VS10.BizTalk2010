namespace BizTalk {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://BizTalk.Executive",@"Executive")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "level", XPath = @"/*[local-name()='Executive' and namespace-uri()='http://BizTalk.Executive']/@*[local-name()='level' and namespace-uri()='']", XsdType = @"string")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Executive"})]
    public sealed class Executive : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://BizTalk.Executive"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://BizTalk.Executive"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""Executive"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property distinguished=""true"" xpath=""/*[local-name()='Executive' and namespace-uri()='http://BizTalk.Executive']/@*[local-name()='level' and namespace-uri()='']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""Name"">
          <xs:complexType>
            <xs:attribute name=""fname"" type=""xs:string"" />
            <xs:attribute name=""lname"" type=""xs:string"" />
          </xs:complexType>
        </xs:element>
      </xs:sequence>
      <xs:attribute name=""id"" type=""xs:string"" />
      <xs:attribute name=""level"" type=""xs:string"" />
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public Executive() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "Executive";
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
