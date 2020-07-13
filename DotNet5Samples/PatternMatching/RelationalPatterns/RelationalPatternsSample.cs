using DotNet5Samples.PatternMatching.RelationalPatterns.Data;
using System;
using System.Collections.Generic;

namespace DotNet5Samples.PatternMatching.RelationalPatterns
{
	public class RelationalPatternsSample : ISample
	{
		private readonly List<Vehicle> vehicles = new List<Vehicle>
		{
			new(550),
			new(5000),
			new(1500),
			new(12500),
			new(20000),
		};

		public void RunCSharp8()
		{
			foreach (Vehicle vehicle in vehicles)
				Console.WriteLine(GetTax(vehicle));

			static int GetTax(Vehicle vehicle)
			{
				if (vehicle.Weight < 500)
					return 0;
				if (vehicle.Weight == 500)
					return 5;
				if (vehicle.Weight <= 5000)
					return 15;
				if (vehicle.Weight >= 15000)
					return 40;
				return 25;
			};
		}

		public void RunCSharp9()
		{
			foreach (Vehicle vehicle in vehicles)
				Console.WriteLine(GetTax(vehicle));

			static int GetTax(Vehicle vehicle) => vehicle.Weight switch
			{
				< 500 => 0,
				500 => 5,
				<= 5000 => 15,
				>= 15000 => 40,
				_ => 25
			};
		}
	}
}