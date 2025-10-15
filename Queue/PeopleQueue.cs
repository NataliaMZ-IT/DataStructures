using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    public class PeopleQueue
    {
        public Person Head;
        public Person Tail;

        // Creates/initializes the queue
        public void CreateQueue()
        {
            Person Head = null;
            Person Tail = Head;
        }

        // Verifies if the queue is empty
        public bool EmptyQueue()
        {
            if (Head == null)
                return true;
            else
                return false;
        }

        // Inserts a new person into the queue
        public void InsertPerson(Person p)
        {
            if (EmptyQueue())
            {
                Head = p;
                Tail = p;
            }
            else
            {
                Tail.Next = p;
                Tail = p;
            }
        }

        // Removes the next person from the queue
        public void RemovePerson()
        {
            if (EmptyQueue())
            {
                Console.WriteLine("The queue is empty!");
            }
            else
            {
                Head = Head.Next;
                if (Head == null)
                {
                    Tail = null;
                }
            }
        }

        // Counts quantity of people in the queue
        public int QueueSize()
        {
            if (EmptyQueue())
            {
                return 0;
            }
            else
            {
                Person aux = Head;
                int size = 1;
                while (aux.Next != null)
                {
                    size++;
                    aux = aux.Next;
                }
                return size;
            }
        }


        public void ShowQueue()
        {
            if (EmptyQueue())
            {
                Console.WriteLine("There is no one in the queue!");
            }
            else
            {
                Person aux = Head;
                while (aux != null)
                {
                    Console.WriteLine(aux.Name);
                    aux = aux.Next;
                }
            }
        }
    }
}
