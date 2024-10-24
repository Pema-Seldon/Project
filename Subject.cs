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
    public partial class Subject : Form
    {
        public Subject()
        {
            InitializeComponent();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dell\source\repos\Project\Database1.mdf;Integrated Security=True");
            con.Open();

            SqlCommand cnn = new SqlCommand("delete from subtab where SubjectId='" + txtid.Text + "'", con);
            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("record delete successfully", "delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            txtid.Text = "";
            txtsnm.Text = "";
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dell\source\repos\Project\Database1.mdf;Integrated Security=True");
            con.Open();

            SqlCommand cnn = new SqlCommand("insert into subtab(SubjectId,SubjectName) Values('" + txtid.Text + "','" + txtsnm.Text + "')", con);

            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("record saved successfully", "save", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dell\source\repos\Project\Database1.mdf;Integrated Security=True");
            con.Open();

            SqlCommand cnn = new SqlCommand("Select * from subtab", con);
            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dell\source\repos\Project\Database1.mdf;Integrated Security=True");
            con.Open();

            SqlCommand cnn = new SqlCommand("update subtab set SubjectName='" + txtsnm.Text + "' where SubjectId='" + txtid.Text + "'", con);
            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("record update successfully", "update", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void btn_display_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dell\source\repos\Project\Database1.mdf;Integrated Security=True");
            con.Open();

            SqlCommand cnn = new SqlCommand("Select * from subtab", con);
            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void Subject_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dell\source\repos\Project\Database1.mdf;Integrated Security=True");
            con.Open();

            SqlCommand cnn = new SqlCommand("Select * from subtab", con);
            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txtsnm.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
        }
    }
}
