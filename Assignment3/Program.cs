using Assignment3.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Program
    {
        public static void Main(string[] args) 
        {
            Console.WriteLine("SLL \n");
            SLL sll1 = new SLL();

            sll1.Traverse();
            // conditions: 
            // If list is empty
            // what if there is a single element
            // what if there are more elements


            // preppend : implemented in SLL as it is part of the list (not the node) 


            // two ways of implementing
            sll1.AddFirst("Name 1");
            sll1.AddFirst("Name 2");
            sll1.AddFirst("Name 3");
            sll1.AddLast("Name 4");
            sll1.AddLast("Name 5");
            sll1.AddLast("Name 6");
            //sll1.AddFirst(new Node("Name 2"));

            //sll1.AddFirst(new Node("Name1"));
            sll1.Traverse();


            //remove first node
            sll1.RemoveFirst();
            Console.WriteLine("\nRemoved first node:");
            sll1.Traverse();


            //remove last node
            sll1.RemoveLast();
            Console.WriteLine("\nRemoved last node:");
            sll1.Traverse();

            //get data by index
            Console.WriteLine($"\nValue returned by index: {sll1.GetValue(-1)}");


            //get size of SLL
            Console.WriteLine($"\nSize of SLL is: {sll1.SizeOfSLL()}");


            Console.WriteLine("\n\nFinished.");

        }
    }
}
