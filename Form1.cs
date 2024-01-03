using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task3_b
{
    public partial class Form1 : Form
    {
        // Define the dictionary to store student information
        Dictionary<string, Student> studentdict = new Dictionary<string, Student>();

        public Form1()
        {
            // Create two Student objects
            Student student1 = new Student("2234stu", "Udeme");
            Student student2 = new Student("3434stu", "Mfon");

            // Add the students to the dictionary
            studentdict.Add(student1.Stud_id, student1);
            studentdict.Add(student2.Stud_id, student2);

            InitializeComponent();
        }

        private void btn_status_Click(object sender, EventArgs e)
        {
            showBox.Items.Clear();

            // Get the student ID entered by the user
            Student student_of_interest = studentdict[txt_Stud_id.Text];

            // Display the enrollment status of the student
            showBox.Items.Add(student_of_interest.Enrolled);

            // Clear the text box
            txt_Stud_id.Clear();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            // Create a new Student object with the entered ID and name
            Student student = new Student(txt_Stud_id.Text, txt_stud_name.Text);

            // Add or update the Student in the dictionary
            studentdict[txt_Stud_id.Text] = student;

            // Clear the text boxes
            txt_Stud_id.Clear();
            txt_stud_name.Clear();
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            // Get the student ID of the student to be removed
            string studentId = txt_Stud_id.Text;

            // Remove the student with the specified ID from the dictionary
            studentdict.Remove(studentId);

            // Clear the text box
            txt_Stud_id.Clear();
        }

        private void btn_status_update_Click(object sender, EventArgs e)
        {
            // Get the student ID
            string studentId = txt_Stud_id.Text;

            // Parse the enrollment status entered by the user
            if (bool.TryParse(txt_status.Text, out bool status))
            {
                // Check if the student ID exists in the dictionary
                if (studentdict.ContainsKey(studentId))
                {
                    // Update the enrollment status of the student
                    studentdict[studentId].Enrolled = status;

                    // Display a success message
                    MessageBox.Show("Enrollment status updated successfully!");

                    // Clear the text boxes
                    txt_Stud_id.Clear();
                    txt_status.Clear();
                }
                else
                {
                    // Show an error message when an invalid student ID is entered
                    MessageBox.Show("Student with ID " + studentId + " does not exist!");
                }
            }
            else
            {
                // Show an error message when an invalid enrollment status is entered
                MessageBox.Show("Please enter a valid enrollment status (true/false)!");
            }
        }

        private void btn_by_status_Click(object sender, EventArgs e)
        {
            showBox.Items.Clear();
            // Get the enrollment status entered by the user
            bool status = bool.Parse(txt_status.Text);

            // Iterate through all items in the dictionary with the specified enrollment status
            foreach (KeyValuePair<string, Student> student in studentdict)
            {
                if (student.Value.Enrolled == status)
                {
                    showBox.Items.Add("Name: " + student.Value.Stud_name + " - " + "Student Id: " + student.Value.Stud_id);
                }
            }

            // Clear both textboxes used
            txt_Stud_id.Clear();
            txt_status.Clear();
        }

        private void btn_stud_display_Click(object sender, EventArgs e)
        {
            showBox.Items.Clear();
            // Get the student name entered by the user
            string name = txt_stud_name.Text;

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please enter a name!");
            }
            else
            {
                // Iterate through all items in the dictionary and display students with the specified name
                foreach (KeyValuePair<string, Student> student in studentdict)
                {
                    if (student.Value.Stud_name == name)
                    {
                        showBox.Items.Add("Student Id: " + student.Value.Stud_id + " - " + "Enrollment status: " + student.Value.Enrolled);
                    }
                }

                // Clear both textboxes used
                txt_Stud_id.Clear();
                txt_status.Clear();
            }
        }

        private void btn_show_all_Click(object sender, EventArgs e)
        {
            showBox.Items.Clear();

            // Iterate through all items in the dictionary and display all students
            foreach (KeyValuePair<string, Student> student in studentdict)
            {
                showBox.Items.Add("Student Id: " + student.Value.Stud_id + " - " + "Student Name: " + student.Value.Stud_name + " - " + "Enrollment status: " + student.Value.Enrolled);
            }

            // Clear both textboxes used
            txt_Stud_id.Clear();
            txt_status.Clear();
        }
    }
}
