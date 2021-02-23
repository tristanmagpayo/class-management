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
    public partial class admincon : Form
    {
        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Admin\Desktop\New folder\my app\my app\nstp .accdb");
        public admincon()
        {
            InitializeComponent();
        }

        private void btn_registeradmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            ADMINREG f1 = new ADMINREG();
            f1.ShowDialog();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer sp = new SpeechSynthesizer();
            sp.Speak(label2.Text);
            this.Hide();
            menu f = new menu();
            f.ShowDialog();
        }

        private void admincon_Load(object sender, EventArgs e)

        {

            // TODO: This line of code loads data into the 'nstp_DataSet21.student' table. You can move, or remove it, as needed.
            this.studentTableAdapter7.Fill(this.nstp_DataSet21.student);
            // TODO: This line of code loads data into the 'nstp_DataSet20.student' table. You can move, or remove it, as needed.
            this.studentTableAdapter6.Fill(this.nstp_DataSet20.student);
            // TODO: This line of code loads data into the 'nstp_DataSet19.student' table. You can move, or remove it, as needed.
            this.studentTableAdapter5.Fill(this.nstp_DataSet19.student);
            // TODO: This line of code loads data into the 'nstp_DataSet18.student' table. You can move, or remove it, as needed.
            this.studentTableAdapter4.Fill(this.nstp_DataSet18.student);
            // TODO: This line of code loads data into the 'nstp_DataSet17.student' table. You can move, or remove it, as needed.
            this.studentTableAdapter3.Fill(this.nstp_DataSet17.student);
     

            // TODO: This line of code loads data into the 'nstp_DataSet14.student' table. You can move, or remove it, as needed.
            this.studentTableAdapter2.Fill(this.nstp_DataSet14.student);


            dataGridView1.Refresh();
            dataGridView1.Update();
           
            // TODO: This line of code loads data into the 'nstp_DataSet2.student' table. You can move, or remove it, as needed.
            this.studentTableAdapter1.Fill(this.nstp_DataSet2.student);
            // TODO: This line of code loads data into the 'nstp_DataSet.student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.nstp_DataSet.student);
            OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Admin\Desktop\New folder\my app\my app\nstp .accdb");
           gridview_data();
            dataGridView1.Refresh();
            this.Refresh();
            dataGridView1.RefreshEdit();
            conn.Open();
            OleDbDataAdapter con = new OleDbDataAdapter("select * from student", conn);
            DataTable sa = new DataTable();
           // comboBox2.Items.Add("1-1");
            //comboBox2.Items.Add("1-2");
            //comboBox2.Items.Add("1-3");
            //comboBox2.Items.Add("1-4");
            //comboBox2.Items.Add("1-5");
            con.Fill(sa);
            dataGridView1.DataSource = sa;
            gridview_data();
            conn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Admin\Desktop\New folder\my app\my app\nstp .accdb");
        }
        public void gridview_data()
        {
            conn.Open();
            OleDbDataAdapter con = new OleDbDataAdapter("select * from student", conn);
            DataSet sa = new DataSet();
            con.Fill(sa, "student");
            dataGridView1.DataSource = sa;
            dataGridView1.DataMember = "student";


            conn.Close();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {


            conn.Open();
            OleDbDataAdapter con = new OleDbDataAdapter("select * from student", conn);
            DataSet sa = new DataSet();
            con.Fill(sa, "student");
            dataGridView1.DataSource = sa;
            dataGridView1.DataMember = "student";


            
            dataGridView1.Refresh();
            dataGridView1.Update();
            conn.Close();


           // conn.Close();

        }

        private void txtbox_serach_TextChanged(object sender, EventArgs e)
        {
            conn.Open();
            OleDbDataAdapter con = new OleDbDataAdapter("select * from student where ID like '" + txtbox_serach.Text + "' ", conn);
            DataTable sa = new DataTable();
            con.Fill(sa);
            dataGridView1.DataSource = sa;
            conn.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           /* conn.Open();
            OleDbDataAdapter con = new OleDbDataAdapter("select * from student where Section like '"+comboBox2.Text+"' ", conn);
            DataTable sa = new DataTable();
            con.Fill(sa);
            dataGridView1.DataSource = sa;
            conn.Close();
            */
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           // conn.Open();
           // OleDbCommand cm = conn.CreateCommand();
            //cm.CommandType = CommandType.Text;
            //cm.CommandText = "select * from student where ID='" + txtbox_serach.Text + "' and Section='" + txtbox_serach.Text + "'";
            //cm.ExecuteNonQuery();

            //DataTable dt = new DataTable();
            //OleDbDataAdapter da = new OleDbDataAdapter(cm);
            //da.Fill(dt);
            //dataGridView1.DataSource = dt;
            //conn.Close();
        }
      



    }
}
