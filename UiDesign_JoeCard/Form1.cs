using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UiDesign_JoeCard.Properties;

namespace UiDesign_JoeCard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            this.button1.BackgroundImage = Resources.CloseBlack2;
            this.button1.BackColor = Color.Transparent;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            this.button1.BackgroundImage = Resources.CloseWhite2;
            this.button1.BackColor = Color.Red;
        }


        private void btnDrawer_Click(object sender, EventArgs e)
        {
            if (sideMenu.Width == 50)
            {
                LogoVertAnimator.HideSync(LogoVertical);
                sideMenu.Visible = false;
                sideMenu.Width = 250;
                PanelAnimator.ShowSync(sideMenu);
                LogoAnimator.ShowSync(logo);
            }
            else
            {
                LogoAnimator.HideSync(logo);
                sideMenu.Visible = false;
                sideMenu.Width = 50;
                PanelAnimator.ShowSync(sideMenu);
                LogoVertAnimator.ShowSync(LogoVertical);
            }

        }

        private void bunifuGradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton2_Click_1(object sender, EventArgs e)
        {   

        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {

        }

        private void Mural_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
 
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
