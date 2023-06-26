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

            LList.AddNode(56);
            LList.AddNode(30);
            LList.AddNode(70);

            Console.WriteLine("Inserting 40 after 30");
            LList.InsertAfter(30, 40);
            LList.PrintList();

        }
    }
}