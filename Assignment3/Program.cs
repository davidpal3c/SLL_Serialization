
using System;
using Assignment3.Utility;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment3.Services;


namespace Assignment3
{
    internal class Program
    {
        public static void Main(string[] args) 
        {

            try
            {
                IOService.LoadFile();

                User usr1 = new User(001, "Otto", "blind_melon@springfieldelementary.com", "password");
                User usr2 = new User(002, "Skinner", "mom_s_boy@springfieldelementary.com", "password");
                User usr3 = new User(003, "Ralph", "ralphy@springfieldelementary.com", "password");
                User usr4 = new User(004, "Lisa", "lisa@springfieldelementary.com", "password");
                User usr5 = new User(005, "Milhouse", "foureyes@springfieldelementary.com", "password");
                User usr6 = new User(006, "Nelson", "aaaha@springfieldelementary.com", "password");
                User usr7 = new User(007, "Willie", "scottishkeeper@springfieldelementary.com", "password");
                User usr8 = new User(008, "None", "another@springfieldelementary.com", "password");


                SLL sll1 = new SLL();


                if (sll1.IsEmpty())
                {
                    Console.WriteLine("List is empty!");
                }
                else
                {
                    Console.WriteLine("List is NOT empty!");
                }


                sll1.AddFirst(usr1);
                sll1.AddLast(usr2);
                sll1.AddLast(usr3);
                sll1.AddLast(usr4);
                sll1.AddLast(usr5);
                sll1.AddFirst(usr6);



                sll1.Traverse();

                //sll1.GetValue(usr2);

                try
                {
                    Console.WriteLine();
                    Console.WriteLine($"\n{sll1.GetValue(2).ToString()}");
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine($"{ex.Message}");
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine($"{ex.Message}");
                }

                /*
                try
                {
                    sll1.IsEmpty();
                }
                */

                if (sll1.IsEmpty())
                {
                    Console.WriteLine("List is empty!");
                }
                else
                {
                    Console.WriteLine("List is NOT empty!");
                }

                Console.WriteLine("\nClearing list...");
                sll1.Clear();

                sll1.Traverse();


                if (sll1.IsEmpty())
                {
                    Console.WriteLine("List is empty!");
                }
                else
                {
                    Console.WriteLine("List is NOT empty!");
                }

                sll1.AddFirst(usr1);
                sll1.AddLast(usr2);
                sll1.AddLast(usr3);
                sll1.AddLast(usr4);
                sll1.AddLast(usr5);
                sll1.AddFirst(usr6);

                sll1.Traverse();
                Console.WriteLine(sll1.Count());



                Console.WriteLine("\n");
                Console.WriteLine("\nAdding using index");


                sll1.Add(usr7, 4);

                sll1.Traverse();
                Console.WriteLine(sll1.Count());


                //Console.WriteLine("\nReplace by index");
                //sll1.Replace(usr7, 3);

                Console.WriteLine("\nRemove obj by index");
                sll1.Remove(6);

                sll1.Traverse();

                Console.WriteLine(sll1.Count());


                Console.WriteLine("\nTest find object index");
                Console.WriteLine(sll1.IndexOf(usr6));



                Console.WriteLine("\nContains value test");

                bool k = sll1.Contains(usr6);
                bool j = sll1.Contains(usr7);

                if (k == true)
                {
                    Console.WriteLine("True");
                }
                else
                {
                    Console.WriteLine("False");
                }


                if (j == true)
                {
                    Console.WriteLine("True");
                }
                else
                {
                    Console.WriteLine("False");
                }


                Console.WriteLine("\nBubble Sort test:");
                sll1.Traverse();

                Console.WriteLine();
                sll1.SortByName();
                sll1.Traverse();


                IOService.SaveToFile(sll1);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


        }

    }
}
