using System;
using System.Threading;

namespace BasicThreading
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t1= new Thread(new ThreadStart(Function1));
            Thread t2= new Thread(new ThreadStart(Function2));
            t1.Start();
            t2.Start();

            Console.WriteLine("Hello World!");
        }

        public static void Function1()
        {
            for (int i = 0; i < 30; i++)
            {
                Thread.Sleep(1000);
                System.Console.WriteLine("Func1 : Hello");
            }
        }

        public static void Function2()
        {
           for (int i = 0; i < 30; i++)
            {
                Thread.Sleep(1000);
                System.Console.WriteLine("Func2 : Hello");
            }
        }

    }
}
