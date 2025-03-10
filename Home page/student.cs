using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
namespace Home_page
{
    public partial class student : Form
    {
        public student()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string email = guna2TextBox1.Text;
            string password = guna2TextBox2.Text;

            string connectionstring = ("Data Source=BESHOY;Initial Catalog=students;Integrated Security=True;Trust Server Certificate=True");

            SqlConnection conn = new SqlConnection(connectionstring);
            conn.Open();
            string query = "SELECT * FROM stud_new WHERE  email = @email AND password = @password ";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("password", password);
            cmd.Parameters.AddWithValue("email", email);
            cmd.ExecuteNonQuery();


            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    MessageBox.Show("Operation was successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Operation failed. Please try again.", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }


        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // Add your drawing logic here, or leave it empty if not needed
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }
       

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {
            // Code to handle text change event
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            // Code to handle text change event
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            Stud_Reg stud_Reg = new Stud_Reg();
            stud_Reg.Show();

        }

        private void label4_Click(object sender, EventArgs e)
        {
            // Code for label4 click event
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // Code for pictureBox2 click event
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Code for pictureBox1 click event
        }

        private void label3_Click(object sender, EventArgs e)
        {
            // Code for label3 click event
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Code for label2 click event
        }

    }
}
