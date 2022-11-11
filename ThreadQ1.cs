/*
1. Create simple threaded application that prints out the name of a fruit at
timed intervals.
*/

using System;
using System.Threading;

namespace mycode
{
    internal class ThreadQ1
    {
        public static void fruit()
        {
            for(int i=0; i<5; i++ )
            {
                Console.WriteLine("Orange");
                Thread.Sleep(1000);
            }
            Console.WriteLine("Process Terminated");
        }
        public static void Main(String[] args)
        {
            Thread t1 = new Thread(ThreadQ1.fruit);
            t1.Start();
        }
    }
}