using System;
using System.Collections.Generic;
using System.Text;

namespace CLASSES_1
{
    class DeliveryCalculator
    {
        public void ShowCharge(double distance)
        {
            Console.WriteLine("Distance: " + distance + " km");
        }

        static void Main()
        {
            DeliveryCalculator d = new DeliveryCalculator();
            d.ShowCharge(12.5);
        }
    }
    class UsernameGenerator
    {
        public string CreateUsername(string firstName, int id)
        {
            return firstName + id;
        }

        static void Main()
        {
            UsernameGenerator u = new UsernameGenerator();

            Console.WriteLine(u.CreateUsername("Ravi", 101));
        }
    }


}
