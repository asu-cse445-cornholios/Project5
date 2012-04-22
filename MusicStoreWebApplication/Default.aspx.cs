using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OrderSystemLibrary;

namespace MusicStoreWebApplication
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }


        protected void btnSearch_Click(object sender, EventArgs e)
        {
            Album[] albums;

            if (ddlSearchType.Text == "Artist")
            {
                albums = AlbumSearch.searchByArtist(txtSearch.Text);
            }
            else //ddlSearchType.Text == "Album Name")
            {
                albums = AlbumSearch.searchByAlbum(txtSearch.Text);
            }


            foreach (var a in albums)
            {
                AlbumWebControl newAlbumWebControl = (AlbumWebControl)LoadControl("~/AlbumWebControl.ascx");
                newAlbumWebControl.Album = a;
                PlaceHolder1.Controls.Add(newAlbumWebControl);
            }


        }
    }
}
