namespace UiDesign_JoeCard
{
    partial class LoginBoard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginBoard));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.userNameText = new Bunifu.Framework.UI.BunifuTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuThinButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.shutDown = new Bunifu.Framework.UI.BunifuImageButton();
            this.passwordText = new Bunifu.Framework.UI.BunifuTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shutDown)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.bunifuGradientPanel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.userNameText);
            this.bunifuGradientPanel1.Controls.Add(this.label2);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuThinButton22);
            this.bunifuGradientPanel1.Controls.Add(this.shutDown);
            this.bunifuGradientPanel1.Controls.Add(this.passwordText);
            this.bunifuGradientPanel1.Controls.Add(this.label1);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Red;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.MistyRose;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.LightCoral;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Firebrick;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(516, 541);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // userNameText
            // 
            this.userNameText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(117)))), ((int)(((byte)(116)))));
            this.userNameText.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("userNameText.BackgroundImage")));
            this.userNameText.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.userNameText.ForeColor = System.Drawing.Color.Azure;
            this.userNameText.Icon = ((System.Drawing.Image)(resources.GetObject("userNameText.Icon")));
            this.userNameText.Location = new System.Drawing.Point(90, 185);
            this.userNameText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.userNameText.Name = "userNameText";
            this.userNameText.Size = new System.Drawing.Size(333, 52);
            this.userNameText.TabIndex = 49;
            this.userNameText.text = "Usuário";
            this.userNameText.OnTextChange += new System.EventHandler(this.userNameText_OnTextChange);
            this.userNameText.Enter += new System.EventHandler(this.userNameText_Enter);
            this.userNameText.Leave += new System.EventHandler(this.userNameText_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Azure;
            this.label2.Location = new System.Drawing.Point(93, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(310, 54);
            this.label2.TabIndex = 48;
            this.label2.Text = "ATOS CAPITAL";
            // 
            // bunifuThinButton22
            // 
            this.bunifuThinButton22.ActiveBorderThickness = 1;
            this.bunifuThinButton22.ActiveCornerRadius = 20;
            this.bunifuThinButton22.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(78)))), ((int)(((byte)(77)))));
            this.bunifuThinButton22.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton22.ActiveLineColor = System.Drawing.Color.Azure;
            this.bunifuThinButton22.BackColor = System.Drawing.Color.Transparent;
            this.bunifuThinButton22.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton22.BackgroundImage")));
            this.bunifuThinButton22.ButtonText = "Entrar";
            this.bunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton22.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton22.ForeColor = System.Drawing.Color.Azure;
            this.bunifuThinButton22.IdleBorderThickness = 1;
            this.bunifuThinButton22.IdleCornerRadius = 20;
            this.bunifuThinButton22.IdleFillColor = System.Drawing.Color.Transparent;
            this.bunifuThinButton22.IdleForecolor = System.Drawing.Color.Azure;
            this.bunifuThinButton22.IdleLineColor = System.Drawing.Color.Azure;
            this.bunifuThinButton22.Location = new System.Drawing.Point(186, 367);
            this.bunifuThinButton22.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton22.Name = "bunifuThinButton22";
            this.bunifuThinButton22.Size = new System.Drawing.Size(138, 51);
            this.bunifuThinButton22.TabIndex = 47;
            this.bunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // shutDown
            // 
            this.shutDown.BackColor = System.Drawing.Color.Transparent;
            this.shutDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.shutDown.ErrorImage = null;
            this.shutDown.Image = global::UiDesign_JoeCard.Properties.Resources.shutdown;
            this.shutDown.ImageActive = global::UiDesign_JoeCard.Properties.Resources.shutdown_red;
            this.shutDown.InitialImage = null;
            this.shutDown.Location = new System.Drawing.Point(434, 469);
            this.shutDown.Name = "shutDown";
            this.shutDown.Size = new System.Drawing.Size(44, 39);
            this.shutDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.shutDown.TabIndex = 45;
            this.shutDown.TabStop = false;
            this.shutDown.Zoom = 10;
            this.shutDown.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            this.shutDown.MouseEnter += new System.EventHandler(this.bunifuImageButton1_MouseEnter);
            this.shutDown.MouseLeave += new System.EventHandler(this.bunifuImageButton1_MouseLeave);
            // 
            // passwordText
            // 
            this.passwordText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(117)))), ((int)(((byte)(116)))));
            this.passwordText.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("passwordText.BackgroundImage")));
            this.passwordText.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.passwordText.ForeColor = System.Drawing.Color.Azure;
            this.passwordText.Icon = ((System.Drawing.Image)(resources.GetObject("passwordText.Icon")));
            this.passwordText.Location = new System.Drawing.Point(90, 273);
            this.passwordText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(333, 52);
            this.passwordText.TabIndex = 43;
            this.passwordText.text = "Senha";
            this.passwordText.Enter += new System.EventHandler(this.passwordText_Enter);
            this.passwordText.Leave += new System.EventHandler(this.passwordText_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(38)))), ((int)(((byte)(37)))));
            this.label1.Location = new System.Drawing.Point(19, 508);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 20);
            this.label1.TabIndex = 39;
            this.label1.Text = "Procurando por atualização...";
            // 
            // LoginBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 541);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginBoard";
            this.Text = "LoginBoard";
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shutDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuImageButton shutDown;
        private Bunifu.Framework.UI.BunifuTextbox passwordText;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton22;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuTextbox userNameText;
    }
}