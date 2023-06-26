using System.Collections.Generic;
using static DS_LinkedLists.LinkedList;

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


            /*Console.WriteLine("LinkedList before popLast operation:");
            LList.PrintList();

            LList.PopLast();

            Console.WriteLine("LinkedList after popLast operation:");
            LList.PrintList();*/

            Console.WriteLine("Searching for Node with value 30:");
            Node foundNode = LList.Search(30);
            if (foundNode != null)
            {
                Console.WriteLine("Node found with value: " + foundNode.Data);
            }
            else
            {
                Console.WriteLine("Node not found!");
            }



        }
    }
}