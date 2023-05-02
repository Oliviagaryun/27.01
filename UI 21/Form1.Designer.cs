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
            this.btn_hint = new System.Windows.Forms.Button();
            this.LBL_DealerTotal = new System.Windows.Forms.Label();
            this.BTN_Start = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_backOfCard)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Stand
            // 
            this.btn_Stand.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.Btn_Hit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.Btn_Return.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.lbl_TotalBet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_TotalBet.AutoSize = true;
            this.lbl_TotalBet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(100)))), ((int)(((byte)(62)))));
            this.lbl_TotalBet.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_TotalBet.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_TotalBet.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_TotalBet.Location = new System.Drawing.Point(167, 295);
            this.lbl_TotalBet.Name = "lbl_TotalBet";
            this.lbl_TotalBet.Size = new System.Drawing.Size(44, 25);
            this.lbl_TotalBet.TabIndex = 12;
            this.lbl_TotalBet.Text = "////";
            this.lbl_TotalBet.Click += new System.EventHandler(this.lbl_TotalBet_Click);
            // 
            // lbl_cardVal
            // 
            this.lbl_cardVal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.Pb_backOfCard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Pb_backOfCard.BackColor = System.Drawing.Color.Transparent;
            this.Pb_backOfCard.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Pb_backOfCard.BackgroundImage")));
            this.Pb_backOfCard.Location = new System.Drawing.Point(164, 41);
            this.Pb_backOfCard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Pb_backOfCard.Name = "Pb_backOfCard";
            this.Pb_backOfCard.Size = new System.Drawing.Size(86, 123);
            this.Pb_backOfCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pb_backOfCard.TabIndex = 15;
            this.Pb_backOfCard.TabStop = false;
            this.Pb_backOfCard.Click += new System.EventHandler(this.BackofCard);
            // 
            // btn_hint
            // 
            this.btn_hint.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            // LBL_DealerTotal
            // 
            this.LBL_DealerTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LBL_DealerTotal.AutoSize = true;
            this.LBL_DealerTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(100)))), ((int)(((byte)(62)))));
            this.LBL_DealerTotal.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LBL_DealerTotal.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LBL_DealerTotal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LBL_DealerTotal.Location = new System.Drawing.Point(560, 10);
            this.LBL_DealerTotal.Name = "LBL_DealerTotal";
            this.LBL_DealerTotal.Size = new System.Drawing.Size(44, 25);
            this.LBL_DealerTotal.TabIndex = 19;
            this.LBL_DealerTotal.Text = "////";
            this.LBL_DealerTotal.Click += new System.EventHandler(this.LBL_DealerTotal_Click);
            // 
            // BTN_Start
            // 
            this.BTN_Start.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_Start.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.BTN_Start.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BTN_Start.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BTN_Start.Location = new System.Drawing.Point(12, 132);
            this.BTN_Start.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTN_Start.Name = "BTN_Start";
            this.BTN_Start.Size = new System.Drawing.Size(108, 32);
            this.BTN_Start.TabIndex = 20;
            this.BTN_Start.Text = "START GAME";
            this.BTN_Start.UseVisualStyleBackColor = false;
            this.BTN_Start.Click += new System.EventHandler(this.BTN_Start_Click);
            // 
            // Frm_Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.BTN_Start);
            this.Controls.Add(this.LBL_DealerTotal);
            this.Controls.Add(this.btn_hint);
            this.Controls.Add(this.Pb_backOfCard);
            this.Controls.Add(this.lbl_cardVal);
            this.Controls.Add(this.lbl_TotalBet);
            this.Controls.Add(this.Btn_Return);
            this.Controls.Add(this.Btn_Hit);
            this.Controls.Add(this.btn_Stand);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Frm_Game";
            this.Text = "Frm_Game";
            this.Load += new System.EventHandler(this.Frm_Game_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pb_backOfCard)).EndInit();
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
        private Button btn_hint;
        private Label LBL_DealerTotal;
        private Button BTN_Start;
    }
}