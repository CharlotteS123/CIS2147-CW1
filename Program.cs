using System;

namespace W3_Ex1
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
            public string programmeTitle;
            public string programmeCode;
        }
        /// <summary>
        /// This populates the structure student_data with the information for each student.
        /// </summary>
        /// <param name="student"> allows data to be modified and used outside of the function. </param>
        /// <param name="fname"> String type which represents the student's first name. </param>
        /// <param name="surname"> String type which represents the student's last name. </param>
        /// <param name="id_number"> Integer type which represents the student's ID number. </param>
        /// <param name="programmeTitle"> String type which represent's the student's programme title. </param>
        /// <param name="programmeCode"> String type which represent's the student's programme code. </param>
        static void populateStruct(out student_data student, string fname, string surname, int id_number, string programmeTitle, string programmeCode)
        {
            student.forename = fname;
            student.surname = surname;
            student.id_number = id_number;
            student.averageGrade = 0.0F;
            student.programmeTitle = programmeTitle;
            student.programmeCode = programmeCode;
        }
        /// <summary>
        /// This takes the data for the student and calls a function to print it.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            student_data student1;
            populateStruct(out student1, "Charlotte", "Street", 1, "Programming Languages", "CIS2147");
            printStudent(student1);
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
            Console.WriteLine("Programme Title: " + student.programmeTitle);
            Console.WriteLine("Programme Code: " + student.programmeCode);
        }
    }
}
