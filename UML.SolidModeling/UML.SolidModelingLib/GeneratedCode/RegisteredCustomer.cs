﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

public class RegisteredCustomer : Customer
{
	/// <summary>
	/// Get discount applied to total Sales
	/// </summary>
	public override double getDiscount(double TotalSales)
	{
        var sales = base.getDiscount(TotalSales);
        return (sales * 0.05);
    }
}

