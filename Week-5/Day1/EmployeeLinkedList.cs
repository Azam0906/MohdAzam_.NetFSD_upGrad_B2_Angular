using System;

namespace ArraysDemo
{
    internal class EmployeeLinkedList
    {
        class Node
        {
            public int id;
            public string name;
            public Node next;

            public Node(int id, string name)
            {
                this.id = id;
                this.name = name;
                this.next = null;
            }
        }

        Node head;

        public void InsertAtEnd(int id, string name)
        {
            Node newNode = new Node(id, name);

            if (head == null)
            {
                head = newNode;
                return;
            }

            Node temp = head;
            while (temp.next != null)
            {
                temp = temp.next;
            }

            temp.next = newNode;
        }

        public void Delete(int id)
        {
            if (head == null)
                return;

            if (head.id == id)
            {
                head = head.next;
                return;
            }

            Node temp = head;
            while (temp.next != null && temp.next.id != id)
            {
                temp = temp.next;
            }

            if (temp.next != null)
            {
                temp.next = temp.next.next;
            }
        }

        public void Display()
        {
            Node temp = head;
            while (temp != null)
            {
                Console.WriteLine(temp.id + " - " + temp.name);
                temp = temp.next;
            }
        }

        static void Main(string[] args)
        {
            EmployeeLinkedList list = new EmployeeLinkedList();

            list.InsertAtEnd(101, "John");
            list.InsertAtEnd(102, "Sara");
            list.InsertAtEnd(103, "Mike");
            list.Delete(102);
            Console.WriteLine("Employee List After Deletion:");
            list.Display();
        }
    }
}