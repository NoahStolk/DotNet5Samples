using System;

namespace DotNet5Samples.PatternMatching.LogicalPatterns
{
	public class LogicalPatternsAndSample : ISample
	{
		public void RunCSharp8()
		{
			for (int i = 0; i < 15; i++)
				Console.WriteLine(GetScore(i));

			static int GetScore(int i)
			{
				if (i > 3 && i < 6)
					return 10;
				if (i > 9 && i < 12)
					return 100;
				return 1;
			}
		}

		public void RunCSharp9()
		{
			for (int i = 0; i < 15; i++)
				Console.WriteLine(GetScore(i));

			static int GetScore(int i) => i switch
			{
				> 3 and < 6 => 10,
				> 9 and < 12 => 100,
				_ => 1
			};
		}
	}
}