namespace VS10 {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"VS10.Freight.FreightSystemService_schemas_datacontract_org_2004_07_Argix_Freight+LTLShipment", typeof(global::VS10.Freight.FreightSystemService_schemas_datacontract_org_2004_07_Argix_Freight.LTLShipment))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"VS10.Freight.FreightSystemService_argix_freight+DispatchShipment", typeof(global::VS10.Freight.FreightSystemService_argix_freight.DispatchShipment))]
    public sealed class LTLShipmentToLTLShipmentRequestMap : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var"" version=""1.0"" xmlns:ns1=""http://schemas.datacontract.org/2004/07/VS10.Freight"" xmlns:ns0=""http://VS10.Freight"" xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/ns1:LTLShipment"" />
  </xsl:template>
  <xsl:template match=""/ns1:LTLShipment"">
    <ns0:DispatchShipment>
      <ns0:shipment>
        <xsl:if test=""ns1:AccessorialCharge"">
          <ns1:AccessorialCharge>
            <xsl:value-of select=""ns1:AccessorialCharge/text()"" />
          </ns1:AccessorialCharge>
        </xsl:if>
        <xsl:if test=""ns1:AppointmentDestination"">
          <ns1:AppointmentDestination>
            <xsl:value-of select=""ns1:AppointmentDestination/text()"" />
          </ns1:AppointmentDestination>
        </xsl:if>
        <xsl:if test=""ns1:AppointmentOrigin"">
          <ns1:AppointmentOrigin>
            <xsl:value-of select=""ns1:AppointmentOrigin/text()"" />
          </ns1:AppointmentOrigin>
        </xsl:if>
        <xsl:if test=""ns1:Approved"">
          <ns1:Approved>
            <xsl:value-of select=""ns1:Approved/text()"" />
          </ns1:Approved>
        </xsl:if>
        <xsl:if test=""ns1:ApprovedDate"">
          <ns1:ApprovedDate>
            <xsl:value-of select=""ns1:ApprovedDate/text()"" />
          </ns1:ApprovedDate>
        </xsl:if>
        <xsl:if test=""ns1:ApprovedUser"">
          <xsl:variable name=""var:v1"" select=""string(ns1:ApprovedUser/@xsi:nil) = 'true'"" />
          <xsl:if test=""string($var:v1)='true'"">
            <ns1:ApprovedUser>
              <xsl:attribute name=""xsi:nil"">
                <xsl:value-of select=""'true'"" />
              </xsl:attribute>
            </ns1:ApprovedUser>
          </xsl:if>
          <xsl:if test=""string($var:v1)='false'"">
            <ns1:ApprovedUser>
              <xsl:value-of select=""ns1:ApprovedUser/text()"" />
            </ns1:ApprovedUser>
          </xsl:if>
        </xsl:if>
        <xsl:if test=""ns1:ClientID"">
          <ns1:ClientID>
            <xsl:value-of select=""ns1:ClientID/text()"" />
          </ns1:ClientID>
        </xsl:if>
        <xsl:if test=""ns1:ConsigneeID"">
          <ns1:ConsigneeID>
            <xsl:value-of select=""ns1:ConsigneeID/text()"" />
          </ns1:ConsigneeID>
        </xsl:if>
        <xsl:if test=""ns1:Created"">
          <ns1:Created>
            <xsl:value-of select=""ns1:Created/text()"" />
          </ns1:Created>
        </xsl:if>
        <xsl:if test=""ns1:FSC"">
          <ns1:FSC>
            <xsl:value-of select=""ns1:FSC/text()"" />
          </ns1:FSC>
        </xsl:if>
        <xsl:if test=""ns1:ID"">
          <ns1:ID>
            <xsl:value-of select=""ns1:ID/text()"" />
          </ns1:ID>
        </xsl:if>
        <xsl:if test=""ns1:InsidePickupDelivery"">
          <ns1:InsidePickupDelivery>
            <xsl:value-of select=""ns1:InsidePickupDelivery/text()"" />
          </ns1:InsidePickupDelivery>
        </xsl:if>
        <xsl:if test=""ns1:Insurance"">
          <ns1:Insurance>
            <xsl:value-of select=""ns1:Insurance/text()"" />
          </ns1:Insurance>
        </xsl:if>
        <xsl:if test=""ns1:LastUpdated"">
          <ns1:LastUpdated>
            <xsl:value-of select=""ns1:LastUpdated/text()"" />
          </ns1:LastUpdated>
        </xsl:if>
        <xsl:if test=""ns1:LiftGate"">
          <ns1:LiftGate>
            <xsl:value-of select=""ns1:LiftGate/text()"" />
          </ns1:LiftGate>
        </xsl:if>
        <xsl:if test=""ns1:Pallet1Class"">
          <xsl:variable name=""var:v2"" select=""string(ns1:Pallet1Class/@xsi:nil) = 'true'"" />
          <xsl:if test=""string($var:v2)='true'"">
            <ns1:Pallet1Class>
              <xsl:attribute name=""xsi:nil"">
                <xsl:value-of select=""'true'"" />
              </xsl:attribute>
            </ns1:Pallet1Class>
          </xsl:if>
          <xsl:if test=""string($var:v2)='false'"">
            <ns1:Pallet1Class>
              <xsl:value-of select=""ns1:Pallet1Class/text()"" />
            </ns1:Pallet1Class>
          </xsl:if>
        </xsl:if>
        <xsl:if test=""ns1:Pallet1Weight"">
          <ns1:Pallet1Weight>
            <xsl:value-of select=""ns1:Pallet1Weight/text()"" />
          </ns1:Pallet1Weight>
        </xsl:if>
        <xsl:if test=""ns1:Pallet2Class"">
          <xsl:variable name=""var:v3"" select=""string(ns1:Pallet2Class/@xsi:nil) = 'true'"" />
          <xsl:if test=""string($var:v3)='true'"">
            <ns1:Pallet2Class>
              <xsl:attribute name=""xsi:nil"">
                <xsl:value-of select=""'true'"" />
              </xsl:attribute>
            </ns1:Pallet2Class>
          </xsl:if>
          <xsl:if test=""string($var:v3)='false'"">
            <ns1:Pallet2Class>
              <xsl:value-of select=""ns1:Pallet2Class/text()"" />
            </ns1:Pallet2Class>
          </xsl:if>
        </xsl:if>
        <xsl:if test=""ns1:Pallet2Weight"">
          <ns1:Pallet2Weight>
            <xsl:value-of select=""ns1:Pallet2Weight/text()"" />
          </ns1:Pallet2Weight>
        </xsl:if>
        <xsl:if test=""ns1:Pallet3Class"">
          <xsl:variable name=""var:v4"" select=""string(ns1:Pallet3Class/@xsi:nil) = 'true'"" />
          <xsl:if test=""string($var:v4)='true'"">
            <ns1:Pallet3Class>
              <xsl:attribute name=""xsi:nil"">
                <xsl:value-of select=""'true'"" />
              </xsl:attribute>
            </ns1:Pallet3Class>
          </xsl:if>
          <xsl:if test=""string($var:v4)='false'"">
            <ns1:Pallet3Class>
              <xsl:value-of select=""ns1:Pallet3Class/text()"" />
            </ns1:Pallet3Class>
          </xsl:if>
        </xsl:if>
        <xsl:if test=""ns1:Pallet3Weight"">
          <ns1:Pallet3Weight>
            <xsl:value-of select=""ns1:Pallet3Weight/text()"" />
          </ns1:Pallet3Weight>
        </xsl:if>
        <xsl:if test=""ns1:Pallet4Class"">
          <xsl:variable name=""var:v5"" select=""string(ns1:Pallet4Class/@xsi:nil) = 'true'"" />
          <xsl:if test=""string($var:v5)='true'"">
            <ns1:Pallet4Class>
              <xsl:attribute name=""xsi:nil"">
                <xsl:value-of select=""'true'"" />
              </xsl:attribute>
            </ns1:Pallet4Class>
          </xsl:if>
          <xsl:if test=""string($var:v5)='false'"">
            <ns1:Pallet4Class>
              <xsl:value-of select=""ns1:Pallet4Class/text()"" />
            </ns1:Pallet4Class>
          </xsl:if>
        </xsl:if>
        <xsl:if test=""ns1:Pallet4Weight"">
          <ns1:Pallet4Weight>
            <xsl:value-of select=""ns1:Pallet4Weight/text()"" />
          </ns1:Pallet4Weight>
        </xsl:if>
        <xsl:if test=""ns1:Pallet5Class"">
          <xsl:variable name=""var:v6"" select=""string(ns1:Pallet5Class/@xsi:nil) = 'true'"" />
          <xsl:if test=""string($var:v6)='true'"">
            <ns1:Pallet5Class>
              <xsl:attribute name=""xsi:nil"">
                <xsl:value-of select=""'true'"" />
              </xsl:attribute>
            </ns1:Pallet5Class>
          </xsl:if>
          <xsl:if test=""string($var:v6)='false'"">
            <ns1:Pallet5Class>
              <xsl:value-of select=""ns1:Pallet5Class/text()"" />
            </ns1:Pallet5Class>
          </xsl:if>
        </xsl:if>
        <xsl:if test=""ns1:Pallet5Weight"">
          <ns1:Pallet5Weight>
            <xsl:value-of select=""ns1:Pallet5Weight/text()"" />
          </ns1:Pallet5Weight>
        </xsl:if>
        <xsl:if test=""ns1:Pallets"">
          <ns1:Pallets>
            <xsl:value-of select=""ns1:Pallets/text()"" />
          </ns1:Pallets>
        </xsl:if>
        <xsl:if test=""ns1:PickupDate"">
          <ns1:PickupDate>
            <xsl:value-of select=""ns1:PickupDate/text()"" />
          </ns1:PickupDate>
        </xsl:if>
        <xsl:if test=""ns1:PickupID"">
          <ns1:PickupID>
            <xsl:value-of select=""ns1:PickupID/text()"" />
          </ns1:PickupID>
        </xsl:if>
        <xsl:if test=""ns1:Rate"">
          <ns1:Rate>
            <xsl:value-of select=""ns1:Rate/text()"" />
          </ns1:Rate>
        </xsl:if>
        <xsl:if test=""ns1:ShipmentNumber"">
          <xsl:variable name=""var:v7"" select=""string(ns1:ShipmentNumber/@xsi:nil) = 'true'"" />
          <xsl:if test=""string($var:v7)='true'"">
            <ns1:ShipmentNumber>
              <xsl:attribute name=""xsi:nil"">
                <xsl:value-of select=""'true'"" />
              </xsl:attribute>
            </ns1:ShipmentNumber>
          </xsl:if>
          <xsl:if test=""string($var:v7)='false'"">
            <ns1:ShipmentNumber>
              <xsl:value-of select=""ns1:ShipmentNumber/text()"" />
            </ns1:ShipmentNumber>
          </xsl:if>
        </xsl:if>
        <xsl:if test=""ns1:ShipperID"">
          <ns1:ShipperID>
            <xsl:value-of select=""ns1:ShipperID/text()"" />
          </ns1:ShipperID>
        </xsl:if>
        <xsl:if test=""ns1:SpecialRequirements"">
          <xsl:variable name=""var:v8"" select=""string(ns1:SpecialRequirements/@xsi:nil) = 'true'"" />
          <xsl:if test=""string($var:v8)='true'"">
            <ns1:SpecialRequirements>
              <xsl:attribute name=""xsi:nil"">
                <xsl:value-of select=""'true'"" />
              </xsl:attribute>
            </ns1:SpecialRequirements>
          </xsl:if>
          <xsl:if test=""string($var:v8)='false'"">
            <ns1:SpecialRequirements>
              <xsl:value-of select=""ns1:SpecialRequirements/text()"" />
            </ns1:SpecialRequirements>
          </xsl:if>
        </xsl:if>
        <xsl:if test=""ns1:TSC"">
          <ns1:TSC>
            <xsl:value-of select=""ns1:TSC/text()"" />
          </ns1:TSC>
        </xsl:if>
        <xsl:if test=""ns1:TotalCharge"">
          <ns1:TotalCharge>
            <xsl:value-of select=""ns1:TotalCharge/text()"" />
          </ns1:TotalCharge>
        </xsl:if>
        <xsl:if test=""ns1:UserID"">
          <xsl:variable name=""var:v9"" select=""string(ns1:UserID/@xsi:nil) = 'true'"" />
          <xsl:if test=""string($var:v9)='true'"">
            <ns1:UserID>
              <xsl:attribute name=""xsi:nil"">
                <xsl:value-of select=""'true'"" />
              </xsl:attribute>
            </ns1:UserID>
          </xsl:if>
          <xsl:if test=""string($var:v9)='false'"">
            <ns1:UserID>
              <xsl:value-of select=""ns1:UserID/text()"" />
            </ns1:UserID>
          </xsl:if>
        </xsl:if>
        <xsl:if test=""ns1:Weight"">
          <ns1:Weight>
            <xsl:value-of select=""ns1:Weight/text()"" />
          </ns1:Weight>
        </xsl:if>
      </ns0:shipment>
    </ns0:DispatchShipment>
  </xsl:template>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"VS10.Freight.FreightSystemService_schemas_datacontract_org_2004_07_Argix_Freight+LTLShipment";
        
        private const global::VS10.Freight.FreightSystemService_schemas_datacontract_org_2004_07_Argix_Freight.LTLShipment _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"VS10.Freight.FreightSystemService_argix_freight+DispatchShipment";
        
        private const global::VS10.Freight.FreightSystemService_argix_freight.DispatchShipment _trgSchemaTypeReference0 = null;
        
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
                _TrgSchemas[0] = @"VS10.Freight.FreightSystemService_argix_freight+DispatchShipment";
                return _TrgSchemas;
            }
        }
    }
}
