namespace Facade;

public class MediaConverterFacade
{
    private readonly CodecConverter _codecConverter = new();
    private readonly AudioMixer _audioMixer = new();
    private readonly CompressionTool _compressionTool = new();

    public string ConvertVideo(string filename, string format)
    {
        var convertedFile = _codecConverter.Convert(filename, format);
        var fixedAudio = _audioMixer.FixAudio(convertedFile);
        var compressedFile = _compressionTool.Compress(fixedAudio);
        return compressedFile;
    }
}