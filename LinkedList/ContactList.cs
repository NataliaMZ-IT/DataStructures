using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class ContactList
    {
        public Contact Head { get; set; }
        public Contact Tail { get; set; }
        public int Counter { get; set; }

        public ContactList()
        {
            this.Head = null;
            this.Tail = null;
        }

        public bool IsEmpty()
        {
            if (this.Head == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void InsertBeginning(Contact c)
        {
            if (IsEmpty())
            {
                this.Head = c;
                this.Tail = c;
            }
            else
            {
                c.Next = this.Head;
                this.Head = c;
            }
        }
        private void InsertMiddle(Contact c, Contact before, Contact after)
        {
            before.Next = c;
            c.Next = after; 
        }
        private void InsertEnd(Contact c)
        {
            this.Tail.Next = c;
            this.Tail = c;
        }

        public void InsertContact(Contact c)
        {
            if (IsEmpty())
            {
                InsertBeginning(c);
            }
            else
            {
                if (String.Compare(c.Name, this.Head.Name, StringComparison.OrdinalIgnoreCase) < 0)
                {
                    InsertBeginning(c);
                }
                else if (String.Compare(c.Name, this.Tail.Name, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    InsertEnd(c);
                }
                else
                {
                    Contact aux = this.Head.Next;
                    Contact before = Head;
                    while (String.Compare(c.Name, aux.Name, StringComparison.OrdinalIgnoreCase) > 0)
                    {
                        before = aux;
                        aux = aux.Next;
                    }
                    InsertMiddle(c, before, aux);
                }
            }
            Counter++;
        }

        private void RemoveBeginning()
        {
            this.Head = this.Head.Next;
            if (this.Head == null) 
            {
                this.Tail = null;
            }
        }
        private void RemoveMiddle(Contact before, Contact after)
        {
            before.Next = after.Next;
        }
        private void RemoveEnd(Contact before)
        {
            before.Next = null;
        }

        public void RemoveContact(Contact c)
        {
            if (IsEmpty())
            {
                Console.WriteLine("\nThere are no contacts to delete!");
                return;
            }
            else
            {
                if ((String.Compare(c.Name, this.Head.Name) == 0) && (String.Compare(c.Telephone, this.Head.Telephone) == 0))
                {
                    RemoveBeginning();
                    Counter--;
                    return;
                }
                Contact aux = this.Head.Next;
                Contact before = this.Head;
                while (aux != null)
                {
                    if ((String.Compare(c.Name, aux.Name) == 0) && (String.Compare(c.Telephone, aux.Telephone) == 0))
                    {
                        Counter--;
                        if (aux.Next == null)
                        {
                            RemoveEnd(before);
                            return;
                        }
                        else
                        {
                            RemoveMiddle(before, aux);
                            return;
                        }
                    }
                    before = aux;
                    aux = aux.Next;
                }
            }

            Console.WriteLine("\nContact not found! Verify spelling before trying again.");
        }

        public int Size()
        {
            return Counter;
        }

        public void ShowList()
        {
            if (IsEmpty()) 
            {
                Console.WriteLine("You have no contacts :(");
            }
            else
            {
                Contact aux = this.Head;
                while (aux != null)
                {
                    Console.WriteLine(aux.Name + " " + aux.Telephone);
                    aux = aux.Next;
                }

            }
        }
    }
}
