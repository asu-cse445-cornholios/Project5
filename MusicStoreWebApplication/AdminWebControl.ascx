<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="AdminWebControl.ascx.cs" Inherits="MusicStoreWebApplication.AdminWebControl" %>
<style type="text/css">
    div.accountInfo
{
    width: 63%;
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
        width: 402px;
        height: 147px;
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

    <asp:Panel ID="LoginPanel" runat="server" BackColor="#E9EBFE" 
    Visible="False">
        <div class="accountInfo" style="background-color: #E9EBFE; margin-left: 111px;">
            <p>
                Please enter your username and password.
            </p>
            <fieldset class="login">
                <legend>Account Information</legend>
                <p>
                    <asp:Label ID="UserNameLabel" runat="server" AssociatedControlID="acctName">Username:</asp:Label>
                    <asp:TextBox ID="acctName" runat="server" CssClass="textEntry"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="UserNameRequired" runat="server" ControlToValidate="acctName" 
                             CssClass="failureNotification" 
                    ErrorMessage="User Name is required." ToolTip="User Name is required." 
                             ValidationGroup="LoginUserValidationGroup">*</asp:RequiredFieldValidator>
                </p>
                <p>
                    <asp:Label ID="PasswordLabel" runat="server" AssociatedControlID="acctPassword" 
                    Height="24px" Width="352px">Password:</asp:Label>
                    <asp:TextBox ID="acctPassword" runat="server" CssClass="passwordEntry" 
                            TextMode="Password" Width="320px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="PasswordRequired" runat="server" ControlToValidate="acctPassword" 
                             CssClass="failureNotification" 
                    ErrorMessage="Password is required." ToolTip="Password is required." 
                             ValidationGroup="LoginUserValidationGroup">*</asp:RequiredFieldValidator>
                </p>
            </fieldset><p class="submitButton" align="left" dir="rtl">
                <asp:Button ID="LoginButton" runat="server" CommandName="Login" Text="Log In" 
                        ValidationGroup="LoginUserValidationGroup" 
                onclick="LoginButton_Click"/>
            </p>
            <p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label" runat="server"></asp:Label>
            </p>
        </div>
</asp:Panel>
<asp:Panel ID="DeleteUser" runat="server" Visible="False" BackColor="White" 
    Height="380px">
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Panel ID="Panel1" runat="server" BackColor="White" Height="280px" 
        Width="411px" style="margin-left: 30px">
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Large" 
            Text="Users:"></asp:Label>
        <br />
        <asp:Label ID="outputLabel" runat="server"></asp:Label>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="enterLabel" runat="server" Text="Enter User to Delete:"></asp:Label>
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="deleteBox" runat="server" Width="124px"></asp:TextBox>
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="DeleteBtn" runat="server" Text="Delete User" 
            onclick="DeleteBtn_Click" />
        <br />
    </asp:Panel>
</asp:Panel>

    

