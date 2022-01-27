using System;
using System.Linq;

static int DescendingOrder(int num)
{
    return int.Parse(string.Concat(num.ToString().OrderByDescending(x => x)));
}

Console.WriteLine(DescendingOrder(94823));




static int AscendingOrder(int num)
{
    return int.Parse(string.Concat(num.ToString().OrderBy(x => x)));
}

Console.WriteLine(AscendingOrder(94823));




//OR



//static int DescendingOrder(int num)
//{
//    char[] arr = num.ToString().ToCharArray();
//    Array.Sort(arr);
//    Array.Reverse(arr);
//    return Convert.ToInt32(new string(arr));
//}




//OR

//static int DescendingOrder(int num)
//{
//    var chars = num.ToString().ToCharArray();
//    Array.Sort(chars);
//    Array.Reverse(chars);
//    var s = new string(chars);
//    return Int32.Parse(s);
//}


















