using System;
using System.Threading;

namespace ThreadSafeExample
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("----- Select options from below:");
                Console.WriteLine("0. EXIT");  
                Console.WriteLine("1. Execute Thread Unsafe");
                Console.WriteLine("2. Execute Thread Safe with Lock");            
                Console.WriteLine("--------------------------------");      
                var userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "0":
                        Environment.Exit(0);
                        break;

                    case "1":
                        CallThreadUnsafe();
                        break;

                    case "2":
                        CallThreadSafe();
                        break;
                    
                    default:
                        Console.WriteLine("Please select corect option");
                        break;
                }
            }
        }

        public static void CallThreadUnsafe()
        {
            Console.WriteLine("----- Executing Thread UnSafe Example ");
            unsafeExample obj = new unsafeExample();
            Thread t = new Thread(new ThreadStart(obj.unsafeMethod));
            t.Start();
            obj.unsafeMethod();
        }

        public static void CallThreadSafe()
        {
            Console.WriteLine("----- Executing Thread Safe with Lock Example ");
            unsafeExample obj = new unsafeExample();
            Thread t = new Thread(new ThreadStart(obj.safeMethod));
            t.Start();
            obj.safeMethod();
            Console.WriteLine("----- Completed Execution of Thread Safe with Lock Example ");
        }
    }
    
    class unsafeExample
    {
        int num1=0;
        int num2=0;
        int result=0;
        public void unsafeMethod()
        {
            num1=1;
            num2=1;
            // .... Below 2 lines of code in thread unsafe
            Thread.Sleep(200);
            result = num1/num2; 

            num1=0;
            num2=0;
        }

        public void safeMethod()
        {
            // lock statement will be imposed just to have one thread using below bloack of code
            lock (this)
            {
                num1=1;
                num2=1;
                Thread.Sleep(200);
                result = num1/num2; 
                num1=0;
                num2=0;
            }
        }

    }

}

