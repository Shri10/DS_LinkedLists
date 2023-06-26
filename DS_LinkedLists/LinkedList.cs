using System;

namespace DS_LinkedLists
{
    internal class LinkedList
    {
        public class Node
        {
            public int Data;
            public Node Next;

            public Node(int data)
            {
                Data = data;
                Next = null;
            }
        }

        public Node Head;

        public LinkedList()
        {
            Head = null;
        }

        public void AddNode(int data)
        {
            Node newNode = new Node(data);

            if (Head == null)
            {
                Head = newNode;
            }
            else
            {
                Node currentNode = Head;
                while (currentNode.Next != null)
                {
                    currentNode = currentNode.Next;
                }

                currentNode.Next = newNode;
            }
        }

        public void AddToStart(int data)
        {
            Node newNode = new Node(data);
            newNode.Next = Head;
            Head = newNode;
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
