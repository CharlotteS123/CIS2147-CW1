using System;

namespace W3_Ex6
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
            public module_data module1;
            public module_data module2;
            public module_data module3;
            public module_data module4;
            public module_data module5;
            public module_data module6;
        }
        /// <summary>
        /// This populates the structure module_data with the information for each module.
        /// </summary>
        public struct module_data
        {
            public string code;
            public string title;
            public int mark;
        }
        /// <summary>
        /// This populates the structure student_data with the information for each student and calculates an average grade based off their module scores.
        /// </summary>
        /// <param name="student"> allows data to be modified and used outside of the function. </param>
        /// <param name="fname"> String type which represents the student's first name. </param>
        /// <param name="surname"> String type which represents the student's last name. </param>
        /// <param name="id_number"> Integer type which represents the student's ID number. </param>
        /// <param name="module1"> module_data type which represents the information for module 1 </param>
        /// <param name="module2"> module_data type which represents the information for module 2 </param>
        /// <param name="module3"> module_data type which represents the information for module 3 </param>
        /// <param name="module4"> module_data type which represents the information for module 4 </param>
        /// <param name="module5"> module_data type which represents the information for module 5 </param>
        /// <param name="module6"> module_data type which represents the information for module 6 </param>
        static void populateStruct(out student_data student, string fname, string surname, int id_number, module_data module1, module_data module2, module_data module3, module_data module4, module_data module5, module_data module6)
        {
            student.forename = fname;
            student.surname = surname;
            student.id_number = id_number;
            student.module1 = module1;
            student.module2 = module2;
            student.module3 = module3;
            student.module4 = module4;
            student.module5 = module5;
            student.module6 = module6;
            float averageScore = student.module1.mark + student.module2.mark + student.module3.mark + student.module4.mark + student.module5.mark + student.module6.mark;
            student.averageGrade = (averageScore / 6);
        }
        /// <summary>
        /// This populates the structure for each module with information
        /// </summary>
        /// <param name="module"> allows data to be modified and used outside of the function</param>
        /// <param name="mcode"> String type which represents the code for the module </param>
        /// <param name="mname"> String type which represents the name of the module </param>
        /// <param name="score"> Int type which represents the score of the module </param>
        static void populateModule(out module_data module, string mcode, string mname, int score)
        {
            module.code = mcode;
            module.title = mname;
            module.mark = score;
        }
        /// <summary>
        /// Main method for the code
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            module_data module1, module2, module3, module4, module5, module6;
            populateModule(out module1, "1", "Programming 1", 70);
            populateModule(out module2, "2", "Programming 2", 60);
            populateModule(out module3, "3", "Programming 3", 90);
            populateModule(out module4, "4", "Data Mining", 85);
            populateModule(out module5, "5", "Employability", 72);
            populateModule(out module6, "6", "Concepts To Computing", 69);
            student_data student1;
            populateStruct(out student1, "Charlotte", "Street", 1, module1, module2, module3, module4, module5, module6);
            printStudent(student1);

        }
        /// <summary>
        /// This prints the student's data, and gives them a grade based off their score for the module.
        /// </summary>
        /// <param name="student"> This is the student data that needs to be printed. </param>
        static void printStudent(student_data student)
        {
            Console.WriteLine("Name: " + student.forename + " " + student.surname);
            Console.WriteLine("Id: " + student.id_number);
            float grade = student.averageGrade;
            Console.WriteLine("Av grade: " + student.averageGrade);
            if (grade < 0 || grade > 100) { Console.WriteLine("There is an error in your marks"); }
            else if (grade > 84) { Console.WriteLine("Your grade is outstanding!"); }
            else if (grade > 69) { Console.WriteLine("Your grade is excellent!"); }
            else if (grade > 59) { Console.WriteLine("Your grade is very good"); }
            else if (grade > 49) { Console.WriteLine("Your grade is good"); }
            else if (grade > 39) { Console.WriteLine("Your grade is a pass"); }
            else if (grade > 29) { Console.WriteLine("Your grade is a narrow fail"); }
            else if (grade > -1) { Console.WriteLine("Your grade is a fail"); }
        }
    }
}