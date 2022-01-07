using System;

namespace W4_Ex2
{
    class MyDoublyLinkedList
    {
        private string name;
        public MyDoublyLinkedList next;
        public MyDoublyLinkedList prev;
        private MyDoublyLinkedList head;

        /// <summary>
        /// Creates a default constructor for MyDoublyLinkedList with a value of 0
        /// </summary>
        public MyDoublyLinkedList()
        {
            name = "";
            next = null;
            prev = null;
        }
        
        /// <summary>
        /// Creates a constructor for MyDoublyLinkedList with an inputted string value
        /// </summary>
        /// <param name="value"> String value used for the created node </param>
        public MyDoublyLinkedList(string value)
        {
            name = value;
            next = null;
            prev = null;
        }
         /// <summary>
         /// Assigns the head pointer to the first node in the list
         /// </summary>
        public void AssignHead() { head = this; }

        /// <summary>
        /// Inserts a new node with the inputted value after the current node
        /// </summary>
        /// <param name="current"> MyDoublyLinkedList that the new node will be inserted after </param>
        /// <param name="value"> String value that the new node will be assigned </param>
        public void InsertNextNode(MyDoublyLinkedList current, string value)
        {
            MyDoublyLinkedList node = new MyDoublyLinkedList(value);
            if (current.next == null)  { current.next = node; node.prev = current; }
            else { node.next = current.next; current.next = node; }
        }

        /// <summary>
        /// Inserts a new node with the inputted value before the current node
        /// </summary>
        /// <param name="current"> MyDoublyLinkedList that the new node will be inserted before </param>
        /// <param name="value"> String value that the new node will be assigned </param>
        public void InsertPrevtNode(MyDoublyLinkedList current, string value)
        {
            MyDoublyLinkedList node = new MyDoublyLinkedList(value);
            if (current.prev == null) { node.next = current; current.prev = node; head = node; }
            else { node.prev = current.prev; node.next = current; }
        }

        /// <summary>
        /// Deletes the node inputted to the method
        /// </summary>
        /// <param name="node"> MyDoublyLinkedList node that is to be deleted</param>
        public void DeleteNode(MyDoublyLinkedList node)
        {
            if (node.next != null) { node.next.prev = node.prev; }
            if (node.prev != null) { node.prev.next = node.next; }
            node = null;
        }

        /// <summary>
        /// Traverses through the list forward, printing the name for each node as it goes along
        /// </summary>
        /// <param name="node"> MyDoublyLinkedList node that the traversing will start from </param>
        public void TraverseForward(MyDoublyLinkedList node)
        {
            Console.WriteLine("Traversing in forward direction...");
            while (node != null) { Console.WriteLine(node.name); node = node.next; }
        }
        
        /// <summary>
        /// Traverses through the list backwards, printing the name for each node as it goes along
        /// </summary>
        /// <param name="node"> MyDoublyLinkedList node that the traversing will start from </param>
        public void TraverseBackward(MyDoublyLinkedList node)
        {
            Console.WriteLine("Traversing in backward direction...");
            string names = "";
            while (node != null) {  names = node.name + "\n" + names; node = node.next; }
            Console.WriteLine(names);
        }
        /// <summary>
        /// Goes through the list and stops once it finds the name that it wants
        /// </summary>
        /// <param name="node"> MyDoublyLinkedList node that the searching will start from </param>
        /// <param name="wantedname"> String name that the method is wanting to find in the list </param>
        /// <returns> MyDoublyLinkedList name that the method is trying to find </returns>
        public MyDoublyLinkedList FindNode(MyDoublyLinkedList node, string wantedname)
        {
            while (wantedname != node.name) { node = node.next; }
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
            //Create the first node
            MyDoublyLinkedList node = new MyDoublyLinkedList("Ardhendu");
            //Assign head
            node.AssignHead();
            //Add 9 more consecutive nodes (Tom, Jones, David, Andrew, Peter, Mark, Collette, Dave, Dan)
            MyDoublyLinkedList temp = node;
            string[] names = new string[9] { "Tom", "Jones", "David", "Andrew", "Peter", "Mark", "Collette", "Dave", "Dan" };
            for (int i = 0; i <= 8; i++)
            {
                temp.InsertNextNode(temp, names[i]);
                temp = temp.next;
            }
            node.TraverseForward(node);
            // Deletes Peter from the list then traverses forwards
            MyDoublyLinkedList peter = node.FindNode(node, "Peter");
            node.DeleteNode(peter);
            node.TraverseForward(node);

            // Add Peter back after Mark
            MyDoublyLinkedList mark = node.FindNode(node, "Mark");
            node.InsertNextNode(mark, "Peter");
            node.TraverseBackward(node);
        }
    }
}
