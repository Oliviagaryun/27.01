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
            this.SuspendLayout();
            // 
            // Btn_chip1
            // 
            resources.ApplyResources(this.Btn_chip1, "Btn_chip1");
            this.Btn_chip1.Name = "Btn_chip1";
            // 
            // Btn_chip5
            // 
            resources.ApplyResources(this.Btn_chip5, "Btn_chip5");
            this.Btn_chip5.Name = "Btn_chip5";
            // 
            // Btn_chip100
            // 
            resources.ApplyResources(this.Btn_chip100, "Btn_chip100");
            this.Btn_chip100.Name = "Btn_chip100";
            // 
            // Btn_Chip500
            // 
            resources.ApplyResources(this.Btn_Chip500, "Btn_Chip500");
            this.Btn_Chip500.Name = "Btn_Chip500";
            // 
            // Btn_MM
            // 
            resources.ApplyResources(this.Btn_MM, "Btn_MM");
            this.Btn_MM.Name = "Btn_MM";
            // 
            // Btn_Bet
            // 
            resources.ApplyResources(this.Btn_Bet, "Btn_Bet");
            this.Btn_Bet.Name = "Btn_Bet";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            // 
            // Frm_Betting
            // 
            this.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this, "$this");
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
    }
}