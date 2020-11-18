using System;
using System.Collections.Generic;
using System.Text;

namespace University_Management_System
{
    class Faculty
    {

        private string fName;

        public string FName
        {
            get { return fName; }
            set { fName = value; }
        }

        private string fId;

        public string FId
        {
            get { return fId; }
            set { fId = value; }
        }

        private float weeklyLoad;

        public float WeeklyLoad
        {
            get { return weeklyLoad; }
            set { weeklyLoad = value; }
        }

        private Section[] fSections;

        public Section[] FSections
        {
            get { return fSections; }
            set { fSections = value; }
        }


        public Faculty()
        {
            fSections = new Section[8];
        }

        public Faculty(string fName, string fId)
        {
            fSections = new Section[8];
            this.fName = fName;
            this.fId = fId;
        }

        public void ShowFaculty()
        {
            Console.WriteLine("");
            Console.WriteLine("Assigned Faculty: ");
            Console.WriteLine("Faculty Name: " + fName);
            Console.WriteLine("Faculty ID: " + fId);
            Console.WriteLine("Weekly load: {0} hour" , weeklyLoad);
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("");
        }

        private int secCount;

        public int SecCount
        {
            get { return secCount; }
            set { secCount = value; }
        }

        public void AddSections(Section section)
        {
            
            fSections[secCount++] = section;
        }

        public void ShowRegisteredSections()
        {
            Console.WriteLine("{0}'s Registered section details:", fName);
            Console.WriteLine("");
            for (int i=0; i<secCount; i++)
            {
                fSections[i].ShowAllSections();
            }
        }

    }
}
