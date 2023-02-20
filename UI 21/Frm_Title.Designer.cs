namespace UI_21
{
    partial class Frm_Title
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Title));
            this.Btn_History = new System.Windows.Forms.Button();
            this.Btn_Play = new System.Windows.Forms.Button();
            this.Btn_HowToPlay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_History
            // 
            this.Btn_History.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_History.BackgroundImage")));
            this.Btn_History.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_History.Location = new System.Drawing.Point(191, 342);
            this.Btn_History.Name = "Btn_History";
            this.Btn_History.Size = new System.Drawing.Size(138, 68);
            this.Btn_History.TabIndex = 0;
            this.Btn_History.Text = "History";
            this.Btn_History.UseVisualStyleBackColor = true;
            this.Btn_History.Click += new System.EventHandler(this.History);
            // 
            // Btn_Play
            // 
            this.Btn_Play.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Play.BackgroundImage")));
            this.Btn_Play.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_Play.Location = new System.Drawing.Point(388, 342);
            this.Btn_Play.Name = "Btn_Play";
            this.Btn_Play.Size = new System.Drawing.Size(131, 68);
            this.Btn_Play.TabIndex = 1;
            this.Btn_Play.Text = "Play";
            this.Btn_Play.UseVisualStyleBackColor = true;
            this.Btn_Play.Click += new System.EventHandler(this.Play);
            // 
            // Btn_HowToPlay
            // 
            this.Btn_HowToPlay.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_HowToPlay.BackgroundImage")));
            this.Btn_HowToPlay.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_HowToPlay.Location = new System.Drawing.Point(572, 342);
            this.Btn_HowToPlay.Name = "Btn_HowToPlay";
            this.Btn_HowToPlay.Size = new System.Drawing.Size(137, 68);
            this.Btn_HowToPlay.TabIndex = 2;
            this.Btn_HowToPlay.Text = "How to Play";
            this.Btn_HowToPlay.UseVisualStyleBackColor = true;
            this.Btn_HowToPlay.Click += new System.EventHandler(this.HowToPlay);
            // 
            // Frm_Title
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(898, 501);
            this.Controls.Add(this.Btn_HowToPlay);
            this.Controls.Add(this.Btn_Play);
            this.Controls.Add(this.Btn_History);
            this.ForeColor = System.Drawing.Color.Green;
            this.Name = "Frm_Title";
            this.Text = "Title";
            this.Load += new System.EventHandler(this.Frm_Title_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button Btn_History;
        private Button Btn_Play;
        private Button Btn_HowToPlay;
    }
}