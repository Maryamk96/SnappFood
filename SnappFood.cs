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
    public partial class SnappFood : Form
    {
        public SnappFood()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Login login = new Login();
            login.ShowDialog();
            if (login.DialogResult != System.Windows.Forms.DialogResult.OK)
            {
                Application.ExitThread();
            }
            if(Login.flag==1)
            {
                menuStrip1.Items["A1"].Enabled = false;
                menuStrip1.Items["A1"].Visible = false;
            }
            if(Login.flag==2)
            {
                menuStrip1.Items["A1"].Enabled = false;
                menuStrip1.Items["A1"].Visible = false;
            }

            label1.BackColor = System.Drawing.Color.Transparent;
            label2.BackColor = System.Drawing.Color.Transparent;
            label3.BackColor = System.Drawing.Color.Transparent;
            label4.BackColor = System.Drawing.Color.Transparent;
            label5.BackColor = System.Drawing.Color.Transparent;
            label6.BackColor = System.Drawing.Color.Transparent;
            label7.BackColor = System.Drawing.Color.Transparent;
            label8.BackColor = System.Drawing.Color.Transparent;
            label9.BackColor = System.Drawing.Color.Transparent;
            label10.BackColor = System.Drawing.Color.Transparent;
            label11.BackColor = System.Drawing.Color.Transparent;
           
            // groupBox1.BackColor = System.Drawing.Color.Transparent;
            groupBox1.BackColor = Color.FromArgb(88, label1.BackColor);
            groupBox2.BackColor = System.Drawing.Color.Transparent;
            groupBox3.BackColor = Color.FromArgb(88, label1.BackColor);
            groupBox4.BackColor = Color.FromArgb(88, label1.BackColor);
            groupBox5.BackColor = Color.FromArgb(88, label1.BackColor);
            groupBox6.BackColor = Color.FromArgb(88, label1.BackColor);

            //Tooltip
            ToolTip tip = new ToolTip();
            tip.SetToolTip(button1, ".کلیک کنید");
            tip.SetToolTip(label4, ".جهت ورود به برنامه و یا عضویت کلیک کنید ");

           
           /* if (Login.flag == 1)
            {
                menuStrip1.Items["A1"].Enabled = false;
                menuStrip1.Items["B1"].Enabled = false;
                menuStrip1.Items["A1"].Visible = false;
                menuStrip1.Items["B1"].Visible = false;
            }*/

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(comboBox1.Text))
            {
                errorProvider1.SetError(comboBox1, "فیلد شهر نمی تواند خالی باشد");
            }
            else if (string.IsNullOrEmpty(comboBox2.Text))
            {
                errorProvider1.SetError(comboBox2, "فیلد محله نمی تواند خالی باشد");
            }
            else if (string.IsNullOrEmpty(comboBox3.Text))
            {
                errorProvider1.SetError(comboBox3, "فیلد غذا نمی تواند خالی باشد");
            }
            
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            Super_Market market = new Super_Market();
            market.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Coffee_Shop coffee = new Coffee_Shop();
            coffee.Show();
        }

        private void label10_Click(object sender, EventArgs e)
        {
           // SnappFood snapp = new SnappFood();
           // snapp.Visible = false;
            Confectionery Sweets = new Confectionery();
            Sweets.Show();
           // this.Hide();
            
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Restaurant res = new Restaurant();
            res.Show();
        }

   
    }
}
