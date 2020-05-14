using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using UWPMusicLibrary.Model;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UWPMusicLibrary
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private List<MainMenuItem> MainMenuItems;
        private ObservableCollection<Album> Albums;

        public MainPage()
        {
            this.InitializeComponent();
            Albums = new ObservableCollection<Album>();
            AlbumManager.GetAllAlbums(Albums);

            MainMenuItems = new List<MainMenuItem>();
            MainMenuItems.Add(new MainMenuItem { IconFile = "Assets/Icons/home.png", Category = MainMenuCategory.Home });
            MainMenuItems.Add(new MainMenuItem { IconFile = "Assets/Icons/search.png", Category = MainMenuCategory.Search });

            var enumValue = MainMenuCategory.CreatePlayList;
            string stringValue = enumValue.ToDescription();
            //MainMenuCategory createPlayList = (MainMenuCategory)Enum.Parse(typeof(MainMenuCategory), stringValue);


            MainMenuItems.Add(new MainMenuItem { IconFile = "Assets/Icons/create.png", Category = MainMenuCategory.CreatePlayList });
            MainMenuItems.Add(new MainMenuItem { IconFile = "Assets/Icons/mylibrary.png", Category = MainMenuCategory.MyLibrary });            

        }

        private void MainMenuItemsListView_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void AlbumGridView_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
    }
}
