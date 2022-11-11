/*
2. Write a c# program that creates three threads. First thread displays “Good Morning”  every one second, 
	the second thread displays “Hello” every two seconds and the third  thread displays “Welcome”every three seconds 
*/

using System;
using System.Threading;

namespace mycode
{
    internal class ThreadQ2
    {
        public static void goodMorning()
        {
            for(int i=0; i<5; i++ )
            {
                Console.WriteLine("Good Morning");
                Thread.Sleep(2000);
            }
        }
        public static void Hello()
        {
            for(int i=0; i<5; i++ )
            {
                Console.WriteLine("Helloo");
                Thread.Sleep(2000);
            }
        }
        public static void Welcome()
        {
            for(int i=0; i<5; i++ )
            {
                Console.WriteLine("Welcome...");
                Thread.Sleep(4000);
            }
        }
        public static void Main(String[] args)
        {
            Thread t1 = new Thread(ThreadQ2.goodMorning);
            Thread t2 = new Thread(ThreadQ2.Hello);
            Thread t3 = new Thread(ThreadQ2.Welcome);

            t1.Name="First";
            t2.Name="Second";
            t3.Name="Third";

            t1.Start();
            t2.Start();
            t3.Start();

        }
    }
}