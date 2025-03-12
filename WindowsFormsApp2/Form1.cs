using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void log_Click(object sender, EventArgs e)
        {
            string username = user.Text;
            string password = pass.Text;

            if (username == "Username" || string.IsNullOrWhiteSpace(username) ||
                password == "password" || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter username and password.");

            }
            else if (username != "Lawrence")
            {
                MessageBox.Show("Incorrect username or password!.");

            }
            else if (password != "012404")
            {
                MessageBox.Show("Incorrect username or password!.");

            }
            else
            {
                // Successful login
                StudentForm studentForm = new StudentForm();
                studentForm.Show();
                this.Hide();
            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void user_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
