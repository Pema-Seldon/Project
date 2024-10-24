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
    public partial class Enrollment : Form
    {
        SqlDataAdapter da;
        DataSet ds;
        private CrystalDecisions.CrystalReports.Engine.ReportDocument cr = new CrystalDecisions.CrystalReports.Engine.ReportDocument();

        static string Crypath = "";
        public Enrollment()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dell\source\repos\Project\Database1.mdf;Integrated Security=True");
            con.Open();

            SqlCommand cnn = new SqlCommand("insert into entab(EId,StudentName,Section,EnrollDate) Values('" + txtid.Text + "','" + txtsnm.Text + "','" + txtsect.Text + "','"+dateTimePicker1.Value+"')", con);
            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("record saved successfully", "save", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dell\source\repos\Project\Database1.mdf;Integrated Security=True");
            con.Open();

            SqlCommand cnn = new SqlCommand("Select * from entab", con);
            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dell\source\repos\Project\Database1.mdf;Integrated Security=True");
            con.Open();

            SqlCommand cnn = new SqlCommand("update entab set StudentName='" + txtsnm.Text + "',Section='" + txtsect.Text + "',EnrollDate='" + dateTimePicker1.Value + "' where EId='" + txtid.Text + "'", con);
            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("record update successfully", "update", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dell\source\repos\Project\Database1.mdf;Integrated Security=True");
            con.Open();

            SqlCommand cnn = new SqlCommand("delete from entab where EId='" + txtid.Text + "'", con);
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

            SqlCommand cnn = new SqlCommand("Select * from entab", con);
            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
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

        private void Enrollment_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dell\source\repos\Project\Database1.mdf;Integrated Security=True");
            con.Open();

            SqlCommand cnn = new SqlCommand("Select * from entab", con);
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
                dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[3].Value);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dell\source\repos\Project\Database1.mdf;Integrated Security=True");
            con.Open();
            da = new SqlDataAdapter("select * from entab", con);
            ds = new DataSet();
            da.Fill(ds);
            string xml = @"C:/Users/dell/source/repos/Project/data1.xml";
            ds.WriteXmlSchema(xml);

            Crypath = @"C:/Users/dell/source/repos/Project/Enroll.rpt";
            cr.Load(Crypath);
            cr.SetDataSource(ds);
            cr.Database.Tables[0].SetDataSource(ds);
            cr.Refresh();
            crystalReportViewer1.ReportSource = cr;
        }
    }
}
