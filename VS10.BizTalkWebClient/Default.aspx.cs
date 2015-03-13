using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

public partial class _Default : System.Web.UI.Page {
    //Members

    //Interface
    protected void Page_Load(object sender, EventArgs e) {
        //
    }
    protected void OnSubmit(object sender, EventArgs e) {
        //
        string uri = "http://127.0.0.1/BizTalkHttpReceiveService/BTSHTTPReceive.dll";
        this.lblStatus.Text = "";
        XmlDocument xmlDocument = new XmlDocument();
        xmlDocument.PreserveWhitespace = true;

        XmlNode xmlNode = xmlDocument.CreateNode(XmlNodeType.Element,"Activity","http://VS10.Activity");
        xmlDocument.AppendChild(xmlNode);
        xmlNode = xmlDocument.CreateNode(XmlNodeType.Attribute,"type","");
        xmlNode.Value = this.ddlType.SelectedItem.Value;
        xmlDocument.DocumentElement.Attributes.Append((XmlAttribute)xmlNode);
        xmlNode = xmlDocument.CreateNode(XmlNodeType.Element,"Location","");
        xmlNode.InnerText = this.txtLocation.Text;
        xmlDocument.DocumentElement.AppendChild(xmlNode);
        xmlNode = xmlDocument.CreateNode(XmlNodeType.Element,"Timestamp","");
        xmlNode.InnerText = DateTime.Now.ToString("s");
        xmlDocument.DocumentElement.AppendChild(xmlNode);
        xmlNode = xmlDocument.CreateNode(XmlNodeType.Element,"Notes","");
        xmlNode.InnerText = this.txtNotes.Text;
        xmlDocument.DocumentElement.AppendChild(xmlNode);

        try {
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(uri);
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = xmlDocument.OuterXml.Length;

            byte[] requestData = new ASCIIEncoding().GetBytes(xmlDocument.OuterXml);

            this.lblStatus.Text += "Submitting activity message";
            Stream stream = request.GetRequestStream();
            stream.Write(requestData,0,requestData.Length);
            stream.Flush();
            stream.Close();

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader streamr = new StreamReader(response.GetResponseStream());
            this.lblStatus.Text = HttpUtility.HtmlEncode(streamr.ReadToEnd()) + "<br>";
        }
        catch (WebException wex) {
            this.lblStatus.Text = "Unable to complete the web request. Web exception error: " + wex.Message;
        }
    }
}
