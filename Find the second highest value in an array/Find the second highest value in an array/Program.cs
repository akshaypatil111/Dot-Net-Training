using System;
using System.Collections.Generic;

namespace Find_the_second_highest_value_in_an_array
{
    class Program
    {

        static void Main(string[] args)
        // {
        //     int[] array = { 2, 11, 15, 1, 7, 99, 6, 85, 4 };
        //   Array.Sort(array); //sorting array  
        //    Array.Reverse(array); // Reverse Sorting array value  
        //    Console.WriteLine("Second Highest Value In Array " + array[1]);

        //      foreach (var result in array)
        //      {
        //          Console.Write(result + " "); // Array values   
        //     }



        {

            int[] array = new int[5];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            var dict = new Dictionary<int, int>();
            foreach (var value in array)
            {
                if (dict.ContainsKey(value)) dict[value]++;
                else dict[value] = 1;
            }
            foreach (var pair in dict)
                Console.WriteLine("Value {0} occurred {1} times", pair.Key, pair.Value);
            Console.ReadKey();



        }
    }
}