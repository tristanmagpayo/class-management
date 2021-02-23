namespace my_app
{
    partial class deluser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(deluser));
            this.btn_users = new System.Windows.Forms.PictureBox();
            this.btn_student = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btn_users)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_student)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_users
            // 
            this.btn_users.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_users.BackgroundImage")));
            this.btn_users.Image = ((System.Drawing.Image)(resources.GetObject("btn_users.Image")));
            this.btn_users.Location = new System.Drawing.Point(74, 47);
            this.btn_users.Name = "btn_users";
            this.btn_users.Size = new System.Drawing.Size(94, 82);
            this.btn_users.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_users.TabIndex = 0;
            this.btn_users.TabStop = false;
            this.btn_users.Click += new System.EventHandler(this.btn_users_Click);
            // 
            // btn_student
            // 
            this.btn_student.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_student.BackgroundImage")));
            this.btn_student.Image = ((System.Drawing.Image)(resources.GetObject("btn_student.Image")));
            this.btn_student.Location = new System.Drawing.Point(216, 47);
            this.btn_student.Name = "btn_student";
            this.btn_student.Size = new System.Drawing.Size(94, 82);
            this.btn_student.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_student.TabIndex = 1;
            this.btn_student.TabStop = false;
            this.btn_student.Click += new System.EventHandler(this.btn_student_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(77, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "DELETE USERS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(208, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "DELETE STUDENTS";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(353, 118);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(39, 34);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Minion Pro", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(104, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "DELETE RECORDS";
            // 
            // deluser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(393, 154);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_student);
            this.Controls.Add(this.btn_users);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "deluser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "deluser";
            this.Load += new System.EventHandler(this.deluser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btn_users)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_student)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btn_users;
        private System.Windows.Forms.PictureBox btn_student;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label3;
    }
}