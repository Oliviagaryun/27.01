namespace UI_21
{
    partial class Frm_History
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
            this.Btn_MM = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_MM
            // 
            this.Btn_MM.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.Btn_MM.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn_MM.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Btn_MM.Location = new System.Drawing.Point(12, 23);
            this.Btn_MM.Name = "Btn_MM";
            this.Btn_MM.Size = new System.Drawing.Size(123, 43);
            this.Btn_MM.TabIndex = 9;
            this.Btn_MM.Text = "MAIN MENU";
            this.Btn_MM.UseVisualStyleBackColor = false;
            this.Btn_MM.Click += new System.EventHandler(this.Btn_MM_Click);
            // 
            // Frm_History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_MM);
            this.Name = "Frm_History";
            this.Text = "Frm_History";
            this.ResumeLayout(false);

        }

        #endregion

        private Button Btn_MM;
    }
}