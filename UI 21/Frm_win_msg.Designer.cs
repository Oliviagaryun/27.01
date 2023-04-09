namespace UI_21
{
    partial class Frm_win_msg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_win_msg));
            this.txt_winner = new System.Windows.Forms.TextBox();
            this.txt_betWin = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_winner
            // 
            this.txt_winner.Location = new System.Drawing.Point(138, 138);
            this.txt_winner.Name = "txt_winner";
            this.txt_winner.Size = new System.Drawing.Size(125, 27);
            this.txt_winner.TabIndex = 0;
            this.txt_winner.Text = "WINNER";
            // 
            // txt_betWin
            // 
            this.txt_betWin.Location = new System.Drawing.Point(139, 197);
            this.txt_betWin.Name = "txt_betWin";
            this.txt_betWin.Size = new System.Drawing.Size(267, 27);
            this.txt_betWin.TabIndex = 1;
            this.txt_betWin.Text = "you win. bet x2 ( variable ) ";
            // 
            // Frm_win_msg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_betWin);
            this.Controls.Add(this.txt_winner);
            this.Name = "Frm_win_msg";
            this.Text = "Frm_win_msg";
            this.Load += new System.EventHandler(this.Frm_win_msg_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txt_winner;
        private TextBox txt_betWin;
    }
}