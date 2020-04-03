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
        int valueP = 30;
        int valueT = 0;
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

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            this.timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            valueP+=2;
            bunifuCircleProgressbar1.Value = valueP;
            if(bunifuCircleProgressbar1.Value >= 100)
            {
                bunifuCircleProgressbar1.Value = 0;
                timer1.Stop();
                MessageBox.Show("Valor é 100", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            this.timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            valueT += 2;
            bunifuGauge1.Value = valueT;
            if (bunifuGauge1.Value >= 100)
            {
                bunifuGauge1.Value = 0;
                timer2.Stop();
                MessageBox.Show("Valor é 100", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void bunifuProgressBar1_progressChanged(object sender, EventArgs e)
        {
            
        }
    }
}
