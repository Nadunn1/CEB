using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CEB_App
{
    public partial class frm_hotCatH_1 : Form
    {

        double charge = 21.50;
       
        double fixed_charge = 600;
        double max_demandCharge = 0;
        double chg_forUnits;
        
        double total_charge;



        public frm_hotCatH_1()
        {
            InitializeComponent();
        }

        private void btn_calculate_Click(object sender, EventArgs e)
        {
            string temp = tb_units.Text;
            int value;
            if (int.TryParse(temp, out value))
            {
                int units_consumed = int.Parse(tb_units.Text);

                if (units_consumed >= 0)
                {
                    chg_forUnits = units_consumed * charge;
                    lbl_1.Text = chg_forUnits.ToString();
                    
                    lbl_2.Text = fixed_charge.ToString();

                    total_charge = chg_forUnits + fixed_charge;
                    lbl_3.Text = total_charge.ToString();
                    pnl_result.Visible = true;
                    tb_units.Text = "";

                }
                
                else MessageBox.Show("Please Enter a Valid Number !", "Invalid Number", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            }
            else
            {
                MessageBox.Show("Please Enter a Valid Number !", "Invalid Number", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }

        }

       
      private void frm_hotCatH_1_Load_1(object sender, EventArgs e)
        {

           
            lbl_t_1.Text = charge.ToString();
            lbl_t_2.Text = fixed_charge.ToString();
            lbl_t_3.Text = max_demandCharge.ToString();
        }
    }
}
