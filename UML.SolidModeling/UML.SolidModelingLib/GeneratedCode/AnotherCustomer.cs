public class AnotherCustomer : IDiscountable
{
    /// <summary>
    /// Calculate the Discount based on its level or grade.
    /// </summary>
    /// <param name="TotalSales"></param>
    /// <returns></returns>
    public double getDiscount(double TotalSales)
    {
        return TotalSales * 0.01;
    }
}
