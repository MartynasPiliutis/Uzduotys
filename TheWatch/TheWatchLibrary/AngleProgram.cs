using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheWatchLibrary
{
    public class AngleProgram
    {
        public double CalculateArrowsAngle(List<TheHands> YourWatchList)    //Calculates angle between arrows
        {
            int hour = YourWatchList[0].Hour;
            int minute = YourWatchList[0].Minute;
            if (hour > 11)
            {
                hour = hour - 12;
            }
            double hourAngle = hour * 30 + minute * 0.5;
            double minuteAngle = minute * 6;
            double arrowAngle = minuteAngle - hourAngle;

            if (arrowAngle > 180)
            {
                arrowAngle = 360 - arrowAngle;
            }
            else if (arrowAngle < 0)
            {
                if (arrowAngle < -180)
                {
                    arrowAngle += 360;
                }
                else
                {
                    arrowAngle *= -1;
                }
            }
            return arrowAngle;
        }
    }
}
