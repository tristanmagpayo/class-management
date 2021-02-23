using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace my_app
{
    public partial class deluser : Form
    {
        public deluser()
        {
            InitializeComponent();
        }

        private void deluser_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu me = new menu();
            me.Show();
        }

        private void btn_users_Click(object sender, EventArgs e)
        {
            this.Hide();
            view_delete v = new view_delete();
            v.Show();
        }

        private void btn_student_Click(object sender, EventArgs e)
        {
            this.Hide();
            delstudent d = new delstudent();
            d.Show();
        }
    }
}
