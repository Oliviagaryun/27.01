namespace UI_21
{
    partial class Frm_HowToPlay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_HowToPlay));
            this.lbl_rules = new System.Windows.Forms.Label();
            this.lbl_HowToPlay = new System.Windows.Forms.Label();
            this.Btn_MM = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_rules
            // 
            this.lbl_rules.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_rules.AutoSize = true;
            this.lbl_rules.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(214)))), ((int)(((byte)(91)))));
            this.lbl_rules.Font = new System.Drawing.Font("Segoe UI Historic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_rules.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_rules.Location = new System.Drawing.Point(21, 152);
            this.lbl_rules.Name = "lbl_rules";
            this.lbl_rules.Size = new System.Drawing.Size(803, 300);
            this.lbl_rules.TabIndex = 0;
            this.lbl_rules.Text = resources.GetString("lbl_rules.Text");
            this.lbl_rules.Click += new System.EventHandler(this.HowToPlay_txt);
            // 
            // lbl_HowToPlay
            // 
            this.lbl_HowToPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_HowToPlay.AutoSize = true;
            this.lbl_HowToPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(224)))), ((int)(((byte)(91)))));
            this.lbl_HowToPlay.Font = new System.Drawing.Font("Sylfaen", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_HowToPlay.Location = new System.Drawing.Point(280, 33);
            this.lbl_HowToPlay.Name = "lbl_HowToPlay";
            this.lbl_HowToPlay.Size = new System.Drawing.Size(260, 57);
            this.lbl_HowToPlay.TabIndex = 1;
            this.lbl_HowToPlay.Text = "How to Play";
            this.lbl_HowToPlay.Click += new System.EventHandler(this.TITLE);
            // 
            // Btn_MM
            // 
            this.Btn_MM.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_MM.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.Btn_MM.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn_MM.Location = new System.Drawing.Point(12, 12);
            this.Btn_MM.Name = "Btn_MM";
            this.Btn_MM.Size = new System.Drawing.Size(123, 43);
            this.Btn_MM.TabIndex = 2;
            this.Btn_MM.Text = "MAIN MENU";
            this.Btn_MM.UseVisualStyleBackColor = false;
            this.Btn_MM.Click += new System.EventHandler(this.Btn_MM_Click);
            // 
            // Frm_HowToPlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(836, 474);
            this.Controls.Add(this.Btn_MM);
            this.Controls.Add(this.lbl_HowToPlay);
            this.Controls.Add(this.lbl_rules);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Frm_HowToPlay";
            this.Text = "HowToPlay";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_rules;
        private Label lbl_HowToPlay;
        private Button Btn_MM;
    }
}