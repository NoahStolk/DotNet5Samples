using System;

namespace DotNet5Samples.PatternMatching.LogicalPatterns
{
	public class LogicalPatternsOrSample : ISample
	{
		private readonly string[] extensions = new[] { "pdf", "png", "jpg", "jpeg" };

		public void RunCSharp8()
		{
			foreach (string extension in extensions)
				Console.WriteLine(GetMimeFromExtension(extension));

			static string GetMimeFromExtension(string extension)
			{
				if (extension == null)
					throw new ArgumentNullException(nameof(extension));

				return extension switch
				{
					"pdf" => "application/pdf",
					"png" => "image/png",
					var x when x == "jpg" || x == "jpeg" => "image/jpeg",
					_ => throw new Exception($"Extension {extension} is not supported."),
				};
			}
		}

		public void RunCSharp9()
		{
			foreach (string extension in extensions)
				Console.WriteLine(GetMimeFromExtension(extension));

			static string GetMimeFromExtension(string extension) => extension switch
			{
				"pdf" => "application/pdf",
				"png" => "image/png",
				"jpg" or "jpeg" => "image/jpeg",
				null => throw new ArgumentNullException(nameof(extension)),
				not null => throw new Exception($"Extension {extension} is not supported."),
			};
		}
	}
}