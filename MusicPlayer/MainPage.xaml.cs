using MusicPlayer.MusicList;
using MusicPlayer.Interface;
using MusicPlayer.Data;
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
            instance           = this;
            IMusic sampleMusic = new SampleMusic();
            IMusic shapeOfYou  = new ShapeOfYou();
            DataManager.SetData(sampleMusic);
            DataManager.SetData(shapeOfYou);
            // IMusicインターフェースとDataManagerクラスの挙動確認
            IMusic sampleMusicFromDataBase = (IMusic)DataManager.GetData(sampleMusic);
            IMusic shapeOfYouFromDataBase  = (IMusic)DataManager.GetData(shapeOfYou);
            sampleMusicFromDataBase.Play();
            shapeOfYouFromDataBase.Play();
            DataManager.SwitchDataPosition(sampleMusicFromDataBase, shapeOfYouFromDataBase);
        }

        public static MainPage getInstance()
        {
            return instance;
        }

        public List<UIElement> Element
        {
            get
            {
                var elementList = new List<UIElement>();
                elementList.Add(MusicListButton);
                return elementList;
            }
        }
    }
}
