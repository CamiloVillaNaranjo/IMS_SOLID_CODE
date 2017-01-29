using System;

namespace UML.SolidModelingLib
{
    public class Programm
    {
        static void Main()
        {
            var client = new Customer();
            client.CustomerType = CustomersType.Gold_Partner;
            var discount = client.getDiscount(1500000);

            Console.WriteLine("Discount achieved for a client was: $ {0}", discount.ToString("N2"));
            Console.ReadLine();

            var goldClient = new GoldCustomer();
            var goldDiscount = goldClient.getDiscount(1500000);

            Console.WriteLine("Discount achieved for gold was: $ {0}", goldDiscount.ToString("N2"));
            Console.ReadLine();

            var silverClient = new SilverCustomer();
            var silverDiscount = silverClient.getDiscount(1500000);

            Console.WriteLine("Discount achieved for silver was: $ {0}", silverDiscount.ToString("N2"));
            Console.ReadLine();

            var registeredClient = new RegisteredCustomer();
            var registeredDiscount = registeredClient.getDiscount(1500000);

            Console.WriteLine("Discount achieved for registered was: $ {0}", registeredDiscount.ToString("N2"));
            Console.ReadLine();
        }
    }
}
