namespace BizTalk {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://Argix.BasicXMLSchema",@"Contact")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Contact"})]
    public sealed class BasicXMLSchema : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://Argix.BasicXMLSchema"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://Argix.BasicXMLSchema"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""Contact"" type=""ContactType"" />
  <xs:complexType name=""ContactType"">
    <xs:sequence>
      <xs:sequence minOccurs=""1"" maxOccurs=""1"">
        <xs:element minOccurs=""1"" maxOccurs=""1"" name=""Person"">
          <xs:complexType>
            <xs:sequence>
              <xs:element minOccurs=""1"" maxOccurs=""1"" name=""FirstName"" type=""xs:string"" />
              <xs:element minOccurs=""0"" maxOccurs=""1"" name=""MiddleName"" type=""xs:string"" />
              <xs:element minOccurs=""1"" maxOccurs=""1"" name=""LastName"" type=""xs:string"" />
            </xs:sequence>
            <xs:attribute name=""SSN"" type=""xs:string"" use=""required"" />
          </xs:complexType>
        </xs:element>
        <xs:element minOccurs=""1"" maxOccurs=""1"" name=""Location"">
          <xs:complexType>
            <xs:sequence>
              <xs:choice minOccurs=""1"">
                <xs:element name=""Home"">
                  <xs:complexType>
                    <xs:sequence>
                      <xs:element name=""Address"" type=""AddrType"" />
                    </xs:sequence>
                    <xs:attribute name=""apt"" type=""xs:string"" />
                  </xs:complexType>
                </xs:element>
                <xs:element name=""Office"">
                  <xs:complexType>
                    <xs:sequence>
                      <xs:element name=""Address"" type=""AddrType"" />
                    </xs:sequence>
                    <xs:attribute name=""room"" type=""xs:string"" />
                    <xs:attribute name=""mailstop"" type=""xs:string"" />
                  </xs:complexType>
                </xs:element>
              </xs:choice>
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""AddrType"">
    <xs:sequence>
      <xs:sequence minOccurs=""1"" maxOccurs=""1"">
        <xs:element name=""Street1"" type=""xs:string"" />
        <xs:element name=""Street2"" type=""xs:string"" />
        <xs:element name=""City"" type=""xs:string"" />
        <xs:element name=""State"" type=""xs:string"" />
        <xs:element name=""Zip"" type=""xs:string"" />
      </xs:sequence>
    </xs:sequence>
  </xs:complexType>
</xs:schema>";
        
        public BasicXMLSchema() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "Contact";
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
