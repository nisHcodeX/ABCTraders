namespace ABCTraders
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.LoginBtn = new System.Windows.Forms.Button();
            this.loginFormUsernameLabel = new System.Windows.Forms.Label();
            this.LoginFormEmail = new System.Windows.Forms.TextBox();
            this.LoginFormPassword = new System.Windows.Forms.TextBox();
            this.loginFormPasswordLabel = new System.Windows.Forms.Label();
            this.LoginFormRegisterLabel = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LoginFormCombo = new System.Windows.Forms.ComboBox();
            this.loginFormUserTypeLabel = new System.Windows.Forms.Label();
            this.loginFormABCLabel = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginBtn
            // 
            this.LoginBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.LoginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBtn.Location = new System.Drawing.Point(33, 477);
            this.LoginBtn.Margin = new System.Windows.Forms.Padding(4);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(353, 50);
            this.LoginBtn.TabIndex = 0;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = false;
            this.LoginBtn.Click += new System.EventHandler(this.LoginFormLoginBtn_Click);
            // 
            // loginFormUsernameLabel
            // 
            this.loginFormUsernameLabel.AutoSize = true;
            this.loginFormUsernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginFormUsernameLabel.Location = new System.Drawing.Point(28, 315);
            this.loginFormUsernameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.loginFormUsernameLabel.Name = "loginFormUsernameLabel";
            this.loginFormUsernameLabel.Size = new System.Drawing.Size(60, 25);
            this.loginFormUsernameLabel.TabIndex = 1;
            this.loginFormUsernameLabel.Text = "Email";
            this.loginFormUsernameLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // LoginFormEmail
            // 
            this.LoginFormEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginFormEmail.Location = new System.Drawing.Point(33, 344);
            this.LoginFormEmail.Margin = new System.Windows.Forms.Padding(4);
            this.LoginFormEmail.Name = "LoginFormEmail";
            this.LoginFormEmail.Size = new System.Drawing.Size(356, 30);
            this.LoginFormEmail.TabIndex = 2;
            this.LoginFormEmail.TextChanged += new System.EventHandler(this.LoginFormEmail_TextChanged);
            // 
            // LoginFormPassword
            // 
            this.LoginFormPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginFormPassword.Location = new System.Drawing.Point(33, 418);
            this.LoginFormPassword.Margin = new System.Windows.Forms.Padding(4);
            this.LoginFormPassword.Name = "LoginFormPassword";
            this.LoginFormPassword.PasswordChar = '*';
            this.LoginFormPassword.Size = new System.Drawing.Size(356, 30);
            this.LoginFormPassword.TabIndex = 4;
            this.LoginFormPassword.TextChanged += new System.EventHandler(this.LoginFormPassword_TextChanged);
            // 
            // loginFormPasswordLabel
            // 
            this.loginFormPasswordLabel.AutoSize = true;
            this.loginFormPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginFormPasswordLabel.Location = new System.Drawing.Point(28, 389);
            this.loginFormPasswordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.loginFormPasswordLabel.Name = "loginFormPasswordLabel";
            this.loginFormPasswordLabel.Size = new System.Drawing.Size(98, 25);
            this.loginFormPasswordLabel.TabIndex = 3;
            this.loginFormPasswordLabel.Text = "Password";
            // 
            // LoginFormRegisterLabel
            // 
            this.LoginFormRegisterLabel.AutoSize = true;
            this.LoginFormRegisterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginFormRegisterLabel.Location = new System.Drawing.Point(97, 551);
            this.LoginFormRegisterLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LoginFormRegisterLabel.Name = "LoginFormRegisterLabel";
            this.LoginFormRegisterLabel.Size = new System.Drawing.Size(211, 20);
            this.LoginFormRegisterLabel.TabIndex = 7;
            this.LoginFormRegisterLabel.TabStop = true;
            this.LoginFormRegisterLabel.Text = "Not a user?  Register Here";
            this.LoginFormRegisterLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LoginFormRegisterLabel_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(33, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(356, 164);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // LoginFormCombo
            // 
            this.LoginFormCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LoginFormCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginFormCombo.FormattingEnabled = true;
            this.LoginFormCombo.Items.AddRange(new object[] {
            "Customer",
            "Admin"});
            this.LoginFormCombo.Location = new System.Drawing.Point(33, 268);
            this.LoginFormCombo.Name = "LoginFormCombo";
            this.LoginFormCombo.Size = new System.Drawing.Size(356, 33);
            this.LoginFormCombo.TabIndex = 8;
            this.LoginFormCombo.SelectedIndexChanged += new System.EventHandler(this.LoginFormCombo_SelectedIndexChanged);
            // 
            // loginFormUserTypeLabel
            // 
            this.loginFormUserTypeLabel.AutoSize = true;
            this.loginFormUserTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginFormUserTypeLabel.Location = new System.Drawing.Point(28, 240);
            this.loginFormUserTypeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.loginFormUserTypeLabel.Name = "loginFormUserTypeLabel";
            this.loginFormUserTypeLabel.Size = new System.Drawing.Size(103, 25);
            this.loginFormUserTypeLabel.TabIndex = 9;
            this.loginFormUserTypeLabel.Text = "User Type";
            this.loginFormUserTypeLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // loginFormABCLabel
            // 
            this.loginFormABCLabel.AutoSize = true;
            this.loginFormABCLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginFormABCLabel.Location = new System.Drawing.Point(131, 607);
            this.loginFormABCLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.loginFormABCLabel.Name = "loginFormABCLabel";
            this.loginFormABCLabel.Size = new System.Drawing.Size(152, 18);
            this.loginFormABCLabel.TabIndex = 10;
            this.loginFormABCLabel.Text = "ABC Traders (Pvt) Ltd";
            this.loginFormABCLabel.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(427, 653);
            this.Controls.Add(this.loginFormABCLabel);
            this.Controls.Add(this.loginFormUserTypeLabel);
            this.Controls.Add(this.LoginFormCombo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LoginFormRegisterLabel);
            this.Controls.Add(this.LoginFormPassword);
            this.Controls.Add(this.loginFormPasswordLabel);
            this.Controls.Add(this.LoginFormEmail);
            this.Controls.Add(this.loginFormUsernameLabel);
            this.Controls.Add(this.LoginBtn);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ABC Traders Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.Label loginFormUsernameLabel;
        private System.Windows.Forms.TextBox LoginFormEmail;
        private System.Windows.Forms.TextBox LoginFormPassword;
        private System.Windows.Forms.Label loginFormPasswordLabel;
        private System.Windows.Forms.LinkLabel LoginFormRegisterLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox LoginFormCombo;
        private System.Windows.Forms.Label loginFormUserTypeLabel;
        private System.Windows.Forms.Label loginFormABCLabel;
        private System.Windows.Forms.ImageList imageList1;
    }
}

