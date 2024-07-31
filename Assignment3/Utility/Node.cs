using System;
using System.Collections.Generic;
using System.Linq;
<<<<<<< HEAD
using System.Runtime.Serialization;
=======
>>>>>>> d0f6483ff801db6d9c35d4dbff82b9f132938570
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.Utility
{
<<<<<<< HEAD
    [DataContract]
    public class Node
    {
        [DataMember]
        private User _data;

        [DataMember]
        private Node _next;

        [DataMember]
=======
    public class Node
    {
        private User _data;                                                 
        private Node _next;

>>>>>>> d0f6483ff801db6d9c35d4dbff82b9f132938570
        public User Data 
        {
            get { return _data; } 
            set { _data = value; }        
        }

<<<<<<< HEAD
        [DataMember]
=======
>>>>>>> d0f6483ff801db6d9c35d4dbff82b9f132938570
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
