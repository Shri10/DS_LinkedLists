using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DS_LinkedLists.LinkedList;

namespace DS_LinkedLists
{
    public class SortedLinkedList
    {
        public Node Head;

        public SortedLinkedList()
        {
            Head = null;
        }

        public void AddNode(int data)
        {
            Node newNode = new Node(data);

            if (Head == null || Head.Data >= newNode.Data)
            {
                newNode.Next = Head;
                Head = newNode;
            }
            else
            {
                Node currentNode = Head;
                while (currentNode.Next != null && currentNode.Next.Data < newNode.Data)
                {
                    currentNode = currentNode.Next;
                }
                newNode.Next = currentNode.Next;
                currentNode.Next = newNode;
            }
        }

        public void PrintList()
        {
            Node currentNode = Head;

            while (currentNode != null)
            {
                Console.Write(currentNode.Data + " ");
                currentNode = currentNode.Next;
            }

            Console.WriteLine();
        }
    }
}
