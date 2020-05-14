using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWPMusicLibrary.Model
{
    public enum AlbumCategory
    {
        Instrumental,
        Lullabies
    }
    public class Album
    {
        public string Name { get; set; }
        public AlbumCategory Category { get; set; }
        public string AudioFile { get; set; }
        public string ImageFile { get; set; }

        public Album(string name, AlbumCategory category)
        {
            this.Name = name;
            this.Category = category;
            AudioFile = $"/Assets/Audio/{category}/{name}.mp3";
            ImageFile = $"/Assets/Images/{category}/{name}.png";
        }
    }
}
