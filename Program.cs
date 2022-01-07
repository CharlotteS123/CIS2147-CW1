using System;

namespace W4_Ex3
{
    class MySinglyLinkedList
    {
        public student_data student;
        public MySinglyLinkedList next;
        public MySinglyLinkedList head;

        /// <summary>
        /// Creates a constructor for MySinglyLinkedList with an inputted student data value
        /// </summary>
        /// <param name="value"> Integer which is used for the value of the constructor </param>
        public MySinglyLinkedList(student_data students) { student = students; next = null; }

        /// <summary>
        /// Assigns the head pointer to the first node in the list
        /// </summary>
        public void AssignHead() { head = this; }

        /// <summary>
        /// Inserts a new node with the inputted student data value after the current node
        /// </summary>
        /// <param name="current" > MySinglyLinkedList value that will be before the new node </param> 
        /// <param name="value"> Integer that will be the value of the new node </param> 
        public void InsertNode(MySinglyLinkedList current, student_data students)
        {
            MySinglyLinkedList node = new MySinglyLinkedList(students);
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
            { printStudent(node.student); node = node.next; }
        }
        /// <summary>
        /// Goes through the list and stops once one before the value that it wants
        /// </summary>
        /// <param name="node"> MySinglyLinkedList node that the searching will start from </param>
        /// <param name="wantedvalue"> String value that the method is wanting to find in the list </param>
        /// <returns> MySinglyLinkedList value that the method is trying to find </returns>
        public MySinglyLinkedList FindPrevNode(MySinglyLinkedList node, string wantedvalue)
        {
            while (wantedvalue != node.next.student.forename && node != null) { node = node.next; }
            return node;
        }

        /// <summary>
        /// Goes through the list and stops once one before the value that it wants
        /// </summary>
        /// <param name="node"> MySinglyLinkedList node that the searching will start from </param>
        /// <param name="wantedvalue"> String value that the method is wanting to find in the list </param>
        /// <returns> MySinglyLinkedList value that the method is trying to find </returns>
        public MySinglyLinkedList FindNode(MySinglyLinkedList node, string wantedvalue)
        {
            while (wantedvalue != node.student.forename && node != null) { node = node.next; }
            return node;
        }
        /// <summary>
        /// This creates a structure for student_data which defines the data held for each student.
        /// </summary>
        public struct student_data
        {
            public string forename;
            public string surname;
            public int id_number;
            public float averageGrade;
        }
        /// <summary>
        /// This populates the structure student_data with the information for each student.
        /// </summary>
        /// <param name="student"> allows data to be modified and used outside of the function. </param>
        /// <param name="fname"> String type which represents the student's first name. </param>
        /// <param name="surname"> String type which represents the student's last name. </param>
        /// <param name="id_number"> Integer type which represents the student's ID number. </param>
        static void populateStruct(out student_data student, string fname, string surname, int id_number)
        {
            student.forename = fname;
            student.surname = surname;
            student.id_number = id_number;
            student.averageGrade = 0.0F;
        }
        /// <summary>
        /// This prints the student's data. 
        /// </summary>
        /// <param name="student"> This is the student data that needs to be printed. </param>
        static void printStudent(student_data student)
        {
            Console.WriteLine("Name: " + student.forename + " " + student.surname);
            Console.WriteLine("Id: " + student.id_number);
            Console.WriteLine("Av grade: " + student.averageGrade);

        }
        /// <summary>
        /// This sets up student's data, adds it to the singly linked list, then deletes a node from that list.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Set up students
            student_data student1, student2, student3;
            populateStruct(out student1, "Charlotte", "Street", 1);
            populateStruct(out student2, "Abigail", "Stone", 23);
            populateStruct(out student3, "Tom", "Jones", 51);

            // Insert students to list
            MySinglyLinkedList head = new MySinglyLinkedList(student1);
            MySinglyLinkedList temp = head;
            temp.InsertNode(temp, student2);
            temp = temp.next;
            temp.InsertNode(temp, student3);
            head.TraverseList(head);
            
            // Remove Tom
            MySinglyLinkedList tom = head.FindPrevNode(head, "Tom");
            head.DeleteNextNode(tom);
            head.TraverseList(head);
        }
    }
}