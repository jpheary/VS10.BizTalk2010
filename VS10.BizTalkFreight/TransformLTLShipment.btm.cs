namespace Argix {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Argix.Freight.FreightSystemService_schemas_datacontract_org_2004_07_Argix_Freight+LTLShipment", typeof(global::Argix.Freight.FreightSystemService_schemas_datacontract_org_2004_07_Argix_Freight.LTLShipment))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Argix.Freight.FreightSystemService_argix_freight+SchedulePickupRequest", typeof(global::Argix.Freight.FreightSystemService_argix_freight.SchedulePickupRequest))]
    public sealed class TransformLTLShipment : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var"" version=""1.0"" xmlns:ns1=""http://schemas.datacontract.org/2004/07/Argix.Freight"" xmlns:ns0=""http://Argix.Freight"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/ns1:LTLShipment"" />
  </xsl:template>
  <xsl:template match=""/ns1:LTLShipment"" />
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"Argix.Freight.FreightSystemService_schemas_datacontract_org_2004_07_Argix_Freight+LTLShipment";
        
        private const string _strTrgSchemasList0 = @"Argix.Freight.FreightSystemService_argix_freight+SchedulePickupRequest";
        
        public override string XmlContent {
            get {
                return _strMap;
            }
        }
        
        public override string XsltArgumentListContent {
            get {
                return _strArgList;
            }
        }
        
        public override string[] SourceSchemas {
            get {
                string[] _SrcSchemas = new string [1];
                _SrcSchemas[0] = @"Argix.Freight.FreightSystemService_schemas_datacontract_org_2004_07_Argix_Freight+LTLShipment";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"Argix.Freight.FreightSystemService_argix_freight+SchedulePickupRequest";
                return _TrgSchemas;
            }
        }
    }
}
