using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MusicStoreWebApplication
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            MusicServiceProxy.MusicServiceClient client = new MusicServiceProxy.MusicServiceClient();
            MusicServiceProxy.ReleaseSearch search = new MusicServiceProxy.ReleaseSearch();

            if (ddlSearchType.Text == "Artist")
            {
                search.ArtistName = txtSearch.Text.Replace(" ", "\\ ");
            }
            else if (ddlSearchType.Text == "Album Name")
            {
                search.ReleaseName = txtSearch.Text.Replace(" ", "\\ ");
            }

            MusicServiceProxy.ReleaseResult[] result = client.findReleases(search);

            AlbumWebControl album;


            List<string> addedSongs = new List<string>();
            int numAdded = 0;
            foreach (MusicServiceProxy.ReleaseResult r in result)
            {
                if (numAdded > 20) break;
                if ((int.Parse(r.Score) > 50) &&
                    !addedSongs.Contains(r.Title) &&
                    (r.Type == "Album"))
                {
                    album = (AlbumWebControl)LoadControl("~/AlbumWebControl.ascx");
                    album.AlbumName = r.Title;
                    album.Price = (double.Parse(r.Score)/10).ToString("C0");
                    album.Date = r.Date;
                    album.NumTracks = r.TrackCount;
                    album.Artist = r.Artist;
                    PlaceHolder1.Controls.Add(album);
                    addedSongs.Add(r.Title);
                    numAdded++;
                }
  
            }
           
        }
    }
}
