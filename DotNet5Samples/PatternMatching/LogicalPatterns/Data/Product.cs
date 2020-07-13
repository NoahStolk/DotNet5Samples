namespace DotNet5Samples.PatternMatching.LogicalPatterns.Data
{
	public abstract class Product
	{
		protected Product(double price)
		{
			Price = price;
		}

		public double Price { get; set; }
	}
}