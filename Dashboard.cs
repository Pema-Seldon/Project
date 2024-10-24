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

namespace Project
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        private void displaystudent()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dell\source\repos\Project\Database1.mdf;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM studentab", con);
            Int32 count = Convert.ToInt32(cmd.ExecuteScalar());
            if (count > 0)
            {
               std.Text = Convert.ToString(count.ToString());
            }
            else
            {
                std.Text = "0";
            }
            con.Close();

        }
        private void displaycourse()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dell\source\repos\Project\Database1.mdf;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM subtab", con);
            Int32 count = Convert.ToInt32(cmd.ExecuteScalar());
            if (count > 0)
            {
                sub.Text = Convert.ToString(count.ToString());
            }
            else
            {
                sub.Text = "0";
            }
            con.Close();

        }
        private void displayteacher()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dell\source\repos\Project\Database1.mdf;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM teachertab", con);
            Int32 count = Convert.ToInt32(cmd.ExecuteScalar());
            if (count > 0)
            {
                tea.Text = Convert.ToString(count.ToString());
            }
            else
            {
                tea.Text = "0";
            }
            con.Close();

        }
        private void displayenrollment()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dell\source\repos\Project\Database1.mdf;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM entab", con);
            Int32 count = Convert.ToInt32(cmd.ExecuteScalar());
            if (count > 0)
            {
                en.Text = Convert.ToString(count.ToString());
            }
            else
            {
                en.Text = "0";
            }
            con.Close();

        }

        private void Display_student_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Dashboard_Load_1(object sender, EventArgs e)
        {
            displaystudent();
            displaycourse();
            displayteacher();
            displayenrollment();
        }
    }
}
