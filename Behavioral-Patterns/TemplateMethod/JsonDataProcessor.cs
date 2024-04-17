namespace TemplateMethod;

public class JsonDataProcessor : DataProcessor
{
    protected override void ReadData()
    {
        Console.WriteLine("Read JSON Data.");
    }

    protected override void ProcessDataCore()
    {
        Console.WriteLine("Process JSON Data.");
    }

    protected override void WriteData()
    {
        Console.WriteLine("Write JSON Data.");
    }
}