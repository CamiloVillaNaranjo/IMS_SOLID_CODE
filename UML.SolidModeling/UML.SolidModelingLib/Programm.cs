using System;
using System.Collections.Generic;

namespace UML.SolidModelingLib
{
    public class Programm
    {
        static void Main()
        {
            var clientList = new List<Customer>();
            double sales = 1500000;

            clientList.Add(new GoldCustomer());
            clientList.Add(new SilverCustomer());
            clientList.Add(new RegisteredCustomer());

            foreach (var item in clientList)
            {
                var discount = item.getDiscount(sales);
                Console.WriteLine("Discount achieved for {0} was: $ {1}", item.GetType().ToString(), discount.ToString("N2"));
            }
            Console.ReadLine();
        }
    }
}
