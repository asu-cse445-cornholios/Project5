using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrderSystemLibrary
{
    public static class AlbumSearch
    {
        /// <summary>
        /// Returns all albums associated with the specified artist.
        /// </summary>
        /// <param name="artist"></param>
        /// <returns></returns>
        public static Album[] searchByArtist(string artist)
        {
            MusicServiceProxy.MusicServiceClient client = new MusicServiceProxy.MusicServiceClient();
            MusicServiceProxy.ReleaseSearch search = new MusicServiceProxy.ReleaseSearch();

            search.ArtistName = artist.Replace(" ", "\\ ");

            MusicServiceProxy.ReleaseResult[] result = client.findReleases(search);

            List<Album> albumsToReturn = new List<Album>();

            List<string> addedSongs = new List<string>();
            int numAdded = 0;
            foreach (MusicServiceProxy.ReleaseResult r in result)
            {
                if (numAdded > 20) break;
                if ((int.Parse(r.Score) > 50) &&
                    !addedSongs.Contains(r.Title))
                {
                    Album newAlbum = new Album();
                    newAlbum.Name = r.Title;
                    newAlbum.Artist = r.Artist;
                    newAlbum.Date = r.Date;
                    newAlbum.Price = 10;
                    try { newAlbum.TrackCount = int.Parse(r.TrackCount); }
                    catch { newAlbum.TrackCount = 0; }
                    albumsToReturn.Add(newAlbum);
                    addedSongs.Add(r.Title);
                    numAdded++;
                }
            }

            return albumsToReturn.ToArray();
        }

        /// <summary>
        /// Returns all albums which have the specified album name.
        /// </summary>
        /// <param name="album">The name of the album</param>
        /// <returns></returns>
        public static Album[] searchByAlbum(string album)
        {
            MusicServiceProxy.MusicServiceClient client = new MusicServiceProxy.MusicServiceClient();
            MusicServiceProxy.ReleaseSearch search = new MusicServiceProxy.ReleaseSearch();

            search.ReleaseName = album.Replace(" ", "\\ ");

            MusicServiceProxy.ReleaseResult[] result = client.findReleases(search);

            List<Album> albumsToReturn = new List<Album>();

            List<string> addedSongs = new List<string>();
            int numAdded = 0;
            foreach (MusicServiceProxy.ReleaseResult r in result)
            {
                if (numAdded > 20) break;
                if ((int.Parse(r.Score) > 50) &&
                    !addedSongs.Contains(r.Title) &&
                    (r.Type == "Album"))
                {
                    Album newAlbum = new Album();
                    newAlbum.Name = r.Title;
                    newAlbum.Artist = r.Artist;
                    newAlbum.Date = r.Date;
                    newAlbum.Price = 10;
                    try { newAlbum.TrackCount = int.Parse(r.TrackCount); }
                    catch { newAlbum.TrackCount = 0; }
                    albumsToReturn.Add(newAlbum);
                    addedSongs.Add(r.Title);
                    numAdded++;
                }
            }

            return albumsToReturn.ToArray();
        }
    }
}
