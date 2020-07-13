using DotNet5Samples.PatternMatching.LogicalPatterns;
using DotNet5Samples.PatternMatching.RelationalPatterns;
using DotNet5Samples.TargetTyping.NewExpressions;
using DotNet5Samples.TargetTyping.NullCoalescenceExpressions;
using System;

namespace DotNet5Samples
{
	public static class Program
	{
		public static void Main()
		{
			Console.WindowWidth = 140;
			Console.ForegroundColor = ConsoleColor.White;

			for (; ; )
			{
				ConsoleKey input = Console.ReadKey().Key;
				Action action = input switch
				{
					ConsoleKey.D0 or ConsoleKey.NumPad0 => () => RunSample<NewExpressionsSample>(),
					ConsoleKey.D1 or ConsoleKey.NumPad1 => () => RunSample<NullCoalescenceExpressionsSample>(),
					ConsoleKey.D2 or ConsoleKey.NumPad2 => () => RunSample<LogicalPatternsSample>(),
					ConsoleKey.D3 or ConsoleKey.NumPad3 => () => RunSample<RelationalPatternsSample>(),
					ConsoleKey.E => () => Environment.Exit(0),
					_ => () => Console.WriteLine($"No action implemented for {nameof(ConsoleKey)} '{input}'."),
				};
				Console.BackgroundColor = ConsoleColor.Black;
				Console.Clear();
				action();
			}
		}

		private static void RunSample<TSample>()
			where TSample : ISample, new()
		{
			TSample sample = new();

			RunSampleLanguageVersion(() => sample.RunCSharp8(), $"{sample.GetType().Name} (C# 8.0)", ConsoleColor.DarkBlue);
			Console.WriteLine();
			RunSampleLanguageVersion(() => sample.RunCSharp9(), $"{sample.GetType().Name} (C# 9.0)", ConsoleColor.DarkMagenta);
		}

		private static void RunSampleLanguageVersion(Action languageMethod, string displayName, ConsoleColor backgroundColor)
		{
			Console.BackgroundColor = backgroundColor;
			Console.WriteLine($"{displayName}:");
			try
			{
				languageMethod();
			}
			catch (Exception ex)
			{
				Console.BackgroundColor = ConsoleColor.DarkRed;
				Console.WriteLine($"Failed: {ex.Message}");
			}
		}
	}
}