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
    public partial class addmember : Form
    {
        SqlConnection con = new SqlConnection("server =DESKTOP-9U7JFHJ;DataBase=SnappFood ; Integrated Security=true");
        public addmember()
        {
            InitializeComponent();
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nametext.Text))
            {
                errorProvider1.SetError(nametext, ".فیلد مربوطه نمی تواند خالی باشد");
            }
            else if (string.IsNullOrWhiteSpace(familytext.Text))
            {
                errorProvider1.SetError(familytext, ".فیلد مربوطه نمی تواند خالی باشد");
            }
            else if (string.IsNullOrWhiteSpace(usertext.Text))
            {
                errorProvider1.SetError(usertext, ".فیلد مربوطه نمی تواند خالی باشد");
            }
            else if (string.IsNullOrWhiteSpace(passtext.Text))
            {
                errorProvider1.SetError(passtext, ".فیلد مربوطه نمی تواند خالی باشد");
            }
            else if (string.IsNullOrWhiteSpace(telltext.Text))
            {
                errorProvider1.SetError(telltext, ".فیلد مربوطه نمی تواند خالی باشد");
            }
            else if (string.IsNullOrWhiteSpace(emailtext.Text))
            {
                errorProvider1.SetError(emailtext, ".فیلد مربوطه نمی تواند خالی باشد");
            }
            else if (string.IsNullOrWhiteSpace(addresstext.Text))
            {
                errorProvider1.SetError(addresstext, ".فیلد مربوطه نمی تواند خالی باشد");
            }
            else if (string.IsNullOrWhiteSpace(cardtext.Text))
            {
                errorProvider1.SetError(cardtext, ".فیلد مربوطه نمی تواند خالی باشد");
            }
            else
            {
                SqlCommand command = new SqlCommand("addmember", con);
                command.CommandType = CommandType.StoredProcedure;
                //set parametr
                command.Parameters.AddWithValue("@name", nametext.Text);
                command.Parameters.AddWithValue("@family", familytext.Text);
                command.Parameters.AddWithValue("@user", usertext.Text);
                command.Parameters.AddWithValue("@pass", passtext.Text);
                command.Parameters.AddWithValue("@tell", telltext.Text);
                command.Parameters.AddWithValue("@address", addresstext.Text);
                command.Parameters.AddWithValue("@card", cardtext.Text);
                //open connection
                con.Open();
                command.ExecuteNonQuery();
                //close connection
                con.Close();
                MessageBox.Show(".عضو اسنپ فود شدید");
                nametext.ResetText();
                familytext.ResetText();
                usertext.ResetText();
                passtext.ResetText();
                telltext.ResetText();
                addresstext.ResetText();
                cardtext.ResetText();
                nametext.Focus();
            }

        }
    }
}
