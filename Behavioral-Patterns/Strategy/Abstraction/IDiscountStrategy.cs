namespace Strategy.Abstraction;

public interface IDiscountStrategy
{
    double CalculateDiscount(double saleAmount);
}