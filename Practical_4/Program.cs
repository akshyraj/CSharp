using System;

namespace Practical_4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            InfixToPostfix infixToPostfix = new InfixToPostfix();
            Console.Write("Enter the Infix String :");
            string infix = Console.ReadLine();
            string postifix;
            infixToPostfix.InfixToPostfixCon(ref infix, out postifix);
            Console.Write("Postfix String is " + postifix);
        }
    }
}
