using Strategy.Abstraction;

namespace Strategy.Implementation;

public class ClearanceDiscountStrategy : IDiscountStrategy
{
    public double CalculateDiscount(double saleAmount)
    {
        return saleAmount * 0.80;  // 20% Rabatt
    }
}