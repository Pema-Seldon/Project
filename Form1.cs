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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (isvalid())
            {

                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dell\source\repos\Project\Database1.mdf;Integrated Security=True");
                try
                {
                    con.Open();
                    String query = "Select * from login_tbl where Username='" + txtUsername.Text + "'and Password='" + txtPassword.Text + "'";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        SqlDataAdapter da = new SqlDataAdapter(cmd);//cnn
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        if (dt.Rows.Count > 0)
                        {
                            Main mn = new Main();
                            mn.Show();
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occured:" + ex.Message);
                }
            }
        }
        private bool isvalid()
        {
            if (txtUsername.Text.TrimStart() == String.Empty)
            {
                MessageBox.Show("enter valid user name please!", "Error");
                return false;
            }
            else if (txtPassword.Text.TrimStart() == String.Empty)
            {
                MessageBox.Show("enter valid password please!", "Error");
                return false;
            }
            return true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}
