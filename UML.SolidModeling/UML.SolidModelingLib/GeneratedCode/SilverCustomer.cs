﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

public class SilverCustomer : Customer
{
	public override double getDiscount(double TotalSales)
	{
        var sales = base.getDiscount(TotalSales);
        return (sales * 0.15);
	}

}

