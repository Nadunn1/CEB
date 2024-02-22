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
    public partial class frm_genCatGP_1 : Form
    {
        double charge_before_300 = 18.30;
        double charge_after_300 = 22.75;
        double fixed_charge = 240;
        double max_demandCharge = 0;
        double before_300;
        double after_300;
        double total_charge;

        public frm_genCatGP_1()
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

                if (units_consumed < 301 && units_consumed >= 0)
                {
                    before_300 = units_consumed * charge_before_300;
                    lbl_1.Text = before_300.ToString();
                    lbl_2.Text = "0";
                    lbl_3.Text = fixed_charge.ToString();
                    total_charge = before_300 + fixed_charge;
                    lbl_4.Text = total_charge.ToString();
                    pnl_result.Visible = true;
                    tb_units.Text = "";

                }
                else if (units_consumed > 300)
                {
                    before_300 = 300 * charge_before_300;
                    after_300 = (units_consumed - 300) * charge_after_300;

                    lbl_1.Text = "300 * " + (charge_before_300.ToString()) + " = " + (before_300.ToString());
                    lbl_2.Text = after_300.ToString();
                    lbl_3.Text = fixed_charge.ToString();
                    total_charge = before_300 + after_300 + fixed_charge;
                    lbl_4.Text = total_charge.ToString();
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

        private void frm_genCatGP_1_Load(object sender, EventArgs e)
        {

            lbl_t_1.Text = charge_before_300.ToString();
            lbl_t_2.Text = charge_after_300.ToString();
            lbl_t_3.Text = fixed_charge.ToString();
            lbl_t_4.Text = max_demandCharge.ToString();
        }
    }
}
