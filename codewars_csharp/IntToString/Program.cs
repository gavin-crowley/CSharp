public class Kata
{
    public static string NumberToString(int num)
    {
        return num.ToString();
    }
}


// OR


public class Kata
{
    public static string NumberToString(int num) => num.ToString();
}



//OR

public class Kata
{
    public static string NumberToString(int num)
    {
        return $"{num}";
    }
}