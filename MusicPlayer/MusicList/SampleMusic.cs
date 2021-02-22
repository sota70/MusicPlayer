using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using MusicPlayer.Interface;

namespace MusicPlayer.MusicList
{
    class SampleMusic : IMusic
    {
        private string name   = "Sample";
        private string artist = "Sota";

        public string MusicName
        {
            get => name;
            set => name = value;
        }

        public string Artist
        {
            get => artist;
            set => artist = value;
        }

        public void Play()
        {
            IElementGetter nameDisplayGetter = MainPage.getInstance();
            TextBlock nameDisplay            = (TextBlock)nameDisplayGetter.Element;
            // ※補足 Environment.NewLine => 改行
            nameDisplay.Text                 = "The music name is : " + MusicName + Environment.NewLine + 
                                               "By " + Artist;
        }
    }
}
