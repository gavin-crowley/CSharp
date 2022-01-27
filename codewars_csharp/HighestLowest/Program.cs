static string HighAndLow(string numbers)
{
    var parsed = numbers.Split().Select(int.Parse);
    return parsed.Max() + " " + parsed.Min();
}

Console.WriteLine(HighAndLow("1 2 3 4 5"));

//OR

//public static string HighAndLow(string numbers)
//{
//    var numbersList = numbers.Split(' ').Select(x => Convert.ToInt32(x));
//    return string.Format("{0} {1}", numbersList.Max(), numbersList.Min());
//}



//public static string HighAndLow(string numbers)
//{
//    var nums = numbers.Split(' ').Select(Int32.Parse).ToArray();
//    return $"{nums.Max()} {nums.Min()}";
//}



//public static String HighAndLow(String numbers)
//{
//    var values = numbers.Split(' ').Select(Int32.Parse);
//    return $"{values.Max()} {values.Min()}";
//}