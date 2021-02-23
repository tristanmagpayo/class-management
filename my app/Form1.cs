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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            //comboBox1.Items.Add("Sunday");
            //comboBox1.Items.Add("Monday");
            //comboBox1.Items.Add("Tuesday");
           // SpeechSynthesizer sp = new SpeechSynthesizer();
           // sp.Speak(label1.Text);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer sp = new SpeechSynthesizer();
            sp.Speak(label5.Text);
            DialogResult exit = MessageBox.Show("Do You Want To Close This Program?", "Alert",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            
            if (DialogResult.Yes == exit)
            {
                Application.Exit();
                SpeechSynthesizer s = new SpeechSynthesizer();
                s.Speak(label8.Text);

            }
            else
            {

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                if (textBox1.Text == String.Empty || textBox2.Text == String.Empty)
                {
                   
                    SpeechSynthesizer s = new SpeechSynthesizer();
                    s.Speak(label9.Text);

                    MessageBox.Show("Please Enter Data!", "Message");
                }
                else
                {
                    var loginResult = DataAccessLayer.GetRecords("SELECT * FROM UserAccount where username = '" + textBox1.Text + "'and [Password]='" + textBox2.Text + "'");

                    if (loginResult.Rows.Count == 0)
                    {
                       
                        SpeechSynthesizer s = new SpeechSynthesizer();
                        s.Speak(label4.Text);

                        MessageBox.Show("Invalid Credentials!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                    }
                    else
                    {
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
                        SpeechSynthesizer sp = new SpeechSynthesizer();
                        sp.Speak(label3.Text);
                        sp.Speak(label7.Text);

                        MessageBox.Show("Log-in Successful!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        

                        this.Hide();
                        load loading = new load();
                        loading.Show();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed due to " + ex.Message, "Message");
            }

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SpeechSynthesizer sp = new SpeechSynthesizer();
            sp.Speak(label10.Text);
            this.Hide();
            ADMINREG AD = new ADMINREG();
            AD.Show();
        }
        
    
        
    
    }

}
