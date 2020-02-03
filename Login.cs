using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnappFood
{
    public partial class Login : Form
    {
        public static int flag = 0;
        public Login()
        {
            InitializeComponent();
        }

        
       

       

        private void Login_Load(object sender, EventArgs e)
        {
            label1.BackColor = System.Drawing.Color.Transparent;
            label2.BackColor = System.Drawing.Color.Transparent;
            groupBox1.BackColor = Color.FromArgb(88, label1.BackColor);
            user.BackColor = System.Drawing.Color.Transparent;
            notuser.BackColor = System.Drawing.Color.Transparent;

        }

        private void notuser_CheckedChanged(object sender, EventArgs e)
        {
            textuser.Enabled = false;
            textpass.Enabled = false;
        }

        private void user_CheckedChanged(object sender, EventArgs e)
        {
            
            textuser.Enabled = true;
            textpass.Enabled = true;
            textuser.Focus();
        }
    }
}
