using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter your day:");
            int day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your day is:  " +  day);


            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;

                case 2:
                    Console.WriteLine("Tuesday");
                    break;

                case 3:
                    Console.WriteLine("Wednsday");
                    break;
                
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                
                case 5:
                    Console.WriteLine("Friday");
                    break;

                case 6:
                    Console.WriteLine("Saturday");
                    break;
               
                case 7:
                    Console.WriteLine("Sunday");
                    break;

                default:
                    Console.WriteLine("Invalid Input");
                    break;



                    





            }
        }
    }
}
