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
            this.Pb_DealtCard1 = new System.Windows.Forms.PictureBox();
            this.Pb_DealtCard2 = new System.Windows.Forms.PictureBox();
            this.btn_hint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_backOfCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_DealtCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_DealtCard2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Stand
            // 
            this.btn_Stand.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Stand.BackgroundImage")));
            this.btn_Stand.Location = new System.Drawing.Point(191, 280);
            this.btn_Stand.Name = "btn_Stand";
            this.btn_Stand.Size = new System.Drawing.Size(94, 29);
            this.btn_Stand.TabIndex = 0;
            this.btn_Stand.Text = "Stand";
            this.btn_Stand.UseVisualStyleBackColor = true;
            this.btn_Stand.Click += new System.EventHandler(this.button1_Click);
            // 
            // Btn_Hit
            // 
            this.Btn_Hit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Hit.BackgroundImage")));
            this.Btn_Hit.Location = new System.Drawing.Point(539, 280);
            this.Btn_Hit.Name = "Btn_Hit";
            this.Btn_Hit.Size = new System.Drawing.Size(94, 29);
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
            this.Btn_Return.Location = new System.Drawing.Point(12, 12);
            this.Btn_Return.Name = "Btn_Return";
            this.Btn_Return.Size = new System.Drawing.Size(123, 43);
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
            this.lbl_TotalBet.Location = new System.Drawing.Point(388, 186);
            this.lbl_TotalBet.Name = "lbl_TotalBet";
            this.lbl_TotalBet.Size = new System.Drawing.Size(54, 31);
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
            this.lbl_cardVal.Location = new System.Drawing.Point(539, 312);
            this.lbl_cardVal.Name = "lbl_cardVal";
            this.lbl_cardVal.Size = new System.Drawing.Size(28, 25);
            this.lbl_cardVal.TabIndex = 14;
            this.lbl_cardVal.Text = "//";
            this.lbl_cardVal.Click += new System.EventHandler(this.label2_Click);
            // 
            // Pb_backOfCard
            // 
            this.Pb_backOfCard.BackColor = System.Drawing.Color.Transparent;
            this.Pb_backOfCard.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Pb_backOfCard.BackgroundImage")));
            this.Pb_backOfCard.Location = new System.Drawing.Point(188, 55);
            this.Pb_backOfCard.Name = "Pb_backOfCard";
            this.Pb_backOfCard.Size = new System.Drawing.Size(97, 162);
            this.Pb_backOfCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pb_backOfCard.TabIndex = 15;
            this.Pb_backOfCard.TabStop = false;
            this.Pb_backOfCard.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Pb_DealtCard1
            // 
            this.Pb_DealtCard1.BackColor = System.Drawing.Color.DimGray;
            this.Pb_DealtCard1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Pb_DealtCard1.Location = new System.Drawing.Point(294, 292);
            this.Pb_DealtCard1.Name = "Pb_DealtCard1";
            this.Pb_DealtCard1.Size = new System.Drawing.Size(97, 162);
            this.Pb_DealtCard1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Pb_DealtCard1.TabIndex = 16;
            this.Pb_DealtCard1.TabStop = false;
            this.Pb_DealtCard1.Click += new System.EventHandler(this.Pb_DealtCard1_Click);
            // 
            // Pb_DealtCard2
            // 
            this.Pb_DealtCard2.BackColor = System.Drawing.Color.DimGray;
            this.Pb_DealtCard2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Pb_DealtCard2.Location = new System.Drawing.Point(413, 292);
            this.Pb_DealtCard2.Name = "Pb_DealtCard2";
            this.Pb_DealtCard2.Size = new System.Drawing.Size(97, 162);
            this.Pb_DealtCard2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pb_DealtCard2.TabIndex = 17;
            this.Pb_DealtCard2.TabStop = false;
            // 
            // btn_hint
            // 
            this.btn_hint.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_hint.BackgroundImage")));
            this.btn_hint.Location = new System.Drawing.Point(234, 315);
            this.btn_hint.Name = "btn_hint";
            this.btn_hint.Size = new System.Drawing.Size(51, 51);
            this.btn_hint.TabIndex = 18;
            this.btn_hint.Text = ".";
            this.btn_hint.UseVisualStyleBackColor = true;
            this.btn_hint.Click += new System.EventHandler(this.btn_hint_Click);
            // 
            // Frm_Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_hint);
            this.Controls.Add(this.Pb_DealtCard2);
            this.Controls.Add(this.Pb_DealtCard1);
            this.Controls.Add(this.Pb_backOfCard);
            this.Controls.Add(this.lbl_cardVal);
            this.Controls.Add(this.lbl_TotalBet);
            this.Controls.Add(this.Btn_Return);
            this.Controls.Add(this.Btn_Hit);
            this.Controls.Add(this.btn_Stand);
            this.Name = "Frm_Game";
            this.Text = "Frm_Game";
            this.Load += new System.EventHandler(this.Frm_Game_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pb_backOfCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_DealtCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_DealtCard2)).EndInit();
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
        private PictureBox Pb_DealtCard1;
        private PictureBox Pb_DealtCard2;
        private Button btn_hint;
    }
}