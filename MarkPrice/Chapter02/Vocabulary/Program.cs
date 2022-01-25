// See https://aka.ms/new-console-template for more information
using System.Reflection;

System.Data.DataSet ds;
HttpClient client;

//#error version
//Console.WriteLine();
//Console.WriteLine("Hello Ahmed");
//Console.WriteLine("Temperature on {0:D} is {1}C.", DateTime.Today, 23.4);

    Assembly? assembly = Assembly.GetEntryAssembly();
    if (assembly == null) return;

    foreach (AssemblyName name in assembly.GetReferencedAssemblies())
    {
    Assembly a = Assembly.Load(name);
    int methodCount = 0;

    foreach (TypeInfo t in a.DefinedTypes)
    {
        methodCount += t.GetMethods().Count();

    }

    Console.WriteLine("{0:N0} types with {1:N0} methods in {2} assembly.",
    arg0: a.DefinedTypes.Count(),
    arg1: methodCount, arg2: name.Name);
    }

