namespace UI_21
{
    partial class frm_hint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_hint));
            this.Pb_yellow = new System.Windows.Forms.PictureBox();
            this.txt_hint = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_yellow)).BeginInit();
            this.SuspendLayout();
            // 
            // Pb_yellow
            // 
            this.Pb_yellow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(214)))), ((int)(((byte)(91)))));
            this.Pb_yellow.Location = new System.Drawing.Point(80, 82);
            this.Pb_yellow.Name = "Pb_yellow";
            this.Pb_yellow.Size = new System.Drawing.Size(270, 187);
            this.Pb_yellow.TabIndex = 0;
            this.Pb_yellow.TabStop = false;
            // 
            // txt_hint
            // 
            this.txt_hint.Location = new System.Drawing.Point(113, 112);
            this.txt_hint.Name = "txt_hint";
            this.txt_hint.Size = new System.Drawing.Size(198, 27);
            this.txt_hint.TabIndex = 1;
            this.txt_hint.TextChanged += new System.EventHandler(this.Hint_TextChanged);
            // 
            // frm_hint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(422, 309);
            this.Controls.Add(this.txt_hint);
            this.Controls.Add(this.Pb_yellow);
            this.Name = "frm_hint";
            this.Text = "frm_hint";
            ((System.ComponentModel.ISupportInitialize)(this.Pb_yellow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox Pb_yellow;
        private TextBox txt_hint;
    }
}