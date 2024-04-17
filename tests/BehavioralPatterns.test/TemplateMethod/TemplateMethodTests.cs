using NUnit.Framework;
using FluentAssertions;
using TemplateMethod;

namespace BehavioralPatterns.test.TemplateMethod;

[TestFixture]
public class TemplateMethodTests
{
    private class TestableDataProcessor : DataProcessor
    {
        public bool IsReadCalled { get; private set; }
        public bool IsProcessCalled { get; private set; }
        public bool IsWriteCalled { get; private set; }

        protected override void ReadData()
        {
            IsReadCalled = true;
        }

        protected override void ProcessDataCore()
        {
            IsProcessCalled = true;
        }

        protected override void WriteData()
        {
            IsWriteCalled = true;
        }
    }

    [Test]
    public void ProcessData_ShouldInvokeAllSteps()
    {
        // Arrange
        var processor = new TestableDataProcessor();

        // Act
        processor.ProcessData();

        // Assert
        processor.IsReadCalled.Should().BeTrue("because ReadData should be called as part of ProcessData");
        processor.IsProcessCalled.Should().BeTrue("because ProcessDataCore should be called as part of ProcessData");
        processor.IsWriteCalled.Should().BeTrue("because WriteData should be called as part of ProcessData");
    }
}