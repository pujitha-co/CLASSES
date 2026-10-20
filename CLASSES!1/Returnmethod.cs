using System;
using System.Collections.Generic;
using System.Text;

namespace CLASSES_1
{
    class ElectricityBill
    {
        public double CalculateBill(int units)
        {
            return units * 6.5;
        }

        static void Main()
        {
            ElectricityBill e = new ElectricityBill();
            double bill = e.CalculateBill(100);

            Console.WriteLine("Bill: " + bill);
        }
    }
    class MarksCalculator
    {
        public double CalculateAverage(int a, int b, int c)
        {
            return (a + b + c) / 3.0;
        }

        static void Main()
        {
            MarksCalculator m = new MarksCalculator();

            Console.WriteLine(m.CalculateAverage(70, 80, 90));
        }
    }
}
