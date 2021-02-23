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
    public partial class delstudent : Form
    {
        private const string conString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Admin\Desktop\New folder\my app\my app\nstp .accdb";
        OleDbCommand cmd;
        OleDbDataAdapter adapter;
        readonly DataTable dt = new DataTable();
        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Admin\Desktop\New folder\my app\my app\nstp .accdb");
          
        public delstudent()
        {
            InitializeComponent();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer sp = new SpeechSynthesizer();
            sp.Speak(label3.Text);
            this.Hide();
            menu f = new menu();
            f.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer sp = new SpeechSynthesizer();
            sp.Speak(label5.Text);
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
            SpeechSynthesizer sp = new SpeechSynthesizer();
            sp.Speak(label6.Text);
            int selectedIndex = dataGridView1.SelectedRows[0].Index;
            if (selectedIndex != -1)
            {
                String selected= dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                int id = Convert.ToInt32(selected);
                delete(id);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Admin\Desktop\New folder\my app\my app\nstp .accdb");
        }

        private void delstudent_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nstp_DataSet16.student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.nstp_DataSet16.student);
            OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Admin\Desktop\New folder\my app\my app\nstp .accdb");
            gridview_data();
            dataGridView1.Refresh();
            this.Refresh();
            dataGridView1.RefreshEdit();
            conn.Open();
            OleDbDataAdapter con = new OleDbDataAdapter("select * from student", conn);
            DataTable sa = new DataTable();
            con.Fill(sa);
            dataGridView1.DataSource = sa;
            gridview_data();
            conn.Close();
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
        private void delete(int id)
        {
            //SQL STATEMENTT
            String sql = "DELETE * FROM student WHERE ID ='" + textBox1.Text + "'";
            cmd = new OleDbCommand(sql, conn);

            //'OPEN CONNECTION,EXECUTE DELETE,CLOSE CONNECTION
            try
            {
                conn.Open();
                adapter = new OleDbDataAdapter(cmd);
                adapter.DeleteCommand = conn.CreateCommand();
                adapter.DeleteCommand.CommandText = sql;

                //PROMPT FOR CONFIRMATION BEFORE DELETING
                if (MessageBox.Show(@"Are you sure to permanently delete this?", @"DELETE", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show(@"Successfully deleted");
                    }
                }
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
        }
    }

}
