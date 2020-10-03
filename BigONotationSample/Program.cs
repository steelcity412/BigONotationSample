﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace BigONotationSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            
            string[] arr = { "John", "Jane", "Evan" };
            string[] arr2 = { "Evan", "Peter", "Eric" };

            int[] numbers = { 1,12, 56, 32, 4, 67, 8 };
            int[] numbers2 = { 10, 17, 25, 35, 52, 55, 62, 77, 90, 95 };

            List<int> list = new List<int> { 1, 2, 3, 4, 5 };

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
            foreach (int n in bubbleSort(numbers))
                Console.Write(n + " ");
            
            Console.WriteLine("\n");

            Console.WriteLine("Original Array: ");
            foreach (var n in numbers)
                Console.Write(n + " ");
            Console.WriteLine("\n");
            Console.WriteLine("Binary Search: The number {0} is found at index {1}", numbers2[7], Program.binarySearch(numbers2, numbers2[7]));
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
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if(arr[j] > arr[j + 1])
                    {
                        temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            return arr;
        }

        static object binarySearch(int[] list, int valueToBeSearched)
        {
            int minNum = 0;
            int maxNum = list.Length - 1;

            while (minNum <= maxNum)
            {
                int mid = (minNum + maxNum) / 2;
                Console.WriteLine("{0} = ({1} + {2}) / 2", "mid","minNum", "maxNum");
                Console.WriteLine("{0} = ({1} + {2}) / 2", mid, minNum, maxNum);
                Console.WriteLine("Mid = " + mid);
                Console.WriteLine("\n");

                if (valueToBeSearched == list[mid])
                {
                    Console.WriteLine("\t{0} == {1}", "valueToBeSearched", "list[mid]");
                    Console.WriteLine("\t{0} == {1}", valueToBeSearched, list[mid]);
                    Console.WriteLine("\t{0} = {1}", "mid", ++mid);
                    Console.WriteLine("\n");
                    return --mid;
                }
                else if ( valueToBeSearched < list[mid])
                {
                    Console.WriteLine("\t{0} < {1}", "valueToBeSearched", "list[mid]");
                    Console.WriteLine("\t{0} < {1}", valueToBeSearched, list[mid]);
                    Console.WriteLine("\t{0} = {1} - 1", "maxNum", "mid");
                    maxNum = mid - 1;
                    Console.WriteLine("\t{0} = {1} - 1", maxNum, mid);
                    Console.WriteLine("\n");
                    
                }
                else
                {
                    Console.WriteLine("\t{0} > {1}", "valueToBeSearched", "list[mid]");
                    Console.WriteLine("\t{0} > {1}", valueToBeSearched, list[mid]);
                    Console.WriteLine("\t{0} = {1} + 1", "minNum", "mid");
                    minNum = mid + 1;
                    Console.WriteLine("\t{0} = {1} + 1", minNum, mid);
                    Console.WriteLine("\n");
                }
            }
            return "None";
        }
    }
}
