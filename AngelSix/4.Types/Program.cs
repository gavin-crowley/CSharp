using System;

namespace _4.Types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Integral Types, from smallest up (hold whole numbers)
            sbyte mySByte;
            byte myByte;
            short myShort;
            ushort myUShort;
            int myInt;
            uint myUInt;
            long myLong;
            ulong myULong;


            // floats
            float myFloat;
            double myDouble;
            decimal myDecimal;


            bool myBool;
            char myChar;
            string myString;

            myBool = false;
            myBool = true;

            myChar = 'a';
            myString = "aaa";

            DateTime myDateTime;
            TimeSpan myTimeSpan;

            // Options for storing data
            //
            // 1. Whole numbers
            // 2. Floating point numbers
            // 3. Truth values
            // 4. Text (char/string)
            //
        }
    }
}

// https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/integral-numeric-types