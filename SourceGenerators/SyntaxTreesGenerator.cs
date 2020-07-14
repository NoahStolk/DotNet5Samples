using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Text;
using System.Text;

namespace SourceGenerators
{
	[Generator]
    public class SyntaxTreesGenerator : ISourceGenerator
    {
        public void Execute(SourceGeneratorContext context)
        {
			StringBuilder sourceBuilder = new StringBuilder(@"
using System;

namespace SyntaxTreesGenerated
{
    public static class SyntaxTrees
    {
        public static void PrintSyntaxTrees() 
        {
            Console.WriteLine(""The following syntax trees existed in the compilation that created this program:"");
");

            foreach (SyntaxTree tree in context.Compilation.SyntaxTrees)
                sourceBuilder.AppendLine($@"Console.WriteLine(@""{tree.FilePath}"");");

            sourceBuilder.Append(@"
        }
    }
}");

            context.AddSource("syntaxTreesGenerator", SourceText.From(sourceBuilder.ToString(), Encoding.UTF8));
        }

        public void Initialize(InitializationContext context)
        {
        }
    }
}