<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RMA.aspx.cs" Inherits="MusicStoreWebApplication.RMAPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <p>
    <asp:Label ID="labelTitle" runat="server" Font-Bold="True" Font-Names="Tahoma" 
        ForeColor="#3333CC" Text="List of orders:"></asp:Label>
</p>
<p>
</p>
<p>
    <asp:PlaceHolder ID="placeHolder" runat="server" ClientIDMode="Predictable">
    </asp:PlaceHolder>
</p>
</asp:Content>
