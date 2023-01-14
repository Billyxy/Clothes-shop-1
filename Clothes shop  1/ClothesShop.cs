using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clothes_shop__1
{
    public partial class ClothesShop : Form
    {    
        

        public ClothesShop()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizd_Click(object sender, EventArgs e)
        {
            WindowState= FormWindowState.Minimized;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            panelHome.BringToFront();
            

        }

        private void btncategory_Click(object sender, EventArgs e)
        {
            panelCategory.BringToFront();
        }

        private void btnWallt_Click(object sender, EventArgs e)
        {
            panelWallt.BringToFront();
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            panelCart.BringToFront();
        }

        private void btnuserProfile_Click(object sender, EventArgs e)
        {
            panelUserProfile.BringToFront();
        }

        private void btnsetting_Click(object sender, EventArgs e)
        {
            panelSetting.BringToFront();
        }

        private void btnBackCategory_Click(object sender, EventArgs e)
        {
            panelHome.BringToFront();
        }

        private void btnBackWallt_Click(object sender, EventArgs e)
        {
            panelHome.BringToFront();
        }

        private void btnBackCart_Click(object sender, EventArgs e)
        {
            panelHome.BringToFront();
        }

        private void btnBackUserProfile_Click(object sender, EventArgs e)
        {
            panelHome.BringToFront();
        }

        private void btnBackSetting_Click(object sender, EventArgs e)
        {
            panelHome.BringToFront();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
              
           Welcom wel = new Welcom();
             
            wel.Show();
            this.Close();
            
        }

        private void panelViwe_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblblouse1_Click(object sender, EventArgs e)
        {

        }

        private void panelHomeHome_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2VScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }
    }
}
