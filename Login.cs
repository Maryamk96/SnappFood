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

    public partial class Login : Form
    {
        SqlConnection con = new SqlConnection("server =DESKTOP-9U7JFHJ;DataBase=SnappFood ; Integrated Security=true");
        public static int flag = 0;
        public Login()
        {
            InitializeComponent();
        }

        private void man_CheckedChanged(object sender, EventArgs e)
        {
            enterbtn.Enabled = true;
            textuser.Enabled = true;
            textpass.Enabled = true;
            textuser.Focus();
            addbtn.Enabled = false;
        }

        private void user_CheckedChanged(object sender, EventArgs e)
        {
            enterbtn.Enabled = true;
            addbtn.Enabled = false;
            textuser.Enabled = true;
            textpass.Enabled = true;
            textuser.Focus();
            
        }

        private void mehman_CheckedChanged(object sender, EventArgs e)
        {
            enterbtn.Enabled = true;
            addbtn.Enabled = true;
            textuser.Enabled = false;
            textpass.Enabled = false;
        }



        private void enterbtn_Click(object sender, EventArgs e)
        {
            if (mehman.Checked == true)
            {
                flag = 1;
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();

            }

            else if (user.Checked == true)
            {
                flag = 2;
                if (string.IsNullOrWhiteSpace(textuser.Text))
                {
                    errorProvider1.SetError(textuser, "نام کاربری خود را وارد کنید.");
                }
                else if (string.IsNullOrWhiteSpace(textpass.Text))
                {
                    errorProvider1.SetError(textpass, "رمز عبور خود را وارد کنید.");
                }

                else
                {
                    SqlDataAdapter data = new SqlDataAdapter("user_admin", con);
                    data.SelectCommand.CommandType = CommandType.StoredProcedure;
                    data.SelectCommand.Parameters.AddWithValue("@user", textuser.Text.Trim());
                    data.SelectCommand.Parameters.AddWithValue("@pass", textpass.Text.Trim());
                    //return result
                    DataTable da = new DataTable();
                    data.Fill(da);

                    if (da.Rows.Count == 0)
                    {
                        MessageBox.Show(".نام کاربری یا رمز عبور خود را اشتباه وارد کرده اید", "!توجه");
                        textuser.ResetText();
                        textpass.ResetText();
                        textuser.Focus();
                        //reset error provider
                        //////////
                    }
                    else
                    {
                        this.DialogResult = System.Windows.Forms.DialogResult.OK;
                        this.Close();
                    }
                }
            }
            else if (man.Checked == true)
            {
                flag = 0;
                if (string.IsNullOrWhiteSpace(textuser.Text))
                {
                    errorProvider1.SetError(textuser, "نام کاربری خود را وارد کنید.");
                }
                else if (string.IsNullOrWhiteSpace(textpass.Text))
                {
                    errorProvider1.SetError(textpass, "رمز عبور خود را وارد کنید.");
                }

                else
                {
                    SqlDataAdapter data = new SqlDataAdapter("user_admin", con);
                    data.SelectCommand.CommandType = CommandType.StoredProcedure;
                    data.SelectCommand.Parameters.AddWithValue("@user", textuser.Text.Trim());
                    data.SelectCommand.Parameters.AddWithValue("@pass", textpass.Text.Trim());
                    //return result
                    DataTable da = new DataTable();
                    data.Fill(da);

                    if (da.Rows.Count == 0)
                    {
                        MessageBox.Show(".نام کاربری یا رمز عبور خود را اشتباه وارد کرده اید", "!توجه");
                        textuser.ResetText();
                        textpass.ResetText();
                        textuser.Focus();
                        //reset error provider
                        //////////
                    }
                    else
                    {
                        this.DialogResult = System.Windows.Forms.DialogResult.OK;
                        this.Close();
                    }
                }
            }

            
        }

        private void notuser_CheckedChanged(object sender, EventArgs e)
        {
            textuser.Enabled = false;
            textpass.Enabled = false;
            addbtn.Enabled = true;
            enterbtn.Enabled = false;
        
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            addmember add = new addmember();
            add.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }
    }

}