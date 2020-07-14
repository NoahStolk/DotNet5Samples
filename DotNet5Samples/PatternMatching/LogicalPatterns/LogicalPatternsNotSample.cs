using DotNet5Samples.PatternMatching.LogicalPatterns.Data;
using System;
using System.Collections.Generic;

namespace DotNet5Samples.PatternMatching.LogicalPatterns
{
	public class LogicalPatternsNotSample : ISample
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
				if (!(product is Mouse) && !(product is Keyboard))
					Console.WriteLine($"{product.GetType().Name} is not a {nameof(Mouse)} nor a {nameof(Keyboard)}.");
		}

		public void RunCSharp9()
		{
			foreach (Product product in products)
				if (product is not Mouse && product is not Keyboard)
					Console.WriteLine($"{product.GetType().Name} is not a {nameof(Mouse)} nor a {nameof(Keyboard)}.");
		}
	}
}