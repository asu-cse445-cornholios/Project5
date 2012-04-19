<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Administration.aspx.cs" Inherits="MusicStoreWebApplication.AdministrationPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="accountInfo" __designer:mapid="b2">
    <p>
        Please enter your username and password.
        </p>
        <fieldset class="login" __designer:mapid="b3">
            <legend __designer:mapid="b4">Account Information</legend>
            <p __designer:mapid="b5">
                <asp:Label ID="UserNameLabel" runat="server" AssociatedControlID="UserName">Username:</asp:Label>
                <asp:TextBox ID="acctName" runat="server" CssClass="textEntry"></asp:TextBox>
                <asp:RequiredFieldValidator ID="UserNameRequired" runat="server" ControlToValidate="UserName" 
                             CssClass="failureNotification" 
                    ErrorMessage="User Name is required." ToolTip="User Name is required." 
                             ValidationGroup="LoginUserValidationGroup">*</asp:RequiredFieldValidator>
            </p>
            <p __designer:mapid="b9">
                <asp:Label ID="PasswordLabel" runat="server" AssociatedControlID="Password" 
                    Height="24px" Width="352px">Password:</asp:Label>
                <asp:TextBox ID="acctPassword" runat="server" CssClass="passwordEntry" 
                            TextMode="Password" Width="320px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="PasswordRequired" runat="server" ControlToValidate="Password" 
                             CssClass="failureNotification" 
                    ErrorMessage="Password is required." ToolTip="Password is required." 
                             ValidationGroup="LoginUserValidationGroup">*</asp:RequiredFieldValidator>
            </p>
        </fieldset><p class="submitButton" __designer:mapid="c0" align="left" dir="rtl">
            <asp:Button ID="LoginButton" runat="server" CommandName="Login" Text="Log In" 
                        ValidationGroup="LoginUserValidationGroup" 
                onclick="LoginButton_Click"/>
        </p>
    </div>
    <br />
    <asp:PlaceHolder ID="validatePlaceHolder" runat="server"></asp:PlaceHolder>
</asp:Content>
