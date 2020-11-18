 using System;

namespace University_Management_System
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Wlcome to my University Management System (^_^) *****");
            Console.WriteLine("_______________________________________________");
            Console.WriteLine("");

            Department d1 = new Department("CSE", "cs-001");
            Department d2 = new Department("EEE", "eee-001");

            Course c1 = new Course("OOP2", "cs01", 15.0f);
            Course c2 = new Course("DLC", "eee01", 3.0f);

            Section s1 = new Section("L","s01","MS teams");
            Section s2 = new Section("A", "s02", "MS teams");
            Section s3 = new Section("B", "s03", "MS teams");
            Section s4 = new Section("J", "s03", "MS teams");

            Faculty f1 = new Faculty("Tanvir Ahmed", "t01");
            Faculty f2 = new Faculty("Nobobi Hasan", "t02");

            d1.AddCourse(c1);
            d2.AddCourse(c2);

            c1.AddSection(s1);
            c1.AddSection(s2);
            c2.AddSection(s3);
            c2.AddSection(s4);

            s1.AddTeacher(f1);
            s2.AddTeacher(f1);
            s3.AddTeacher(f1);
            s4.AddTeacher(f2);

            

            c1.ShowCourseSections();
            Console.WriteLine("##########################################");
            Console.WriteLine("");

            c2.ShowCourseSections();
            Console.WriteLine("##########################################");
            Console.WriteLine("");

            f1.ShowRegisteredSections();
            Console.WriteLine("##########################################");
            Console.WriteLine("");

            f2.ShowRegisteredSections();
            Console.WriteLine("##########################################");
            Console.WriteLine("");

            //f1.ShowFaculty();
            //f2.ShowFaculty();
            //Console.WriteLine("##########################################");
            //Console.WriteLine("");

            Console.WriteLine("--------------End--------------");

        }
    }
}
