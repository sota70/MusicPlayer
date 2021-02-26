using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer
{
    public interface IMusicSettable
    {
        string MusicName   { set; }
        string Artist      { set; }
        string Description { set; }
    }
}
