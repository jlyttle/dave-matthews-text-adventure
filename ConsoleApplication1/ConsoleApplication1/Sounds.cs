using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DaveMatthewsTextAdventure
{
    class Sounds
    {
        public static void Play()
        {
            WMPLib.WindowsMediaPlayer pssPss = new WMPLib.WindowsMediaPlayer();
            (pssPss.settings as WMPLib.IWMPSettings).setMode("loop", true);
            string filePath = Path.GetFullPath("daveDeath.wav");
            pssPss.URL = filePath;
           // pssPss.Play
        }
    }
}
