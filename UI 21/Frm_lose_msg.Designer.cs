namespace UI_21
{
    partial class Frm_lose_msg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_lose_msg));
            this.txt_loseMsg = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_loseMsg
            // 
            this.txt_loseMsg.Location = new System.Drawing.Point(380, 101);
            this.txt_loseMsg.Name = "txt_loseMsg";
            this.txt_loseMsg.Size = new System.Drawing.Size(212, 27);
            this.txt_loseMsg.TabIndex = 0;
            this.txt_loseMsg.Text = "lose. bank = bank-bet";
            this.txt_loseMsg.TextChanged += new System.EventHandler(this.txt_loseMsg_TextChanged);
            // 
            // Frm_lose_msg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_loseMsg);
            this.Name = "Frm_lose_msg";
            this.Text = "Frm_lose_msg";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txt_loseMsg;
    }
}