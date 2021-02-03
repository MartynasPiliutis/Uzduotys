using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheWatchLibrary
{
    public class ProgramRun
    {
        public static void MasterCode()
        {
            Console.WriteLine("check1");
            TimeRepository timeRepository = new TimeRepository(); //Setting up time

            Console.WriteLine("check2");
            timeRepository.PrintTime();
            ProgramRepeatMessage();
        }
        private static void ProgramRepeatMessage()
        {
            Console.Write("Do you want to calculate another angle? (y/n) ");
            string reply = Convert.ToString(Console.ReadKey().KeyChar);
            if (reply == "y" || reply == "n")
            {
                while (reply == "y")
                {
                    Console.Clear();
                    MasterCode();
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
            Environment.Exit(0);

        }
    }
}
