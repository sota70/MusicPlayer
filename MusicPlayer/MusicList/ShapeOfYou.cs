using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicPlayer.Interface;
using Windows.UI.Xaml.Controls;

namespace MusicPlayer.MusicList
{
    class ShapeOfYou : IMusic
    {
        private string musicName   = "ShapeOfYou";
        private string artist      = "EdSheeran";
        private string description = "This is one of my favorite songs";

        public string MusicName
        {
            get => musicName;
            set => musicName = value;
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
            Console.WriteLine("shapeOfYou");
            Console.ReadLine();
        }
    }
}
