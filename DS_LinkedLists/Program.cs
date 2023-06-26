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

            Console.WriteLine("LinkedList before popLast operation:");
            LList.PrintList();

            LList.PopLast();

            Console.WriteLine("LinkedList after popLast operation:");
            LList.PrintList();

        }
    }
}