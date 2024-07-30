using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.Utility
{
    [DataContract]
    public class Node
    {
        [DataMember]
        private User _data;

        [DataMember]
        private Node _next;

        [DataMember]
        public User Data 
        {
            get { return _data; } 
            set { _data = value; }        
        }

        [DataMember]
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
