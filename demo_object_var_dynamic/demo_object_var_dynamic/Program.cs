using System;

namespace demo_object_var_dynamic
{
    class Program
    {
        static void Main(string[] args)
        {
            // This program will give example of diff between object-var-dynamic

            //...... Object 
            object amountObj = 10;
            Console.WriteLine("Type of object : "+ amountObj.GetType());

            //...even if we get type of amountObj as int in above line below line will throw compile time error
            //amountObj = amountObj + 100;
            /*.. WHY ? ANS -> An object requires explicit type conversion before it can be used.
            We can store anything in the object type variable but for performing an
            operation we must type cast it. */


            //...... Var
            var amountVar = 10;
            Console.WriteLine("Type of var : " + amountVar.GetType());
            amountVar = amountVar + 20;
            Console.WriteLine("Type of var : " + amountVar.GetType());
            //...Cannot change the type of these variables at runtime
            //.. so below line will throw error
            //amountVar = "test";


            //...... Dynamic
            dynamic amountDyn = 10;
            Console.WriteLine("Type of Dynamic : " + amountDyn.GetType());
            amountDyn = amountDyn + 20;
            Console.WriteLine("Type of Dynamic : " + amountDyn.GetType());
            amountDyn = "test";
            Console.WriteLine("Type of Dynamic : " + amountDyn.GetType());


            Console.ReadLine();
        }

        
    }
}
