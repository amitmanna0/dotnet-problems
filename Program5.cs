/*4 A class has an integer data member 'i' and a function named 'printNum' to print the
 value of 'i'. Its subclass also has an integer data member 'j' and a function named 'printNum'
 to print the value of 'j'. Now call the function 'printNum' by this object.*/

using System;
namespace mycode
{
    internal class Program5
    {
        static void Main(String[] args)
        {
            B obj = new B();
            obj.printNum();
        }
    }
    class A
    {
        public int i=33;
    
        public virtual void printNum()
        {
            Console.WriteLine("The value of  I of class A :"+i);
        }
    }
    class B : A
    {
        public int j=99;

        public override void printNum()
        {
            base.printNum();
            Console.WriteLine("The value of  J of class B :"+j);
        }
    }
}