using System;
using System.Collections.Generic;
using System.Text;

namespace University_Management_System
{
    class Section
    {

        private string sName;

        public string SName
        {
            get { return sName; }
            set { sName = value; }
        }

        private string sId;

        public string SId
        {
            get { return sId; }
            set { sId = value; }
        }

        private string sRoom;

        public string SRoom
        {
            get { return sRoom; }
            set { sRoom = value; }
        }

        private string cName;

        public string CName
        {
            get { return cName; }
            set { cName = value; }
        }



        public Section()
        {

        }

        public Section(string sName, string sId, string sRoom)
        {
            this.sName = sName;
            this.sId = sId;
            this.sRoom = sRoom;
        }

        public void ShowAllSections()
        {
            Console.WriteLine("Course Name: " + cName);
            Console.WriteLine("Section: " + sName);
            Console.WriteLine("Section ID: " + sId);
            Console.WriteLine("Section Room: " + sRoom);
            if(sTeacher!=null)
                sTeacher.ShowFaculty();
            else
                Console.WriteLine("Section Teacher: No teacher found");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("");
        }

        private Faculty sTeacher;

        public Faculty STeacher
        {
            get { return sTeacher; }
            set { sTeacher = value; }
        }


        public void AddTeacher(Faculty teacher)
        {
            if(teacher.WeeklyLoad+this.teachingHour<=21)
            {
                sTeacher = teacher;
                teacher.AddSections(this);
                teacher.WeeklyLoad += teachingHour;
            }
            else
            {
                Console.WriteLine("***Weekly load reached for {0}",teacher.FName);
            }
                

        }

        private float teachingHour;

        public float TeachingHour
        {
            get { return teachingHour; }
            set { teachingHour = value; }
        }




    }
}
