using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using MusicPlayer.Interface;

namespace MusicPlayer.Events
{
    class ButtonPointer : IEvent
    {
        public void registerEvents()
        {
            MainPage mainPage                        = MainPage.getInstance();
            Button musicListButton                   = mainPage.MusicListButton;
            musicListButton.PointerEntered          += pointerEntered;
            musicListButton.PointerExited           += pointerExited;
        }

        private void pointerEntered(object sender, PointerRoutedEventArgs args)
        {

        }

        private void pointerExited(object sender, PointerRoutedEventArgs args)
        {

        }
    }
}
