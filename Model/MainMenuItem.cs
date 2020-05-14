using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace UWPMusicLibrary.Model
{
    public enum MainMenuCategory
    {
        Home = 1,
        Search = 2,
        [Description("Create PlayList")]
        CreatePlayList = 3,
        [Description("My Library")]
        MyLibrary = 4
    }

    public class MainMenuItem
    {
        public string IconFile { get; set; }
        public MainMenuCategory Category {get;set;}

    }
}
