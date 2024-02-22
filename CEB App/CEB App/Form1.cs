using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;


namespace CEB_App
{
    public partial class frm_register : Form
    {
        SqlConnection conn = new Database().DBConnect();
        public frm_register()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_firstName.Text == "" || txt_lastName.Text == "" || txt_address.Text == "" || txt_nic.Text == "" || txt_phoneNumber.Text=="")
                {
                    MessageBox.Show("Details Cannot be null", "Register", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (txt_phoneNumber.Text.Length == 10)
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("insert into Details values(@F_Name,@L_Name,@Address,@NIC,@Phone)", conn);
                        cmd.Parameters.AddWithValue("@F_Name", txt_firstName.Text);
                        cmd.Parameters.AddWithValue("@L_Name", txt_lastName.Text);
                        cmd.Parameters.AddWithValue("@Address", txt_address.Text);
                        cmd.Parameters.AddWithValue("@NIC", txt_nic.Text);
                        cmd.Parameters.AddWithValue("@Phone", txt_phoneNumber.Text);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Register Completed", "Register", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        txt_firstName.Clear();
                        txt_lastName.Clear();
                        txt_address.Clear();
                        txt_nic.Clear();
                        txt_phoneNumber.Clear();
                        txt_firstName.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Mobile number must be 10 numbers", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        conn.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Found:" + ex.Message, "Register", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }
    }
}
