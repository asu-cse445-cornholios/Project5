<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="AdminWebControl.ascx.cs" Inherits="MusicStoreWebApplication.AdminWebControl" %>
<style type="text/css">
    div.accountInfo
{
    width: 74%;
}

p
{
    margin-bottom: 10px;
    line-height: 1.6em;
}


fieldset
{
    margin: 1em 0px;
    padding: 1em;
    border: 1px solid #ccc;
        width: 372px;
    }

legend 
{
    font-size: 1.1em;
    font-weight: 600;
    padding: 2px 4px 8px 4px;
}

fieldset p 
{
    margin: 2px 12px 10px 10px;
        width: 351px;
    }

fieldset.login label, fieldset.register label, fieldset.changePassword label
{
    display: block;
}

input.textEntry 
{
    width: 320px;
    border: 1px solid #ccc;
}

.failureNotification
{
    font-size: 1.2em;
    color: Red;
}

input.passwordEntry 
{
    border: 1px solid #ccc;
}

.submitButton
{
    text-align: right;
    padding-right: 10px;
        width: 230px;
        margin-right: 0px;
    }</style>

<div class="accountInfo">
    <p>
        Invalid Password or Username. Please try again or create new account below.</p>
    <fieldset class="login">
        <legend>Create New User</legend>
        <p>
            <asp:Label ID="UserNameLabel" runat="server" AssociatedControlID="UserName">Username:</asp:Label>
            <asp:TextBox ID="user" runat="server" CssClass="textEntry" 
                ontextchanged="user_TextChanged"></asp:TextBox>
            <asp:RequiredFieldValidator ID="UserNameRequired" runat="server" ControlToValidate="UserName" 
                             CssClass="failureNotification" 
                ErrorMessage="User Name is required." ToolTip="User Name is required." 
                             ValidationGroup="LoginUserValidationGroup">*</asp:RequiredFieldValidator>
        </p>
        <p>
            <asp:Label ID="PasswordLabel" runat="server" AssociatedControlID="Password" 
                Height="24px" Width="352px">Password:</asp:Label>
            <asp:TextBox ID="pass" runat="server" CssClass="passwordEntry" 
                            TextMode="Password" Width="320px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="PasswordRequired" runat="server" ControlToValidate="Password" 
                             CssClass="failureNotification" 
                ErrorMessage="Password is required." ToolTip="Password is required." 
                             ValidationGroup="LoginUserValidationGroup">*</asp:RequiredFieldValidator>
        </p>
        <p>
            <asp:Label ID="PasswordLabel0" runat="server" AssociatedControlID="Password" 
                Height="24px" Width="352px">Confirm Password:</asp:Label>
            <asp:TextBox ID="confirmPass" runat="server" CssClass="passwordEntry" 
                            TextMode="Password" Width="320px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="PasswordRequired0" runat="server" ControlToValidate="Password" 
                             CssClass="failureNotification" 
                ErrorMessage="Password is required." ToolTip="Password is required." 
                             ValidationGroup="LoginUserValidationGroup">*</asp:RequiredFieldValidator>
            <asp:RequiredFieldValidator ID="PasswordRequired1" runat="server" ControlToValidate="Password" 
                             CssClass="failureNotification" 
                ErrorMessage="Password is required." ToolTip="Password is required." 
                             ValidationGroup="LoginUserValidationGroup">*</asp:RequiredFieldValidator>
        </p>
    </fieldset><p class="submitButton" align="left" dir="ltr">
        <asp:Button ID="CreateButton" runat="server" CommandName="Create" Text="Create User" 
                        ValidationGroup="CreateUserValidationGroup" 
            onclick="LoginButton_Click"/>
    </p>
    <p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label1" runat="server" Font-Bold="True"></asp:Label>
    </p>
</div>

