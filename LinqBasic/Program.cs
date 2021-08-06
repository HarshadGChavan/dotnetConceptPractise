using System;
using System.Collections.Generic;
using static LinqBasic.LinqOperations;

namespace LinqBasic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------- SELECT LINQ OPERATION ---------------");
            Console.WriteLine("1.  Where Operation");
            Console.WriteLine("2.  OfType Operation");
            Console.WriteLine("3.  Order By Operation");
            Console.WriteLine("4.  ThenBy Operation");
            Console.WriteLine("5.  GroupBy Operation");
            Console.WriteLine("6.  Inner-Join Operation");
            Console.WriteLine("7.  Contains Operation");
            Console.WriteLine("8.  Count Operation");
            Console.WriteLine("9.  First Operation");
            Console.WriteLine("10. First Or Default Operation");
            Console.WriteLine("11. Take Operation");
            Console.WriteLine("12. Skip Operation");
            Console.WriteLine("----------------------------------------------------");

            var choice = Convert.ToInt16(Console.ReadLine());
            LinqOperations linqOperations = new LinqOperations();
            switch (choice)
            {
                case 1:
                    linqOperations.ExecuteWhere();
                    break;
                case 2:
                    linqOperations.ExecuteOfType();
                    break;
                case 3:
                    linqOperations.ExecuteOrderBy();
                    break;
                case 4:
                    linqOperations.ExecuteThenBy();
                    break;
                case 5:
                    linqOperations.ExecuteGroupBy();
                    break;
                case 6:
                    linqOperations.ExecuteInnerJoin();
                    break;
                case 7:
                    linqOperations.ExecuteContains();
                    break;
                case 8:
                    linqOperations.ExecuteCount();
                    break;
                case 9:
                    linqOperations.ExecuteFirst();
                    break;
                case 10:
                    linqOperations.ExecuteFirstOrDefault();
                    break;
                case 11:
                    linqOperations.ExecuteTake();
                    break;
                case 12:
                    linqOperations.ExecuteSkip();
                    break;
                default:
                    Console.WriteLine("Please select correct option!");
                    break;
            }
           
        }

    }
}
