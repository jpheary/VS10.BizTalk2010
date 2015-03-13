namespace VS10.Freight {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::VS10.PickupID), XPath = @"/*[local-name()='PickupRequest' and namespace-uri()='http://schemas.datacontract.org/2004/07/VS10.Freight']/*[local-name()='RequestID' and namespace-uri()='http://schemas.datacontract.org/2004/07/VS10.Freight']", XsdType = @"int")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.Int32), "ID", XPath = @"/*[local-name()='LTLShipment' and namespace-uri()='http://schemas.datacontract.org/2004/07/VS10.Freight']/*[local-name()='ID' and namespace-uri()='http://schemas.datacontract.org/2004/07/VS10.Freight']", XsdType = @"int")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"PickupRequest", @"DispatchFault", @"LTLShipment", @"LTLFault"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"VS10.FreightProperties", typeof(global::VS10.FreightProperties))]
    public sealed class FreightSystemService_schemas_datacontract_org_2004_07_Argix_Freight : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:tns=""http://schemas.datacontract.org/2004/07/VS10.Freight"" xmlns:ns0=""http://VS10.Freight.Properties"" elementFormDefault=""qualified"" targetNamespace=""http://schemas.datacontract.org/2004/07/VS10.Freight"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:annotation>
    <xs:appinfo>
      <b:imports>
        <b:namespace prefix=""ns0"" uri=""http://VS10.Freight.Properties"" location=""VS10.FreightProperties"" />
      </b:imports>
    </xs:appinfo>
  </xs:annotation>
  <xs:complexType name=""PickupRequest"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""ActualPickup"" type=""xs:dateTime"" />
      <xs:element minOccurs=""0"" name=""Amount"" type=""xs:int"" />
      <xs:element minOccurs=""0"" name=""AmountType"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""CallerName"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""Cancelled"" type=""xs:dateTime"" />
      <xs:element minOccurs=""0"" name=""CancelledUserID"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""Client"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""ClientNumber"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""Comments"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""CreateUserID"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""Created"" type=""xs:dateTime"" />
      <xs:element minOccurs=""0"" name=""DriverName"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""FreightType"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""IsTemplate"" type=""xs:boolean"" />
      <xs:element minOccurs=""0"" name=""LastUpdated"" type=""xs:dateTime"" />
      <xs:element minOccurs=""0"" name=""OrderType"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""RequestID"" type=""xs:int"" />
      <xs:element minOccurs=""0"" name=""ScheduleDate"" type=""xs:dateTime"" />
      <xs:element minOccurs=""0"" name=""Shipper"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""ShipperAddress"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""ShipperNumber"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""ShipperPhone"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""Terminal"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""TerminalNumber"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""UserID"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""Weight"" type=""xs:int"" />
      <xs:element minOccurs=""0"" name=""WindowClose"" type=""xs:int"" />
      <xs:element minOccurs=""0"" name=""WindowOpen"" type=""xs:int"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""PickupRequest"" nillable=""true"" type=""tns:PickupRequest"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property name=""ns0:PickupID"" xpath=""/*[local-name()='PickupRequest' and namespace-uri()='http://schemas.datacontract.org/2004/07/VS10.Freight']/*[local-name()='RequestID' and namespace-uri()='http://schemas.datacontract.org/2004/07/VS10.Freight']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:complexType name=""DispatchFault"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""Message"" nillable=""true"" type=""xs:string"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""DispatchFault"" nillable=""true"" type=""tns:DispatchFault"" />
  <xs:complexType name=""LTLShipment"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""AccessorialCharge"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""AppointmentDestination"" type=""xs:dateTime"" />
      <xs:element minOccurs=""0"" name=""AppointmentOrigin"" type=""xs:dateTime"" />
      <xs:element minOccurs=""0"" name=""Approved"" type=""xs:boolean"" />
      <xs:element minOccurs=""0"" name=""ApprovedDate"" type=""xs:dateTime"" />
      <xs:element minOccurs=""0"" name=""ApprovedUser"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""ClientID"" type=""xs:int"" />
      <xs:element minOccurs=""0"" name=""ConsigneeID"" type=""xs:int"" />
      <xs:element minOccurs=""0"" name=""Created"" type=""xs:dateTime"" />
      <xs:element minOccurs=""0"" name=""FSC"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""ID"" type=""xs:int"" />
      <xs:element minOccurs=""0"" name=""InsidePickupDelivery"" type=""xs:boolean"" />
      <xs:element minOccurs=""0"" name=""Insurance"" type=""xs:boolean"" />
      <xs:element minOccurs=""0"" name=""LastUpdated"" type=""xs:dateTime"" />
      <xs:element minOccurs=""0"" name=""LiftGate"" type=""xs:boolean"" />
      <xs:element minOccurs=""0"" name=""Pallet1Class"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""Pallet1Weight"" type=""xs:int"" />
      <xs:element minOccurs=""0"" name=""Pallet2Class"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""Pallet2Weight"" type=""xs:int"" />
      <xs:element minOccurs=""0"" name=""Pallet3Class"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""Pallet3Weight"" type=""xs:int"" />
      <xs:element minOccurs=""0"" name=""Pallet4Class"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""Pallet4Weight"" type=""xs:int"" />
      <xs:element minOccurs=""0"" name=""Pallet5Class"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""Pallet5Weight"" type=""xs:int"" />
      <xs:element minOccurs=""0"" name=""Pallets"" type=""xs:int"" />
      <xs:element minOccurs=""0"" name=""PickupDate"" type=""xs:dateTime"" />
      <xs:element minOccurs=""0"" name=""PickupID"" type=""xs:int"" />
      <xs:element minOccurs=""0"" name=""Rate"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""ShipDate"" type=""xs:dateTime"" />
      <xs:element minOccurs=""0"" name=""ShipmentNumber"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""ShipperID"" type=""xs:int"" />
      <xs:element minOccurs=""0"" name=""SpecialRequirements"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""TSC"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""TotalCharge"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" name=""UserID"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""Weight"" type=""xs:int"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""LTLShipment"" nillable=""true"" type=""tns:LTLShipment"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property distinguished=""true"" xpath=""/*[local-name()='LTLShipment' and namespace-uri()='http://schemas.datacontract.org/2004/07/VS10.Freight']/*[local-name()='ID' and namespace-uri()='http://schemas.datacontract.org/2004/07/VS10.Freight']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:complexType name=""LTLFault"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""Message"" nillable=""true"" type=""xs:string"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""LTLFault"" nillable=""true"" type=""tns:LTLFault"" />
</xs:schema>";
        
        public FreightSystemService_schemas_datacontract_org_2004_07_Argix_Freight() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [4];
                _RootElements[0] = "PickupRequest";
                _RootElements[1] = "DispatchFault";
                _RootElements[2] = "LTLShipment";
                _RootElements[3] = "LTLFault";
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
        
        [Schema(@"http://schemas.datacontract.org/2004/07/VS10.Freight",@"PickupRequest")]
        [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::VS10.PickupID), XPath = @"/*[local-name()='PickupRequest' and namespace-uri()='http://schemas.datacontract.org/2004/07/VS10.Freight']/*[local-name()='RequestID' and namespace-uri()='http://schemas.datacontract.org/2004/07/VS10.Freight']", XsdType = @"int")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"PickupRequest"})]
        public sealed class PickupRequest : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public PickupRequest() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "PickupRequest";
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
        
        [Schema(@"http://schemas.datacontract.org/2004/07/VS10.Freight",@"DispatchFault")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"DispatchFault"})]
        public sealed class DispatchFault : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public DispatchFault() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "DispatchFault";
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
        
        [Schema(@"http://schemas.datacontract.org/2004/07/VS10.Freight",@"LTLShipment")]
        [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.Int32), "ID", XPath = @"/*[local-name()='LTLShipment' and namespace-uri()='http://schemas.datacontract.org/2004/07/VS10.Freight']/*[local-name()='ID' and namespace-uri()='http://schemas.datacontract.org/2004/07/VS10.Freight']", XsdType = @"int")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"LTLShipment"})]
        public sealed class LTLShipment : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public LTLShipment() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "LTLShipment";
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
        
        [Schema(@"http://schemas.datacontract.org/2004/07/VS10.Freight",@"LTLFault")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"LTLFault"})]
        public sealed class LTLFault : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public LTLFault() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "LTLFault";
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
}
