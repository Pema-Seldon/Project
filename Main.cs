using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student std = new Student();
            std.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Section sect = new Section();
            sect.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Teacher tea = new Teacher();
            tea.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Attendance att = new Attendance();
            att.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Subject sub = new Subject();
            sub.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Enrollment en = new Enrollment();
            en.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Dashboard dah = new Dashboard();
            dah.Show();
        }
    }
}
