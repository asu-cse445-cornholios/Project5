<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ShoppingCart.aspx.cs" Inherits="MusicStoreWebApplication.ShoppingCartPage" %>
<%@ Register src="ManageShoppingCartControl.ascx" tagname="ManageShoppingCartControl" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <uc1:ManageShoppingCartControl ID="ManageShoppingCartControl1" runat="server" />
</asp:Content>
