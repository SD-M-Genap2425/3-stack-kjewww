using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.BracketValidation
{
    public class Node
    {
        public char Data;
        public Node Next;

        public Node(char data)
        {
            Data = data;
            Next = null;
        }
    }

    public class Stack
    {
        private Node top;
        
        public Stack()
        {
            top = null;
        }

        public void Push(char data)
        {
            Node newNode = new(data);
            newNode.Next = top;
            top = newNode;
        }

        public char Pop()
        {
            char Popped = top.Data;
            top = top.Next; 
            return Popped;
        }

        public bool IsEmpty()
        {
            return top == null;
        }
    }

    public class BracketValidator
    {
        public static bool ValidasiEkspresi(string ekspresi)
        {
            Stack stack = new Stack();

            foreach (char c in ekspresi)
            {
                if (c == '(' || c == '{' || c == '[')
                {
                    stack.Push(c);
                }
                else if (c == ')' || c == '}' || c == ']')
                {
                    if (stack.IsEmpty())
                    {
                        return false;
                    }
                    char top = stack.Pop();

                    if (c == ')' && top != '(' ||
                        c == '}' && top != '{' ||
                        c == ']' && top != '[')
                    {
                        return false;
                    }

                }
            }
            return stack.IsEmpty();
        }
    }
}
