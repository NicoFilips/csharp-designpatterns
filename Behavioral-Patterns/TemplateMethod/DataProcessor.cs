namespace TemplateMethod;

public abstract class DataProcessor
{
    public void ProcessData()
    {
        ReadData();
        ProcessDataCore();
        WriteData();
    }
    
    protected abstract void ReadData();
    
    protected abstract void ProcessDataCore();
    
    protected abstract void WriteData();
}