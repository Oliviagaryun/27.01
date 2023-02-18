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
            this.txtLoginUsername = new System.Windows.Forms.TextBox();
            this.txtLoginPassword = new System.Windows.Forms.TextBox();
            this.Pb_loginTitle = new System.Windows.Forms.PictureBox();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_login)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_loginTitle)).BeginInit();
            this.SuspendLayout();
            // 
            // Pb_login
            // 
            this.Pb_login.Location = new System.Drawing.Point(234, 126);
            this.Pb_login.Name = "Pb_login";
            this.Pb_login.Size = new System.Drawing.Size(439, 206);
            this.Pb_login.TabIndex = 0;
            this.Pb_login.TabStop = false;
            // 
            // txtLoginUsername
            // 
            this.txtLoginUsername.Location = new System.Drawing.Point(513, 171);
            this.txtLoginUsername.Name = "txtLoginUsername";
            this.txtLoginUsername.Size = new System.Drawing.Size(125, 27);
            this.txtLoginUsername.TabIndex = 1;
            this.txtLoginUsername.TextChanged += new System.EventHandler(this.txtLoginUsername_TextChanged);
            // 
            // txtLoginPassword
            // 
            this.txtLoginPassword.Location = new System.Drawing.Point(513, 227);
            this.txtLoginPassword.Name = "txtLoginPassword";
            this.txtLoginPassword.Size = new System.Drawing.Size(125, 27);
            this.txtLoginPassword.TabIndex = 2;
            this.txtLoginPassword.TextChanged += new System.EventHandler(this.txtLoginPassword_TextChanged);
            // 
            // Pb_loginTitle
            // 
            this.Pb_loginTitle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Pb_loginTitle.BackgroundImage")));
            this.Pb_loginTitle.Location = new System.Drawing.Point(316, 12);
            this.Pb_loginTitle.Name = "Pb_loginTitle";
            this.Pb_loginTitle.Size = new System.Drawing.Size(150, 108);
            this.Pb_loginTitle.TabIndex = 3;
            this.Pb_loginTitle.TabStop = false;
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.Location = new System.Drawing.Point(404, 171);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(75, 20);
            this.lbl_Username.TabIndex = 4;
            this.lbl_Username.Text = "Username";
            this.lbl_Username.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Location = new System.Drawing.Point(404, 227);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(70, 20);
            this.lbl_Password.TabIndex = 5;
            this.lbl_Password.Text = "Password";
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(254, 146);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(94, 29);
            this.btnRegister.TabIndex = 6;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.register_Click);
            // 
            // Frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_Username);
            this.Controls.Add(this.Pb_loginTitle);
            this.Controls.Add(this.txtLoginPassword);
            this.Controls.Add(this.txtLoginUsername);
            this.Controls.Add(this.Pb_login);
            this.Name = "Frm_Login";
            this.Text = "Frm_Login";
            ((System.ComponentModel.ISupportInitialize)(this.Pb_login)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_loginTitle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox Pb_login;
        private TextBox txtLoginUsername;
        private TextBox txtLoginPassword;
        private PictureBox Pb_loginTitle;
        private Label lbl_Username;
        private Label lbl_Password;
        private Button btnRegister;
    }
}