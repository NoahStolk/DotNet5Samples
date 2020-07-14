using System;

namespace DotNet5Samples.SourceGenerators
{
	public class SyntaxTreesGeneratorSample : ISample
	{
		public void RunCSharp8()
		{
			throw new NotImplementedException();
		}

		public void RunCSharp9()
		{
			SyntaxTreesGenerated.SyntaxTrees.PrintSyntaxTrees();
		}
	}
}