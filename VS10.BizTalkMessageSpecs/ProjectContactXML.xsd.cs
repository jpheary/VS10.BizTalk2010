namespace BizTalk {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://Argix.ProjectContactXML",@"Project")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Project"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"BizTalk.DerivedXMLSchema", typeof(global::BizTalk.DerivedXMLSchema))]
    public sealed class ProjectContactXML : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://Argix.ProjectContactXML"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:ns0=""http://Argix.BasicXMLSchema"" targetNamespace=""http://Argix.ProjectContactXML"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:import schemaLocation=""BizTalk.DerivedXMLSchema"" namespace=""http://Argix.BasicXMLSchema"" />
  <xs:annotation>
    <xs:appinfo>
      <b:references>
        <b:reference targetNamespace=""http://Argix.BasicXMLSchema"" />
      </b:references>
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""Project"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""Name"" type=""xs:string"" />
        <xs:element name=""Contact"" type=""ns0:ContactType"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public ProjectContactXML() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "Project";
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
