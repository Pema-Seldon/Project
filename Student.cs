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
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace Project
{
    public partial class Student : Form
    {
        SqlDataAdapter da;
        DataSet ds;
        private CrystalDecisions.CrystalReports.Engine.ReportDocument cr = new CrystalDecisions.CrystalReports.Engine.ReportDocument();

        static string Crypath = "";
        public Student()
        {
            InitializeComponent();
        }
        String Gender;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dell\source\repos\Project\Database1.mdf;Integrated Security=True");
            con.Open();

            SqlCommand cnn = new SqlCommand("Select * from studentab", con);
            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dell\source\repos\Project\Database1.mdf;Integrated Security=True");
            con.Open();

            SqlCommand cnn = new SqlCommand("insert into studentab(StudentId,StudentName,Dob,Gender,Phone,Email) Values('" + txtid.Text + "','" + txtsnm.Text + "',@Dob,'" + label8.Text + "','" + txtph.Text + "','" + txtem.Text + "')", con);
            cnn.Parameters.AddWithValue("@Dob", dateTimePicker1.Value);
            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("record saved successfully", "save", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.CustomFormat = "dd-MM-yyyy";
        }

        private void dateTimePicker1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                dateTimePicker1.CustomFormat = "";
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dell\source\repos\Project\Database1.mdf;Integrated Security=True");
            con.Open();

            SqlCommand cnn = new SqlCommand("update studentab set StudentName='" + txtsnm.Text + "',Dob=@Dob,Gender='" + label8.Text + "',Phone='" + txtph.Text + "',Email='" + txtem.Text + "' where StudentId='" + txtid.Text + "'", con);
            cnn.Parameters.AddWithValue("@Dob", dateTimePicker1.Value);
            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("record update successfully", "update", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dell\source\repos\Project\Database1.mdf;Integrated Security=True");
            con.Open();

            SqlCommand cnn = new SqlCommand("delete from studentab where StudentId='" + txtid.Text + "'", con);
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

            SqlCommand cnn = new SqlCommand("Select * from studentab", con);
            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void Student_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dell\source\repos\Project\Database1.mdf;Integrated Security=True");
            con.Open();

            SqlCommand cnn = new SqlCommand("Select * from studentab", con);
            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void txtem_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtsnm_TextChanged(object sender, EventArgs e)
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
                dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[2].Value);
                label8.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                txtph.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                txtem.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dell\source\repos\Project\Database1.mdf;Integrated Security=True");
            con.Open();
            da = new SqlDataAdapter("select * from studentab", con);
            ds = new DataSet();
            da.Fill(ds);
            string xml = @"C:/Users/dell/source/repos/Project/data2.xml";
            ds.WriteXmlSchema(xml);

            Crypath = @"C:/Users/dell/source/repos/Project/stud.rpt";
            cr.Load(Crypath);
            cr.SetDataSource(ds);
            cr.Database.Tables[0].SetDataSource(ds);
            cr.Refresh();
            crystalReportViewer1.ReportSource = cr;
        }
    }
}
