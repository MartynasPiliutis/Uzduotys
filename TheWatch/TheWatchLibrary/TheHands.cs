using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheWatchLibrary
{
    public class TheHands
    {
        public int Mminute { get; private set; }
        public int Hour { get; private set; }

        public TheHands(int mminute, int hour)
        {
            Mminute = mminute;
            Hour = hour;
        }
    }
}
