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
    public partial class ADMINREG : Form
    {
        public ADMINREG()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer sp = new SpeechSynthesizer();
            sp.Speak(label8.Text);
            this.Hide();
         Form1 RE = new Form1();
            RE.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (txtbox_retype.Text == txtbox_Pass.Text)
            {
                if (txtbox_name.Text == String.Empty || textbox_lastname.Text == String.Empty || txtbox_Pass.Text == String.Empty || txtbox_User.Text == String.Empty)
                {
                    SpeechSynthesizer sp = new SpeechSynthesizer();
                    sp.Speak(label10.Text);
                    MessageBox.Show("Please Enter Data!", "Message");
                }
                else
                {

                    var existingUser = DataAccessLayer.GetRecords("SELECT * FROM UserAccount where username = '" + txtbox_User.Text + "'");
                    if (existingUser.Rows.Count > 0)
                    {
                        MessageBox.Show("Username Already Exist!", "Message");
                        return;
                    }


                    StringBuilder qry = new StringBuilder();
                    qry.AppendLine("INSERT INTO UserAccount ");
                    qry.AppendLine("(");
                    qry.AppendLine("username,");
                    qry.AppendLine("[password],");
                    qry.AppendLine("fname,");
                    qry.AppendLine("mi,");
                    qry.AppendLine("lname");
                    qry.AppendLine(") VALUES (");
                    qry.AppendLine("'" + txtbox_User.Text.Trim() + "',");
                    qry.AppendLine("'" + txtbox_Pass.Text.Trim() + "',");
                    qry.AppendLine("'" + txtbox_name.Text.Trim() + "',");
                    qry.AppendLine("'" + txtbox_mi.Text.Trim() + "',");
                    qry.AppendLine("'" + textbox_lastname.Text.Trim() + "'");
                    qry.AppendLine(")");

                    DataAccessLayer.ExecuteNonQuery(qry.ToString());
                    SpeechSynthesizer sp = new SpeechSynthesizer();
                    sp.Speak(label9.Text);
                    MessageBox.Show("Account Successfully Created!", "Message");
                    this.Close();
                    Form1 f1 = new Form1();
                    f1.Show();

                }
            }
        }

        private void ADMINREG_Load(object sender, EventArgs e)
        {

        }
    }
}
