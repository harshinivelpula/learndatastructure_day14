using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datastructure
{
    internal class queue
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Stack And Queue");
            enqueue Enqueue = new enqueue();
            Enqueue.Enqueue(56);
            Enqueue.Enqueue(30);
            Enqueue.Enqueue(70);
     
            Enqueue.Display();
            Console.ReadLine();
        }
    }
}
