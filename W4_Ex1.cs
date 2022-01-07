using System;

namespace W4_Ex1
{
    class MySinglyLinkedList
    {
        public int val;
        public MySinglyLinkedList next;
        public MySinglyLinkedList head;

        /// <summary>
        /// Creates a default contructor for MySinglyLinkedList with the value of 0
        /// </summary>
        public MySinglyLinkedList() { val = 0; next = null; }

        /// <summary>
        /// Creates a constructor for MySinglyLinkedList with an inputted value
        /// </summary>
        /// <param name="value"> Integer which is used for the value of the constructor </param>
        public MySinglyLinkedList(int value) { val = value; next = null; }

        /// <summary>
        /// Assigns the head pointer to the first node in the list
        /// </summary>
        public void AssignHead() { head = this; }

        /// <summary>
        /// Inserts a new node with the inputted integer value after the current node
        /// </summary>
        /// <param name="current" > MySinglyLinkedList value that will be before the new node </param> 
        /// <param name="value"> Integer that will be the value of the new node </param> 
        public void InsertNode(MySinglyLinkedList current, int value)
        {
            MySinglyLinkedList node = new MySinglyLinkedList(value);
            if (current.next == null) { current.next = node; }
            else { node.next = current.next; current.next = node; }
        }

        /// <summary>
        /// Deletes the next node from the list. It will also do nothing if it is the last value in the list
        /// </summary>
        /// <param name="current"> MySinglyLinkedList node that is before the intended node to be deleted </param>
        public void DeleteNextNode(MySinglyLinkedList current)
        {
            if (current.next == null) { return; }
            else { current.next = current.next.next; }
        }

        /// <summary>
        /// Goes through the list and prints off all of the values in the list
        /// </summary>
        /// <param name="node"> MySinglyLinkedList node that the traversing starts from </param>
        public void TraverseList(MySinglyLinkedList node)
        {
            //Print the values stored at the each node in the list from head to tail
            Console.WriteLine("Traversing in forward direction...");
            while (node != null)//Traverse from the current node
            { Console.WriteLine(node.val); node = node.next; }
        }

        /// <summary>
        /// Goes through the list and stops once it finds the value that it wants
        /// </summary>
        /// <param name="node"> MySinglyLinkedList node that the searching will start from </param>
        /// <param name="wantedvalue"> Integer value that the method is wanting to find in the list </param>
        /// <returns> MySinglyLinkedList value that the method is trying to find </returns>
        public MySinglyLinkedList FindNode(MySinglyLinkedList node, int wantedvalue)
        {
            while (wantedvalue != node.val && node != null) { node = node.next; }
            return node;
        }
    }
    class Program
    {
        /// <summary>
        /// Main method that contains the code that is to be executed
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            //Create the first node as head
            MySinglyLinkedList head = new MySinglyLinkedList(1);
            //Temporary node to build the list
            MySinglyLinkedList temp = head;
            //Add 9 more consecutive nodes 2-9
            for (int i = 2; i <= 10; i++) { temp.InsertNode(temp, i); temp = temp.next; }
            //Traverse the linked list from head to tail
            head.TraverseList(head);
            //Delete 3rd node and then traverse
            MySinglyLinkedList second = head.FindNode(head, 2);
            head.DeleteNextNode(second);
            head.TraverseList(head);
            //Insert 100 after the node value 7 and then traverse
            MySinglyLinkedList seven = head.FindNode(head, 7);
            head.InsertNode(seven, 100);
            head.TraverseList(head);
        }
    }
}
