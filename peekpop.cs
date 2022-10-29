using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datastructure
{
    internal class peekpop
    {
        public static void Display()
        {
            Console.WriteLine("Welcome to Stack And Queue");
            Stack stack = new Stack();
            stack.Push(70);
            stack.Push(30);
            stack.Push(56);
            stack.Display();

            stackpeek stackPeek = new stackpeek();
            stackPeek.Peek();
            stackPeek.Pop();
            stackPeek.Display();
            stackPeek.Peek();
            stackPeek.Pop();
            stackPeek.Display();
            stackPeek.Peek();
            stackPeek.Pop();
            stackPeek.Display();

            
            Console.ReadLine();
        }
    }
}
