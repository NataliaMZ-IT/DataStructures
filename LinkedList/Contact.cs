using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class Contact
    {
        public string Name { get; set; }
        public string Telephone { get; set; }
        public Contact Next { get; set; }

        public Contact() 
        {
            this.Next = null;
        }
    }
}
