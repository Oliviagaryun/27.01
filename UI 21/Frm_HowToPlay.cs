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
    public partial class Frm_HowToPlay : Form
    {
        public Frm_HowToPlay()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Btn_MM_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Title form1 = new Frm_Title();
            form1.ShowDialog();
            this.Close();
        }

        private void Frm_rules_Load(object sender, EventArgs e)
        {

        }
    }
}
