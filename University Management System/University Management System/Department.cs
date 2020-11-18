using System;
using System.Collections.Generic;
using System.Text;

namespace University_Management_System
{
    class Department
    {

        private string dName;

        public string DName
        {
            get { return dName; }
            set { dName = value; }
        }

        private string dId;

        public string Did
        {
            get { return dId; }
            set { dId = value; }
        }

        private Course[] dCourses;

        public Course[] DCourses
        {
            get { return dCourses; }
            set { dCourses = value; }
        }


        public Department()
        {
            dCourses = new Course[25];
        }

        public Department(string dName, string dId)
        {
            dCourses = new Course[25];
            this.dName = dName;
            this.dId = dId;
        }

        private int courseCount;

        public int CourseCount
        {
            get { return courseCount; }
            set { courseCount = value; }
        }

        public void AddCourse(Course course)
        {
            dCourses[courseCount++] = course;
        }


    }
}
