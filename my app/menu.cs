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

namespace my_app
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void menu_Load(object sender, EventArgs e)
        {
            var loggedInUser = GlobalVariable.LoggedInUser;
            btn_del.Visible = false;
            label13.Visible = false;
            //btn_updatestudent.Enabled = false;
            
            p.Visible = false;
            label11.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            panel1.Visible = false;
            panel2.Visible = false;
            txtpass.Visible = false;
            txtuser.Visible = false;
            btnlogin.Visible = false;
            btncancel.Visible = false;
            panel3.Visible = false;
            btn_editgrade.Visible = false;
            label14.Visible = false;
            
            label6.Text = loggedInUser.Rows[0].Field<string>("username");

            label9.Text = DateTime.Now.ToString("MMM-dd-yyyy");
            label8.Text = DateTime.Now.ToString("hh:mm tt");

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer sp = new SpeechSynthesizer();
            sp.Speak(label1.Text);
            this.Hide();
            Form1 f1= new Form1();
            f1.ShowDialog();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer sp = new SpeechSynthesizer();
            sp.Speak(label2.Text);
            this.Hide();
            register r = new register();
            r.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            admincon a = new admincon();
            a.ShowDialog();

        }

        private void btn_updatestudent_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer sp = new SpeechSynthesizer();
            sp.Speak(label4.Text);
            this.Hide();
            edit f1= new edit();
            f1.ShowDialog();
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer sp = new SpeechSynthesizer();
            sp.Speak(label3.Text);
            this.Hide();
            admincon f5 = new admincon();
            f5.ShowDialog();
        }

        private void btn_admin_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer s = new SpeechSynthesizer();
            s.Speak(label10.Text);
            s.Speak(label11.Text);


            btn_updatestudent.Enabled = true;
            p.Visible = true;
            label11.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            panel1.Visible = true;
            panel2.Visible = true;
            txtpass.Visible = true;
            txtuser.Visible = true;
            btnlogin.Visible = true;
            btncancel.Visible = true;
            panel3.Visible = true;
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer s = new SpeechSynthesizer();
            s.Speak(label15.Text);
            //btn_updatestudent.Enabled = false;
            p.Visible = false;
            label11.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            panel1.Visible = false;
            panel2.Visible = false;
            txtpass.Visible = false;
            txtuser.Visible = false;
            btnlogin.Visible = false;
            btncancel.Visible = false;
            panel3.Visible = false;

            SpeechSynthesizer dd = new SpeechSynthesizer();
            dd.Speak("wala");
        
        }


        private void btnlogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtuser.Text == String.Empty || txtpass.Text == String.Empty)
                {
                    SpeechSynthesizer s = new SpeechSynthesizer();
                    s.Speak(label18.Text);
                    MessageBox.Show("Please Enter Data!", "Message");
                }
                else
                {
                    var loginResult = DataAccessLayer.GetRecords("SELECT * FROM UserAccount where Username = '" + txtuser.Text + "'and [Pass]='" + txtpass.Text + "'");

                    if (loginResult.Rows.Count == 0)
                    {
                        SpeechSynthesizer s = new SpeechSynthesizer();
                        s.Speak(label17.Text);
                        MessageBox.Show("Invalid Credentials!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                        
                    }
                    else
                    {

                        SpeechSynthesizer s = new SpeechSynthesizer();
                        
                        
                        GlobalVariable.LoggedInUser = loginResult;


                        StringBuilder qry = new StringBuilder();
                        qry.AppendLine("INSERT INTO UserLogs ");
                        qry.AppendLine("(");
                        qry.AppendLine("UserId,");
                        qry.AppendLine("Activity,");
                        qry.AppendLine("LogDate");
                        qry.AppendLine(") VALUES (");
                        qry.AppendLine("'" + loginResult.Rows[0].Field<int>("ID").ToString() + "',");
                        qry.AppendLine("'" + Class1.Activity.LOGIN.ToString() + "',");
                        qry.AppendLine("'" + DateTime.Now.ToString("MMM-dd-yyyy hh:mm:ss tt") + "'");
                        qry.AppendLine(")");
                        DataAccessLayer.ExecuteNonQuery(qry.ToString());

                        SpeechSynthesizer sa = new SpeechSynthesizer();
                        sa.Speak(label16.Text);
                        MessageBox.Show("Log-in Successful!","Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                       /* this.Hide();
                        load loading = new load();
                        loading.Show();*/
                        p.Visible = false;
                        label11.Visible = false;
                        pictureBox2.Visible = false;
                        pictureBox3.Visible = false;
                        panel1.Visible = false;
                        panel2.Visible = false;
                        txtpass.Visible = false;
                        txtuser.Visible = false;
                        btnlogin.Visible = false;
                        btncancel.Visible = false;
                        panel3.Visible = false;
                        btn_del.Visible = true;
                        label13.Visible = true;
                        label10.Visible = false;
                        btn_admin.Visible = false;
                        btn_editgrade.Visible = false;
                        label14.Visible = false;
                    
                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed due to " + ex.Message, "Message");
            }




        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            SpeechSynthesizer s = new SpeechSynthesizer();
            s.Speak(label12.Text);
            this.Hide();
            grade g = new grade();
            g.Show();
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer s = new SpeechSynthesizer();
            s.Speak(label13.Text);
             deluser d = new deluser();
            d.Show();
        }

        private void btn_editgrade_Click(object sender, EventArgs e)
        {

        }
        
    }
}
