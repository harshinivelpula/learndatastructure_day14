using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datastructure
{
    internal class deque
    {
        public static void Display()
        {
            Console.WriteLine("Welcome to Stack And Queue");
            delete Delete = new delete();
            Delete.Enqueue(56);
            Delete.Enqueue(30);
            Delete.Enqueue(70);
            Delete.Display();

            Delete.Dequeue();
            Delete.Display();
            Delete.Dequeue();
            Delete.Display();
            Delete.Dequeue();
            Delete.Display();

            Console.ReadLine();
        }
    }
}
