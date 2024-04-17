namespace TemplateMethod;

public class XmlDataProcessor : DataProcessor
{
    protected override void ReadData()
    {
        Console.WriteLine("Read XML Data.");
    }

    protected override void ProcessDataCore()
    {
        Console.WriteLine("Process XML Data.");
    }

    protected override void WriteData()
    {
        Console.WriteLine("Write XML Data.");
    }
}