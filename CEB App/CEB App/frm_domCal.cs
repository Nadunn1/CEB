﻿using System;
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
    public partial class frm_domCal : Form
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

        double charge_0_30;
        double charge_31_60;
        double charge_61_90;
        double charge_91_120;
        double charge_121_180;
        double charge_above_180;
        double total_charge;




        public frm_domCal()
        {
            InitializeComponent();
        }

        private void myMethod1(double fixedCharge)
        {
            lbl_1.Text = charge_0_30.ToString();
            lbl_2.Text = charge_31_60.ToString();
            lbl_3.Text = charge_61_90.ToString();
            lbl_4.Text = charge_91_120.ToString();
            lbl_5.Text = charge_121_180.ToString();
            lbl_6.Text = charge_above_180.ToString();
            lbl_7.Text = fixedCharge.ToString();
            lbl_8.Text = total_charge.ToString();

        }

        private void btn_calculate_Click(object sender, EventArgs e)
        {
            string temp = tb_units.Text;
            int value;
            if (int.TryParse(temp, out value))
            {
                int units_consumed = int.Parse(tb_units.Text);

                if (units_consumed < 61 && units_consumed >= 0)
                {
                    
                   if(units_consumed<= 30)
                    {
                        charge_0_30 = units_consumed * charge_0_30_if_below_60KWh;
                        total_charge = charge_0_30 + fixed_charge_0_30_if_below_60KWh;

                        myMethod1(fixed_charge_31_60_if_below_60KWh);

                        pnl_result.Visible = true;
                        tb_units.Text = "";
                    }
                    else
                    {
                        charge_0_30 = 30 * charge_0_30_if_below_60KWh;
                        charge_31_60 = (units_consumed-30) * fixed_charge_31_60_if_below_60KWh;
                        total_charge = charge_0_30 + charge_31_60+ fixed_charge_0_30_if_below_60KWh;

                        myMethod1(fixed_charge_0_30_if_below_60KWh);

                        pnl_result.Visible = true;
                        tb_units.Text = "";
                    }


                }
                else if (units_consumed > 60)
                {
                    
                    if (units_consumed <= 90)
                    {
                        charge_0_30 = 30 * charge_0_60_if_above_60KWh;
                        charge_31_60 = 30 * charge_0_60_if_above_60KWh;
                        charge_61_90 =  (units_consumed - 60) * charge_61_90_if_above_60KWh;

                        total_charge = charge_0_30 + charge_31_60 +charge_61_90 + fixed_charge_61_90_if_above_60KWh;

                        myMethod1(fixed_charge_61_90_if_above_60KWh);

                        pnl_result.Visible = true;
                        tb_units.Text = "";
                    }
                    else if (units_consumed <= 120)
                    {
                        charge_0_30 = 30 * charge_0_60_if_above_60KWh;
                        charge_31_60 = 30 * charge_0_60_if_above_60KWh;
                        charge_61_90 = 30 * charge_61_90_if_above_60KWh;
                        charge_91_120 = (units_consumed - 90) * charge_91_120_if_above_60KWh;

                        total_charge = charge_0_30 + charge_31_60 + charge_61_90 + charge_91_120 + fixed_charge_91_120_if_above_60KWh;

                        myMethod1(charge_91_120_if_above_60KWh);

                        pnl_result.Visible = true;
                        tb_units.Text = "";
                    }
                    else if (units_consumed <= 180)
                    {
                        charge_0_30 = 30 * charge_0_60_if_above_60KWh;
                        charge_31_60 = 30 * charge_0_60_if_above_60KWh;
                        charge_61_90 = 30 * charge_61_90_if_above_60KWh;
                        charge_91_120 = 30 * charge_91_120_if_above_60KWh;
                        charge_121_180 = (units_consumed - 120) * charge_121_180_if_above_60KWh;

                        total_charge = charge_0_30 + charge_31_60 + charge_61_90 + charge_91_120 + charge_121_180 + fixed_charge_121_180_if_above_60KWh;

                        myMethod1(fixed_charge_121_180_if_above_60KWh);

                        pnl_result.Visible = true;
                        tb_units.Text = "";
                    }
                    else if (units_consumed > 180)
                    {
                        charge_0_30 = 30 * charge_0_60_if_above_60KWh;
                        charge_31_60 = 30 * charge_0_60_if_above_60KWh;
                        charge_61_90 = 30 * charge_61_90_if_above_60KWh;
                        charge_91_120 = 30 * charge_91_120_if_above_60KWh;
                        charge_121_180 = 60 * charge_121_180_if_above_60KWh;
                        charge_above_180 = (units_consumed - 180) * charge_180_infinity_if_above_60KWh;

                        total_charge = charge_0_30 + charge_31_60 + charge_61_90 + charge_91_120 + charge_above_180+ charge_121_180 + fixed_charge_180_infinity_if_above_60KWh;

                        myMethod1(fixed_charge_180_infinity_if_above_60KWh);

                        pnl_result.Visible = true;
                        tb_units.Text = "";
                    }

                }
                else MessageBox.Show("Please Enter a Valid Number !", "Invalid Number", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            }
            else
            {
                MessageBox.Show("Please Enter a Valid Number !", "Invalid Number", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }
    }
}