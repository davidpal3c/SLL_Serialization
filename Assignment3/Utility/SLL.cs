using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Assignment3.Utility
{
    internal class SLL : ILinkedListADT
    {

        private Node _head;
        private Node _tail;

        private string _message;

        public Node Head { get { return _head; } set { _head = value; } }

        public Node Tail { get { return _tail; } set { _tail = value; } }


        public string Message
        {
            get { return _message; }
            set { _message = value; }
        }


        public SLL()
        {
            _head = _tail = null;           // both head & tail point to null (initially)            
        }


        public bool IsEmpty() 
        {
            if (this.Head == null || this.Tail == null) 
            {
                return true;
            }
            else
            {
                return false;
            }                                
        }

        public void Clear() 
        {
            this.Head = null;
            this.Tail = null;
        }

        public void AddLast(User value) 
        {
            Node new_node = new Node(value);

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

        public void AddFirst(User value) 
        {
            Node new_node = new Node(value);

            if (_head == null)
            {
                this._head = this._tail = new_node;
            }
            else
            {
                new_node.Next = this._head;
                this._head = new_node;
            }            
        }

        public void Add(User value, int index) 
        {
            
            Node newNode = new Node(value);

            if (this.Head == null)
            {
                if(index == 0)
                {
                    this.Head = newNode;
                    this.Tail = newNode;

                }
                else
                {
                    throw new IndexOutOfRangeException("Index out of bounds!");
                }
                
            }
            else
            {
                int length = 0;
                Node n = this.Head;

                while (n != null)
                {
                    n = n.Next;
                    length++;
                }


                if (index < 0)
                {
                    index = length + index;
                }

                if (index < 0 || index > length)
                {
                    throw new ArgumentOutOfRangeException("Index out of bounds!");
                }


                if (index == 0)
                {
                    newNode.Next = this.Head;
                    this.Head = newNode;

                    if (length == 0) 
                    {
                        this.Tail = newNode;
                    }
                }
                else
                {
                    Node prev = null;
                    n = this.Head;

                    //find node before index
                    for (int i = 0; i < index; i++)
                    {
                        prev = n;
                        n = n.Next;    
                    }

                    //insert node
                    prev.Next = newNode;
                    newNode.Next = n;

                    if (newNode.Next != null)
                    {
                        this.Tail = newNode;
                    }   

                }
            }
        }            

        public void Replace(User value, int index) 
        {
            if (this.Head != null)
            {
                int length = 0;
                Node n = this.Head;

                while (n != null)
                {
                    n = n.Next;
                    length++;
                }

                if (index < 0)
                {
                    index = length + index;
                }

                if (index < 0 || index > length)
                {
                    throw new ArgumentOutOfRangeException("Index out of bounds!");
                }

                n = this.Head;
                //traverse sll finding node using index
                for (int i = 0; i < index; i++)
                {
                    if (n == null)
                    {
                        throw new InvalidOperationException("Unexpected null node during traverse.");
                    }
                    
                    n = n.Next;
                }

                if (n != null)
                {
                    n.Data = value;
                }
                else
                {
                    throw new InvalidOperationException("Node at the specified index is null.");
                }                

                //add NullReferenceException
            }
            else
            {
                throw new InvalidOperationException("The list is empty!");
            }
        }


        public int Count() 
        {
            int length = 0;

            if (this.Head != null)
            {                
                Node n = this.Head; 

                while (n != null)
                {
                    n = n.Next;
                    length++;
                }                
            }
            return length;        
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
            }
        }    

        public void Remove(int index) 
        {
            if (this.Head == null)
            {
                throw new InvalidOperationException("The list is empty.");
            }

            int length = 0;
            Node n = this.Head;                       

            while (n != null)
            {
                n = n.Next;
                length++;
            }

            if (index < 0)
            {
                index = length + index;
            }

            if (index < 0 || index > length)
            {
                throw new ArgumentOutOfRangeException("Index out of bounds!");
            }

            n = this.Head;
            Node prev = null;

            for (int i = 0; i < index; i++)
            {
                prev = n;
                n = n.Next;
            }
                                
            if (n != null)
            {
                //removing head node if prev is null
                if (prev == null)
                {
                    this.Head = n.Next;

                    //if list becomes is empty
                    if (this.Head == null)
                    {
                        this.Tail = null;
                    }
                }
                else
                {                    
                    prev.Next = n.Next;
                    if (n.Next == null)
                    {
                        this.Tail = prev;
                    }
                }

                n = null;           //null reference of removed node
                
            }
            else
            {
                throw new InvalidOperationException("Node at the specified index is null.");
            }
      
        }
               
        public User GetValue(int index)
        {
            //try/catch exception handling

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
                    throw new ArgumentOutOfRangeException("Index out of bounds!");
                    
                    //return "Index out of bounds!";                                       
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
                throw new InvalidOperationException("Empty list!");
            }
        }

        public int IndexOf(User value) 
        {

            if (this.Head == null || value == null)
            {
                throw new InvalidOperationException("Empty list!");
            }

            Node n = this._head;
            int index = 0;
                                        
            while (n != null)
            {                                               
                if (n.Data == value)
                {
                    return index;
                }

                n = n.Next;
                index++;
            }

            throw new FileNotFoundException("User object not found in list");
                                 
        }


        public bool Contains(User value) 
        {
            if (this.Head == null)
            {
                throw new InvalidOperationException("Empty list!");
            }           

            Node n = this._head;            
            int k = 0;

            while (n != null)
            {
                if (n.Data == value)
                {
                    //k = 1;
                    return true;
                }
                n = n.Next;                
            }

            return false;                  
        }



        public void Traverse()
        {
            if (this._head != null)
            {
                Node n = _head;                 

                do
                {
                    Console.WriteLine($"--> {n.Data.ToString()}");
                    n = n.Next;                          //updating reference to the next (move to the next)
                }
                while (n != null);
            }
            else
            {
                Console.WriteLine("\nEmpty List!");
            }
        }

        public int GetSizeOfSLL()
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

        public void Sort()
        {
            if (this.Head == null)
            {
                throw new InvalidOperationException("Empty list!");
            }

            Node n;
            User temp;
            bool swapped;

            do
            {
                swapped = false;
                n = this._head;

                while (n != null && n.Next != null)
                {
                    if (n.Data.Name[0] > n.Next.Data.Name[0])
                    {
                        temp = n.Data;
                        n.Data = n.Next.Data;
                        n.Next.Data = temp;

                        swapped = true;
                    }
                    n = n.Next;
                }
            }
            while (swapped);
        }


        /*
        //using bubble sort (int)
        public void Sort()
        {
            if (this.Head == null)
            {
                throw new InvalidOperationException("Empty list!");
            }

            Node n;
            int temp;
            bool swapped;

            do
            {
                swapped = false;
                n = this._head;

                while (n != null && n.Next != null)
                {
                    if (n.Data.Id > n.Next.Data.Id)
                    {
                        temp = n.Data.Id;
                        n.Data.Id = n.Next.Data.Id;
                        n.Next.Data.Id = temp;

                        swapped = true;
                    }
                    n = n.Next;
                }
            }
            while (swapped);                
        }
        */

    }
}
