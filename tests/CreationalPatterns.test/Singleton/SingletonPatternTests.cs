using FluentAssertions;
using Singleton;

namespace CreationalPatterns.test.Singleton;

[TestFixture]
public class SingletonPatternTests
{
    [Test]
    public void Instance_ReturnsSameInstance()
    {
        var instance1 = SingletonService.Instance;
        var instance2 = SingletonService.Instance;

        instance1.Should().BeSameAs(instance2, because: "Singleton should always return the same instance");
    }

    [Test]
    public void Instance_IsSingleton()
    {
        var instance1 = SingletonService.Instance;
        var instance2 = SingletonService.Instance;

        instance1.Should().NotBeNull();
        instance2.Should().NotBeNull();
        ReferenceEquals(instance1, instance2).Should()
            .BeTrue(because: "both variables should reference the same Singleton instance");
    }

    [Test]
    public async Task Instance_ThreadSafetyTest()
    {
        SingletonService instance1 = null!;
        SingletonService instance2 = null!;

        var task1 = Task.Run(() => instance1 = SingletonService.Instance);
        var task2 = Task.Run(() => instance2 = SingletonService.Instance);

        await Task.WhenAll(task1, task2);

        instance1.Should().BeSameAs(instance2, because: "Singleton instance should be the same across threads");
    }
}