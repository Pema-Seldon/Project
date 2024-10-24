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
    public partial class Section : Form
    {
        public Section()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dell\source\repos\Project\Database1.mdf;Integrated Security=True");
            con.Open();

            SqlCommand cnn = new SqlCommand("insert into sectiontab(SectionId,StudentName,Section) Values('" + txtid.Text + "','" + txtsnm.Text + "','" + txtsect.Text + "')", con);

            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("record saved successfully", "save", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dell\source\repos\Project\Database1.mdf;Integrated Security=True");
            con.Open();

            SqlCommand cnn = new SqlCommand("Select * from sectiontab", con);
            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dell\source\repos\Project\Database1.mdf;Integrated Security=True");
            con.Open();

            SqlCommand cnn = new SqlCommand("update sectiontab set StudentName='" + txtsnm.Text + "',Section='" + txtsnm.Text + "' where SectionId='" + txtid.Text + "'", con);
            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("record update successfully", "update", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dell\source\repos\Project\Database1.mdf;Integrated Security=True");
            con.Open();

            SqlCommand cnn = new SqlCommand("delete from sectiontab where SectionId='" + txtid.Text + "'", con);
            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("record delete successfully", "delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtid.Text = "";
            txtsnm.Text = "";
            txtsect.Text = "";
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dell\source\repos\Project\Database1.mdf;Integrated Security=True");
            con.Open();

            SqlCommand cnn = new SqlCommand("Select * from sectiontab", con);
            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void Section_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dell\source\repos\Project\Database1.mdf;Integrated Security=True");
            con.Open();

            SqlCommand cnn = new SqlCommand("Select * from sectiontab", con);
            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtid.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                txtsnm.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                txtsect.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            }
        }
    }
}
