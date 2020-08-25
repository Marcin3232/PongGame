using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PongGame
{
    class PlaySound
    {
        public PlaySound(int index, List<System.Media.SoundPlayer> soundlist)
        {
            soundlist[index].Play();
        }
    }
}
