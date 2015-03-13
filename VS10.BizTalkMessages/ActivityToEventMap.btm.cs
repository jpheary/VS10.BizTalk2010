namespace BizTalk {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"BizTalk.Activity", typeof(global::BizTalk.Activity))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"BizTalk.Event", typeof(global::BizTalk.Event))]
    public sealed class ActivityToEventMap : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0"" version=""1.0"" xmlns:s0=""http://ArgixLogistics.Activity"" xmlns:ns0=""http://Argix.Event"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:Activity"" />
  </xsl:template>
  <xsl:template match=""/s0:Activity"">
    <ns0:Event>
      <xsl:attribute name=""id"">
        <xsl:value-of select=""@type"" />
      </xsl:attribute>
      <xsl:attribute name=""site"">
        <xsl:value-of select=""Location/text()"" />
      </xsl:attribute>
      <xsl:attribute name=""time"">
        <xsl:value-of select=""Timestamp/text()"" />
      </xsl:attribute>
      <xsl:value-of select=""Notes/text()"" />
    </ns0:Event>
  </xsl:template>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"BizTalk.Activity";
        
        private const string _strTrgSchemasList0 = @"BizTalk.Event";
        
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
                _SrcSchemas[0] = @"BizTalk.Activity";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"BizTalk.Event";
                return _TrgSchemas;
            }
        }
    }
}
