using System;
using System.Collections.Generic;

namespace DS_LinkedLists
{
    public class LinkedList
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
        public Node Search(int value)
        {
            Node currentNode = Head;

            while (currentNode != null)
            {
                if (currentNode.Data == value)
                {
                    return currentNode;
                }
                currentNode = currentNode.Next;
            }

            return null;
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

        public void InsertAtPosition(int position, int data)
        {
            Node newNode = new Node(data);

            if (Head == null || position == 0)
            {
                AddToStart(data);
            }
            else
            {
                Node currentNode = Head;
                for (int i = 0; i < position - 1; i++)
                {
                    if (currentNode.Next != null)
                    {
                        currentNode = currentNode.Next;
                    }
                    else
                    {
                        throw new IndexOutOfRangeException("Position is greater than the length of LinkedList");
                    }
                }

                newNode.Next = currentNode.Next;
                currentNode.Next = newNode;
            }
        }

        public void InsertAfter(int existingNodeData, int newNodeData)
        {
            Node newNode = new Node(newNodeData);
            Node existingNode = Search(existingNodeData);

            if (existingNode == null)
            {
                Console.WriteLine($"Element {existingNodeData} is not present in the Linked List");
                return;
            }

            newNode.Next = existingNode.Next;
            existingNode.Next = newNode;
        }

        public void Pop()
        {
            if (Head == null)
            {
                throw new InvalidOperationException("Empty LinkedList");
            }

            Head = Head.Next;
        }

        public void PopLast()
        {
            if (Head == null)
            {
                throw new InvalidOperationException("Empty LinkedList");
            }

            if (Head.Next == null)
            {
                Head = null;
            }
            else
            {
                Node currentNode = Head;
                while (currentNode.Next.Next != null)
                {
                    currentNode = currentNode.Next;
                }

                currentNode.Next = null;
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

        public void DeleteWithValue(int value)
        {
            Node temp = Head, prev = null;

            if (temp != null && temp.Data == value)
            {
                Head = temp.Next;
                return;
            }

            while (temp != null && temp.Data != value)
            {
                prev = temp;
                temp = temp.Next;
            }

            if (temp == null)
            {
                Console.WriteLine($"Element {value} is not present in the Linked List");
                return;
            }

            prev.Next = temp.Next;
        }

        public int Size()
        {
            Node temp = Head;
            int size = 0;

            while (temp != null)
            {
                size++;
                temp = temp.Next;
            }

            return size;
        }

    }
}
