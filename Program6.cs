/*9 Write a c# program for overloading operator++ and operator—*/

using System;
namespace mycode
{
    internal class Program6
    {
        static void Main(String[] args)
        {
            SubClass o1 = new SubClass(9,9);
            o1.Show();


            SubClass obj = ++o1;
            obj.Show();

        }
    }
    class SubClass
    {
        public int x;
        public int y;

        public SubClass(int x, int y)
        {
            this.x=x;
            this.y=y;
        }
    
        public static SubClass operator ++ (SubClass obj1)
        {
            SubClass obj = new SubClass(0,0);
            obj.x = ++ obj1.x;
            obj.y = ++ obj1.y;

            return obj;

        }
        public void Show()
        {
            Console.WriteLine("value of a " + x);
            Console.WriteLine("value of b " + y + "\n");


        }

    }
   
}