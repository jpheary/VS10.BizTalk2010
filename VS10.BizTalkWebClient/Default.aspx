<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>Generate an Activity</h2>
    <hr />
    <table>
        <tr><td style="width:100px; text-align:right">Type</td><td>
            <asp:DropDownList ID="ddlType" runat="server">
                <asp:ListItem Text="1" Value="1" />
                <asp:ListItem Text="2" Value="2" />
                <asp:ListItem Text="3" Value="3" />
                <asp:ListItem Text="4" Value="4" />
                <asp:ListItem Text="5" Value="5" />
                <asp:ListItem Text="6" Value="6" />
                <asp:ListItem Text="7" Value="7" />
                <asp:ListItem Text="8" Value="8" />
                <asp:ListItem Text="9" Value="9" />
                <asp:ListItem Text="10" Value="10" />
            </asp:DropDownList>
        </td></tr>
        <tr><td style="width:100px; text-align:right">Location</td><td><asp:TextBox ID="txtLocation" runat="server" Width="400px" Text="" /></td></tr>
        <tr><td style="width:100px; text-align:right">Notes</td><td><asp:TextBox ID="txtNotes" runat="server" Text="" Width="400px" /></td></tr>
        <tr><td style="width:100px; text-align:right">&nbsp;</td><td><asp:Button ID="btnSubmit" runat="server" Width="75px" Height="25px" Text="Submit" OnClick="OnSubmit" /></td></tr>
    </table>
    <asp:Label ID="lblStatus" runat="server" Text="" />
</asp:Content>
