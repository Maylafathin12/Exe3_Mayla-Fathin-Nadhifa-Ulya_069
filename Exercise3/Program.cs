using System;

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
    }
}
