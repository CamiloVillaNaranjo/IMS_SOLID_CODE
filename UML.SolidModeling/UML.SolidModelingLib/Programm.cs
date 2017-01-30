using System;
using System.Collections.Generic;

namespace UML.SolidModelingLib
{
    public class Programm
    {
        static void Main()
        {
            var clientList = new List<IManageable>();

            clientList.Add(new GoldCustomer(new EmailLogger()));
            clientList.Add(new SilverCustomer(new FileLogger()));
            clientList.Add(new RegisteredCustomer(new EvenViewerLogger()));
            clientList.Add(new PlatiniumCustomer(new EmailLogger()));

            foreach (var item in clientList)
            {
                try
                {
                    item.Add();
                }
                catch (Exception)
                {
                    continue;
                }
            }

            IManageable masterCardClient = new Customer(new EmailLogger());

            Console.ReadLine();
        }
    }
}
