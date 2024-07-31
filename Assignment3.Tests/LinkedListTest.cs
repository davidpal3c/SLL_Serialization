using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment3.Utility;

namespace Assignment3.Tests
{
    internal class LinkedListTest
    {
        private SLL sll1;

        [SetUp]        
        public void Setup()
        {

            sll1 = new SLL();


            /*
            User usr1 = new User(001, "Otto", "blind_melon@springfieldelementary.com", "password");
            User usr2 = new User(002, "Skinner", "yes_mom@springfieldelementary.com", "password");
            User usr3 = new User(003, "Ralph", "ralphy@springfieldelementary.com", "password");
            User usr4 = new User(004, "Lisa", "lisa@springfieldelementary.com", "password");
            User usr5 = new User(005, "Milhouse", "foureyes@springfieldelementary.com", "password");
            User usr6 = new User(006, "Nelson", "aaaha@springfieldelementary.com", "password");
            User usr7 = new User(007, "Willie", "scottishkeeper@springfieldelementary.com", "password");
            
            User usr8 = new User(008, "None", "another@springfieldelementary.com", "password");

            
            sll1.AddFirst(usr1);
            sll1.AddLast(usr2);
            sll1.AddLast(usr3);
            sll1.AddFirst(usr4);
            sll1.AddLast(usr5);
            sll1.AddFirst(usr6);
            sll1.AddLast(usr7);
            */

            //sll1.AddLast(usr8);
        }


        [Test]
        [TestCase(true)]
        [TestCase(false)]
        public void EmptyList(bool expected)
        {
            if (!expected)
            {
                User usr1 = new User(001, "Otto", "blind_melon@springfieldelementary.com", "password");
                sll1.AddFirst(usr1);
            }

            bool actual = sll1.IsEmpty();

            Assert.That(actual, Is.EqualTo(expected));
        }


        [Test]
        public void PrependItem_Test()
        {
            User usr1 = new User(001, "Otto", "blind_melon@springfieldelementary.com", "password");
            User usr2 = new User(002, "Skinner", "yes_mom@springfieldelementary.com", "password");
            User usr3 = new User(003, "Ralph", "ralphy@springfieldelementary.com", "password");
            
            sll1.AddLast(usr1);
            sll1.AddLast(usr2);
            sll1.AddLast(usr3);            

            User actual = sll1.GetValue(2);
            Assert.That(actual, Is.EqualTo(usr3));
        }



        [Test]
        public void AppendItem_Test()
        {
            User usr1 = new User(001, "Otto", "blind_melon@springfieldelementary.com", "password");
            User usr2 = new User(002, "Skinner", "yes_mom@springfieldelementary.com", "password");


            sll1.AddLast(usr1);
            sll1.AddLast(usr2);


            User actual = sll1.GetValue(-1);

            Assert.That(actual, Is.EqualTo(usr2));
        }


        [Test]
        public void InsertAyIndex_Test()
        {
            User usr1 = new User(001, "Otto", "blind_melon@springfieldelementary.com", "password");
            User usr2 = new User(002, "Skinner", "yes_mom@springfieldelementary.com", "password");
            User usr3 = new User(003, "Ralph", "ralphy@springfieldelementary.com", "password");
            User usr4 = new User(004, "Lisa", "lisa@springfieldelementary.com", "password");
            User usr5 = new User(005, "Milhouse", "foureyes@springfieldelementary.com", "password");

            sll1.AddFirst(usr1);
            sll1.AddLast(usr2);            
            sll1.AddLast(usr4);
            sll1.AddLast(usr5);

            sll1.Add(usr3, 2);

            User actual = sll1.GetValue(2);

            Assert.That(actual, Is.EqualTo(usr3));
        }


        [Test]
        public void Replace_Test()
        {
            User usr1 = new User(001, "Otto", "blind_melon@springfieldelementary.com", "password");
            User usr2 = new User(002, "Skinner", "yes_mom@springfieldelementary.com", "password");
            User usr3 = new User(003, "Ralph", "ralphy@springfieldelementary.com", "password");
            User usr4 = new User(004, "Lisa", "lisa@springfieldelementary.com", "password");
            User usr5 = new User(005, "Milhouse", "foureyes@springfieldelementary.com", "password");
            
            User usr9 = new User(009, "Bart", "elbarto@springfieldelementary.com", "password");

            sll1.AddFirst(usr1);
            sll1.AddLast(usr2);
            sll1.AddLast(usr3);
            sll1.AddLast(usr4);
            sll1.AddLast(usr5);

            sll1.Replace(usr9, -4);

            User actual = sll1.GetValue(1);

            Assert.That(actual, Is.EqualTo(usr9));
        }

        [Test]
        public void Replace_EmptyList_Test()
        {
            User usr9 = new User(009, "Bart", "elbarto@springfieldelementary.com", "password");

            bool listBefore = sll1.IsEmpty();

            try
            {
                sll1.Replace(usr9, 0);
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }

            bool listAfter = sll1.IsEmpty();

            Assert.That(listBefore, Is.True);
            Assert.That(listAfter, Is.True); 
        }


