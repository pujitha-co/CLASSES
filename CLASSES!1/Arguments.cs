using System;
using System.Collections.Generic;
using System.Text;

namespace CLASSES_1
{
    class ParkingFee
    {
        public int Calculate(int hours, int ratePerHour)
        {
            return hours * ratePerHour;
        }

        static void Main()
        {
            ParkingFee p = new ParkingFee();
            Console.WriteLine(p.Calculate(4, 30));
        }
    }


    /// <summary>
    /// ///////////////////////////////////////
    /// </summary>
    class EventDetails
    {
        public void Display(string eventName, int participants)
        {
            Console.WriteLine(eventName);
            Console.WriteLine(participants);
        }

        static void Main()
        {
            EventDetails e = new EventDetails();
            e.Display("Tech Conference", 250);
        }
    }
}
