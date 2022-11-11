/*C# Program Create a class student with a data member name, age, marks of English, marks of math,
 marks of science, total marks, obtained marks and percentage provide member
 functions CalculateTotalMarks and CalculatePercentage to calculate marks and percentage
using System;*/

using System;
namespace mycode
{
    internal class Program2
    {
        static void Main(String[] args)
        {
            Student s = new Student();
            s.ReadData();
            s.CalculateTotalMarks();
            s.CalculatePercentage();
        }
    }
    class Student
    {
        string Name;
        int Age;
        int EnglishMark;
        int MathMark;
        int ScienceMark;
        int Total;
        float per;

        public void ReadData()
        {
            Console.WriteLine("Enter the Student Name -");
            Name =  Console.ReadLine();

            Console.WriteLine("Enter the Age -");
            Age = Int32.Parse(Console.ReadLine());


            Console.WriteLine("Enter the English Mark -");
            EnglishMark = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Math Mark -");
            MathMark = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Science Mark -");
            ScienceMark = Int32.Parse(Console.ReadLine());
        }
        public void CalculateTotalMarks()
        {
            Total = (EnglishMark+MathMark+ScienceMark);
            Console.WriteLine("TOTAL - "+Total);
        }
        public void CalculatePercentage()
        {
            per = (Total / 300f  )*100;
            Console.WriteLine("Percentage - "+per+"%");
        }
    }
}