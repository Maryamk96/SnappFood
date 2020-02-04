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
    public partial class Confectionery : Form
    {
        public Confectionery()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=9C7J2Be07jE");
        }

        private void Confectionery_Load(object sender, EventArgs e)
        {
            
        }

        private void exit_Click(object sender, EventArgs e)
        {
            SnappFood food = new SnappFood();
           // food.Visible = true;
            food.Show();
            this.Close();
        }
    }
}
