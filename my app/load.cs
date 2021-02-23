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
    public partial class load : Form
    {
        public load()
        {
            InitializeComponent();
        }

        private void load_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pb_loading.Value != 100)
            {
                
                pb_loading.Increment(2);
                lbl_loading.Text = pb_loading.Value.ToString() + "%";
               
            }
            else
            {
                
                
                timer1.Stop();
                this.Hide();
                menu m= new menu();
                m.Show();
            }
        }

        private void pb_loading_Click(object sender, EventArgs e)
        {

        }

        private void load_Load_1(object sender, EventArgs e)
        {
            SpeechSynthesizer s = new SpeechSynthesizer();
            s.Speak(label2.Text);
        }
    }
}
