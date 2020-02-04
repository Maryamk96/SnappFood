using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SnappFood
{
    public partial class Confectionery : Form
    {
        SqlConnection con = new SqlConnection("server =DESKTOP-9U7JFHJ;DataBase=SnappFood ; Integrated Security=true");
        public Confectionery()
        {
            InitializeComponent();
        }

        

        private void Confectionery_Load(object sender, EventArgs e)
        {
          /*  SqlDataAdapter seldata = new SqlDataAdapter("selectAdmin", con);
            seldata.SelectCommand.CommandType = CommandType.StoredProcedure;
            //return table
            DataTable table = new DataTable();
            seldata.Fill(table);
            dataGridView1.DataSource = table;*/

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
