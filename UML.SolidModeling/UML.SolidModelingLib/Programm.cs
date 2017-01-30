using System;
using System.Collections.Generic;

namespace UML.SolidModelingLib
{
    public class Programm
    {
        static void Main()
        {
            var clientList = new List<IManageable>();

            clientList.Add(new GoldCustomer());
            clientList.Add(new SilverCustomer());
            clientList.Add(new RegisteredCustomer());
            clientList.Add(new PlatiniumCustomer());

            foreach (var item in clientList)
            {
                item.Add();
            }
            Console.ReadLine();
        }
    }
}
