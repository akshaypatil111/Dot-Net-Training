using System;

namespace ConsoleApp3
{
    class GFG
    {

        // Function to print hollow square with
        // primary and secondary diagonal
        static void print_squaredi(int n)
        {
            int i, j;
            for (i = 1; i <= n; i++)
            {
                for (j = 1; j <= n; j++)
                {
                    if (i == 1 || i == n ||
                        j == 1 || j == n ||
                        i == j || j == n - i + 1)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }

        }

        // Driver code
        public static void Main()
        {
            int rows = 8;
            print_squaredi(rows);
        }
    }
}