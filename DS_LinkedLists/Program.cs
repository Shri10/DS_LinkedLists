using System.Collections.Generic;

namespace DS_LinkedLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, here We'll be working on LinkedList!");

            LinkedList LList = new LinkedList();

            /*LList.AddNode(56);
            LList.AddNode(30);
            LList.AddNode(70);

            LList.AddToStart(70);
            LList.AddToStart(30);
            LList.AddToStart(56);*/

            LList.AddNode(56);
            LList.InsertAtPosition(1 , 70);
            LList.InsertAtPosition(1 , 30);

            Console.WriteLine("LinkedList before pop operation:");
            LList.PrintList();

            LList.Pop();

            Console.WriteLine("LinkedList after pop operation:");
            LList.PrintList();

        }
    }
}