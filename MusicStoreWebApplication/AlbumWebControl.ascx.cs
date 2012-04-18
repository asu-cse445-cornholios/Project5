using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MusicStoreWebApplication
{
    public partial class AlbumWebControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public string AlbumName
        {
            get { return lblAlbumName.Text; }
            set { lblAlbumName.Text = value; }
        }

        public string Artist
        {
            get { return lblArtist.Text; }
            set { lblArtist.Text = value; }
        }

        public string Rating
        {
            get { return lblRating.Text; }
            set { lblRating.Text = value; }
        }
        public string Price
        {
            get { return lblPrice.Text; }
            set { lblPrice.Text = value; }
        }
    }
}