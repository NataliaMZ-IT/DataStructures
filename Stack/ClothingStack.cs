using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class ClothingStack
    {
        public Clothing Top { get; set; }

        public ClothingStack()
        {
            Top = null;
        }

        public bool EmptyStack()
        {
            if (Top == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void PushStack(Clothing clothing) 
        {
            if (!EmptyStack())
            {
                clothing.Next = Top;
            }
            Top = clothing;
        }

        public void PopStack()
        {
            if (EmptyStack())
            {
                Console.WriteLine("There are no clothes in the pile to take from!");
            }
            else
            {
                Console.WriteLine($"{Top.ToString()} has been taken from the pile.");
                Top = Top.Next;
            }
        }

        public void ShowStack()
        {
            if (EmptyStack())
            {
                Console.WriteLine("There are no clothes in the pile currently.");
            }
            else
            {
                Clothing aux = Top;
                Console.WriteLine("Top\n|");
                while (aux != null)
                {
                    Console.WriteLine($"| {aux.ToString()}");
                    aux = aux.Next;

                }
                Console.WriteLine("|\nBottom");
            }
        }
    }
}
