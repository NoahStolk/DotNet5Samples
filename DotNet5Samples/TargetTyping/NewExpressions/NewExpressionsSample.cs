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
		}

		public void RunCSharp9()
		{
			Coordinate coord = new(1, 2, 3);
			Console.WriteLine(coord);
		}
	}
}