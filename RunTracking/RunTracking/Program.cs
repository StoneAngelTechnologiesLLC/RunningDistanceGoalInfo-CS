using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunTracking
{
    class Program
    {
        static void Main(string[] args)
        {

            double runTimeGoal = 0;
            double runTimeDistance = 0;
            double runTime = 0;

            runTimeGoal = GetDouble("Enter your average run time goal: ");
            runTimeDistance = GetDouble("Enter your run time distance in miles: ");
            runTime = GetDouble("Enter your run time: ");
            Console.WriteLine();
            Console.WriteLine("You ran {0} miles, {2} meters, or {1} feet", runTimeDistance,
                                Utility.MileToFeet(runTimeDistance), Utility.MeterToMile(runTimeDistance));
            Console.WriteLine("The goal differance per mile was: {0}",
                Utility.GoalDifferance(runTimeGoal, runTimeDistance, runTime)); 
            Console.ReadKey();
        }

        static double GetDouble(string question)
        {
            string input;
            double number;
            
            Console.WriteLine(question + ": ");
            input = Console.ReadLine();
            // testing to see if input string can be converted to numbers
            if (!double.TryParse(input, out number))
            {

                Console.WriteLine("invalad Entery, Number is zero");
            }
            return number;
        }
    }
}
