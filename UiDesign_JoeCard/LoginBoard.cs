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
    public partial class LoginBoard : Form
    {
        public LoginBoard()
        {
            InitializeComponent();
        }

        private void bunifuCustomTextbox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void userNameText_Enter(object sender, EventArgs e)
        {
            if (userNameText.text.Equals("Usuário"))
            {
                userNameText.text = String.Empty;
            }
        }

        private void userNameText_Leave(object sender, EventArgs e)
        {
            if (userNameText.text.Equals(""))
            {
                userNameText.text = "Usuário";
            }
        }

        private void passwordText_Enter(object sender, EventArgs e)
        {
            if (passwordText.text.Equals("Senha"))
            {
                passwordText.text = String.Empty;
            }
        }

        private void passwordText_Leave(object sender, EventArgs e)
        {
            if (passwordText.text.Equals(""))
            {
                passwordText.text = "Senha";
            }
        }

        private void bunifuImageButton1_MouseEnter(object sender, EventArgs e)
        {
            this.shutDown.Image = Resources.shutdown_red;
            //this.bunifuImageButton1.BackColor = Color.Red;
        }

        private void bunifuImageButton1_MouseLeave(object sender, EventArgs e)
        {
            this.shutDown.Image = Resources.shutdown;
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void userNameText_OnTextChange(object sender, EventArgs e)
        {

        }
    }
}
