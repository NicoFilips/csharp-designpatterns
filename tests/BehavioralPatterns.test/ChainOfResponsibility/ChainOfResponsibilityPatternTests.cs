using FluentAssertions;
using ChainOfResponsibility;

namespace BehavioralPatterns.test.ChainOfResponsibility;

[TestFixture]
public class ChainOfResponsibilityPatternTests
{
    private StringWriter _stringWriter;
    private TextWriter _originalOutput;

    [SetUp]
    public void Setup()
    {
        _stringWriter = new StringWriter();
        _originalOutput = Console.Out;
        Console.SetOut(_stringWriter);
    }

    [TearDown]
    public void Teardown()
    {
        Console.SetOut(_originalOutput);
        _stringWriter.Dispose();
    }

    [Test]
    public void ConcernHandler_HandlesConcernRequest()
    {
        var handler = new ConcernHandler();
        handler.HandleRequest("Concern");

        var output = _stringWriter.ToString().Trim();
        output.Should().Be("ConcernHandler is handling the request.",
            because: "ConcernHandler should handle concern requests");
    }

    [Test]
    public void FeatureRequestHandler_HandlesFeatureRequest()
    {
        var handler = new FeatureRequestHandler();
        handler.HandleRequest("Feature");

        var output = _stringWriter.ToString().Trim();
        output.Should().Be("FeatureRequestHandler is handling the request.",
            because: "FeatureRequestHandler should handle feature requests");
    }

    [Test]
    public void RequestIsPassedDownTheChain()
    {
        var concernHandler = new ConcernHandler();
        var featureRequestHandler = new FeatureRequestHandler();
        var infoHandler = new InfoHandler();

        concernHandler.SetNextHandler(featureRequestHandler);
        featureRequestHandler.SetNextHandler(infoHandler);

        concernHandler.HandleRequest("Info");

        var output = _stringWriter.ToString().Trim();
        output.Should().Be("InfoHandler is handling the request.",
            because: "Info request should be passed down to InfoHandler");
    }

    [Test]
    public void UnhandledRequestIsIgnored()
    {
        var concernHandler = new ConcernHandler();
        var featureRequestHandler = new FeatureRequestHandler();
        // Not setting next for featureRequestHandler, so it ends the chain.

        concernHandler.SetNextHandler(featureRequestHandler);

        concernHandler.HandleRequest("UnknownRequest");

        var output = _stringWriter.ToString().Trim();
        output.Should().BeEmpty(because: "Unhandled requests should be ignored or specifically handled");
    }
}