using Strategy.Abstraction;

namespace Strategy.Implementation;

public class NoDiscountStrategy : IDiscountStrategy
{
    public double CalculateDiscount(double saleAmount)
    {
        return saleAmount;
    }
}