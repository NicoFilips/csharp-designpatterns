using FluentAssertions;
using Prototype;

namespace CreationalPatterns.test.Prototype;

[TestFixture]
public class PrototypePatternTests
{
    [Test]
    public void Clone_CreatesObjectWithSameValues()
    {
        var original = new ConcretePrototype(1, "Original");
        var clone = original.Clone() as ConcretePrototype;

        clone.Should().NotBeNull();
        clone.Id.Should().Be(original.Id, because: "the clone should have the same Id as the original");
        clone.Name.Should().Be(original.Name, because: "the clone should have the same Name as the original");
    }

    [Test]
    public void Clone_CreatedObjectIsSeparateInstance()
    {
        var original = new ConcretePrototype(1, "Original");
        var clone = original.Clone() as ConcretePrototype;

        clone.Should().NotBeSameAs(original, because: "the clone should be a separate instance from the original");
    }

    [Test]
    public void Clone_ChangesToCloneDoNotAffectOriginal()
    {
        var original = new ConcretePrototype(1, "Original");
        var clone = original.Clone() as ConcretePrototype;

        // Ändere den Namen des Klons
        clone.Name = "Modified Clone";

        clone.Name.Should().NotBe(original.Name, because: "changes to the clone should not affect the original object");
        clone.Name.Should().Be("Modified Clone", because: "the clone's name was changed");
        original.Name.Should().Be("Original", because: "the original's name should remain unchanged");
    }
}