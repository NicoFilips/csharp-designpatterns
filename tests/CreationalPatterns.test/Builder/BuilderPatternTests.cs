using Builder;
using FluentAssertions;

namespace CreationalPatterns.test.Builder;

[TestFixture]
public class BuilderPatternTests
{
    [Test]
    public void BuilderSetsPartACorrectly()
    {
        var product = new Product.Builder()
            .SetPartA("CustomA")
            .Build();

        product.PartA.Should().Be("CustomA", because: "the builder should set PartA to the custom value");
    }

    [Test]
    public void BuilderSetsPartBCorrectly()
    {
        var product = new Product.Builder()
            .SetPartB("CustomB")
            .Build();

        product.PartB.Should().Be("CustomB", because: "the builder should set PartB to the custom value");
    }

    [Test]
    public void BuilderSetsPartCCorrectly()
    {
        var product = new Product.Builder()
            .SetPartC("CustomC")
            .Build();

        product.PartC.Should().Be("CustomC", because: "the builder should set PartC to the custom value");
    }

    [Test]
    public void BuilderUsesDefaultValuesWhenNotSet()
    {
        var product = new Product.Builder().Build();

        product.PartA.Should().Be("DefaultA", because: "the builder should use default value for PartA when not set");
        product.PartB.Should().Be("DefaultB", because: "the builder should use default value for PartB when not set");
        product.PartC.Should().Be("DefaultC", because: "the builder should use default value for PartC when not set");
    }

    [Test]
    public void BuilderAllowsChainingToSetParts()
    {
        var product = new Product.Builder()
            .SetPartA("CustomA")
            .SetPartB("CustomB")
            .SetPartC("CustomC")
            .Build();

        product.PartA.Should().Be("CustomA", because: "the builder should allow chaining to set PartA");
        product.PartB.Should().Be("CustomB", because: "the builder should allow chaining to set PartB");
        product.PartC.Should().Be("CustomC", because: "the builder should allow chaining to set PartC");
    }
}