using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.Utility
{
    internal class SLL
    {

        private Node _head;
        private Node _tail;
        private int _count;

        private string _message;

        public Node Head { get { return _head; } }

        public Node Tail { get { return _tail; } }

        public int Count
        {
            get { return _count; }
            set { _count = value; }
        }

        public string Message
        {
            get { return _message; }
            set { _message = value; }
        }


        public SLL()
        {
            _head = _tail = null;           // both head & tail point to null (initially)
            _count = 0;
        }


        public void AddFirst(string s)
        {
            Node new_node = new Node(s);
            if (_head == null)
            {
                _head = _tail = new_node;
                Count++;
            }
            else
            {
                new_node.Next = this._head;
                this._head = new_node;
            }
            //_head = new Node(s);            // object created inside the method
        }

        public void RemoveFirst()
        {
            if (_head != null)
            {
                Node temp = _head;
                this._head = temp.Next;
                temp = null;
            }
            else
            {
                Console.WriteLine("Empty list!");
                this._message = "Empty list!";               //unit test msg
            }
        }

        public void AddLast(string s)
        {
            Node new_node = new Node(s);

            if (_head != null)
            {
                this._tail.Next = new_node;
                this._tail = new_node;
            }
            else
            {
                this._head = this._tail = new_node;
                this._tail = new_node;
            }
        }

        public void RemoveLast()
        {
            if (_head != null)
            {
                Node scnd_last = _head;
                while (scnd_last.Next.Next != null)
                {                                       // traverse until second last
                    scnd_last = scnd_last.Next;
                }

                scnd_last.Next = null;             //remove last node
            }
            else
            {
                Console.WriteLine("Empty list!");
                this._message = "Empty list!";
            }
        }

        public void Traverse()
        {
            if (this._head != null)
            {
                Node n = _head;                 //reusing object pointed by the head variable

                do
                {
                    Console.WriteLine($"--> {n.Data}");
                    n = n.Next;                          //updating reference to the next (move to the next)
                }
                while (n != null);
            }
            else
            {
                Console.WriteLine("Empty List!");
            }
        }


        public string GetValue(int index)
        {
            if (this._head != null)
            {
                int length = 0;
                Node n = this._head;

                while (n != null)
                {
                    n = n.Next;
                    length++;
                }

                //convert index to positive if less than zero
                if (index < 0)
                {
                    index = length + index;
                }

                if (index < 0 || index > length)
                {
                    this._message = "Index out of bounds!";
                    return "Index out of bounds!";
                }

                //traverse sll and find node using index
                n = this._head;
                for (int i = 0; i < index; i++)
                {
                    n = n.Next;
                }

                return n.Data;

            }
            else
            {
                this._message = "Empty list!";
                return "Empty list!";
            }

        }


        public int SizeOfSLL()
        {
            int size = 0;

            if (this._head == null)
            {
                return size;
            }
            else
            {
                Node n = this._head;

                while (n != null)
                {
                    n = n.Next;
                    size++;
                }
            }

            return size;
        }
    }
}
