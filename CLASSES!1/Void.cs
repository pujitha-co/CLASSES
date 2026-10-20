using System;
using System.Collections.Generic;
using System.Text;

namespace CLASSES_1
{
    class InvoicePrinter
    {
        public void PrintHeading()
        {
            Console.WriteLine("INVOICE");
        }

        static void Main()
        {
            InvoicePrinter p = new InvoicePrinter();
            p.PrintHeading();
        }
    }

    class TemperatureMonitor
    {
        public void CheckTemperature(double temperature)
        {
            if (temperature > 37.5)
                Console.WriteLine("High temperature");
            else
                Console.WriteLine("Normal temperature");
        }

        static void Main()
        {
            TemperatureMonitor t = new TemperatureMonitor();
            t.CheckTemperature(38.2);
        }
    }
}
