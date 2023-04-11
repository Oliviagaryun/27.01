namespace UI_21
{
    partial class Frm_Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Game));
            this.btn_Stand = new System.Windows.Forms.Button();
            this.Btn_Hit = new System.Windows.Forms.Button();
            this.Btn_Return = new System.Windows.Forms.Button();
            this.lbl_TotalBet = new System.Windows.Forms.Label();
            this.lbl_cardVal = new System.Windows.Forms.Label();
            this.Pb_backOfCard = new System.Windows.Forms.PictureBox();
            this.Pb_PLY_DealtCard1 = new System.Windows.Forms.PictureBox();
            this.Pb_PLY_DealtCard2 = new System.Windows.Forms.PictureBox();
            this.btn_hint = new System.Windows.Forms.Button();
            this.Pb_PLY_DealtCard3 = new System.Windows.Forms.PictureBox();
            this.Pb_PLY_DealtCard4 = new System.Windows.Forms.PictureBox();
            this.Pb_PLY_DealtCard5 = new System.Windows.Forms.PictureBox();
            this.Pb_Dealer_DealtCard5 = new System.Windows.Forms.PictureBox();
            this.Pb_Dealer_DealtCard4 = new System.Windows.Forms.PictureBox();
            this.Pb_Dealer_DealtCard3 = new System.Windows.Forms.PictureBox();
            this.Pb_Dealer_DealtCard2 = new System.Windows.Forms.PictureBox();
            this.Pb_Dealer_DealtCard1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_backOfCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_PLY_DealtCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_PLY_DealtCard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_PLY_DealtCard3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_PLY_DealtCard4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_PLY_DealtCard5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Dealer_DealtCard5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Dealer_DealtCard4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Dealer_DealtCard3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Dealer_DealtCard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Dealer_DealtCard1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Stand
            // 
            this.btn_Stand.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Stand.BackgroundImage")));
            this.btn_Stand.Location = new System.Drawing.Point(167, 210);
            this.btn_Stand.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Stand.Name = "btn_Stand";
            this.btn_Stand.Size = new System.Drawing.Size(82, 22);
            this.btn_Stand.TabIndex = 0;
            this.btn_Stand.Text = "Stand";
            this.btn_Stand.UseVisualStyleBackColor = true;
            this.btn_Stand.Click += new System.EventHandler(this.btn_stand);
            // 
            // Btn_Hit
            // 
            this.Btn_Hit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Hit.BackgroundImage")));
            this.Btn_Hit.Location = new System.Drawing.Point(472, 210);
            this.Btn_Hit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Hit.Name = "Btn_Hit";
            this.Btn_Hit.Size = new System.Drawing.Size(82, 22);
            this.Btn_Hit.TabIndex = 1;
            this.Btn_Hit.Text = "Hit";
            this.Btn_Hit.UseVisualStyleBackColor = true;
            this.Btn_Hit.Click += new System.EventHandler(this.Btn_Hit_Click);
            // 
            // Btn_Return
            // 
            this.Btn_Return.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.Btn_Return.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn_Return.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Btn_Return.Location = new System.Drawing.Point(10, 9);
            this.Btn_Return.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Return.Name = "Btn_Return";
            this.Btn_Return.Size = new System.Drawing.Size(108, 32);
            this.Btn_Return.TabIndex = 9;
            this.Btn_Return.Text = "RETURN";
            this.Btn_Return.UseVisualStyleBackColor = false;
            this.Btn_Return.Click += new System.EventHandler(this.Btn_Return_Click);
            // 
            // lbl_TotalBet
            // 
            this.lbl_TotalBet.AutoSize = true;
            this.lbl_TotalBet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(100)))), ((int)(((byte)(62)))));
            this.lbl_TotalBet.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_TotalBet.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_TotalBet.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_TotalBet.Location = new System.Drawing.Point(391, 33);
            this.lbl_TotalBet.Name = "lbl_TotalBet";
            this.lbl_TotalBet.Size = new System.Drawing.Size(44, 25);
            this.lbl_TotalBet.TabIndex = 12;
            this.lbl_TotalBet.Text = "////";
            this.lbl_TotalBet.Click += new System.EventHandler(this.lbl_TotalBet_Click);
            // 
            // lbl_cardVal
            // 
            this.lbl_cardVal.AutoSize = true;
            this.lbl_cardVal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(100)))), ((int)(((byte)(62)))));
            this.lbl_cardVal.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_cardVal.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_cardVal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_cardVal.Location = new System.Drawing.Point(472, 234);
            this.lbl_cardVal.Name = "lbl_cardVal";
            this.lbl_cardVal.Size = new System.Drawing.Size(23, 20);
            this.lbl_cardVal.TabIndex = 14;
            this.lbl_cardVal.Text = "//";
            this.lbl_cardVal.Click += new System.EventHandler(this.lbl_PlayerTotal);
            // 
            // Pb_backOfCard
            // 
            this.Pb_backOfCard.BackColor = System.Drawing.Color.Transparent;
            this.Pb_backOfCard.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Pb_backOfCard.BackgroundImage")));
            this.Pb_backOfCard.Location = new System.Drawing.Point(164, 41);
            this.Pb_backOfCard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Pb_backOfCard.Name = "Pb_backOfCard";
            this.Pb_backOfCard.Size = new System.Drawing.Size(97, 160);
            this.Pb_backOfCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pb_backOfCard.TabIndex = 15;
            this.Pb_backOfCard.TabStop = false;
            this.Pb_backOfCard.Click += new System.EventHandler(this.BackofCard);
            // 
            // Pb_PLY_DealtCard1
            // 
            this.Pb_PLY_DealtCard1.BackColor = System.Drawing.Color.DarkRed;
            this.Pb_PLY_DealtCard1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Pb_PLY_DealtCard1.Location = new System.Drawing.Point(271, 219);
            this.Pb_PLY_DealtCard1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Pb_PLY_DealtCard1.Name = "Pb_PLY_DealtCard1";
            this.Pb_PLY_DealtCard1.Size = new System.Drawing.Size(97, 162);
            this.Pb_PLY_DealtCard1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Pb_PLY_DealtCard1.TabIndex = 16;
            this.Pb_PLY_DealtCard1.TabStop = false;
            this.Pb_PLY_DealtCard1.Click += new System.EventHandler(this.Pb_DealtCard1_Click);
            // 
            // Pb_PLY_DealtCard2
            // 
            this.Pb_PLY_DealtCard2.BackColor = System.Drawing.Color.Goldenrod;
            this.Pb_PLY_DealtCard2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Pb_PLY_DealtCard2.Location = new System.Drawing.Point(294, 219);
            this.Pb_PLY_DealtCard2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Pb_PLY_DealtCard2.Name = "Pb_PLY_DealtCard2";
            this.Pb_PLY_DealtCard2.Size = new System.Drawing.Size(85, 122);
            this.Pb_PLY_DealtCard2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pb_PLY_DealtCard2.TabIndex = 17;
            this.Pb_PLY_DealtCard2.TabStop = false;
            this.Pb_PLY_DealtCard2.Click += new System.EventHandler(this.Pb_DealtCard2_Click);
            // 
            // btn_hint
            // 
            this.btn_hint.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_hint.BackgroundImage")));
            this.btn_hint.Location = new System.Drawing.Point(205, 236);
            this.btn_hint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_hint.Name = "btn_hint";
            this.btn_hint.Size = new System.Drawing.Size(45, 38);
            this.btn_hint.TabIndex = 18;
            this.btn_hint.Text = ".";
            this.btn_hint.UseVisualStyleBackColor = true;
            this.btn_hint.Click += new System.EventHandler(this.btn_hint_Click);
            // 
            // Pb_PLY_DealtCard3
            // 
            this.Pb_PLY_DealtCard3.BackColor = System.Drawing.Color.Khaki;
            this.Pb_PLY_DealtCard3.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.Pb_PLY_DealtCard3.Location = new System.Drawing.Point(318, 219);
            this.Pb_PLY_DealtCard3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Pb_PLY_DealtCard3.Name = "Pb_PLY_DealtCard3";
            this.Pb_PLY_DealtCard3.Size = new System.Drawing.Size(85, 122);
            this.Pb_PLY_DealtCard3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pb_PLY_DealtCard3.TabIndex = 19;
            this.Pb_PLY_DealtCard3.TabStop = false;
            this.Pb_PLY_DealtCard3.Click += new System.EventHandler(this.Pb_DealtCard3_Click);
            // 
            // Pb_PLY_DealtCard4
            // 
            this.Pb_PLY_DealtCard4.BackColor = System.Drawing.Color.LimeGreen;
            this.Pb_PLY_DealtCard4.Location = new System.Drawing.Point(340, 219);
            this.Pb_PLY_DealtCard4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Pb_PLY_DealtCard4.Name = "Pb_PLY_DealtCard4";
            this.Pb_PLY_DealtCard4.Size = new System.Drawing.Size(85, 122);
            this.Pb_PLY_DealtCard4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pb_PLY_DealtCard4.TabIndex = 20;
            this.Pb_PLY_DealtCard4.TabStop = false;
            this.Pb_PLY_DealtCard4.Click += new System.EventHandler(this.Pb_DealtCard4_Click);
            // 
            // Pb_PLY_DealtCard5
            // 
            this.Pb_PLY_DealtCard5.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Pb_PLY_DealtCard5.Location = new System.Drawing.Point(361, 219);
            this.Pb_PLY_DealtCard5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Pb_PLY_DealtCard5.Name = "Pb_PLY_DealtCard5";
            this.Pb_PLY_DealtCard5.Size = new System.Drawing.Size(85, 122);
            this.Pb_PLY_DealtCard5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pb_PLY_DealtCard5.TabIndex = 21;
            this.Pb_PLY_DealtCard5.TabStop = false;
            this.Pb_PLY_DealtCard5.Click += new System.EventHandler(this.Pb_DealtCard5_Click);
            // 
            // Pb_Dealer_DealtCard5
            // 
            this.Pb_Dealer_DealtCard5.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Pb_Dealer_DealtCard5.Location = new System.Drawing.Point(404, 2);
            this.Pb_Dealer_DealtCard5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Pb_Dealer_DealtCard5.Name = "Pb_Dealer_DealtCard5";
            this.Pb_Dealer_DealtCard5.Size = new System.Drawing.Size(85, 122);
            this.Pb_Dealer_DealtCard5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pb_Dealer_DealtCard5.TabIndex = 26;
            this.Pb_Dealer_DealtCard5.TabStop = false;
            this.Pb_Dealer_DealtCard5.Click += new System.EventHandler(this.Pb_Dealer_DealtCard5_Click);
            // 
            // Pb_Dealer_DealtCard4
            // 
            this.Pb_Dealer_DealtCard4.BackColor = System.Drawing.Color.LimeGreen;
            this.Pb_Dealer_DealtCard4.Location = new System.Drawing.Point(382, 2);
            this.Pb_Dealer_DealtCard4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Pb_Dealer_DealtCard4.Name = "Pb_Dealer_DealtCard4";
            this.Pb_Dealer_DealtCard4.Size = new System.Drawing.Size(85, 122);
            this.Pb_Dealer_DealtCard4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pb_Dealer_DealtCard4.TabIndex = 25;
            this.Pb_Dealer_DealtCard4.TabStop = false;
            // 
            // Pb_Dealer_DealtCard3
            // 
            this.Pb_Dealer_DealtCard3.BackColor = System.Drawing.Color.Khaki;
            this.Pb_Dealer_DealtCard3.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.Pb_Dealer_DealtCard3.Location = new System.Drawing.Point(360, 2);
            this.Pb_Dealer_DealtCard3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Pb_Dealer_DealtCard3.Name = "Pb_Dealer_DealtCard3";
            this.Pb_Dealer_DealtCard3.Size = new System.Drawing.Size(85, 122);
            this.Pb_Dealer_DealtCard3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pb_Dealer_DealtCard3.TabIndex = 24;
            this.Pb_Dealer_DealtCard3.TabStop = false;
            // 
            // Pb_Dealer_DealtCard2
            // 
            this.Pb_Dealer_DealtCard2.BackColor = System.Drawing.Color.Goldenrod;
            this.Pb_Dealer_DealtCard2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Pb_Dealer_DealtCard2.Location = new System.Drawing.Point(337, 2);
            this.Pb_Dealer_DealtCard2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Pb_Dealer_DealtCard2.Name = "Pb_Dealer_DealtCard2";
            this.Pb_Dealer_DealtCard2.Size = new System.Drawing.Size(85, 122);
            this.Pb_Dealer_DealtCard2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pb_Dealer_DealtCard2.TabIndex = 23;
            this.Pb_Dealer_DealtCard2.TabStop = false;
            // 
            // Pb_Dealer_DealtCard1
            // 
            this.Pb_Dealer_DealtCard1.BackColor = System.Drawing.Color.DarkRed;
            this.Pb_Dealer_DealtCard1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Pb_Dealer_DealtCard1.Location = new System.Drawing.Point(314, 2);
            this.Pb_Dealer_DealtCard1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Pb_Dealer_DealtCard1.Name = "Pb_Dealer_DealtCard1";
            this.Pb_Dealer_DealtCard1.Size = new System.Drawing.Size(97, 162);
            this.Pb_Dealer_DealtCard1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pb_Dealer_DealtCard1.TabIndex = 22;
            this.Pb_Dealer_DealtCard1.TabStop = false;
            this.Pb_Dealer_DealtCard1.Click += new System.EventHandler(this.Pb_Dealer_DealtCard1_Click);
            // 
            // Frm_Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.Pb_Dealer_DealtCard5);
            this.Controls.Add(this.Pb_Dealer_DealtCard4);
            this.Controls.Add(this.Pb_Dealer_DealtCard3);
            this.Controls.Add(this.Pb_Dealer_DealtCard2);
            this.Controls.Add(this.Pb_Dealer_DealtCard1);
            this.Controls.Add(this.Pb_PLY_DealtCard5);
            this.Controls.Add(this.Pb_PLY_DealtCard4);
            this.Controls.Add(this.Pb_PLY_DealtCard3);
            this.Controls.Add(this.btn_hint);
            this.Controls.Add(this.Pb_PLY_DealtCard2);
            this.Controls.Add(this.Pb_PLY_DealtCard1);
            this.Controls.Add(this.Pb_backOfCard);
            this.Controls.Add(this.lbl_cardVal);
            this.Controls.Add(this.lbl_TotalBet);
            this.Controls.Add(this.Btn_Return);
            this.Controls.Add(this.Btn_Hit);
            this.Controls.Add(this.btn_Stand);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Frm_Game";
            this.Text = "Frm_Game";
            this.Load += new System.EventHandler(this.Frm_Game_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pb_backOfCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_PLY_DealtCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_PLY_DealtCard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_PLY_DealtCard3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_PLY_DealtCard4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_PLY_DealtCard5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Dealer_DealtCard5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Dealer_DealtCard4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Dealer_DealtCard3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Dealer_DealtCard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Dealer_DealtCard1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Button button2;
        private Button Btn_Return;
        private Button btn_Stand;
        private Button Btn_Hit;
        private Label lbl_TotalBet;
        private Label lbl_cardVal;
        private PictureBox Pb_backOfCard;
        private PictureBox Pb_PLY_DealtCard1;
        private PictureBox Pb_PLY_DealtCard2;
        private Button btn_hint;
        private PictureBox Pb_PLY_DealtCard3;
        private PictureBox Pb_PLY_DealtCard4;
        private PictureBox Pb_PLY_DealtCard5;
        private PictureBox Pb_Dealer_DealtCard5;
        private PictureBox Pb_Dealer_DealtCard4;
        private PictureBox Pb_Dealer_DealtCard3;
        private PictureBox Pb_Dealer_DealtCard2;
        private PictureBox Pb_Dealer_DealtCard1;
    }
}