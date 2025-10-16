// Messing with Stacks
using Stack;

Clothing AddClothing()
{
    Clothing aux = new Clothing();
    Console.WriteLine("Insert the type of clothing (example: shirt, skirt, dress)");
    aux.Type = Console.ReadLine()!;
    Console.WriteLine("Insert the color of the clothing");
    aux.Color = Console.ReadLine()!;

    return aux;
}

ClothingStack clothingStack = new ClothingStack();

int op;
Clothing clothing;
do
{
    Console.WriteLine("\n-----------------------------");
    Console.WriteLine("Choose an option:\n1 - Add Clothing\n2 - Take Clothing\n3 - Show Clothes Pile\n0 - Exit");
    Console.WriteLine("-----------------------------");
    op = int.Parse(Console.ReadLine()!);
    Console.WriteLine();

    switch (op)
    {
        case 0:
            Console.WriteLine("Exiting program...");
            break;
        case 1:
            clothing = AddClothing();
            clothingStack.PushStack(clothing);
            Console.WriteLine("\nClothes have been added to the pile.");
            break;
        case 2:
            clothingStack.PopStack();
            break;
        case 3:
            clothingStack.ShowStack();
            break;
        default:
            Console.WriteLine("Invalid option!");
            break;
    }
} while (op != 0);