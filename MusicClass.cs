using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PongGame
{
    class MusicClass
    {
        public List<System.Media.SoundPlayer> soundlist = new List<System.Media.SoundPlayer>();

        public MusicClass(List<System.Media.SoundPlayer> soundlist)
        {
            soundlist.Add(new System.Media.SoundPlayer(Properties.Resources.loseBall));
            soundlist.Add(new System.Media.SoundPlayer(Properties.Resources.hitDisc));
            soundlist.Add(new System.Media.SoundPlayer(Properties.Resources.jumpToWall));
            soundlist.Add(new System.Media.SoundPlayer(Properties.Resources.Click));
            soundlist.Add(new System.Media.SoundPlayer(Properties.Resources.Win));
            soundlist.Add(new System.Media.SoundPlayer(Properties.Resources.GameOver));

        }

    }
}
