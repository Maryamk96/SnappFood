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
    public partial class managemember : Form
    {
        SqlConnection con = new SqlConnection("server =DESKTOP-9U7JFHJ;DataBase=SnappFood ; Integrated Security=true");
        public managemember()
        {
            InitializeComponent();
        }

        private void managemember_Load(object sender, EventArgs e)
        {
            SqlDataAdapter seldata = new SqlDataAdapter("selectinfo", con);
            seldata.SelectCommand.CommandType = CommandType.StoredProcedure;
            //return table
            DataTable table = new DataTable();
            seldata.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("آیا می خواهید کاربر انتخاب شده حذف شود؟", "!هشدار", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                SqlCommand cm = new SqlCommand("deleteinfo", con);
                cm.CommandType = CommandType.StoredProcedure;
                cm.Parameters.AddWithValue("@userid", textBox9.Text.Trim());
                con.Open();
                cm.ExecuteNonQuery();
                con.Close();
                MessageBox.Show(".عملیات حذف با موفقیت انجام گردید");
                //refreshgridview
                managemember_Load(null, null);
                textBox1.Enabled = true;
                button2.Enabled = false;
                button1.Enabled = false;
                addbtn.Enabled = true;
                
            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show(".عملیات حذف لغو گردید");
                //refreshgridview
                managemember_Load(null, null);
                textBox1.Enabled = true;
               // button2.Enabled = false;
              //  button1.Enabled = false;
              //  addbtn.Enabled = true;
            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox9.Enabled = false;
           // button1.Enabled = true;
          //  button2.Enabled = true;
           // addbtn.Enabled = false;
            textBox1.Text = dataGridView1.CurrentRow.Cells["family"].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells["name"].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells["username"].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells["userpass"].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells["usertell"].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells["email"].Value.ToString();
            textBox7.Text = dataGridView1.CurrentRow.Cells["add"].Value.ToString();
            textBox8.Text = dataGridView1.CurrentRow.Cells["card"].Value.ToString();
            textBox9.Text = dataGridView1.CurrentRow.Cells["userid"].Value.ToString();
            textBox10.Text = dataGridView1.CurrentRow.Cells["usertype"].Value.ToString();
            textBox2.Focus();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update1", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@family", textBox1.Text);
            cmd.Parameters.AddWithValue("@name", textBox2.Text);
            cmd.Parameters.AddWithValue("@user", textBox3.Text);
            cmd.Parameters.AddWithValue("@pass", textBox4.Text);
            cmd.Parameters.AddWithValue("@tell", textBox5.Text);
            cmd.Parameters.AddWithValue("@email", textBox6.Text);
            cmd.Parameters.AddWithValue("@address", textBox7.Text);
            cmd.Parameters.AddWithValue("@card", textBox8.Text);
          //  cmd.Parameters.AddWithValue("@userid", textBox9.Text);
            cmd.Parameters.AddWithValue("@usertype", textBox10.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show(".ویرایش با موفقیت انجام شد");
            //refresh
            managemember_Load(null, null);

        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("addmember", con);
            command.CommandType = CommandType.StoredProcedure;
            //set parametr
            command.Parameters.AddWithValue("@name", textBox2.Text);
            command.Parameters.AddWithValue("@family", textBox1.Text);
            command.Parameters.AddWithValue("@user", textBox3.Text);
            command.Parameters.AddWithValue("@pass", textBox4.Text);
            command.Parameters.AddWithValue("@tell", textBox5.Text);
            command.Parameters.AddWithValue("@address", textBox7.Text);
            command.Parameters.AddWithValue("@card", textBox8.Text);
            command.Parameters.AddWithValue("@usertype", textBox10.Text);
            command.Parameters.AddWithValue("@email", textBox6.Text);
            command.Parameters.AddWithValue("@userid", textBox9.Text);

            //open connection
            con.Open();
            command.ExecuteNonQuery();
            //close connection
            con.Close();
            MessageBox.Show(".عضو جدید افزوده شد");
            managemember_Load(null, null);
        }
    }
}
