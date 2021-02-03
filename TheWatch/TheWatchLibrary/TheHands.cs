using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheWatchLibrary
{
    public class TheHands
    {
        public int Hour { get; set; }
        public int Minute { get; set; }

        public TheHands(int hour, int minute)
        {
            Hour = hour;
            Minute = minute;
        }


    }
}
