using System;
using System.Threading.Tasks;

namespace AsyncAwaitPractise
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine( await p.MakeTeaAsync());
        }

        public async Task<string> MakeTeaAsync()
        {
            
            var boilingWater = BoilingWaterAsync();
            Console.WriteLine("Take out Cups");
            Console.WriteLine("attach Tea bag to cups");
            await boilingWater;
            Console.WriteLine(boilingWater);
            var tea= "Tea is ready to serve";
            return tea;
        }

         public async Task<string> BoilingWaterAsync()
        {
            Console.WriteLine("Start the kettle");
            Console.WriteLine("waiting for kettel to boil water");
            await Task.Delay(3000);

            Console.WriteLine("Kettle is hot enough");
            return "water bolied";
        }

    }
}
