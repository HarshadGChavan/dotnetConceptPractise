using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqBasic
{
    class Program
    {
        static List<string> lstOperation = new List<string> (){
            "Audi","Tesla","Ford","Ferrari","Porche"
        };
        
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine("------------- LINQ Take 3 ----------------");
            dynamic result = lstOperation.Take(3);
            DisplayResult(result);
            Console.WriteLine("------------- LINQ Skip 3 ----------------");
            result = lstOperation.Skip(3);
            DisplayResult(result);
            Console.WriteLine("------------- LINQ First & First Or Default ----------------");
            result = lstOperation.First(x => x == "Audi");
            if (result != null)
                Console.WriteLine(result);

            result = lstOperation.FirstOrDefault(x => x == "Audis");
            if (result != null)
                Console.WriteLine(result);
            else
                Console.WriteLine("Unable to find !");
        }

        static void DisplayResult(dynamic result)
        {
            foreach (var item in result)
                Console.WriteLine(item);
        }
    }
}
