using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Node
    {
        //creates nodes for the circular nexted list
        public int rollNumber;
        public string name;
        public Node next;
    }
    class CuircularList
    {
        Node LAST;

        public CircularList()
        {
            LAST = null;
        }
        public bool Search(int rollNo, ref Node previous, ref Node current)
        {
            for (previous = current = LAST.next; current != LAST; previous = current, current = current.next)
            {
                if (rollNo == LAST.rollNumber)/*if the node is present at the end*/
                    return true;
            }
            if (rollNo == LAST.rollNumber)
                return true;
            else
                return false;
        }
        public bool ListEmpty()
        {
            if (LAST == null)
                return true;
            else
                return false;
        }
        public void traverse()
        {
            if (ListEmpty())
            {

                Console.WriteLine("\nList is Empty");
            }
            else
            {
                Console.WriteLine("\nRecords in the list are:");
                Node currentNode;
                currentNode = LAST.next;
                while (currentNode != LAST)
                {
                    Console.Write(currentNode.rollNumber + " " + currentNode.name + "\n");
                    currentNode = currentNode.next;
                }
                Console.Write(LAST.rollNumber + " " + LAST.name + "\n");
            }
        }
        public void firstNode()
        {
            if (ListEmpty())
                Console.WriteLine("\nList is empty");
            else
                Console.WriteLine("\nThe first record in the list is : \n\n" + LAST.next.rollNumber + "   " + LAST.next.name);
        }
        static void Main(string[] args)
        {
            CircularList obj = new CircularList();
            while (true)
            {
                try
                {
                    Console.WriteLine("\n Menu");
                    Console.WriteLine("\n 1. View all the records in the list");
                    Console.WriteLine("\n 2. Search for a record in the list");
                    Console.WriteLine("\n 3. Display the first record in the list");
                    Console.WriteLine("\n 4. Exit\n");
                    Console.WriteLine("\n Enter your choice (1-4): ");
                    char ch = Convert.ToChar(Console.ReadLine());
                    switch (ch)
                    {
                        case '1':
                            {
                                obj.traverse();
                            }
                            break;
                        case '2':
                            {
                                if (obj.listEmpty())
                                {
                                    Console.WriteLine("\nList is Empty");
                                    break;
                                }
                                Node prev, curr;
                                prev = curr = null;
                                Console.WriteLine("\n Enter the roll number of the student whose record is to be searched: ");
                                int num = Convert.ToInt32(Console.ReadLine());
                                if (obj.Search(num, ref prev, ref curr) == false)
                                    Console.WriteLine("\n Record not found");
                                else
                                {
                                    Console.WriteLine("\n Record found");
                                    Console.WriteLine("\n Roll number:" + curr.rollNumber);
                                    Console.WriteLine("\nName: " + curr.name);
                                }
                            }
                            break;
                        case '3':
                            {
                                obj.firstNode();
                            }
                            break;
                        case '4':
                            {
                                return;
                            }
                }
            }
        }
    }
}
