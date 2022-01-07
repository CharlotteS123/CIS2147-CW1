using System;

namespace W3_Ex4
{
    class Program
    {
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
        public struct module_data
        {
            public string code;
            public string title;
            public int mark;
        }
        static void populateStruct(out student_data student, string fname, string surname, int id_number, module_data module1, module_data module2, module_data module3, module_data module4, module_data module5, module_data module6)
        {
            student.forename = fname;
            student.surname = surname;
            student.id_number = id_number;
            student.averageGrade = 0.0F;
            student.module1 = module1;
            student.module2 = module2;
            student.module3 = module3;
            student.module4 = module4;
            student.module5 = module5;
            student.module6 = module6;
        }
        static void populateModule(out module_data module, string mcode, string mname, int score)
        {
            module.code = mcode;
            module.title = mname;
            module.mark = score;
        }
        static void Main(string[] args)
        {
            module_data module1, module2, module3, module4, module5, module6;
            populateModule(out module1, "1", "Programming 1", 0);
            populateModule(out module2, "2", "Programming 2", 0);
            populateModule(out module3, "3", "Programming 3", 0);
            populateModule(out module4, "4", "Data Mining", 0);
            populateModule(out module5, "5", "Employability", 0);
            populateModule(out module6, "6", "Concepts To Computing", 0);
            student_data student1;
            populateStruct(out student1, "Charlotte", "Street", 1, module1, module2, module3, module4, module5, module6);
            printStudent(student1);
        }
        static void printStudent(student_data student)
        {
            Console.WriteLine("Name: " + student.forename + " " + student.surname);
            Console.WriteLine("Id: " + student.id_number);
            Console.WriteLine("Av grade: " + student.averageGrade);
            Console.WriteLine("Module 1 Code: " + student.module1.code);
            Console.WriteLine("Module 1 Name: " + student.module1.title);
            Console.WriteLine("Module 1 Mark: " + student.module1.mark);
            Console.WriteLine("Module 2 Code: " + student.module2.code);
            Console.WriteLine("Module 2 Name: " + student.module2.title);
            Console.WriteLine("Module 2 Mark: " + student.module2.mark);
        }
    }
}