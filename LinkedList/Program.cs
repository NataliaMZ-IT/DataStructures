// Messing with Dynamic Lists
using LinkedList;

Contact TypeContact()
{
    Contact contact = new Contact();
    Console.Write("Insert name of contact: ");
    contact.Name = Console.ReadLine()!;
    Console.Write("Insert telephone number of contact: ");
    contact.Telephone = Console.ReadLine()!;
    return contact;
}

ContactList contactBook = new ContactList();

int op;
Contact contact;
do
{
    Console.WriteLine("\n----------------------------------");
    Console.WriteLine("Choose an option:" +
        "\n1 - Add Contact\n2 - Remove Contact" +
        "\n3 - Show Number of Contacts" +
        "\n4 - Show All Contacts\n0 - Exit");
    Console.WriteLine("----------------------------------");
    op = int.Parse(Console.ReadLine()!);

    switch (op)
    {
        case 0:
            Console.WriteLine("\nExiting program...");
            break;
        case 1:
            contact = TypeContact();
            contactBook.InsertContact(contact);
            break;
        case 2:
            contact = TypeContact();
            contactBook.RemoveContact(contact);
            break;
        case 3:
            Console.WriteLine("\nThere are " + contactBook.Size() + " contacts in your contact book.");
            break;
        case 4:
            Console.WriteLine("\nYour Contacts:");
            contactBook.ShowList();
            break;
        default:
            Console.WriteLine("\nInvalid option!");
            break;
    }
} while (op != 0);