namespace BizTalk {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://Argix.BasicXMLSchema",@"Contact")]
    [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::BizTalk.ContactID), XPath = @"/*[local-name()='Contact' and namespace-uri()='http://Argix.BasicXMLSchema']/*[local-name()='Person' and namespace-uri()='']/@*[local-name()='SSN' and namespace-uri()='']", XsdType = @"string")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Contact"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"BizTalk.ContactProperties", typeof(global::BizTalk.ContactProperties))]
    public sealed class DerivedXMLSchema : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://Argix.BasicXMLSchema"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:ns0=""https://Argix.ContactProperties"" targetNamespace=""http://Argix.BasicXMLSchema"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:annotation>
    <xs:appinfo>
      <b:imports>
        <b:namespace prefix=""ns0"" uri=""https://Argix.ContactProperties"" location=""BizTalk.ContactProperties"" />
      </b:imports>
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""Contact"" type=""ContactType"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property name=""ns0:ContactID"" xpath=""/*[local-name()='Contact' and namespace-uri()='http://Argix.BasicXMLSchema']/*[local-name()='Person' and namespace-uri()='']/@*[local-name()='SSN' and namespace-uri()='']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
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
            <xs:attribute name=""SSN"" use=""required"">
              <xs:simpleType>
                <xs:restriction base=""xs:string"">
                  <xs:pattern value=""[0-9]{3}-[0-9]{2}-[0-9]{4}"" />
                </xs:restriction>
              </xs:simpleType>
            </xs:attribute>
          </xs:complexType>
        </xs:element>
        <xs:element minOccurs=""1"" maxOccurs=""1"" name=""Location"">
          <xs:complexType>
            <xs:sequence>
              <xs:choice minOccurs=""1"">
                <xs:element name=""Home"" type=""HomeType"" />
                <xs:element name=""Office"" type=""OfficeType"" />
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
  <xs:complexType name=""HomeType"">
    <xs:complexContent mixed=""false"">
      <xs:extension base=""AddrType"">
        <xs:attribute name=""apt"" type=""xs:string"" />
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:complexType name=""OfficeType"">
    <xs:complexContent mixed=""false"">
      <xs:extension base=""AddrType"">
        <xs:attribute name=""room"" type=""xs:string"" />
        <xs:attribute name=""mailstop"" type=""xs:string"" />
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
</xs:schema>";
        
        public DerivedXMLSchema() {
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
