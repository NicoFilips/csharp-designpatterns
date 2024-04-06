namespace Prototype;

public class Product
{
    // Fields representing parts of the complex object
    public string PartA { get; private set; }
    public string PartB { get; private set; }
    public string PartC { get; private set; }

    public class Builder
    {
        // Fields initialized with default values
        private string partA = "DefaultA";
        private string partB = "DefaultB";
        private string partC = "DefaultC";

        // Method to set partA and return the Builder for chaining
        public Builder SetPartA(string partA)
        {
            this.partA = partA;
            return this;
        }

        // Method to set partB and return the Builder for chaining
        public Builder SetPartB(string partB)
        {
            this.partB = partB;
            return this;
        }

        // Method to set partC and return the Builder for chaining
        public Builder SetPartC(string partC)
        {
            this.partC = partC;
            return this;
        }

        // Method to construct the final Product object
        public Product Build()
        {
            return new Product
            {
                PartA = this.partA,
                PartB = this.partB,
                PartC = this.partC
            };
        }
    }
}