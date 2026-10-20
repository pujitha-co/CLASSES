using System;
using System.Collections.Generic;
using System.Text;

namespace CLASSES_1
{
   
        public class Department
        {
            public string name;
            public int doctors;

            public void Display()
            {
                Console.WriteLine(name + ": " + doctors);
            }

            static void Main()
            {
                Department d1 = new Department();
                d1.name = "Cardiology";
                d1.doctors = 8;

                Department d2 = new Department();
                d2.name = "Neurology";
                d2.doctors = 5;

                d1.Display();
                d2.Display();
            }
       
    }
    class Vehicle
    {
        public string model;
        public int speed;

        public void Show()
        {
            Console.WriteLine(model + " - " + speed + " km/h");
        }

        static void Main()
        {
            Vehicle v1 = new Vehicle();
            v1.model = "Car";
            v1.speed = 120;

            Vehicle v2 = new Vehicle();
            v2.model = "Bike";
            v2.speed = 80;

            v1.Show();
            v2.Show();
        }
    }
}

