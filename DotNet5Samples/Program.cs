#pragma warning disable IDE0051 // Remove unused private members
using DotNet5Samples;
using DotNet5Samples.PatternMatching.LogicalPatterns;
using DotNet5Samples.PatternMatching.RelationalPatterns;
using DotNet5Samples.SourceGenerators;
using DotNet5Samples.TargetTyping.NewExpressions;
using DotNet5Samples.TargetTyping.NullCoalescenceExpressions;
using System;

Console.WindowWidth = 140;
Console.WindowHeight = 40;
Console.ForegroundColor = ConsoleColor.White;

for (; ; )
{
	ConsoleKey input = Console.ReadKey().Key;
	Action action = input switch
	{
		ConsoleKey.D0 or ConsoleKey.NumPad0 => () => RunSample<NewExpressionsSample>(),
		ConsoleKey.D1 or ConsoleKey.NumPad1 => () => RunSample<NullCoalescenceExpressionsSample>(),
		ConsoleKey.D2 or ConsoleKey.NumPad2 => () => RunSample<RelationalPatternsSample>(),
		ConsoleKey.D3 or ConsoleKey.NumPad3 => () => RunSample<LogicalPatternsAndSample>(),
		ConsoleKey.D4 or ConsoleKey.NumPad4 => () => RunSample<LogicalPatternsOrSample>(),
		ConsoleKey.D5 or ConsoleKey.NumPad5 => () => RunSample<LogicalPatternsSimpleTypeSample>(),
		ConsoleKey.D6 or ConsoleKey.NumPad6 => () => RunSample<LogicalPatternsNotSample>(),
		ConsoleKey.D7 or ConsoleKey.NumPad7 => () => RunSample<SyntaxTreesGeneratorSample>(),
		ConsoleKey.E => () => Environment.Exit(0),
		_ => () => Console.WriteLine($"No action implemented for {nameof(ConsoleKey)} '{input}'."),
	};
	Console.BackgroundColor = ConsoleColor.Black;
	Console.Clear();
	action();
}

static void RunSample<TSample>()
	where TSample : ISample, new()
{
	TSample sample = new();

	RunSampleLanguageVersion(() => sample.RunCSharp8(), $"{sample.GetType().Name} (C# 8.0)", ConsoleColor.DarkBlue);
	Console.WriteLine();
	RunSampleLanguageVersion(() => sample.RunCSharp9(), $"{sample.GetType().Name} (C# 9.0)", ConsoleColor.DarkMagenta);
}

static void RunSampleLanguageVersion(Action languageMethod, string displayName, ConsoleColor backgroundColor)
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
#pragma warning restore IDE0051 // Remove unused private members