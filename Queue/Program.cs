// Messing with Queues
using Queue;

PeopleQueue pQueue = new PeopleQueue();
pQueue.CreateQueue();

int op;
Person person;
do
{
    Console.WriteLine("\n-------------------------");
    Console.WriteLine("Choose an option:\n1 - Insert Person\n2 - Remove Person\n3 - View Queue Size\n4 - View Queue\n5 - Exit");
    Console.WriteLine("-------------------------");
    op = int.Parse(Console.ReadLine()!);

    switch (op)
    {
        case 1:
            person = new Person();
            Console.Write("\nInsert name of the person: ");
            person.Name = Console.ReadLine()!;
            pQueue.InsertPerson(person);
            break;
        case 2:
            pQueue.RemovePerson();
            break;
        case 3:
            Console.WriteLine("\nQueue size: " + pQueue.QueueSize());
            break;
        case 4:
            Console.WriteLine();
            pQueue.ShowQueue();
            break;
        case 5:
            Console.WriteLine("\nExiting program...");
            break;
        default:
            Console.WriteLine("\nInvalid option!");
            break;
    }

} while (op != 5);