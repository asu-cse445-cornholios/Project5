<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="RMAWebUserControl.ascx.cs" Inherits="MusicStoreWebApplication.RMAWebUserControl" %>
<p>
    Order Id:
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
&nbsp;&nbsp;&nbsp; Submitted at:
    <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
        Text="Submit RMA" />
</p>
<p>
    <asp:GridView ID="GridView1" runat="server">
    </asp:GridView>
</p>

