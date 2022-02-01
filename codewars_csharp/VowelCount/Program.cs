

    static int GetVowelCount(string str)
    {
        return str.Count(i => "aeiou".Contains(i));
    }

Console.WriteLine(GetVowelCount("gavin"));





//public static int GetVowelCount(string str)
//{
//    return str.ToLower().Count(c => "aeiou".IndexOf(c) != -1);
//}



//public static int GetVowelCount(string str)
//{
//    return (Regex.Matches(str, @"[aeiouAEIOU]")).Count;
//}



//public static int GetVowelCount(string str)
//{
//    int vowelCount = 0;
//    string vowels = "aeiou";

//    foreach (char letter in str)
//    {
//        if (vowels.IndexOf(letter) != -1)
//            vowelCount++;
//    }

//    return vowelCount;
}