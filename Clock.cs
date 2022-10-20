using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ReizTechHomework
{
    public static class Clock
    {
        public static int hours;
        public static int minutes;

        public static void ArrowAngel()
        {
            var stringNumber = string.Empty;
            var hour = 0;
            var minute = 0;

            do
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("Enter hours:");
                    stringNumber = Console.ReadLine();
                }
                while (!int.TryParse(stringNumber, out hour));

                do
                {
                    Console.Clear();
                    Console.WriteLine("Enter minutes:");
                    stringNumber = Console.ReadLine();
                    Console.Clear();
                }
                while (!int.TryParse(stringNumber, out minute));

                hours = hour;
                minutes = minute;

                if (hours < 0 || minutes < 0 || hours > 24 || minutes > 60)
                {
                    Console.WriteLine("wrong format");
                    Console.ReadLine();
                }
                    
            }
            while (!((hours >= 0) && (minutes >= 0) && (hours < 24) && (minutes < 60)));

                if (hours == 12)
                {
                    hours = 0;
                }

                Console.WriteLine($"Angle between clock arrows is:\n\n{AngleInDegrees()} degrees\n\nif shown time is: {hours}:{minutes}");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("press Enter to finish \"Clock\"");
                Console.ReadLine();
        }
            


        public static double AngleInDegrees()
        {
            double angle = 0;
            angle = Math.Abs(AngleHours(hours, minutes) - AngleMinutes(minutes));
            return Math.Min(360 - angle, angle);
        }

        public static double AngleMinutes(int minutes)
        {
            return minutes * 6;
        }

        public static double AngleHours(int hours, int minutes)
        {
            if (hours > 12)
            {
                return 0.5 * ((hours - 12) * 60 + minutes);
            }
            return 0.5 * (hours * 60 + minutes);
        }

        
    }
}
