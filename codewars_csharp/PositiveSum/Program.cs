static int PositiveSum(int[] arr)
{
    int total = 0;
    if (arr != null)
    {
        foreach (int i in arr)
        {

            if (i > 0)
            {
                total += i;
            }
        }
        return total;
    }

    return 0;
}

int[] arr = { 1, -4, 7, 12 };

//Console.WriteLine(PositiveSum(new int[] { 1, -4, 7, 12 }));
Console.WriteLine(PositiveSum(arr));


//OR



//public static int PositiveSum(int[] arr)
//{
//    return arr.Where(x => x > 0).Sum();
//}


//OR

//public static int PositiveSum(int[] arr)
//{
//    return arr.Sum(c => (c < 0 ? 0 : c));
//}


//OR


//static int PositiveSum(int[] arr)
//{
//    int sum = 0;

//    if (arr != null)
//    {
//        foreach (int i in arr)
//        {
//            if (i > 0)
//            {
//                sum += i;
//            }
//            else
//            {
//                sum += 0;
//            }
//        }
//        return sum;
//    }
//    return 0;
//}


