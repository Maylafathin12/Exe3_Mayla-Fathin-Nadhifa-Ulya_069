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

    }
}
