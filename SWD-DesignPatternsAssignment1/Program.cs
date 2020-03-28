using System;
using System.Collections.Generic;

namespace SWD_DesignPatternsAssignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Order> Orders;
            Orders = new List<Order>();

            int myIndex = 0;


            Console.WriteLine("Ordrer: ");
            Order Ost = new Order("Ost", 24.25, "Det lugter");
            Order Banan = new Order("Banan", 2.00, "Øko");

            Console.WriteLine(Ost.ToString());
            Console.WriteLine(Banan.ToString());

            Orders.Add(Ost);
            Orders.Add(Banan);

            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Liste: ");

            foreach (var Order in Orders)
            {
                Console.WriteLine(Order.ToString());
            }

            Console.WriteLine("");
            Console.WriteLine("");

            Orders.Add(new Order("Tandpasta", 22.50, "Skummet"));

            Console.WriteLine("Liste (added): ");

            foreach (var Order in Orders)
            {
                Console.WriteLine(Order.ToString());
            }


















            //Console.WriteLine(myOrder1.ToString());
            //Console.WriteLine(myOrder2.ToString());
            //Console.WriteLine(myOrder3.ToString());
        }
    }
}
