


static string EvenOrOdd(int number)
{
    if (number % 2 == 0)
    {
        return ("Even");
    }
    else
    {
        return ("Odd");
    }
}

Console.WriteLine(EvenOrOdd(3));


//OR

public class SolutionClass
{
    public static string EvenOrOdd(int number)
    {
        return number % 2 == 0 ? "Even" : "Odd";
    }
}

// comment 
// comment
// comment
// comment
// comment 