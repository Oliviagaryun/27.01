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
    public partial class Frm_lose_msg : Form
    {
        public Frm_lose_msg()
        {
            InitializeComponent();
            this.Hide();
            Frm_lose_msg form1 = new Frm_lose_msg();
            form1.ShowDialog();
            this.Close();
        }

        private void txt_loseMsg_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
