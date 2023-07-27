using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpPracticeApp
{
    internal class Student
    {
        public int ID { get; set; }
        /*public string Name { get; set; }*/
        public string Email { get; set; }
        public string PhoneNo { get; set; }

        #region for Encapsulation
        // Private fields (data)
        private string name;
        private int age;
        private string studentID;

        // Public properties (getters and setters)
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        // Public method to set studentID (Encapsulation through a method)
        public void SetStudentID(string id)
        {
            // Here, we can perform some validation or other logic before setting the studentID
            studentID = id;
        }

        // Public method to display student information
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Student ID: {studentID}");
        }
        #endregion
    }
}
