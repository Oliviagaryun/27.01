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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Btn_MM = new System.Windows.Forms.Button();
            this.Btn_Bet = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
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
            // Btn_chip5
            // 
            this.Btn_chip5.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.Btn_chip5, "Btn_chip5");
            this.Btn_chip5.Name = "Btn_chip5";
            this.Btn_chip5.UseVisualStyleBackColor = false;
            this.Btn_chip5.Click += new System.EventHandler(this.Btn_chip25_Click);
            // 
            // Btn_chip100
            // 
            this.Btn_chip100.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.Btn_chip100, "Btn_chip100");
            this.Btn_chip100.ForeColor = System.Drawing.Color.Black;
            this.Btn_chip100.Name = "Btn_chip100";
            this.Btn_chip100.UseVisualStyleBackColor = false;
            this.Btn_chip100.Click += new System.EventHandler(this.Btn_chip50_Click);
            // 
            // Btn_Chip500
            // 
            this.Btn_Chip500.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.Btn_Chip500, "Btn_Chip500");
            this.Btn_Chip500.ForeColor = System.Drawing.Color.Black;
            this.Btn_Chip500.Name = "Btn_Chip500";
            this.Btn_Chip500.UseVisualStyleBackColor = false;
            this.Btn_Chip500.Click += new System.EventHandler(this.Btn_Chip100_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.textBox1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            resources.ApplyResources(this.textBox1, "textBox1");
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
            // Btn_Bet
            // 
            this.Btn_Bet.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            resources.ApplyResources(this.Btn_Bet, "Btn_Bet");
            this.Btn_Bet.Name = "Btn_Bet";
            this.Btn_Bet.UseVisualStyleBackColor = true;
            this.Btn_Bet.Click += new System.EventHandler(this.Btn_Bet_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.button1, "button1");
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_3);
            // 
            // Frm_Betting
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Btn_Bet);
            this.Controls.Add(this.Btn_MM);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Btn_Chip500);
            this.Controls.Add(this.Btn_chip100);
            this.Controls.Add(this.Btn_chip5);
            this.Controls.Add(this.Btn_chip1);
            this.Name = "Frm_Betting";
            this.Load += new System.EventHandler(this.form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button Btn_chip1;
        private Button Btn_chip5;
        private Button Btn_chip100;
        private Button Btn_Chip500;
        private TextBox textBox1;
        private Button Btn_MM;
        private Button Btn_History;
        private Button Btn_Bet;
        private Button button1;
    }
}