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
        private string name        = "Sample";
        private string artist      = "Sota";
        private string description = "これはサンプルの曲です";

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

        public string Description
        {
            get => description;
            set
            {
                // ※補足 もし説明文が無かったら”説明なし”と置き換える
                description            = value;
                bool descriptionExists = description == null || description.Equals("");
                if (descriptionExists)
                {
                    description = "説明なし";
                }
            }
        }

        public void Play()
        {
            IElementGetter nameDisplayGetter = MainPage.getInstance();
            TextBlock nameDisplay            = (TextBlock)nameDisplayGetter.Element;
            // ※補足 Environment.NewLine => 改行
            nameDisplay.Text                 = "Music Name : " + MusicName + Environment.NewLine +
                                               "Artist : " + Artist + Environment.NewLine +
                                               "Description : " + Description; 
        }
    }
}
