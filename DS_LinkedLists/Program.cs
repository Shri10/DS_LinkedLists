using System.Collections.Generic;
using static DS_LinkedLists.LinkedList;

namespace DS_LinkedLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, here We'll be working on LinkedList!");

            /*            LinkedList LList = new LinkedList();
            //            int size = LList.Size();

                        LList.AddNode(56);
                        LList.AddNode(30);
                        LList.AddNode(70);

                        Console.WriteLine("Inserting 40 after 30");
                        LList.InsertAfter(30, 40);
                        Console.WriteLine("List As of Now:");
                        LList.PrintList();
                        Console.WriteLine($"Size of LinkedList: {LList.Size()}");

                        Console.WriteLine();
                        Console.WriteLine("Deleting 40");
                        LList.DeleteWithValue(40);
                        LList.PrintList();

                        Console.WriteLine($"Size of LinkedList: {LList.Size()}");
            */

            SortedLinkedList sortedLList = new SortedLinkedList();
            sortedLList.AddNode(56);
            sortedLList.AddNode(30);
            sortedLList.AddNode(40);
            sortedLList.AddNode(70);

            Console.WriteLine("Printing Sorted Linked List");
            sortedLList.PrintList();


        }
    }
}