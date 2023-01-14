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
    public partial class Welcom : Form
    {
        public  ClothesShop my = new ClothesShop();
          
        public Welcom()
        {
          
            InitializeComponent();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            string X = "admin";
            if (txtUserName.Text == X & txtPassword.Text == X)
            {
                my.Show();




            }
            else { MessageBox.Show("The username or password is incorrect"); }
        }
      /*  private void btnLogin_Click(object sender, EventArgs e)
        {
            string X = "admin";
            if (txtUserName.Text == X & txtPassword.Text == X ) 
            {       my.Show();       }
            else { MessageBox.Show("The username or password is incorrect"); }
         } */   

        private void button1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Welcom_Load(object sender, EventArgs e)
        {

        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        
    }
}
