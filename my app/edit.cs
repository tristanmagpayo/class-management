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
    public partial class edit : Form
    {
        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Admin\Desktop\New folder\my app\my app\nstp .accdb");
       
        public edit()
        {
            InitializeComponent();
        }

        private void btn_update_Click(object sender, EventArgs e)

        {
            if (txtbox_ID.Text == String.Empty || txtbox_firstname.Text == String.Empty || txtbox_surename.Text == string.Empty)
            {
                MessageBox.Show("Please Click Data!", "Message");
            }
            else
            {
                OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Admin\Desktop\New folder\my app\my app\nstp .accdb");
                conn.Open();
                OleDbCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update student set Status ='" + comboBox1.Text + "', Prof='" + textBox1 .Text+ "' where ID ='" + txtbox_ID.Text + "'";
                cmd.ExecuteNonQuery();
                conn.Close();
                SpeechSynthesizer sp = new SpeechSynthesizer();
                sp.Speak(label13.Text);
                MessageBox.Show("Profile Successfuly Updated|!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gridview_data();
                this.Refresh();
                dataGridtt.Refresh();

                txtbox_ID.Text = "";
                txtbox_surename.Text = "";
                txtbox_firstname.Text = "";
                txtbox_MI.Text = "";
                txtbox_year.Text = "";
                txtbox_course.Text = "";
                txtbox_sem.Text = "";
                comboBox1.Text = "";
                textBox1.Text = "";
            }
        }

        private void edit_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nstp_DataSet23.student' table. You can move, or remove it, as needed.
            this.studentTableAdapter6.Fill(this.nstp_DataSet23.student);
            // TODO: This line of code loads data into the 'nstp_DataSet22.student' table. You can move, or remove it, as needed.
            this.studentTableAdapter5.Fill(this.nstp_DataSet22.student);
            comboBox1.Items.Add("ACTIVE");
            comboBox1.Items.Add("NOTACTIVE");
            comboBox1.Items.Add("DROP");
            // TODO: This line of code loads data into the 'nstp_DataSet15.student' table. You can move, or remove it, as needed.
            this.studentTableAdapter4.Fill(this.nstp_DataSet15.student);
            OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Admin\Desktop\New folder\my app\my app\nstp .accdb");

            // TODO: This line of code loads data into the 'nstp_DataSet6.student' table. You can move, or remove it, as needed.
            this.studentTableAdapter3.Fill(this.nstp_DataSet6.student);
            // TODO: This line of code loads data into the 'nstp_DataSet5.student' table. You can move, or remove it, as needed.
            //this.studentTableAdapter.Fill(this.nstp_DataSet5.student);
            // TODO: This line of code loads data into the 'nstp_DataSet4.student' table. You can move, or remove it, as needed.
           // this.studentTableAdapter3.Fill(this.nstp_DataSet4.student);
            // TODO: This line of code loads data into the 'nstp_DataSet3.student' table. You can move, or remove it, as needed.
            this.studentTableAdapter2.Fill(this.nstp_DataSet3.student);
            // TODO: This line of code loads data into the 'nstp_DataSet1.student' table. You can move, or remove it, as needed.
            this.studentTableAdapter1.Fill(this.nstp_DataSet1.student);
            // TODO: This line of code loads data into the 'nstp_DataSet.student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.nstp_DataSet.student);
            this.Refresh();
            dataGridtt.Refresh();
            gridview_data();
           
          /*  conn.Open();
            OleDbCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from student =";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);
            dataGridView5.DataSource = dt;
            conn.Close();
         */
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
     
        }

        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          //  int Selected_row;
            //OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Admin\Desktop\New folder\my app\nstp .accdb");
           // if (e.RowIndex >= 0)
           // {
             //   Selected_row = e.RowIndex;
              //  DataGridViewRow row = this.dataGridtt.Rows[e.RowIndex];

                //txtbox_ID.Text = row.Cells[0].Value.ToString();
             /*   txtbox_surename.Text = row.Cells[1].Value.ToString();
                txtbox_firstname.Text = row.Cells[2].Value.ToString();
                txtbox_MI.Text = row.Cells[3].Value.ToString();
                txtbox_sem.Text = row.Cells[4].Value.ToString();
                txtbox_yr.Text = row.Cells[5].Value.ToString();
                txtbox_course.Text = row.Cells[6].Value.ToString();
                txtbox_year.Text = row.Cells[7].Value.ToString();
                txtbox_status.Text = row.Cells[8].Value.ToString();
                textBox1.Text = row.Cells[9].Value.ToString();
                gridview_data();
                this.Refresh();
            }*/

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu f = new menu();
            f.ShowDialog();
        }

        private void btn_cancel_Click_1(object sender, EventArgs e)
        {
            SpeechSynthesizer sp = new SpeechSynthesizer();
            sp.Speak(label12.Text);
            this.Hide();
            menu f = new menu();
            f.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           /* conn.Open();
            OleDbCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from student ="; 
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);
            dataGridView5.DataSource = dt;
            conn.Close();
          */
        }
        public void gridview_data()
        {
            conn.Open();
            OleDbDataAdapter con = new OleDbDataAdapter("select * from student", conn);
            DataSet sa = new DataSet();
            con.Fill(sa, "student");
            dataGridtt.DataSource = sa;
            dataGridtt.DataMember = "student";
            
          
            conn.Close();

        }

        private void txtbox_yr_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbox_ID_TextChanged(object sender, EventArgs e)
        {
            conn.Open();
            OleDbDataAdapter con = new OleDbDataAdapter("select * from student where ID like '" + txtbox_ID.Text + "' ", conn);
            DataTable sa = new DataTable();
            con.Fill(sa);
            dataGridtt.DataSource = sa;
            conn.Close();
        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {
            int Selected_row;
            //OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Admin\Desktop\New folder\my app\nstp .accdb");
            if (e.RowIndex >= 0)
            {
                Selected_row = e.RowIndex;
                DataGridViewRow row = this.dataGridtt.Rows[e.RowIndex];

                //txtbox_ID.Text = row.Cells[0].Value.ToString();
                txtbox_surename.Text = row.Cells[1].Value.ToString();
                txtbox_firstname.Text = row.Cells[2].Value.ToString();
                txtbox_MI.Text = row.Cells[3].Value.ToString();
                txtbox_sem.Text = row.Cells[4].Value.ToString();
                txtbox_yr.Text = row.Cells[5].Value.ToString();
                txtbox_course.Text = row.Cells[6].Value.ToString();
                txtbox_year.Text = row.Cells[7].Value.ToString();
                comboBox1.Text = row.Cells[8].Value.ToString();
                textBox1.Text = row.Cells[14].Value.ToString();
                gridview_data();
                this.Refresh();
            }
        }
    }
}
