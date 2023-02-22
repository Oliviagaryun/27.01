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
            this.Btn_chip5 = new System.Windows.Forms.Button();
            this.Btn_chip100 = new System.Windows.Forms.Button();
            this.Btn_Chip500 = new System.Windows.Forms.Button();
            this.Btn_MM = new System.Windows.Forms.Button();
            this.Btn_Bet = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_bank = new System.Windows.Forms.Label();
            this.label2_bet = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn_chip1
            // 
            resources.ApplyResources(this.Btn_chip1, "Btn_chip1");
            this.Btn_chip1.Name = "Btn_chip1";
            this.Btn_chip1.Click += new System.EventHandler(this.Btn_chip1_Click);
            // 
            // Btn_chip5
            // 
            resources.ApplyResources(this.Btn_chip5, "Btn_chip5");
            this.Btn_chip5.Name = "Btn_chip5";
            this.Btn_chip5.Click += new System.EventHandler(this.Btn_chip5_Click);
            // 
            // Btn_chip100
            // 
            resources.ApplyResources(this.Btn_chip100, "Btn_chip100");
            this.Btn_chip100.Name = "Btn_chip100";
            this.Btn_chip100.Click += new System.EventHandler(this.Btn_chip100_Click_1);
            // 
            // Btn_Chip500
            // 
            resources.ApplyResources(this.Btn_Chip500, "Btn_Chip500");
            this.Btn_Chip500.Name = "Btn_Chip500";
            this.Btn_Chip500.Click += new System.EventHandler(this.Btn_Chip50_Click);
            // 
            // Btn_MM
            // 
            this.Btn_MM.BackColor = System.Drawing.Color.DimGray;
            resources.ApplyResources(this.Btn_MM, "Btn_MM");
            this.Btn_MM.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_MM.Name = "Btn_MM";
            this.Btn_MM.UseVisualStyleBackColor = false;
            this.Btn_MM.Click += new System.EventHandler(this.Btn_MM_Click_1);
            // 
            // Btn_Bet
            // 
            resources.ApplyResources(this.Btn_Bet, "Btn_Bet");
            this.Btn_Bet.Name = "Btn_Bet";
            this.Btn_Bet.Click += new System.EventHandler(this.Btn_Bet_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // lbl_bank
            // 
            resources.ApplyResources(this.lbl_bank, "lbl_bank");
            this.lbl_bank.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.lbl_bank.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_bank.Name = "lbl_bank";
            // 
            // label2_bet
            // 
            resources.ApplyResources(this.label2_bet, "label2_bet");
            this.label2_bet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(100)))), ((int)(((byte)(62)))));
            this.label2_bet.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2_bet.Name = "label2_bet";
            this.label2_bet.Click += new System.EventHandler(this.lbl_bet);
            // 
            // Frm_Betting
            // 
            this.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.label2_bet);
            this.Controls.Add(this.lbl_bank);
            this.Controls.Add(this.Btn_chip1);
            this.Controls.Add(this.Btn_chip5);
            this.Controls.Add(this.Btn_chip100);
            this.Controls.Add(this.Btn_Chip500);
            this.Controls.Add(this.Btn_MM);
            this.Controls.Add(this.Btn_Bet);
            this.Controls.Add(this.button1);
            this.Name = "Frm_Betting";
            this.Load += new System.EventHandler(this.Frm_Betting_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button Btn_chip1;
        private Button Btn_chip5;
        private Button Btn_chip100;
        private Button Btn_Chip500;
        private Button Btn_MM;
        private Button Btn_History;
        private Button Btn_Bet;
        private Button button1;
        private Label lbl_Bank;
        private Label lbl_bank;
        private Label label2_bet;
    }
}