using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunTracking
{
    class Utility
    {
        const double feetInMile = 5280;
        const double meterInMile = 1609.34;
       
        public static double MileToFeet(double mile)
        {
            return mile * feetInMile; 
        }

        public static double MeterToMile(double mile)
        {
            return (mile * meterInMile);
        }

        public static string GoalDifferance(double goal, double distance, double time)
        {
            double temp = 0;
            int minute = 0;
            int seconds = 0;
            double differance;
            string Answer;

            temp = time / distance;
            differance = temp - goal;
            minute = Math.Abs((int)(differance));
            differance -= (int)differance;
            seconds = Math.Abs((int)(differance * 60));

            if ((temp - goal) >= 0)

                Answer = String.Format("+{0} minutes and {1} seconds", minute, seconds);
            
            else
            
                Answer = String.Format("-{0} minutes and {1} seconds", minute, seconds);
            
            return Answer;

            
        }
    }
}
