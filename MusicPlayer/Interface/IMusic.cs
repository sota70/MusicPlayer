﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer
{
    public interface IMusic : IMusicNameGetter, IMusicNameSetter, IMusicArtistGetter, IMusicArtistSetter
    {
        void Play();
    }
}
