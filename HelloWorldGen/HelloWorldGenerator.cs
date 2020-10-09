using Microsoft.CodeAnalysis;

namespace HelloWorldGen
{
    [Generator]
    public class HelloWorldGenerator : ISourceGenerator
    {
        private static readonly DiagnosticDescriptor HelloDescriptor =
            new DiagnosticDescriptor("HWG0001", "Hello", "Hello {0}",
                "Hello", DiagnosticSeverity.Warning, true);

        public void Initialize(GeneratorInitializationContext context)
        {
#if DEBUG
            if (!System.Diagnostics.Debugger.IsAttached)
                System.Diagnostics.Debugger.Launch();
#endif
        }

        public void Execute(GeneratorExecutionContext context)
        {
            context.ReportDiagnostic(Diagnostic.Create(HelloDescriptor, Location.None, "World"));
            context.AddSource("HelloWorld.cs", @"
using System;

namespace HelloWorld
{
    public static class Message
    {
        public static void Say()
        {
            Console.WriteLine(""Hello, world"");
        }
    }
}
");
        }
    }
}
