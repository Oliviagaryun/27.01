﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_21
{


    public partial class Frm_Betting : Form
    {
        public int Bank = 1500;
        public int Bet = 0;
        Player player;
        public bool GameResult= false;
           // Bank = Bank - Bet;
        public Frm_Betting()
        {
            InitializeComponent();
            player = new Player();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)// 1
        {

            Btn_chip1.BackColor = Color.Transparent; 
            Bet = Bet + 1;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = Bank.ToString();
        }

        private void form_Load(object sender, EventArgs e)
        {

        }

        private void Btn_MM_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Title form1 = new Frm_Title();
            form1.ShowDialog();
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Btn_chip1.BackColor = Color.Transparent;
            Bet = 0;
        }


        private void button1_Click_3(object sender, EventArgs e)
        {
            Bet = Bet + 25;
        }
        private void Btn_chip25_Click(object sender, EventArgs e)
            
        {
            Bet = Bet + 5;
        }

        private void Btn_chip50_Click(object sender, EventArgs e)
        {
            Bet  = Bet + 50;
        }   

        private void Btn_Chip100_Click(object sender, EventArgs e)
        {
            Bet = Bet + 100;
        }

        public void label1_Click_1(object sender, EventArgs e)
        {
            //Im guessing you havent made the labels yet, this is why this doesn't work, lbl_totalBet doesn't exist yet
            //lbl_TotalBet.Text =  "$" + Bet.ToString();
            //lbl_TotalBet.Text = Console.WriteLine("$ ") + Bet.ToString();

        }

        private void label1_Click_2(object sender, EventArgs e)
        {
            //lbl_Bank.Text = "$" + Bank.ToString();
        }

        private void Btn_Bet_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Game form1 = new Frm_Game(player);
            form1.ShowDialog();
            //form 1.play game 
            //form1.returnResult();
            Boolean GameResult = form1.returnResult();
            this.Close();
        }
        public void SetBankValue()
        {
            if (GameResult = true)
            {
                int Bank = Bank + Bet * 2;

            }
            else (GameResult = false);
            {
                int Bank = Bank - Bet;
            }
                
        }





    }
}
