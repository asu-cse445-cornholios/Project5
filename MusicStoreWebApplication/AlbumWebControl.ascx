<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="AlbumWebControl.ascx.cs" Inherits="MusicStoreWebApplication.AlbumWebControl" %>
<style type="text/css">
    .a1
    {
        width: 53px;
    }
    .a2
    {
        width: 50px;
    }
    .a3
    {
        width: 102px;
        text-align: center;
    }
    .a4
    {
        width: 330px;
    }
    .a5
    {
        height: 46px;
    }
    .style1
    {
        height: 45px;
    }
    .style2
    {
        text-align: center;
    }
</style>
<table style="border: thin solid #000000; margin: 10px 0px 10px 0px; width:100%; padding-right: 10px; padding-left: 10px;" 
    bgcolor="#E9EBFE">
    <tr>
        <td colspan="4" class="style1">
            <h1>
            <asp:Label ID="lblAlbumName" runat="server" Font-Bold="True" Font-Size="X-Large" 
                Text="Album Name"></asp:Label>
            </h1>
        </td>
        <td>
            <h1 class="style2">
            <asp:Label ID="lblPrice" runat="server" Text="Label" Font-Bold="True" 
                    Font-Size="Larger"></asp:Label>
            </h1>
        </td>
    </tr>
    <tr>
        <td class="a1">
            <b>Artist:</b></td>
        <td>
            <asp:Label ID="lblArtist" runat="server" Text="Label"></asp:Label>
        </td>
        <td class="a2">
            <b>Year:</b></td>
        <td class="a4">
            <asp:Label ID="lblYear" runat="server" Text="Label"></asp:Label>
        </td>
        <td rowspan="2" class="a3">
            <asp:Button ID="Button1" runat="server" Text="Purchase" 
                style="text-align: center" />
        </td>
    </tr>
    <tr>
        <td class="a1">
            <b>Rating:</b></td>
        <td>
            <asp:Label ID="lblRating" runat="server" Text="Label"></asp:Label>
        </td>
        <td class="a2">
            <b>Price:</b></td>
        <td class="a4">
            &nbsp;</td>
    </tr>
</table>

