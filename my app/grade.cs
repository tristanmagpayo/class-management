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
    public partial class grade : Form
    {
        private const string conString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Admin\Desktop\New folder\my app\nstp .accdb";
        readonly OleDbConnection con = new OleDbConnection(conString);
        OleDbCommand cmd;
        OleDbDataAdapter adapter;
        readonly DataTable dt = new DataTable();
        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Admin\Desktop\New folder\my app\nstp .accdb");
        public grade()
            
        {
            InitializeComponent();
        }

        private void grade_Load(object sender, EventArgs e)
        {
            var loggedInUser = GlobalVariable.LoggedInUser;
            txt_average.Enabled = false;
            OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Admin\Desktop\New folder\my app\nstp .accdb");
           // gridview_data();
           // dataGridView1.Refresh();
            this.Refresh();
            //dataGridView1.RefreshEdit();
            conn.Open();
            OleDbDataAdapter con = new OleDbDataAdapter("select * from student", conn);
            DataTable sa = new DataTable();
            con.Fill(sa);

            //gridview_data();
            conn.Close();
            label6.Text = loggedInUser.Rows[0].Field<string>("username");

            label9.Text = DateTime.Now.ToString("MMM-dd-yyyy");
            label8.Text = DateTime.Now.ToString("hh:mm tt");

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (txt_prilem.Text == String.Empty || txt_midterm.Text == String.Empty || txt_finals.Text == string.Empty)
            {
                MessageBox.Show("Please input Data!", "Message");
            }
            else
            {
                double ave;
                double prelem;
                double mid;
                double finals;

                prelem = double.Parse(txt_prilem.Text);

                mid = double.Parse(txt_midterm.Text);

                finals = double.Parse(txt_finals.Text);

                // ave = double.Parse(txt_average.Text);
                ave = prelem + mid + finals;
                ave = ave / 3;

                txt_average.Text = ave.ToString();


            }


        }

        private void txtbox_ID_TextChanged(object sender, EventArgs e)

        {

            conn.Open();
            OleDbDataAdapter con = new OleDbDataAdapter("select * from student where ID like '" + txtbox_ID.Text + "' ", conn);
            DataTable sa = new DataTable();
            con.Fill(sa);
            dataGridView1.DataSource = sa;
            conn.Close();
           // OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Admin\Desktop\New folder\my app\nstp .accdb");
           // conn.Open();
           // OleDbDataAdapter con = new OleDbDataAdapter("select * from student where ID like '" + txtbox_ID.Text + "' ", conn);
           // DataTable sa = new DataTable();
           // con.Fill(sa);
           // dataGridView1.DataSource = sa;
          //  conn.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
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

            
            /* Convert.ToInt32(txtbox_ID.Text);
           nstp_DataSet8 dc = new nstp_DataSet8();
            var get = dc.student.Where(a => a.ID == txtbox_ID.Text).SingleOrDefault();
           txtbox_ID.Text = get.ID;
            txtbox_surename.Text = get.Surname;
            txtbox_surename.Text = get.Surname;
            txtbox_MI.Text = get.MI;
            txtbox_sem.Text = get.Semester;
            txtbox_yr.Text = get.Date;
            txtbox_course.Text = get.Course;
            txtbox_year.Text = get.Year;
            txtbox_status.Text = get.Status;
            txt_prilem.Text = get.Prilem;
            txt_midterm.Text = get.Midterm;
            txt_finals.Text = get.Finals;
            txt_average.Text = get.Average;
            */
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Admin\Desktop\New folder\my app\nstp .accdb");
            int Selected_row;
            //OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Admin\Desktop\New folder\my app\nstp .accdb");
            if (e.RowIndex >= 0)
            {
                Selected_row = e.RowIndex;
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                txtbox_ID.Text = row.Cells[0].Value.ToString();
                txtbox_surename.Text = row.Cells[1].Value.ToString();
                txtbox_firstname.Text = row.Cells[2].Value.ToString();
                txtbox_MI.Text = row.Cells[3].Value.ToString();
                txtbox_sem.Text = row.Cells[4].Value.ToString();
                txtbox_yr.Text = row.Cells[5].Value.ToString();
                txtbox_course.Text = row.Cells[6].Value.ToString();
                txtbox_year.Text = row.Cells[7].Value.ToString();
                txtbox_status.Text = row.Cells[8].Value.ToString();
                txt_prilem.Text = row.Cells[9].Value.ToString();

                txt_midterm.Text = row.Cells[10].Value.ToString();
                txt_finals.Text = row.Cells[11].Value.ToString();
                txt_average.Text = row.Cells[12].Value.ToString();
                gridview_data();
                this.Refresh();
            }
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
        /*
        private void update(int id,string surname, string name, string propellant, string sem, string date, string course, string yer ,string stat, string pre, string mid, string final, string ave )
        {
            OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Admin\Desktop\New folder\my app\nstp .accdb");
            
            //SQL STATEMENT
            string sql = "UPDATE student SET Average='"+ave+"',Finals'" +final + "'Midterm='"+mid+"',Prilem='"+pre+"'Status='"+stat+"',Year='"+yer+"',Course='"+course+"',Semester='"+sem+"',Surname='" +surname + "' WHERE ID=" + id + "";
            cmd = new OleDbCommand(sql, conn);

            //OPEN CONNECTION,UPDATE,RETRIEVE DATAGRIDVIEW
            try
            {
                conn.Open();
                adapter = new OleDbDataAdapter(cmd)
                {
                    UpdateCommand = con.CreateCommand()
                };
                adapter.UpdateCommand.CommandText = sql;
                if (adapter.UpdateCommand.ExecuteNonQuery() > 0)
                {
                    txtbox_ID.Text = id;
                    txtbox_surename.Text = surname;
                    txtbox_firstname.Text = name;
                    txtbox_MI.Text = propellant;
                    txtbox_year.Text = sem;
                    txtbox_course.Text = date;
                    txtbox_sem.Text = course;
                    txtbox_status.Text = yer;
                    txtbox_status.Text = stat;
                    txtbox_status.Text = pre;
                    txtbox_status.Text = mid;
                    txtbox_status.Text = final;
                    txtbox_status.Text = ave;
                    MessageBox.Show(@"Successfully Updated");
                }
                con.Close();

                //REFRESH DATA
               // retrieve();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }*/
        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txtbox_ID.Text == String.Empty || txtbox_firstname.Text == String.Empty || txtbox_surename.Text == string.Empty)
            {
                MessageBox.Show("Please Click Data!", "Message");
            }
            else
            {
                OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Admin\Desktop\New folder\my app\nstp .accdb");
                conn.Open();
                OleDbCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update student set Prilem ='" + txt_prilem.Text + "',Midterm='" + txt_midterm.Text + "',Finals='" + txt_finals.Text + "', Average='" + txt_average.Text + "' where ID ='" + txtbox_ID.Text + "'";
                cmd.ExecuteNonQuery();
                conn.Close();
                SpeechSynthesizer sp = new SpeechSynthesizer();
                sp.Speak(label13.Text);
                MessageBox.Show("Profile Successfuly Saved!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gridview_data();
                this.Refresh();
                dataGridView1.Refresh();

                txtbox_ID.Text = "";
                txtbox_surename.Text = "";
                txtbox_firstname.Text = "";
                txtbox_MI.Text = "";
                txtbox_year.Text = "";
                txtbox_course.Text = "";
                txtbox_sem.Text = "";
                txtbox_status.Text = "";

            }
            /*leDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Admin\Desktop\New folder\my app\nstp .accdb");
            int Selected_row;
            int selectedIndex = dataGridView1.SelectedRows[0].Index;
            if (selectedIndex != -1)
            {

                String selected = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                int id = Convert.ToInt32(selected);
                update(id,surname,name,propellant,sem,date,course,yar,stat,pre,mid,final,ave);
            }

            */

          /*  OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Admin\Desktop\New folder\my app\nstp .accdb");
            conn.Open();
            OleDbCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            string constring =@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Admin\Desktop\New folder\my app\nstp .accdb";
            string que = "update student set Status =(ID='" + this.txtbox_ID.Text + "',Surname='" + this.txtbox_surename.Text + "',Firstname'" + this.txtbox_MI.Text + "', Semester='" + this.txtbox_sem.Text + "', Date='" + txtbox_yr.Text + "', Course='" + txtbox_course.Text + "',Year='" + txtbox_year.Text + "',Status='" + txtbox_status.Text + "',Prilem='" + txt_prilem.Text + "',Midterm='" + txt_midterm.Text + "',Finals='" + txt_finals.Text + "',Average='" + txt_average + "');";
            OleDbConnection conns = new OleDbConnection(constring);
            OleDbCommand com = new OleDbCommand(que,conn);

            OleDbDataReader r;
            conn.Open();
            r = com.ExecuteReader();
           // cmd.CommandText = "update student set Status =(ID='" + this.txtbox_ID.Text + "',Surname='" + this.txtbox_surename.Text + "',Firstname'" + this.txtbox_MI.Text + "', Semester='" + this.txtbox_sem.Text + "', Date='" + txtbox_yr.Text + "', Course='" + txtbox_course.Text + "',Year='" + txtbox_year.Text + "',Status='" + txtbox_status.Text + "',Prilem='" + txt_prilem.Text + "',Midterm='" + txt_midterm.Text + "',Finals='" + txt_finals.Text + "',Average='" + txt_average + "');";
            //cmd.ExecuteNonQuery();
           // conn.Close();
            SpeechSynthesizer sp = new SpeechSynthesizer();
            sp.Speak(label13.Text);
            MessageBox.Show("Profile Successfuly Graded|!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            
            gridview_data();
            this.Refresh();
            dataGridView1.Refresh();
            while (r.Read())
            {



            }
            

            txtbox_ID.Text = "";
            txtbox_surename.Text = "";
            txtbox_firstname.Text = "";
            txtbox_MI.Text = "";
            txtbox_year.Text = "";
            txtbox_course.Text = "";
            txtbox_sem.Text = "";
            txtbox_status.Text = "";
            */
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
             int Selected_row;
            //OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Admin\Desktop\New folder\my app\nstp .accdb");
             if (e.RowIndex >= 0)
             {
                 Selected_row = e.RowIndex;
                 DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                 //txtbox_ID.Text = row.Cells[0].Value.ToString();
                 txtbox_surename.Text = row.Cells[1].Value.ToString();
                 txtbox_firstname.Text = row.Cells[2].Value.ToString();
                 txtbox_MI.Text = row.Cells[3].Value.ToString();
                 txtbox_sem.Text = row.Cells[4].Value.ToString();
                 txtbox_yr.Text = row.Cells[5].Value.ToString();
                 txtbox_course.Text = row.Cells[6].Value.ToString();
                 txtbox_year.Text = row.Cells[7].Value.ToString();
                 txtbox_status.Text = row.Cells[8].Value.ToString();
                 txt_prilem.Text = row.Cells[9].Value.ToString();

                 txt_midterm.Text = row.Cells[10].Value.ToString();
                 txt_finals.Text = row.Cells[11].Value.ToString();
                 txt_average.Text = row.Cells[12].Value.ToString();
                 gridview_data();
                 this.Refresh();
             }
            }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu g = new menu();
            g.Show();
        }


    }
        
    }
