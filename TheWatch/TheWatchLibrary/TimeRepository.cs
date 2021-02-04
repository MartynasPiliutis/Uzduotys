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
        ProgramFunctions programFunctions = new ProgramFunctions();
        public List<TheHands> YourWatchList;
        public TimeRepository()
        {
            YourWatchList = new List<TheHands>();
            YourWatchList.Add(new TheHands(RequestHourInput(), RequestMinuteInput()));
        }

        public int RequestHourInput()   //Request of the hour of time and check if the input is correct
        {
            Console.Write("Please enter value of hour: ");
            bool checkHourInput = int.TryParse(Console.ReadLine(), out int hourInput);
            bool checkHourValid = programFunctions.CheckHourInputValid(hourInput);

            while (checkHourInput == false || checkHourValid == false)
            {
                programFunctions.WrongInputMessage();
                Console.Write("Please enter value of hour (between 0 and 11): ");

                checkHourInput = int.TryParse(Console.ReadLine(), out hourInput);
                checkHourValid = programFunctions.CheckHourInputValid(hourInput);
            }
            int hour = hourInput;
            return hour;
        }

        public int RequestMinuteInput() //Request of the minutes of time and check if the input is correct
        {
            Console.Write("Please enter value of minutes: ");
            bool checkMinuteInput = int.TryParse(Console.ReadLine(), out int minuteInput);
            bool checkMinuteValid = programFunctions.CheckMinuteInputValid(minuteInput);

            while (checkMinuteInput == false || checkMinuteValid == false)
            {
                programFunctions.WrongInputMessage();
                Console.Write("Please enter value of minutes (between 0 and 59): ");
                checkMinuteInput = int.TryParse(Console.ReadLine(), out minuteInput);
                checkMinuteValid = programFunctions.CheckMinuteInputValid(minuteInput);
            }
            int minute = minuteInput;
            return minute;
        }
    }
}
