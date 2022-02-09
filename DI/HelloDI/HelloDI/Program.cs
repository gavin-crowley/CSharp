
namespace HelloDI;

public static class Program
{
    private static void Main()
    {
        IMessageWriter writer = new ConsoleMessageWriter();
        var salutation = new Salutation(writer);
        salutation.Exclaim();
    }
}
