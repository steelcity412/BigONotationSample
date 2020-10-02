using System;
using System.Linq;

namespace BigONotationSample
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Hello World!");

            Console.WriteLine("1. O(1) algorithm: " + isMyNameEvan("Evan"));

            string[] arr = { "John", "Jane", "Evan" };
            string[] arr2 = { "Evan", "Peter", "Eric" };

            Console.WriteLine("2.) O(N) algorithm: " + isMyNameEvan(arr,"Evan"));

            Console.WriteLine("3.) O(N^2) algorithm: " + isMyNameEvan(arr, arr2));
            Console.WriteLine("4.) O(2^N) algorithm: " + Fibonacci(3));
        }

        static bool isMyNameEvan(string input)
        {
            return input == "Evan";
        }

        static bool isMyNameEvan(string[] names, string value)
        {
            foreach (var name in names)
            {
                if (name == value)
                {
                    return true;
                }
                
            }
            return false;
        }

        static bool isMyNameEvan(string[] namesList1, string[] namesList2)
        {
            for (int i = 0; i < namesList1.Length; i++) //outer 
            {
                for (int j = 0; j < namesList2.Length; j++) // inner
                {

                    if (namesList1[i] == namesList2[j])
                    {
                        return true;
                    }

                }

            }

            return false;
        }

        static int Fibonacci(int number)
        {
            if (number <= 1) return number;

            return Fibonacci(number - 2) + Fibonacci(number - 1);
        }


    }
}
