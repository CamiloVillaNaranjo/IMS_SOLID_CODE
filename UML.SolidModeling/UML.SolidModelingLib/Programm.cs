using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML.SolidModelingLib
{
    public class Programm
    {
        static void Main()
        {
            var goldClient = new Customer();
            goldClient.CustomerType = CustomersType.Gold_Partner;
            var discount = goldClient.getDiscount(1500000);

            Console.WriteLine("Discount achieved was: $ {0}", discount);
            Console.ReadLine();
        }
    }
}
