using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class EmpDetails
    {
        class employee
        {
            public string EmpName;
            public int EmpId;
            public string EmpGender;
            public int EmpSalary;

            //get Input from User

            //Methods in a class
            public void GetData()
            {
                Console.WriteLine("Please enter Employee Details");
                Console.WriteLine("Please enter Employee Name");
                EmpName = Console.ReadLine();
                Console.WriteLine("Please enter Employee ID");
                EmpId = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter Employee Gender");
                EmpGender = Console.ReadLine();
                Console.WriteLine("Please enter Employee Salary");
                EmpSalary = Convert.ToInt32(Console.ReadLine());
            }

            public void PrintData()
            {
                Console.WriteLine("Employee Details are:");
                Console.WriteLine(EmpName);
                Console.WriteLine(EmpId);
                Console.WriteLine(EmpGender);
                Console.WriteLine(EmpSalary);
            }
        }

        class Class5
        {
            static void Main(string[] args)
            {

                //array of objects
                employee[] empList = new employee[3];
                for (int i = 0; i < empList.Length; i++)
                {
                    employee s = new employee();
                    s.GetData();
                    empList[i] = s;
                }

                for (int i = 0; i < empList.Length; i++)
                {
                    empList[i].PrintData();
                }

            }
        }
    }
}