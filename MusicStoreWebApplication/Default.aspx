<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="MusicStoreWebApplication._Default" %>

<%@ Register TagPrefix="My" TagName="EventUserControl" Src="AlbumWebControl.ascx" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
    <style type="text/css">
    </style>
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2 class="style1" align="center">
        Search&nbsp;
        <asp:DropDownList ID="ddlSearchType" runat="server" Height="23px" Width="115px">
            <asp:ListItem>Artist</asp:ListItem>
            <asp:ListItem>Album Name</asp:ListItem>
        </asp:DropDownList>
&nbsp;<asp:TextBox ID="txtSearch" runat="server" Width="279px"></asp:TextBox>
&nbsp;<asp:Button ID="btnSearch" runat="server" onclick="btnSearch_Click" Text="Go" />
    </h2>
    <p class="style1">
        &nbsp;
        <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
        <asp:Label ID="lblError" runat="server" Visible="False"></asp:Label>
    </p>
    <span id="MySpan" runat="server"/>
</asp:Content>