using FluentAssertions;
using Strategy.Implementation;

namespace BehavioralPatterns.test.Strategy;

[TestFixture]
public class DiscountStrategyTests
{
    [Test]
    public void NoDiscount_Should_ApplyZeroDiscount()
    {
        // Arrange
        var strategy = new NoDiscountStrategy();
        var context = new DiscountContext(strategy);

        // Act
        var result = context.ApplyDiscount(100);

        // Assert
        result.Should().Be(100);
    }

    [Test]
    public void SeasonalDiscount_Should_ApplyTenPercentDiscount()
    {
        // Arrange
        var strategy = new SeasonalDiscountStrategy();
        var context = new DiscountContext(strategy);

        // Act
        var result = context.ApplyDiscount(100);

        // Assert
        result.Should().BeApproximately(90, 0.001);
    }

    [Test]
    public void ClearanceDiscount_Should_ApplyTwentyPercentDiscount()
    {
        // Arrange
        var strategy = new ClearanceDiscountStrategy();
        var context = new DiscountContext(strategy);

        // Act
        var result = context.ApplyDiscount(100);

        // Assert
        result.Should().BeApproximately(80, 0.001);
    }
}