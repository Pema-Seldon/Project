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
    public partial class Teacher : Form
    {
        public Teacher()
        {
            InitializeComponent();
        }
        String Gender;
        private void txtsnm_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtph_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dell\source\repos\Project\Database1.mdf;Integrated Security=True");
            con.Open();

            SqlCommand cnn = new SqlCommand("insert into teachertab(TeacherId,TeacherName,Gender,Phone,Email) Values('" + txtid.Text + "','" + txtsnm.Text + "','" + label8.Text + "','" + txtph.Text + "','" + txtem.Text + "')", con);
            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("record saved successfully", "save", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dell\source\repos\Project\Database1.mdf;Integrated Security=True");
            con.Open();

            SqlCommand cnn = new SqlCommand("Select * from teachertab", con);
            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dell\source\repos\Project\Database1.mdf;Integrated Security=True");
            con.Open();

            SqlCommand cnn = new SqlCommand("update teachertab set teacherName='" + txtsnm.Text + "',Gender='" + label8.Text + "',Phone='" + txtph.Text + "',Email='" + txtem.Text + "' where TeacherId='" + txtid.Text + "'", con);
            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("record update successfully", "update", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dell\source\repos\Project\Database1.mdf;Integrated Security=True");
            con.Open();

            SqlCommand cnn = new SqlCommand("delete from tecahertab where TeacherId='" + txtid.Text + "'", con);
            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("record delete successfully", "delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            txtid.Text = "";
            txtsnm.Text = "";
            label8.Text = "";
            txtph.Text = "";
            txtem.Text = "";
        }

        private void btn_display_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dell\source\repos\Project\Database1.mdf;Integrated Security=True");
            con.Open();

            SqlCommand cnn = new SqlCommand("Select * from teachertab", con);
            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void Teacher_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dell\source\repos\Project\Database1.mdf;Integrated Security=True");
            con.Open();

            SqlCommand cnn = new SqlCommand("Select * from teachertab", con);
            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dell\source\repos\Project\Database1.mdf;Integrated Security=True");
            con.Open();
            Gender = "female";
            label8.Text = Gender;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dell\source\repos\Project\Database1.mdf;Integrated Security=True");
            con.Open();
            Gender = "male";
            label8.Text = Gender;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtid.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                txtsnm.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                label8.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                txtph.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                txtem.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            }
        }
    }
}
