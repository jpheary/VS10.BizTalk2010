namespace VS10 {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"VS10.Freight.FreightSystemService_schemas_datacontract_org_2004_07_Argix_Freight+LTLShipment", typeof(global::VS10.Freight.FreightSystemService_schemas_datacontract_org_2004_07_Argix_Freight.LTLShipment))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"VS10.Freight.FreightSystemService_argix_freight+SchedulePickupRequest", typeof(global::VS10.Freight.FreightSystemService_argix_freight.SchedulePickupRequest))]
    public sealed class ShipmentToPickupMap : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var"" version=""1.0"" xmlns:ns1=""http://schemas.datacontract.org/2004/07/VS10.Freight"" xmlns:ns0=""http://VS10.Freight"" xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/ns1:LTLShipment"" />
  </xsl:template>
  <xsl:template match=""/ns1:LTLShipment"">
    <ns0:SchedulePickupRequest>
      <ns0:request>
        <xsl:if test=""ns1:Pallets"">
          <ns1:Amount>
            <xsl:value-of select=""ns1:Pallets/text()"" />
          </ns1:Amount>
        </xsl:if>
        <ns1:AmountType>
          <xsl:text>Pallets</xsl:text>
        </ns1:AmountType>
        <xsl:if test=""ns1:UserID"">
          <xsl:variable name=""var:v1"" select=""string(ns1:UserID/@xsi:nil) = 'true'"" />
          <xsl:if test=""string($var:v1)='true'"">
            <ns1:CallerName>
              <xsl:attribute name=""xsi:nil"">
                <xsl:value-of select=""'true'"" />
              </xsl:attribute>
            </ns1:CallerName>
          </xsl:if>
          <xsl:if test=""string($var:v1)='false'"">
            <ns1:CallerName>
              <xsl:value-of select=""ns1:UserID/text()"" />
            </ns1:CallerName>
          </xsl:if>
        </xsl:if>
        <ns1:Client>
          <xsl:text>client1</xsl:text>
        </ns1:Client>
        <xsl:if test=""ns1:ClientID"">
          <ns1:ClientNumber>
            <xsl:value-of select=""ns1:ClientID/text()"" />
          </ns1:ClientNumber>
        </xsl:if>
        <ns1:CreateUserID>
          <xsl:text>BizTalk</xsl:text>
        </ns1:CreateUserID>
        <xsl:if test=""ns1:Created"">
          <ns1:Created>
            <xsl:value-of select=""ns1:Created/text()"" />
          </ns1:Created>
        </xsl:if>
        <ns1:FreightType>
          <xsl:text>Tsort</xsl:text>
        </ns1:FreightType>
        <ns1:IsTemplate>
          <xsl:text>0</xsl:text>
        </ns1:IsTemplate>
        <xsl:if test=""ns1:LastUpdated"">
          <ns1:LastUpdated>
            <xsl:value-of select=""ns1:LastUpdated/text()"" />
          </ns1:LastUpdated>
        </xsl:if>
        <ns1:OrderType>
          <xsl:text>B</xsl:text>
        </ns1:OrderType>
        <xsl:if test=""ns1:ShipDate"">
          <ns1:ScheduleDate>
            <xsl:value-of select=""ns1:ShipDate/text()"" />
          </ns1:ScheduleDate>
        </xsl:if>
        <ns1:Shipper>
          <xsl:text>Broad Avenue Bakers</xsl:text>
        </ns1:Shipper>
        <ns1:ShipperAddress>
          <xsl:text>200 Broad Street Ridgefield NJ 07657</xsl:text>
        </ns1:ShipperAddress>
        <xsl:if test=""ns1:ShipperID"">
          <ns1:ShipperNumber>
            <xsl:value-of select=""ns1:ShipperID/text()"" />
          </ns1:ShipperNumber>
        </xsl:if>
        <ns1:UserID>
          <xsl:text>BizTalk</xsl:text>
        </ns1:UserID>
        <xsl:if test=""ns1:Weight"">
          <ns1:Weight>
            <xsl:value-of select=""ns1:Weight/text()"" />
          </ns1:Weight>
        </xsl:if>
        <ns1:WindowClose>
          <xsl:text>1700</xsl:text>
        </ns1:WindowClose>
        <ns1:WindowOpen>
          <xsl:text>900</xsl:text>
        </ns1:WindowOpen>
      </ns0:request>
    </ns0:SchedulePickupRequest>
  </xsl:template>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"VS10.Freight.FreightSystemService_schemas_datacontract_org_2004_07_Argix_Freight+LTLShipment";
        
        private const global::VS10.Freight.FreightSystemService_schemas_datacontract_org_2004_07_Argix_Freight.LTLShipment _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"VS10.Freight.FreightSystemService_argix_freight+SchedulePickupRequest";
        
        private const global::VS10.Freight.FreightSystemService_argix_freight.SchedulePickupRequest _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"VS10.Freight.FreightSystemService_schemas_datacontract_org_2004_07_Argix_Freight+LTLShipment";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"VS10.Freight.FreightSystemService_argix_freight+SchedulePickupRequest";
                return _TrgSchemas;
            }
        }
    }
}
