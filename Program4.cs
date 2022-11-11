/*Devlop a program to copy the value of one object to another object using copy constructor*/

using System;
namespace mycode
{
    internal class Program3
    {
        static void Main(String[] args)
        {
            A obj1 = new A(5,10);
            Console.WriteLine("The value of obj1 X "+obj1.x);
            Console.WriteLine("The value of obj1 Y "+obj1.y+ "\n");

            A obj2 = new A(obj1);
            Console.WriteLine("The value of obj2 X "+obj2.x);
            Console.WriteLine("The value of obj2 Y "+obj2.y);
            
        }
    }
    class A
    {
        public int x;
        public int y;

        public A(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public A(A val)
        {
            this.x = val.x;
            this.y = val.y;
        }
        
    }
}