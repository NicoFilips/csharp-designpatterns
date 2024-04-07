using Facade;
using FluentAssertions;

namespace StructuralPatterns.test.Facade;

public class FacadePatternTests
{
    [Test]
    public void ConvertVideo_ShouldProcessVideoCorrectly()
    {
        // Arrange
        var facade = new MediaConverterFacade();
        string originalFilename = "video.mp4";
        string targetFormat = "AVI";

        // Achte genau auf zusätzliche Leerzeichen oder Zeichen
        string expectedConversionResult = "Compressed Audio of Converted video.mp4 to AVI. fixed..";

        // Act
        var conversionResult = facade.ConvertVideo(originalFilename, targetFormat);

        // Assert
        conversionResult.Should().Be(expectedConversionResult);
    }
}