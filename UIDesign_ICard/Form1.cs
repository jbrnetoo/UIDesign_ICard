using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UIDesign_ICard.Properties;

namespace UIDesign_ICard
{
    public partial class Form1 : Form
    {

        int mouseX = 0;
        int mouseY = 0;
        bool mouseDown;

        public Form1()
        {
            InitializeComponent();
            //this.StartPosition = FormStartPosition.Manual;
            //this.Location = new Point(0, 0);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                mouseX = MousePosition.X - 650;
                mouseY = MousePosition.Y - 40;
                this.SetDesktopLocation(mouseX, mouseY);
            }
        }

        private void panel1_MoveDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void maximizeButton_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
                maximizeButton.Image = Resources.NormalBlack;
            }
            else
            {
                WindowState = FormWindowState.Normal;
                maximizeButton.Image = Resources.MaximizedBlack;
            }

        }
    }
}
