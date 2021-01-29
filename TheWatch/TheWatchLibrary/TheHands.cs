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

        public bool CheckHourInputValid(int hour)
        {
            if (hour >= 0 && hour <= 24)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ChecMinuteInputValid(int minute)
        {
            if (minute >= 0 && minute <= 60)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
