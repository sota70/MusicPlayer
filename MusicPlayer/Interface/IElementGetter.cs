using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace MusicPlayer.Interface
{
    public interface IElementGetter
    {
        UIElement Element { get; }
    }
}
