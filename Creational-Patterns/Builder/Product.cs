namespace Builder;

public class Product
{
    public string? PartA { get; private set; }
    public string? PartB { get; private set; }
    public string? PartC { get; private set; }

    public class Builder
    {
        private string _partA = "DefaultA";
        private string _partB = "DefaultB";
        private string _partC = "DefaultC";
        
        public Builder SetPartA(string partA)
        {
            _partA = partA;
            return this;
        }
        
        public Builder SetPartB(string partB)
        {
            _partB = partB;
            return this;
        }
        
        public Builder SetPartC(string partC)
        {
            _partC = partC;
            return this;
        }
        
        public Product Build()
        {
            return new Product
            {
                PartA = _partA,
                PartB = _partB,
                PartC = _partC
            };
        }
    }
}