using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheWatchLibrary
{
    public class ProgramRun
    {
        public static void MasterCode()     //Program execution
        {
            ProgramFunctions programFunctions = new ProgramFunctions();
            TimeRepository timeRepository = new TimeRepository();
            AngleProgram angleProgram = new AngleProgram();
            Console.WriteLine();
            programFunctions.PrintTime(timeRepository.YourWatchList);
            Console.WriteLine();
            programFunctions.ContinueMessage();
            Console.WriteLine();
            programFunctions.PrintAngle(angleProgram.CalculateArrowsAngle(timeRepository.YourWatchList));
            Console.WriteLine();
            programFunctions.PrintAngleInDegrees(angleProgram.CalculateArrowsAngle(timeRepository.YourWatchList), timeRepository.YourWatchList[0].Minute);
            Console.WriteLine();
            programFunctions.ProgramRepeatMessage();
        }

    }
}
