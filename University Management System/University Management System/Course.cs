using System;
using System.Collections.Generic;
using System.Text;

namespace University_Management_System
{
    class Course
    {

        private string cName;

        public string CName
        {
            get { return cName; }
            set { cName = value; }
        }

        private string cId;

        public string CId
        {
            get { return cId; }
            set { cId = value; }
        }

        private float teachingHour;

        public float TeachingHour
        {
            get { return teachingHour; }
            set { teachingHour = value; }
        }


        private Section[] cSections;

        public Section[] CSection
        {
            get { return cSections; }
            set { cSections = value; }
        }


        public Course()
        {
            cSections = new Section[20];
        }

        public Course(string cName, string cId, float teachingHour)
        {
            cSections = new Section[20];
            this.cName = cName;
            this.cId = cId;
            this.teachingHour = teachingHour;
        }

        private int secCount;

        public int SecCount
        {
            get { return secCount; }
            set { secCount = value; }
        }

        public void AddSection(Section section)
        {
            section.CName = this.cName;
            cSections[secCount++] = section;
            section.TeachingHour = this.TeachingHour;
        }

        public void ShowCourseSections()
        {
            Console.WriteLine("{0} section details:",cName);
            Console.WriteLine("");
            for (int i = 0; i < secCount; i++)
            {
                cSections[i].ShowAllSections();
            }
        }

    }
}
