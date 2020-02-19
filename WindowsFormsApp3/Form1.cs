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

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"|DataDirectory|\\Database1.mdf\";Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;

        private string getUsername()
        {
            con.Open();
            String syntax = "SELECT value FROM systemTable WHERE Property='Username'";
            cmd = new SqlCommand(syntax, con);
            dr = cmd.ExecuteReader();
            dr.Read();
            String temp = dr[0].ToString();
            con.Close();
            return temp;
        }
        private string getPassword()
        {
            con.Open();
            String syntax = "SELECT value FROM systemTable WHERE Property='Password'";
            cmd = new SqlCommand(syntax, con);
            dr = cmd.ExecuteReader();
            dr.Read();
            String temp = dr[0].ToString();
            con.Close();
            return temp;
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {
            string user=getUsername(), passw=getPassword(), us, pa;
            us = textBox2.Text;
            pa = textBox1.Text;

            if(us.Equals(user)&&pa.Equals(passw))
            {
                wrong.Hide();
                // MessageBox.Show("Successful login");

                AppBody obj = new AppBody();
                this.Hide();
                obj.Show();
            }
            else
            {
                wrong.Show();
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
