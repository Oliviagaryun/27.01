﻿using System;
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
    public partial class Frm_win_msg : Form
    {
        public Frm_win_msg()
        {
            InitializeComponent();
            Frm_win_msg form1 = new Frm_win_msg();
            form1.ShowDialog();
            this.Close();
        }

        public void Frm_win_msg_Load(object sender, EventArgs e)
        {
            
            Frm_win_msg form1 = new Frm_win_msg();
            form1.ShowDialog();
            this.Close();
        }

        private void txt_betWin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
