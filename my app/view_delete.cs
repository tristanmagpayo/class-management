using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech;
using System.Speech.Synthesis;
using System.Data.OleDb;


namespace my_app
{
    public partial class view_delete : Form
    {
        private const string conString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Admin\Desktop\New folder\my app\my app\MANSMS,DATABASE.mdb";
        OleDbCommand cmd;
        OleDbDataAdapter adapter;
        readonly DataTable dt = new DataTable();
        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Admin\Desktop\New folder\my app\my app\MANSMS,DATABASE.mdb");
          
        public view_delete()
        {
            InitializeComponent();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer sp = new SpeechSynthesizer();
           // sp.Speak(label12.Text);
            this.Hide();
            menu f = new menu();
            f.ShowDialog();
        }

        private void txtbox_serach_TextChanged(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Admin\Desktop\New folder\my app\my app\MANSMS,DATABASE.mdb");
            
            conn.Open();
            OleDbDataAdapter con = new OleDbDataAdapter("select * from UserAcount where ID like '" + txtbox_serach.Text + "' ", conn);
            DataTable sa = new DataTable();
            con.Fill(sa);
            dataGridView1.DataSource = sa;
            conn.Close();
        }

        private void view_delete_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_MANSMS_DATABASEDataSet3.UserAccount' table. You can move, or remove it, as needed.
            this.userAccountTableAdapter5.Fill(this._MANSMS_DATABASEDataSet3.UserAccount);
            // TODO: This line of code loads data into the '_MANSMS_DATABASEDataSet2.UserAccount' table. You can move, or remove it, as needed.
            this.userAccountTableAdapter4.Fill(this._MANSMS_DATABASEDataSet2.UserAccount);
            // TODO: This line of code loads data into the '_MANSMS_DATABASEDataSet1.UserAccount' table. You can move, or remove it, as needed.
            this.userAccountTableAdapter3.Fill(this._MANSMS_DATABASEDataSet1.UserAccount);
            // TODO: This line of code loads data into the '_MANSMS_DATABASEDataSet.UserAccount' table. You can move, or remove it, as needed.
            this.userAccountTableAdapter2.Fill(this._MANSMS_DATABASEDataSet.UserAccount);
            // TODO: This line of code loads data into the 'nstp_DataSet13.UserAccount' table. You can move, or remove it, as needed.
            this.userAccountTableAdapter1.Fill(this.nstp_DataSet13.UserAccount);
            // TODO: This line of code loads data into the 'nstp_DataSet12.UserAccount' table. You can move, or remove it, as needed.
            OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Admin\Desktop\New folder\my app\my app\MANSMS,DATABASE.mdb");
            gridview_data();
            dataGridView1.Refresh();
            this.Refresh();
            dataGridView1.RefreshEdit();
            conn.Open();
            OleDbDataAdapter con = new OleDbDataAdapter("select * from UserAccount", conn);
            DataTable sa = new DataTable();
            con.Fill(sa);
            dataGridView1.DataSource = sa;
            gridview_data();
            conn.Close();
        }

        public void gridview_data()
        {
            conn.Open();
            OleDbDataAdapter con = new OleDbDataAdapter("select * from UserAccount", conn);
            DataSet sa = new DataSet();
            con.Fill(sa, "UserAccount");
            dataGridView1.DataSource = sa;
            dataGridView1.DataMember = "UserAccount";


            conn.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            conn.Open();
            OleDbDataAdapter con = new OleDbDataAdapter("select * from UserAccount", conn);
            DataSet sa = new DataSet();
            con.Fill(sa, "UserAccount");
            dataGridView1.DataSource = sa;
            dataGridView1.DataMember = "UserAccount";
            conn.Close();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            int selectedIndex = dataGridView1.SelectedRows[0].Index;
            if (selectedIndex != -1)
            {
                String selected = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                int id = Convert.ToInt32(selected);
                delete(id);
            }
        }

        private void delete(int id)
        {
            //SQL STATEMENTT
            String sql = "DELETE FROM UserAccount WHERE ID=" + id + "";
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Admin\Desktop\New folder\my app\my app\MANSMS,DATABASE.mdb");
        }
    }
}
