using System;
using System.Collections.Generic;
using System.Text;

namespace CLASSES_1
{
    class TimeConverter
    {
      
            public static void Convert()
            {
                int hours = 3;
                Console.WriteLine(hours * 60);
            }

            static void Main()
            {
                TimeConverter.Convert();
            }
        }
    class DistanceConverter
    {
        public static void Convert()
        {
            int kilometers = 5;
            Console.WriteLine(kilometers * 1000);
        }

        static void Main()
        {
            DistanceConverter.Convert();
        }
    }
}

