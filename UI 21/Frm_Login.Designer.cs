namespace UI_21
{
    partial class Frm_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Login));
            this.Pb_login = new System.Windows.Forms.PictureBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.Pb_loginTitle = new System.Windows.Forms.PictureBox();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.BTN_Login = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_login)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_loginTitle)).BeginInit();
            this.SuspendLayout();
            // 
            // Pb_login
            // 
            this.Pb_login.Location = new System.Drawing.Point(190, 125);
            this.Pb_login.Name = "Pb_login";
            this.Pb_login.Size = new System.Drawing.Size(439, 240);
            this.Pb_login.TabIndex = 0;
            this.Pb_login.TabStop = false;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(315, 164);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(197, 27);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtLoginUsername_TextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(315, 236);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(197, 27);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtLoginPassword_TextChanged);
            // 
            // Pb_loginTitle
            // 
            this.Pb_loginTitle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Pb_loginTitle.BackgroundImage")));
            this.Pb_loginTitle.Location = new System.Drawing.Point(333, 12);
            this.Pb_loginTitle.Name = "Pb_loginTitle";
            this.Pb_loginTitle.Size = new System.Drawing.Size(150, 108);
            this.Pb_loginTitle.TabIndex = 3;
            this.Pb_loginTitle.TabStop = false;
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.Location = new System.Drawing.Point(383, 141);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(75, 20);
            this.lbl_Username.TabIndex = 4;
            this.lbl_Username.Text = "Username";
            this.lbl_Username.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Location = new System.Drawing.Point(383, 213);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(70, 20);
            this.lbl_Password.TabIndex = 5;
            this.lbl_Password.Text = "Password";
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(258, 304);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(94, 29);
            this.btnRegister.TabIndex = 6;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.register_Click);
            // 
            // BTN_Login
            // 
            this.BTN_Login.Location = new System.Drawing.Point(486, 304);
            this.BTN_Login.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BTN_Login.Name = "BTN_Login";
            this.BTN_Login.Size = new System.Drawing.Size(86, 31);
            this.BTN_Login.TabIndex = 7;
            this.BTN_Login.Text = "Login";
            this.BTN_Login.UseVisualStyleBackColor = true;
            // 
            // Frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 451);
            this.Controls.Add(this.BTN_Login);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_Username);
            this.Controls.Add(this.Pb_loginTitle);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.Pb_login);
            this.Name = "Frm_Login";
            this.Text = "Frm_Login";
            this.Load += new System.EventHandler(this.Frm_Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pb_login)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_loginTitle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox Pb_login;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private PictureBox Pb_loginTitle;
        private Label lbl_Username;
        private Label lbl_Password;
        private Button btnRegister;
        private Button BTN_Login;
    }
}