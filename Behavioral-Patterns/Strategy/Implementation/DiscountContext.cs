using Strategy.Abstraction;

namespace Strategy.Implementation;

public class DiscountContext
{
    private readonly IDiscountStrategy _discountStrategy;

    public DiscountContext(IDiscountStrategy discountStrategy)
    {
        _discountStrategy = discountStrategy;
    }

    public double ApplyDiscount(double saleAmount)
    {
        return _discountStrategy.CalculateDiscount(saleAmount);
    }
}