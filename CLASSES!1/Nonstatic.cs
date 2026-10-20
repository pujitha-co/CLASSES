using System;
using System.Collections.Generic;
using System.Text;

namespace CLASSES_1
{
    class WashingMachine
    {
        public void Start()
        {
            Console.WriteLine("Washing machine started");
        }

        static void Main()
        {
            WashingMachine w = new WashingMachine();
            w.Start();
        }
    }
    class ATM
    {
        public void Withdraw()
        {
            Console.WriteLine("Please collect your cash");
        }

        static void Main()
        {
            ATM a = new ATM();
            a.Withdraw();
        }
    }
    class ShoppingCart
    {
        public void PlaceOrder()
        {
            Console.WriteLine("Order placed successfully");
        }

        static void Main()
        {
            ShoppingCart cart = new ShoppingCart();
            cart.PlaceOrder();
        }
    }
}

