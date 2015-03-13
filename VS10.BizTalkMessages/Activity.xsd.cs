namespace BizTalk {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://ArgixLogistics.Activity",@"Activity")]
    [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::BizTalk.type), XPath = @"/*[local-name()='Activity' and namespace-uri()='http://ArgixLogistics.Activity']/@*[local-name()='type' and namespace-uri()='']", XsdType = @"nonNegativeInteger")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Activity"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"BizTalk.ActivityProperties", typeof(global::BizTalk.ActivityProperties))]
    public sealed class Activity : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://ArgixLogistics.Activity"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:ns0=""https://Argix.ActivityProperties"" targetNamespace=""http://ArgixLogistics.Activity"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:annotation>
    <xs:appinfo>
      <b:imports>
        <b:namespace prefix=""ns0"" uri=""https://Argix.ActivityProperties"" location=""BizTalk.ActivityProperties"" />
      </b:imports>
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""Activity"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property name=""ns0:type"" xpath=""/*[local-name()='Activity' and namespace-uri()='http://ArgixLogistics.Activity']/@*[local-name()='type' and namespace-uri()='']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
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
        
        public Activity() {
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
