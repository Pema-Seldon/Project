
namespace Project
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Display_student = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.std = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Display_subject = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.sub = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Display_teacher = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.tea = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Display_enrollment = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.en = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Display_student.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.Display_subject.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.Display_teacher.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.Display_enrollment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 79);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(162, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin Dashboard";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 79);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 371);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Project.Properties.Resources.admin_removebg_preview;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(170, 109);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Display_student
            // 
            this.Display_student.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Display_student.Controls.Add(this.pictureBox2);
            this.Display_student.Controls.Add(this.std);
            this.Display_student.Controls.Add(this.label2);
            this.Display_student.Location = new System.Drawing.Point(218, 104);
            this.Display_student.Name = "Display_student";
            this.Display_student.Size = new System.Drawing.Size(178, 109);
            this.Display_student.TabIndex = 2;
            this.Display_student.Paint += new System.Windows.Forms.PaintEventHandler(this.Display_student_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Project.Properties.Resources.studpro_removebg_preview;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(55, 18);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 34);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // std
            // 
            this.std.AutoSize = true;
            this.std.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.std.Location = new System.Drawing.Point(105, 80);
            this.std.Name = "std";
            this.std.Size = new System.Drawing.Size(19, 20);
            this.std.TabIndex = 1;
            this.std.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Students: ";
            // 
            // Display_subject
            // 
            this.Display_subject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Display_subject.Controls.Add(this.pictureBox3);
            this.Display_subject.Controls.Add(this.sub);
            this.Display_subject.Controls.Add(this.label5);
            this.Display_subject.Location = new System.Drawing.Point(417, 104);
            this.Display_subject.Name = "Display_subject";
            this.Display_subject.Size = new System.Drawing.Size(178, 109);
            this.Display_subject.TabIndex = 3;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::Project.Properties.Resources.course_removebg_preview;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(48, 18);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(57, 44);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // sub
            // 
            this.sub.AutoSize = true;
            this.sub.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sub.Location = new System.Drawing.Point(111, 80);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(19, 20);
            this.sub.TabIndex = 1;
            this.sub.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Subject:";
            // 
            // Display_teacher
            // 
            this.Display_teacher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Display_teacher.Controls.Add(this.pictureBox4);
            this.Display_teacher.Controls.Add(this.tea);
            this.Display_teacher.Controls.Add(this.label7);
            this.Display_teacher.Location = new System.Drawing.Point(610, 104);
            this.Display_teacher.Name = "Display_teacher";
            this.Display_teacher.Size = new System.Drawing.Size(178, 109);
            this.Display_teacher.TabIndex = 3;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::Project.Properties.Resources.tea_removebg_preview;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(54, 18);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(60, 44);
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            // 
            // tea
            // 
            this.tea.AutoSize = true;
            this.tea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tea.Location = new System.Drawing.Point(111, 80);
            this.tea.Name = "tea";
            this.tea.Size = new System.Drawing.Size(19, 20);
            this.tea.TabIndex = 1;
            this.tea.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(26, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Teachers:";
            // 
            // Display_enrollment
            // 
            this.Display_enrollment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Display_enrollment.Controls.Add(this.pictureBox5);
            this.Display_enrollment.Controls.Add(this.en);
            this.Display_enrollment.Controls.Add(this.label9);
            this.Display_enrollment.Location = new System.Drawing.Point(229, 296);
            this.Display_enrollment.Name = "Display_enrollment";
            this.Display_enrollment.Size = new System.Drawing.Size(178, 109);
            this.Display_enrollment.TabIndex = 3;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(55, 20);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(58, 43);
            this.pictureBox5.TabIndex = 2;
            this.pictureBox5.TabStop = false;
            // 
            // en
            // 
            this.en.AutoSize = true;
            this.en.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.en.Location = new System.Drawing.Point(111, 80);
            this.en.Name = "en";
            this.en.Size = new System.Drawing.Size(19, 20);
            this.en.TabIndex = 1;
            this.en.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(13, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Enrollment:";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Display_subject);
            this.Controls.Add(this.Display_teacher);
            this.Controls.Add(this.Display_enrollment);
            this.Controls.Add(this.Display_student);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Display_student.ResumeLayout(false);
            this.Display_student.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.Display_subject.ResumeLayout(false);
            this.Display_subject.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.Display_teacher.ResumeLayout(false);
            this.Display_teacher.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.Display_enrollment.ResumeLayout(false);
            this.Display_enrollment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel Display_student;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label std;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel Display_subject;
        private System.Windows.Forms.Label sub;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel Display_teacher;
        private System.Windows.Forms.Label tea;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel Display_enrollment;
        private System.Windows.Forms.Label en;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}