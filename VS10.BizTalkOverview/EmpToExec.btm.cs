namespace Argix {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Argix.Employee", typeof(global::Argix.Employee))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Argix.Executive", typeof(global::Argix.Executive))]
    public sealed class EmpToExec : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:ns0=""http://Argix.Executive"" xmlns:s0=""http://Argix.Employee"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:Employee"" />
  </xsl:template>
  <xsl:template match=""/s0:Employee"">
    <xsl:variable name=""var:v1"" select=""userCSharp:StringUpperCase(string(Name/First/text()))"" />
    <xsl:variable name=""var:v2"" select=""userCSharp:StringUpperCase(string(Name/Last/text()))"" />
    <ns0:Executive>
      <xsl:attribute name=""id"">
        <xsl:value-of select=""Personal/SSN/text()"" />
      </xsl:attribute>
      <xsl:if test=""@Grade"">
        <xsl:attribute name=""level"">
          <xsl:value-of select=""@Grade"" />
        </xsl:attribute>
      </xsl:if>
      <Name>
        <xsl:attribute name=""fname"">
          <xsl:value-of select=""$var:v1"" />
        </xsl:attribute>
        <xsl:attribute name=""lname"">
          <xsl:value-of select=""$var:v2"" />
        </xsl:attribute>
      </Name>
    </ns0:Executive>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public string StringUpperCase(string str)
{
	if (str == null)
	{
		return """";
	}
	return str.ToUpper(System.Globalization.CultureInfo.InvariantCulture);
}



]]></msxsl:script>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"Argix.Employee";
        
        private const string _strTrgSchemasList0 = @"Argix.Executive";
        
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
                _SrcSchemas[0] = @"Argix.Employee";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"Argix.Executive";
                return _TrgSchemas;
            }
        }
    }
}
