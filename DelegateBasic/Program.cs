using System;

namespace DelegateBasic
{
    class Program
    {
        static int square(int input) => input * input;
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("Select Options from Below");
            Console.WriteLine("1. Simple Delegate");
            Console.WriteLine("2. Func");
            Console.WriteLine("3. Func with Action");
            Console.WriteLine("-----------------------------------------------------------");
            var inputUser = Console.ReadLine();

            switch (inputUser)
            {
                case "1":
                    SimpleDelegate simpleDelegate = new SimpleDelegate();
                    var result = simpleDelegate.executeDel(square,5);
                    Console.WriteLine("Result is : "+ Convert.ToString(result));
                    break;
                case "2":
                    FuncDelegate funcDelegate = new FuncDelegate();
                    var resultFunc = funcDelegate.executeFuncDel(square,6);
                    Console.WriteLine("Result is : "+ Convert.ToString(resultFunc));
                    break;
                case "3":
                    ActionDelegate actionDelegate = new ActionDelegate();
                    actionDelegate.executeActionDel(Console.WriteLine,"  Harshad");
                    break;
                default:
                    Console.WriteLine("Select Valid Option.");
                    break;
            }

        }
    }

}
