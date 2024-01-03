using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3_b
{
    internal class Student
    {
        private string stud_id; // Student ID
        private string stud_name; // Student name
        private bool enrolled; // Enrolled status

        // Constructor for the Student class
        public Student(string Stud_id, string Stud_name)
        {
            this.stud_id = Stud_id;
            this.stud_name = Stud_name;
            this.enrolled = true; // By default, the student is enrolled
        }

        // Getters and setters for the private fields

        public string Stud_id
        {
            get { return stud_id; }
            set { stud_id = value; }
        }

        public string Stud_name
        {
            get { return stud_name; }
            set { stud_name = value; }
        }

        public bool Enrolled
        {
            get { return enrolled; }
            set { enrolled = value; }
        }
    }
}
