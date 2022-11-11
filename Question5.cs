/*
5. Define a class called “Employee” with the following fields: EmployeeId, Employee Name,
 Address, City, Department,Salary define an array of objects to hold 10 records of Employee.
  Accept the details of 10 employees from the user
  using a loop. Display the Employee Name and Salary of all the employees.
*/

using System;
namespace mycode
{
    internal class Question5
    {
        public static void Main(String[] args)
        {
            Employee[] arr = new Employee[10];
            for(int i=0; i<2; i++)
            {
                Console.WriteLine("Employee - "+(i+1));
                arr[i] = new Employee();
                arr[i].ReadData();
                
            }

            for(int i=0; i<2; i++)
            {
                Console.WriteLine("Employee Details ---------------------- "+(i+1));
                arr[i].Show();
            }
        }
    } 
    class Employee
    {
         int EmployeeId;

         String EmployeeName;

         String Address;

         String City;

         String Department;

         int Salary;

        public void ReadData()
        {
                Console.WriteLine("Enter your name");
                EmployeeName= Console.ReadLine();

                try
                {
                    Console.WriteLine("Enter your Employee Id :");
                    EmployeeId = Int32.Parse(Console.ReadLine());
                }
                catch(FormatException e)
                {
                    Console.WriteLine("It is a System.FormatException");
                    Console.WriteLine("Please, Only give digits");
                    EmployeeId = Int32.Parse(Console.ReadLine());
                }

                Console.WriteLine("Enter your Address :");
                Address= Console.ReadLine();

                Console.WriteLine("Enter your City :");
                City= Console.ReadLine();

                Console.WriteLine("Enter your Department :");
                Department= Console.ReadLine();

                Console.WriteLine("Enter your Salary :");
                try
                {
                    Salary= Int32.Parse(Console.ReadLine());
                }
                catch(FormatException e)
                {
                    Console.WriteLine("It is a System.FormatException");
                    Console.WriteLine("Please, Only give digits");
                    EmployeeId = Int32.Parse(Console.ReadLine());
                }
        }

        public void Show()
        {
            Console.WriteLine("Employee Name :"+EmployeeName);
            Console.WriteLine("Employee Salary :"+Salary);
        }

    }
}
