using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    public class Person
    {
        public string Name {  get; set; }
        public Person Next {  get; set; }


        public Person()
        {
            this.Next = null;
        }
    }
}
