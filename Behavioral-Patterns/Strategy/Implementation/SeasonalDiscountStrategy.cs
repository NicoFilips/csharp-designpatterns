using Strategy.Abstraction;

namespace Strategy.Implementation;

public class SeasonalDiscountStrategy : IDiscountStrategy
{
    public double CalculateDiscount(double saleAmount)
    {
        return saleAmount * 0.90;  // 10% Rabatt
    }
}