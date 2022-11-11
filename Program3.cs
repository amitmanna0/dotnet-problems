/*Create a class to print the area of a square and a rectangle. The class has two functions with the same
 name but different number of parameters. The function for printing the area of rectangle has two
  parameters which are its length and breadth respectively while the other function for printing the 
  area of square has one parameter which is the side of the square.*/

using System;
namespace mycode
{
    internal class Program3
    {
        static void Main(String[] args)
        {
            Sharp sp = new Sharp();
            sp.Area(5,8);
            sp.Area(5);
        }
    }
    class Sharp
    {
    
        public void Area(int a)
        {
            Console.WriteLine("The Area of Square is "+(a*a));
        }
        public void Area(int a, int b)
        {
            Console.WriteLine("The Area of Rectangle is "+(a*b));
        }
    }
}