using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queues
{
    public class PeopleQueue
    {
        // Creates/initializes the queue
        void CreateQueue()
        {
            Person head = null;
            Person tail = head;
        }

        // Verifies if the queue is empty
        bool EmptyQueue(Person head)
        {
            if (head == null)
                return true;
            else
                return false;
        }

        // Inserts a new person into the queue
        void InsertPerson(Person p, Person h, Person t)
        {
            if (EmptyQueue(h))
            {
                h = p;
                t = p;
            }
            else
            {
                t.Next = p;
                t = p;
            }
        }

        // Removes the next person from the queue
        void RemovePerson(Person h, Person t)
        {
            if (EmptyQueue(h))
            {
                Console.WriteLine("The queue is empty!");
            }
            else
            {
                h = h.Next;
                if (h == null)
                {
                    t = null;
                }
            }
        }

        // Counts quantity of people in the queue
        int QueueSize(Person h)
        {
            if (EmptyQueue(h))
            {
                return 0;
            }
            else
            {
                Person aux = h;
                int size = 1;
                while (aux.Next != null)
                {
                    size++;
                    aux = aux.Next;
                }
                return size;
            }
        }


        void ShowQueue(Person h)
        {
            if (EmptyQueue(h))
            {
                Console.WriteLine("There is no one in the queue!");
            }
            else
            {
                Person aux = h;
                while (aux != null)
                {
                    Console.WriteLine(aux.Name);
                    aux = aux.Next;
                }
            }
        }
    }
}
