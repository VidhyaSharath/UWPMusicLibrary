using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWPMusicLibrary.Model
{
    public static class AlbumManager
    {
        public static void GetAllAlbums(ObservableCollection<Album> albums)
        {
            var allAlbums = getAlbums();
            albums.Clear();
            /* foreach(var sound in allSounds)
               {
                   sounds.Add(sound);
               }   */
            allAlbums.ForEach(album => albums.Add(album));
        }

      /*  public static void GetSoundsByCategory(ObservableCollection<Album> sounds, AlbumCategory category)
        {
            var allSounds = getAlbums();
            var filteredSounds = allSounds.Where(sound => sound.Category == category).ToList();
            sounds.Clear();
            filteredSounds.ForEach(sound => sounds.Add(sound));
        }   */

        private static List<Album> getAlbums()
        {
            var albums = new List<Album>();
            albums.Add(new Album("Instrumental", AlbumCategory.Instrumental));
            albums.Add(new Album("Lullabies", AlbumCategory.Lullabies));
            return albums;

        }
    }
}
