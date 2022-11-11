using System;

namespace mycode
{    internal class Factorial
    {
        static void  Main(String[] args)
        {
            int value = 20;
            changeValue(ref value);
            Console.WriteLine(value);
            
        }
        static void changeValue(ref int n)
        {
            n = n + 10;
        }
    }
    
}