/*Write c# Program that receives the following information from a set of students:
Student Id:
Student Name:
Course Name:
Date of Birth:
The application should also display the information of all the students once the data is
Entered. */

using System;

namespace mycode
{
    internal class Program1
    {
        static void Main(String[] args)
        {
            Student st = new Student();
            st.ReadData();
            st.ShowData();
        }
    }
    class Student 
    {
        int StudentId;
        String StudentName;
        String CourseName;
        String DOB;

        public void ReadData()
        {
            Console.WriteLine("Enter the Student Id -");
            StudentId = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Student Name -");
            StudentName =  Console.ReadLine();

            Console.WriteLine("Enter the Course Name -");
            CourseName = Console.ReadLine();

            Console.WriteLine("Enter the Date of Birth -");
            DOB = Console.ReadLine();
        }

        public void ShowData()
        {
            Console.WriteLine("Student Id - "+ StudentId);
            Console.WriteLine("Name - "+StudentName);
            Console.WriteLine("Course - "+ CourseName);
            Console.WriteLine("DOB - "+DOB);
        }
    }
}