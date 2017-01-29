using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML.SolidModelingLib.GeneratedCode
{
    class AnotherCustomer : Customer
    {
        /// <summary>
        /// Calculate the Discount based on its level or grade.
        /// </summary>
        /// <param name="TotalSales"></param>
        /// <returns></returns>
        public override double getDiscount(double TotalSales)
        {
            return base.getDiscount(TotalSales) * 0.01;
        }

        /// <summary>
        /// 
        /// </summary>
        public override void Add()
        {
            throw new ApplicationException("Not allowed");
        }
    }
}
