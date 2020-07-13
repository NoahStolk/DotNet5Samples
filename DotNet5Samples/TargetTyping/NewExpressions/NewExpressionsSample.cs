using DotNet5Samples.TargetTyping.NewExpressions.Data;
using System;

namespace DotNet5Samples.TargetTyping.NewExpressions
{
	public class NewExpressionsSample : ISample
	{
		public void RunCSharp8()
		{
			Coordinate coord = new Coordinate(1, 2, 3);
			Console.WriteLine(coord);

			Console.WriteLine();

			Coordinate[] coords = new Coordinate[]
			{
				new Coordinate(1, 4, 4),
				new Coordinate(4, 5, 4),
				new Coordinate(5, 4, 5),
				new Coordinate(4, 2, 5),
				new Coordinate(4, 5, 5),
			};
			foreach (Coordinate c in coords)
				Console.WriteLine(c);
		}

		public void RunCSharp9()
		{
			Coordinate coord = new(1, 2, 3);
			Console.WriteLine(coord);

			Console.WriteLine();

			Coordinate[] coords = new Coordinate[]
			{
				new(1, 4, 4),
				new(4, 5, 4),
				new(5, 4, 5),
				new(4, 2, 5),
				new(4, 5, 5),
			};
			foreach (Coordinate c in coords)
				Console.WriteLine(c);
		}
	}
}