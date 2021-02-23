using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Speech;
using System.Speech.Synthesis;
namespace my_app
{
    public partial class register : Form

    {
        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Admin\Desktop\New folder\my app\my app\nstp .accdb");
        public register()
        {
            InitializeComponent();

        }


        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu m = new menu();
            m.ShowDialog();
        }

        private void register_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("1-1");
            comboBox1.Items.Add("1-2");
            comboBox1.Items.Add("1-3");
            comboBox1.Items.Add("1-4");
            comboBox1.Items.Add("1-5");
            //comboBox1.Items.Add("Tuesday");
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txtbox_ID.Text == String.Empty || txtbox_firstname.Text == String.Empty || txtbox_surename.Text == string.Empty)
            {
                MessageBox.Show("Please Input Blank Data!", "Message");
            }
            else
            {
                conn.Open();
                OleDbCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into student values('" + txtbox_ID.Text + "','" + txtbox_surename.Text + "','" + txtbox_firstname.Text + "','" + txtbox_MI.Text + "','" + txtbox_sem.Text + "','" + txtbox_yr.Text + "','" + txtbox_course.Text + "','" + txtbox_year.Text + "', '" + txtbox_status.Text + "','" + txt_prilem.Text + "', '" + txt_midterm.Text + "','" + txt_finals.Text + "','" + txt_average.Text + "','" + comboBox1.Text + "','" + textBox1.Text+ "')";
                cmd.ExecuteNonQuery();
                this.Refresh();
                SpeechSynthesizer sp = new SpeechSynthesizer();
                sp.Speak(label13.Text);
                MessageBox.Show("Saved!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();

                txtbox_ID.Text = "";
                txtbox_surename.Text = "";
                txtbox_firstname.Text = "";
                txtbox_MI.Text = "";
                txtbox_year.Text = "";
                txtbox_course.Text = "";
                txtbox_sem.Text = "";
                txtbox_status.Text = "";
                comboBox1.Text = "";
            }
          /* catch (Exception ex)

           {
               MessageBox.Show("Error" + ex);

           }*/
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtbox_surename_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbox_firstname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbox_MI_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbox_sem_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbox_yr_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbox_course_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbox_year_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void txtbox_ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_cancel_Click_1(object sender, EventArgs e)
        {
            SpeechSynthesizer sp = new SpeechSynthesizer();
            sp.Speak(label12.Text);
            this.Hide();
            menu f1 = new menu();
            f1.ShowDialog();
        }
    }
}
