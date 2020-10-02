using System;
using System.Linq;

namespace BigONotationSample
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = { "John", "Jane", "Evan" };
            string[] arr2 = { "Evan", "Peter", "Eric" };

            int[] numbers = { 1, 40, 25, 76, 20, 3, 34 };


            Console.WriteLine("1.) O(1) algorithm: " + isMyNameEvan("Evan"));
            Console.WriteLine("2.) O(N) algorithm: " + isMyNameEvan(arr,"Evan"));
            Console.WriteLine("3.) O(N^2) algorithm: " + isMyNameEvan(arr, arr2));
            Console.WriteLine("4.) O(2^N) algorithm: " + Fibonacci(3));

            Console.WriteLine("\n");

            Console.WriteLine("Another example of O(N^2) is a Bubble Sort!");
            Console.WriteLine("Original Array: ");
            foreach (int n in numbers)
                Console.Write(n + " ");
            Console.WriteLine("\nSorted Array: ");
            numbers = bubbleSort(numbers);
            foreach (int n in numbers)
                Console.Write(n + " ");
            
            Console.WriteLine("\n");

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
            for (int count = 0; count < namesList1.Length; count++) //outer 
            {
                for (int innerCount = 0; innerCount < namesList2.Length; innerCount++) // inner
                {

                    if (namesList1[count] == namesList2[innerCount])
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

        static int[] bubbleSort(int[] arr)
        {
            int temp;
            
            for (int i = 0; i < arr.Length - 2; i++)
            {
                for (int j = 0; j < arr.Length - 2; j++)
                {
                    if(arr[j] > arr[j + 1])
                    {
                        temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            int[] newArr = arr;
            return newArr;
        }
    }
}
