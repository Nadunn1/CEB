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
    public partial class frm_domBilrate : Form
    {
        double charge_0_30_if_below_60KWh = 2.50;
        double charge_31_60_if_below_60KWh = 4.85;

        double fixed_charge_0_30_if_below_60KWh = 30.00;
        double fixed_charge_31_60_if_below_60KWh = 60.00;



        double charge_0_60_if_above_60KWh = 7.85;
        double fixed_charge_0_60_if_above_60KWh = 0;
        double charge_61_90_if_above_60KWh = 10.00;
        double fixed_charge_61_90_if_above_60KWh = 90.00;
        double charge_91_120_if_above_60KWh = 27.75;
        double fixed_charge_91_120_if_above_60KWh = 480.00;
        double charge_121_180_if_above_60KWh = 32.00;
        double fixed_charge_121_180_if_above_60KWh = 480.00;
        double charge_180_infinity_if_above_60KWh = 45.00;
        double fixed_charge_180_infinity_if_above_60KWh = 540.00;

        public frm_domBilrate()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frm_domBilrate_Load(object sender, EventArgs e)
        {
            lbl_t1_1.Text= charge_0_30_if_below_60KWh.ToString();
            lbl_t1_2.Text = charge_31_60_if_below_60KWh.ToString();
            lbl_t1_3.Text = fixed_charge_0_30_if_below_60KWh.ToString();
            lbl_t1_4.Text = fixed_charge_31_60_if_below_60KWh.ToString();


            lbl_t2_1.Text = charge_0_60_if_above_60KWh.ToString();
            lbl_t2_2.Text = charge_61_90_if_above_60KWh.ToString();
            lbl_t2_3.Text = charge_91_120_if_above_60KWh.ToString();
            lbl_t2_4.Text = charge_121_180_if_above_60KWh.ToString();
            lbl_t2_5.Text = charge_180_infinity_if_above_60KWh.ToString();

            lbl_t2_6.Text = fixed_charge_0_60_if_above_60KWh.ToString();
            lbl_t2_7.Text = fixed_charge_61_90_if_above_60KWh.ToString();
            lbl_t2_8.Text = fixed_charge_91_120_if_above_60KWh.ToString();
            lbl_t2_9.Text = fixed_charge_121_180_if_above_60KWh.ToString();
            lbl_t2_10.Text = fixed_charge_180_infinity_if_above_60KWh.ToString();

        }
    }
}
