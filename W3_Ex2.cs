using System;

namespace W3_Ex2
{
    class Program
    {
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
        /// This takes the data for all of the students and calls a function to print them.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            student_data[] students = new student_data[4];
            populateStruct(out students[0], "Mark", "Anderson", 1);
            populateStruct(out students[1], "Ardhendu", "Behera", 2);
            populateStruct(out students[2], "Tom", "Jones", 3);
            populateStruct(out students[3], "Ewan", "Evans", 4);
            printAllStudent(ref students);
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
        /// This takes the data for all of the students, and loops through them calling for the printStudent function for each one.
        /// </summary>
        /// <param name="students"> This is the data for all of the students. </param>
        static void printAllStudent(ref student_data[] students)
        {
            for (int i = 0; i < students.Length; i++) { printStudent(students[i]); }
        }
    }
}
