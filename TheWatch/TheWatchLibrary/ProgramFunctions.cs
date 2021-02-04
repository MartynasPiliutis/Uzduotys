using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheWatchLibrary
{
    public class ProgramFunctions
    {
        // ============ These functions shows messages in console ============

        public void PrintTime(List<TheHands> YourWatchList) //Shows the time given by user
        {
            int cmdWith = Console.WindowWidth;
            Console.SetCursorPosition(cmdWith / 2 - 8, Console.CursorTop);
            Console.WriteLine("The time given:");
            Console.SetCursorPosition(cmdWith / 2 - 3, Console.CursorTop);
            Console.WriteLine($"{ YourWatchList[0].Hour.ToString("D2")}:{ YourWatchList[0].Minute.ToString("D2")}");
        }

        public void PrintAngle(double arrowAngle)   //Shows the angle between arrows mathematically
        {
            int cmdWith = Console.WindowWidth;

            Console.SetCursorPosition(cmdWith / 2 - 11, Console.CursorTop);
            Console.WriteLine("Angle between arrows:");
            Console.SetCursorPosition(cmdWith / 2 - 3, Console.CursorTop);
            Console.WriteLine($"{arrowAngle}");
        }

        public void PrintAngleInDegrees(double arrowAngle, double minutes)  //Shows the angle between arrows in degrees
        {
            char deg = Convert.ToChar(176);
            int cmdWith = Console.WindowWidth;
            Console.SetCursorPosition(cmdWith / 2 - 16, Console.CursorTop);
            Console.WriteLine("Angle between arrows in degrees:");
            if (minutes % 2 != 0)
            {
                Console.SetCursorPosition(cmdWith / 2 - 4, Console.CursorTop);
                Console.WriteLine($"{arrowAngle - 0.5}{deg}30'");
            }
            else
            {
                Console.SetCursorPosition(cmdWith / 2 - 3, Console.CursorTop);
                Console.WriteLine($"{arrowAngle}{deg}");
            }
        }


        public void WrongInputMessage()
        {
            Console.WriteLine("Wrong input. Hit any key to try again..");
            AnyKeyHitDetector();
        }

        public void ContinueMessage()
        {
            Console.WriteLine("Press any key to continue...");
            AnyKeyHitDetector();
        }


        public void ProgramRepeatMessage()  //Offers user to start over the program either close the program
        {
            Console.Write("Do you want to calculate another angle? (y/n) ");
            string reply = Convert.ToString(Console.ReadKey().KeyChar);
            if (reply == "y" || reply == "n")
            {
                while (reply == "y")
                {
                    Console.Clear();
                    ProgramRun.MasterCode();
                }
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Something went wrong...");
                ProgramRepeatMessage();
            }
            Console.WriteLine();
            Console.WriteLine("Bye!!!");
            Console.Write("Press any key to exit...");
            Console.ReadKey();
            Environment.Exit(0);
        }

        // ============ Functions that checks if input is valid to proceed   ============

        public bool CheckHourInputValid(int h)  //hour check
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

        public bool CheckMinuteInputValid(int min)  //minute check
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

        // ============ This little function informs that any key was pressed when the program is paussed ============

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
