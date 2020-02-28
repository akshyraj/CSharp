using System;
using System.Collections;
using System.Collections.Generic;
namespace Practical_4
{
    public class InfixToPostfix
    {
        public string InfixToPostfixCon(ref string infix,out string postfix )
        {
            postfix = "";
            char ch;
            Stack<char> stack = new Stack<char>();
            for(int i=0;i<infix.Length;i++)
            {
                ch = infix[i];
                if (isOperator(ch))
                {
                    if (stack.Count == 0)
                    {
                        stack.Push(ch);
                    }
                    else
                    {
                        if (ch == '(')
                            stack.Push(ch);
                        else if (ch == ')')
                        {
                            while (stack.Peek() != '(')
                                postfix += stack.Pop();
                            stack.Pop();
                        }
                        else if (IsPriority(ch) > IsPriority(stack.Peek()))
                            stack.Push(ch);
                        else
                        {
                            while (stack.Count != 0 && IsPriority(ch)<=IsPriority(ch))
                                postfix += stack.Pop();
                            stack.Push(ch);
                        }
                    }
                }
                else
                    postfix += infix[i];
            }
            while (stack.Count > 0)
                postfix += stack.Pop();
            return postfix;
        }
        private bool isOperator(char ch)
        {
            switch(ch)
            {
                case '+':
                case '-':
                case '*':
                case '/':
                case '(':
                case ')':
                    return true;
                default: return false;
            }
        }
        private int IsPriority(char ch)
        {
            char current = ch;
            switch (current)
            {
                case '#': return 0;
                case '(': return 1;
                case '+': return 2;
                case '-': return 2;
                case '*': return 3;
                case '/': return 3;
                default:return 4;
            }
        }
    }
}
