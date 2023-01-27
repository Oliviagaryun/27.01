using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_21
{
    public partial class Frm_History : Form
    {
        public Frm_History()
        {
            InitializeComponent();
        }

        private void Btn_MM_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Title form1 = new Frm_Title();
            form1.ShowDialog();
            this.Close();
        }
    }
}
