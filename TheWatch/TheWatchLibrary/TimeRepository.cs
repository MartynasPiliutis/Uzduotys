using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheWatchLibrary;

namespace TheWatchLibrary
{
    public class TimeRepository
    {
        private List<TheHands> YourWatchList;
        public TimeRepository()
        {
            YourWatchList = new List<TheHands>();
            YourWatchList.Add(new TheHands(RequestHourInput(), RequestMinuteInput()));
        }

        public int RequestHourInput()
        {
            Console.Write("Please enter value of hour: ");
            bool checkHourInput = int.TryParse(Console.ReadLine(), out int hourInput);
            bool checkHourValid = CheckHourInputValid(hourInput);

            while (checkHourInput == false || checkHourValid == false)
            {
                Console.WriteLine("Wrong input. Hit any key to try again..");
                AnyKeyHitDetector();
                Console.Write("Please enter value of hour (between 0 and 11): ");

                checkHourInput = int.TryParse(Console.ReadLine(), out hourInput);
                checkHourValid = CheckHourInputValid(hourInput);
            }
            int hour = hourInput;
            return hour;
        }

        public int RequestMinuteInput()
        {
            Console.Write("Please enter value of minutes: ");
            bool checkMinuteInput = int.TryParse(Console.ReadLine(), out int minuteInput);
            bool checkMinuteValid = CheckMinuteInputValid(minuteInput);

            while (checkMinuteInput == false || checkMinuteValid == false)
            {
                Console.WriteLine("Wrong input. Hit any key to try again..");
                AnyKeyHitDetector();
                Console.Write("Please enter value of minutes (between 0 and 59): ");
                checkMinuteInput = int.TryParse(Console.ReadLine(), out minuteInput);
                checkMinuteValid = CheckMinuteInputValid(minuteInput);
            }
            int minute = minuteInput;
            return minute;
        }

        public void PrintTime()
        {
            Console.WriteLine($"Jusu ivestas laikas yra: {YourWatchList[0].Hour.ToString("D2")}:{YourWatchList[0].Minute.ToString("D2")}");
            Console.ReadLine();
        }

        public bool CheckHourInputValid(int h)
        {
            if (h >= 0 && h < 24)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CheckMinuteInputValid(int min)
        {
            if (min >= 0 && min < 60)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void AnyKeyHitDetector()
        {
            Console.ReadKey();
            Console.SetCursorPosition(0, Console.CursorTop - 1);
            Console.WriteLine();
            Console.WriteLine("<<< ANY KEY DETECTED >>>");
            Console.WriteLine();
        }

    }
}
