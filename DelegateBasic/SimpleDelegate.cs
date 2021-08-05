namespace DelegateBasic
{
    public class SimpleDelegate
    {
       public  delegate int calculate(int input);

       public int executeDel (calculate calculate,int input)
       {
           return calculate(input);
       }
    }
}