        [Test]
        public void RemoveFirst_Test()
        {
            User usr1 = new User(001, "Otto", "blind_melon@springfieldelementary.com", "password");            
            User usr2 = new User(003, "Ralph", "ralphy@springfieldelementary.com", "password");
            User usr3 = new User(004, "Lisa", "lisa@springfieldelementary.com", "password");
            User usr4 = new User(005, "Milhouse", "foureyes@springfieldelementary.com", "password");
            User usr5 = new User(009, "Bart", "elbarto@springfieldelementary.com", "password");


            sll1.AddLast(usr1);
            sll1.AddLast(usr2);
            sll1.AddLast(usr3);
            sll1.AddLast(usr4);
            sll1.AddFirst(usr5);

            sll1.RemoveFirst();

            User actual = sll1.GetValue(0);

            Assert.That(actual, Is.EqualTo(usr1));
        }


        [Test]
        public void RemoveLast_Test()
        {
            User usr1 = new User(001, "Otto", "blind_melon@springfieldelementary.com", "password");
            User usr2 = new User(003, "Ralph", "ralphy@springfieldelementary.com", "password");
            User usr3 = new User(004, "Lisa", "lisa@springfieldelementary.com", "password");
            User usr4 = new User(005, "Milhouse", "foureyes@springfieldelementary.com", "password");
            User usr5 = new User(009, "Bart", "elbarto@springfieldelementary.com", "password");


            sll1.AddFirst(usr1);
            sll1.AddFirst(usr2);
            sll1.AddFirst(usr3);
            sll1.AddFirst(usr4);
            sll1.AddLast(usr5);

            sll1.RemoveLast();

            User actual = sll1.GetValue(-1);

            Assert.That(actual, Is.EqualTo(usr1));
        }


        [Test]
        public void RemoveLast_EmptyList_Test()
        {          
            try
            {
                sll1.RemoveLast();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Assert.That(sll1.IsEmpty(), Is.True);   
        }



        [Test]
        public void RemoveByIndex_test()
        {
            User usr1 = new User(001, "Otto", "blind_melon@springfieldelementary.com", "password");
            User usr2 = new User(002, "Ralph", "ralphy@springfieldelementary.com", "password");
            User usr3 = new User(003, "Lisa", "lisa@springfieldelementary.com", "password");
            User usr4 = new User(004, "Milhouse", "foureyes@springfieldelementary.com", "password");
            User usr5 = new User(005, "Bart", "elbarto@springfieldelementary.com", "password");

            sll1.AddLast(usr1);
            sll1.AddLast(usr2);
            sll1.AddLast(usr3);
            sll1.AddLast(usr4);
            sll1.AddLast(usr5);

            sll1.Remove(1);

            //confirms object based on index -- 
            User actual = sll1.GetValue(1);

            //verifies confirmed value is equal to the expected
            Assert.That(actual, Is.EqualTo(usr3));
        }


        [Test]
        public void RemoveByIndex_OutOfBounds_test()
        {
            User usr1 = new User(001, "Otto", "blind_melon@springfieldelementary.com", "password");
            User usr2 = new User(002, "Ralph", "ralphy@springfieldelementary.com", "password");
          
            sll1.AddLast(usr1);
            sll1.AddLast(usr2);

            int initialCount = sll1.Count();

            try
            {
                sll1.Remove(4);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            int finalCount = sll1.Count();

            //verifies initial count is equal to final count
            Assert.That(finalCount, Is.EqualTo(initialCount));

            //verifies items in list are still the same
            User firstItem = sll1.GetValue(0);
            User secondItem = sll1.GetValue(1);

            Assert.That(firstItem, Is.EqualTo(usr1));
            Assert.That(secondItem, Is.EqualTo(usr2));
        }


        [Test]
        public void AddRemove_MultipleItems_Test()
        {
            // iterates list adding items
            for (int i = 0; i < 1000; i++)
            {
                sll1.AddLast(new User(i, $"User{i}", $"user{i}@springfieldelementary.com", $"password{i}"));
            }

            // iterates list removing items
            for (int i = 0; i < 1000; i++)
            {
                sll1.RemoveFirst(); 
            }

            // verifies list is empty
            Assert.That(sll1.IsEmpty(), Is.True); 
        }


        [Test]
        public void GetValue_test()
        {
            User usr1 = new User(001, "Otto", "blind_melon@springfieldelementary.com", "password");
            User usr2 = new User(002, "Ralph", "ralphy@springfieldelementary.com", "password");
            User usr3 = new User(003, "Lisa", "lisa@springfieldelementary.com", "password");
            User usr4 = new User(004, "Milhouse", "foureyes@springfieldelementary.com", "password");
            User usr5 = new User(005, "Bart", "elbarto@springfieldelementary.com", "password");

            sll1.AddLast(usr1);
            sll1.AddLast(usr2);
            sll1.AddLast(usr3);
            sll1.AddLast(usr4);
            sll1.AddLast(usr5);

            sll1.Remove(1);

            User actual = sll1.GetValue(-2);

            Assert.That(actual, Is.EqualTo(usr4));
        }


        [Test]
        public void SortList_test()
        {
            User usr1 = new User(001, "Otto", "blind_melon@springfieldelementary.com", "password");
            User usr2 = new User(002, "Ralph", "ralphy@springfieldelementary.com", "password");
            User usr3 = new User(003, "Lisa", "lisa@springfieldelementary.com", "password");
            User usr4 = new User(004, "Milhouse", "foureyes@springfieldelementary.com", "password");
            User usr5 = new User(005, "Bart", "elbarto@springfieldelementary.com", "password");

            sll1.AddLast(usr1);
            sll1.AddLast(usr2);
            sll1.AddLast(usr3);
            sll1.AddLast(usr4);
            sll1.AddLast(usr5);

            sll1.SortByName();

            User actual = sll1.GetValue(0);

            Assert.That(actual, Is.EqualTo(usr5));
        }
    }

}
