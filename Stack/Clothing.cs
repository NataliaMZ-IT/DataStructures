using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class Clothing
    {
        public string Type { get; set; }
        public string Color { get; set; }
        public Clothing Next { get; set; }

        public Clothing()
        {
            Next = null;
        }

        public override string ToString()
        {
            return $"{Color} {Type}";
        }
    }
}
