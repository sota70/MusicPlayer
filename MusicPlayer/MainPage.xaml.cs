using MusicPlayer.MusicList;
using MusicPlayer.Interface;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// 空白ページの項目テンプレートについては、https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x411 を参照してください

namespace MusicPlayer
{
    /// <summary>
    /// それ自体で使用できる空白ページまたはフレーム内に移動できる空白ページ。
    /// </summary>
    public sealed partial class MainPage : Page, IElementGetter
    {
        private static MainPage instance;

        public MainPage()
        {
            this.InitializeComponent();
            instance                                  = this;
            IMusic sampleMusic                        = new SampleMusic();
            /*　もし曲名とアーティスト名を変えたい場合はこうする
            ((IMusicNameSetter)sampleMusic).MusicName = "NameChanged";
            ((IMusicArtistSetter)sampleMusic).Artist  = "ArtistChanged";
            */
            sampleMusic.Play();
        }

        public static MainPage getInstance()
        {
            return instance;
        }

        public TextBlock textBlock
        {
            get => NameDisplay;
        }
    }
}
