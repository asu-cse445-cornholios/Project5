<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ManageShoppingCartControl.ascx.cs" Inherits="MusicStoreWebApplication.ManageShoppingCartControl" %>
<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
    DataSourceID="ShoppingCartLinqDataSource">
    <Columns>
        <asp:BoundField DataField="Item" HeaderText="Item" ReadOnly="True" 
            SortExpression="Item" />
        <asp:BoundField DataField="Price" HeaderText="Price" ReadOnly="True" 
            SortExpression="Price" />
        <asp:BoundField DataField="Quantity" HeaderText="Quantity" ReadOnly="True" 
            SortExpression="Quantity" />
        <asp:BoundField DataField="Modified" HeaderText="Modified" ReadOnly="True" 
            SortExpression="Modified" />
        <asp:BoundField DataField="Created" HeaderText="Created" ReadOnly="True" 
            SortExpression="Created" />
    </Columns>
</asp:GridView>
<asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
    Text="Submit Order" />
<asp:TextBox ID="txtUsername" runat="server" Visible="False"></asp:TextBox>
<br />
<asp:Label ID="lblSuccess" runat="server"></asp:Label>
<asp:LinqDataSource ID="ShoppingCartLinqDataSource" runat="server" 
    ContextTypeName="OrderSystemLibrary.ShoppingCartContext" EntityTypeName="" 
    Select="new (Item, Price, Quantity, Modified, Created)" TableName="CartItems" 
    Where="ShoppingCart.Username == @ShoppingCart">
    <WhereParameters>
        <asp:ControlParameter ControlID="txtUsername" Name="ShoppingCart" 
            PropertyName="Text" Type="Object" />
    </WhereParameters>
</asp:LinqDataSource>

