using System;

namespace DelegateBasic
{
    public class ActionDelegate
    {
        public void executeActionDel(Action<string> print,string input)
        {
            print("Printing it from action"+input);
        }
    }
}