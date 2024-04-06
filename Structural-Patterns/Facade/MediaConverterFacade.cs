namespace Facade;

public class MediaConverterFacade
{
    private CodecConverter codecConverter = new CodecConverter();
    private AudioMixer audioMixer = new AudioMixer();
    private CompressionTool compressionTool = new CompressionTool();

    public string ConvertVideo(string filename, string format)
    {
        string convertedFile = codecConverter.Convert(filename, format);
        string fixedAudio = audioMixer.FixAudio(convertedFile);
        string compressedFile = compressionTool.Compress(fixedAudio);
        return compressedFile;
    }
}