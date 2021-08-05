using System;

namespace DelegateBasic
{
    public class FuncDelegate
    {
       public int executeFuncDel (Func<int,int> calculate,int input)
       {
           return calculate(input);
       }
    }
}