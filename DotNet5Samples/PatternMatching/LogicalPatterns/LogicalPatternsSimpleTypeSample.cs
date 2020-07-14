using DotNet5Samples.PatternMatching.LogicalPatterns.Data;
using System;
using System.Collections.Generic;

namespace DotNet5Samples.PatternMatching.LogicalPatterns
{
	public class LogicalPatternsSimpleTypeSample : ISample
	{
		private readonly List<Product> products = new List<Product>
		{
			new Monitor(500),
			new Mouse(40),
			new Keyboard(100),
			new UsbStick(12),
		};

		public void RunCSharp8()
		{
			foreach (Product product in products)
				Console.WriteLine($"{product.Price * (1 - GetDiscount(product)):0.00}");

			static float GetDiscount(Product product) => product switch
			{
				Mouse _ => 0.2f,
				Monitor _ => 0.15f,
				null => throw new ArgumentNullException(nameof(product)),
				_ => throw new NotImplementedException($"Method '{nameof(GetDiscount)}' does not implement type '{product.GetType().Name}'."),
			};
		}

		public void RunCSharp9()
		{
			foreach (Product product in products)
				Console.WriteLine($"{product.Price * (1 - GetDiscount(product)):0.00}");

			static float GetDiscount(Product product) => product switch
			{
				Mouse => 0.2f,
				Monitor => 0.15f,
				null => throw new ArgumentNullException(nameof(product)),
				not null => throw new NotImplementedException($"Method '{nameof(GetDiscount)}' does not implement type '{product.GetType().Name}'."),
			};
		}
	}
}