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
    public partial class frm_hint : Form
    {
        public frm_hint()
        {
            InitializeComponent();
        }

        private void Hint_TextChanged(object sender, EventArgs e)
        {
            double winRate = Blackjack_Data.ReadBlackJackData();
            Console.WriteLine("Win rate:", winRate );
        }
    }
}
