namespace UI_21
{
    partial class Frm_Betting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Betting));
            this.Btn_chip1 = new System.Windows.Forms.Button();
            this.Btn_chip10 = new System.Windows.Forms.Button();
            this.Btn_chip50 = new System.Windows.Forms.Button();
            this.Btn_chip100 = new System.Windows.Forms.Button();
            this.Btn_Chip500 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Btn_MM = new System.Windows.Forms.Button();
            this.Btn_clear = new System.Windows.Forms.Button();
            this.Btn_Bet = new System.Windows.Forms.Button();
            this.lbl_TotalBet = new System.Windows.Forms.Label();
            this.lbl_Bank = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn_chip1
            // 
            this.Btn_chip1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.Btn_chip1, "Btn_chip1");
            this.Btn_chip1.Name = "Btn_chip1";
            this.Btn_chip1.UseVisualStyleBackColor = false;
            this.Btn_chip1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Btn_chip10
            // 
            this.Btn_chip10.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.Btn_chip10, "Btn_chip10");
            this.Btn_chip10.Name = "Btn_chip10";
            this.Btn_chip10.UseVisualStyleBackColor = false;
            this.Btn_chip10.Click += new System.EventHandler(this.Btn_chip10_Click);
            // 
            // Btn_chip50
            // 
            this.Btn_chip50.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.Btn_chip50, "Btn_chip50");
            this.Btn_chip50.Name = "Btn_chip50";
            this.Btn_chip50.UseVisualStyleBackColor = false;
            this.Btn_chip50.Click += new System.EventHandler(this.Btn_chip50_Click);
            // 
            // Btn_chip100
            // 
            this.Btn_chip100.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.Btn_chip100, "Btn_chip100");
            this.Btn_chip100.ForeColor = System.Drawing.Color.Black;
            this.Btn_chip100.Name = "Btn_chip100";
            this.Btn_chip100.UseVisualStyleBackColor = false;
            this.Btn_chip100.Click += new System.EventHandler(this.Btn_chip100_Click);
            // 
            // Btn_Chip500
            // 
            this.Btn_Chip500.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.Btn_Chip500, "Btn_Chip500");
            this.Btn_Chip500.ForeColor = System.Drawing.Color.Black;
            this.Btn_Chip500.Name = "Btn_Chip500";
            this.Btn_Chip500.UseVisualStyleBackColor = false;
            this.Btn_Chip500.Click += new System.EventHandler(this.Btn_Chip500_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox1.Name = "textBox1";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Btn_MM
            // 
            this.Btn_MM.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.Btn_MM.ForeColor = System.Drawing.SystemColors.ButtonFace;
            resources.ApplyResources(this.Btn_MM, "Btn_MM");
            this.Btn_MM.Name = "Btn_MM";
            this.Btn_MM.UseVisualStyleBackColor = false;
            this.Btn_MM.Click += new System.EventHandler(this.Btn_MM_Click);
            // 
            // Btn_clear
            // 
            this.Btn_clear.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.Btn_clear.ForeColor = System.Drawing.SystemColors.ButtonFace;
            resources.ApplyResources(this.Btn_clear, "Btn_clear");
            this.Btn_clear.Name = "Btn_clear";
            this.Btn_clear.UseVisualStyleBackColor = false;
            this.Btn_clear.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Btn_Bet
            // 
            resources.ApplyResources(this.Btn_Bet, "Btn_Bet");
            this.Btn_Bet.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_Bet.Name = "Btn_Bet";
            this.Btn_Bet.UseVisualStyleBackColor = true;
            this.Btn_Bet.Click += new System.EventHandler(this.Btn_Bet_Click);
            // 
            // lbl_TotalBet
            // 
            resources.ApplyResources(this.lbl_TotalBet, "lbl_TotalBet");
            this.lbl_TotalBet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(100)))), ((int)(((byte)(62)))));
            this.lbl_TotalBet.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_TotalBet.Name = "lbl_TotalBet";
            this.lbl_TotalBet.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lbl_Bank
            // 
            resources.ApplyResources(this.lbl_Bank, "lbl_Bank");
            this.lbl_Bank.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(100)))), ((int)(((byte)(62)))));
            this.lbl_Bank.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_Bank.Name = "lbl_Bank";
            this.lbl_Bank.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // Frm_Betting
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_Bank);
            this.Controls.Add(this.lbl_TotalBet);
            this.Controls.Add(this.Btn_Bet);
            this.Controls.Add(this.Btn_clear);
            this.Controls.Add(this.Btn_MM);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Btn_Chip500);
            this.Controls.Add(this.Btn_chip100);
            this.Controls.Add(this.Btn_chip50);
            this.Controls.Add(this.Btn_chip10);
            this.Controls.Add(this.Btn_chip1);
            this.Name = "Frm_Betting";
            this.Load += new System.EventHandler(this.form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button Btn_chip1;
        private Button Btn_chip10;
        private Button Btn_chip50;
        private Button Btn_chip100;
        private Button Btn_Chip500;
        private TextBox textBox1;
        private Button Btn_MM;
        private Button Btn_clear;
        private Button Btn_History;
        private Button Btn_Bet;
        public Label lbl_TotalBet;
        public Label lbl_Bank;
    }
}