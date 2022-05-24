
    
     ///static void Main(string[] args)
      //{
            //int num1 = 0;
            //int num2 = 0;
            //Console.WriteLine("Type a number");
            //num1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Type a number");
            //num2= Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Choose an option from the following list:");
            //  Console.WriteLine(" +");
            // Console.WriteLine(" -");
            //Console.WriteLine(" *");
            // Console.WriteLine(" /");

            //switch (Console.ReadLine())
            //{
            //    case "+":
            //        Console.WriteLine("Your result:  = " + (num1 + num2));
            //        break;
            //    case "-":
            //        Console.WriteLine("Your result:  = " + (num1 - num2));
            //        break;
            //    case "*":
            //        Console.WriteLine("Your result:  = " + (num1 * num2));
            //        break;
            //   case "/":
            //       Console.WriteLine("Your result:  = " + (num1 / num2));
            //       break;



            //   Console.WriteLine("Nested for loop");
            // for (int i = 0; i < 5; i++)
            //{
            //      for (int j = 0; j <= i; j++)
            //          Console.Write("*");
            //     Console.WriteLine();
using system;
class CFG
{
   static void print_squaredi(int n)
        {

            int i, j;
            for (i = 1;i<= n; i++)
            {
                for (j=1; i <= n; j++)
                {
                    if (i == 1 || i == n ||
                        j == 1 || j == n ||
                        i == j || j == (n - i + 1))
                        Console.Write("*");
                    else
                    Console.Write(" ");

                }

                                    

            }
        


        public static void main()
        {
            int rows = 8;
            print_squaredi(rows);
        }      















        
    }

