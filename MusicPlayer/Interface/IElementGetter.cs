﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace MusicPlayer.Interface
{
    // 他のクラスでもMainPageのUIElementだけにアクセスできるように作った
    public interface IElementGetter
    {
        List<UIElement> Element { get; }
    }
}
