using EmployeeDetails;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to main program !!! \n");
            Console.WriteLine("Specify the number of employees details you want to store here : ");
            
            string Number = Console.ReadLine();
            int num = Convert.ToInt32(Number);
            Console.WriteLine();
            if (num >= 1)
            {
                for (int i = 0; i < num; i++)
                {
                    Console.WriteLine("Enter Employee_{0} FirstName is:",i+1);
                    string FirstName = Console.ReadLine();
                    Console.WriteLine("Enter Employee_{0} LastName is:",i+1);
                    string LastName = Console.ReadLine();
                    Console.WriteLine("Enter Employee_{0} PS Number is:",i+1);
                    string PS = Console.ReadLine();
                    int PSNumber = Convert.ToInt32(PS);

                    Employee emp1 = new Employee(FirstName, LastName, PSNumber);
                    Console.WriteLine();
                    Console.WriteLine("Employee_{0} full details is below : \n", i);
                    emp1.GetFullDetailsOfEmployee();
                    Console.WriteLine();


                }
            }
            else
            {
                Console.WriteLine("The entered value of count for the Employee details is less what program accepts");
                Console.WriteLine("Please do Re-run the program & enter value of count more than 1 ");
            }
           
            
            Console.ReadKey();
        }
    }
}
