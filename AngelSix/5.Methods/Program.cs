using System;

namespace _5.Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // string result = GetUserDateOfBirth("Rusty Malpass");
            // Console.WriteLine(result);

            Console.WriteLine(GetUserDateOfBirth("Rusty Malpass")); 
            

        }

        public static string GetUserDateOfBirth(string fullName)
        {
            return fullName + " was born on Tuesday";
        }


       
    }
}
