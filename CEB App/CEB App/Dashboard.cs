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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void customDesign()
        {
            pnl_btnSubmenu.Visible = false;
        }

        private void showSubmenu(Panel subMenu)
        {
            if(subMenu.Visible == false)
            {
                hideSubmenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }

        }

        private void hideSubmenu()
        {
            if(pnl_btnSubmenu.Visible == true)
            {
                pnl_btnSubmenu.Visible = false;
            }
            
        }


        private void showSubmenu1(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubmenu1();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }

        }

        private void hideSubmenu1()
        {
            if (pnl_domSubmenu.Visible == true)
            {
                pnl_domSubmenu.Visible = false;
            }

        }

        private Form activeForm=null;

        private void openChildForm(Form ChildForm)
        {   if (activeForm != null)
         
            
            activeForm.Close();
            activeForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            pnl_right.Controls.Add(ChildForm);
            pnl_right.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            customDesign();
        }

        private void btn_billCalculator_Click(object sender, EventArgs e)
        {
            showSubmenu(pnl_btnSubmenu);
        }

        private void btn_domCat_1_Click(object sender, EventArgs e)
        {
            showSubmenu1(pnl_domSubmenu); 
        }

        private void btn_indCatI_1_Click(object sender, EventArgs e)
        {
            openChildForm(new frm_indCatI_1());
        }

        private void btn_genCatGp_1_Click(object sender, EventArgs e)
        {
            openChildForm(new frm_genCatGP_1());
        }

        private void btn_hotCatH_1_Click(object sender, EventArgs e)
        {
            openChildForm(new frm_hotCatH_1()); 
        }

        private void btn_govGv_1_Click(object sender, EventArgs e)
        {
            openChildForm(new frm_govCatGv_1());
        }

        private void btn_cal_Click(object sender, EventArgs e)
        {
            openChildForm(new frm_domCal());
        }

        private void btn_billrate_Click(object sender, EventArgs e)
        {
            openChildForm(new frm_domBilrate());
        }

        private void btn_relCatR_1_Click(object sender, EventArgs e)
        {
            openChildForm(new frm_RelCatR_1());
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            openChildForm(new frm_register());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openChildForm(new Users());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new Feedback());
        }
    }
}
