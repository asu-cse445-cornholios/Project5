using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OrderSystemLibrary;

namespace MusicStoreWebApplication
{
    public partial class AlbumWebControl : System.Web.UI.UserControl
    {
        private Album _album;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public AlbumWebControl()
        {
        }

        public OrderSystemLibrary.Album Album
        {
            get
            {
                return _album;
            }
            set
            {
                _album = value;
                lblAlbumName.Text = value.Name;
                lblArtist.Text = value.Artist;
                lblNumTracks.Text = value.TrackCount.ToString();
                lblPrice.Text = "$" + value.Price.ToString();
                lblYear.Text = value.Date;
                btnPurchase.OnClientClick = "javascript:purchase('" + HttpUtility.UrlEncode(value.Name) + "');return False;";
            }
        }


    }
}