using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CEB_App
{
    public partial class Feedback : Form
    {
        SqlConnection conn = new Database().DBConnect();
        public Feedback()
        {
            InitializeComponent();
        }

        private void Feedback_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd1 = new SqlCommand("Select * from feedback", conn);
                SqlDataAdapter adapter1 = new SqlDataAdapter(cmd1);
                DataTable dataTable1 = new DataTable();
                adapter1.Fill(dataTable1);
                dataGridView1.DataSource = dataTable1;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Found" + ex, "Search_button", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt.Text == "")
                {
                    MessageBox.Show("Details Cannot be null", "Register", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("insert into feedback values(@Feedback)", conn);
                        cmd.Parameters.AddWithValue("@Feedback", txt.Text);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Submission Completed", "Register", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        txt.Clear();
                        txt.Focus();
                   
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
