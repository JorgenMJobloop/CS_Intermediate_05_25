namespace CS_Intermediate;

class Program
{
    static void Main(string[] args)
    {
        CustomStack<int> intStack = new CustomStack<int>();

        CustomLinkedList<string> customLinkedList = new CustomLinkedList<string>();

        intStack.Push(1);
        intStack.Push(2);
        intStack.Push(3);

        intStack.Pop();

        Console.WriteLine(intStack.CountItems);

        Console.WriteLine(intStack.IsEmpty);

        Console.WriteLine(intStack.Peek());



        customLinkedList.AddFist("Hello");
        customLinkedList.AddFist("Hello");
        customLinkedList.AddFist("Hello");
        customLinkedList.AddLast("World");


        Console.WriteLine(customLinkedList.Count);

        Console.WriteLine(customLinkedList.Remove("Hello"));

        Console.WriteLine(customLinkedList.Count);

        customLinkedList.Clear();
    }
}
