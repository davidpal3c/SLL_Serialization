using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.Utility
{
    public class Node
    {
        private User _data;                                                 
        private Node _next;

        public User Data 
        {
            get { return _data; } 
            set { _data = value; }        
        }

        public Node Next
        {
            get { return _next; }
            set { _next = value; }  
        }

        public Node(User data)
        {
            _data = data;
            _next = null; 
        }


    }
}
