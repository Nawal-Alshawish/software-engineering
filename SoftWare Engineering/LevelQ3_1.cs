﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftWare_Engineering
{
    public partial class LevelQ3_1 : Form
    {
        public int counter = 0;
        public LevelQ3_1()
        {
            InitializeComponent();
        }

        private void ANSWER1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

            Levels L = new Levels();
            L.Show();
            this.Close();
        }

        private void BOK_Click(object sender, EventArgs e)
        {
            if (ANSWER1.Checked == true && ANSWER2.Checked == false && ANSWER3.Checked == false)
            {

                LevelQ3_2 l = new LevelQ3_2();
                l.Show();
                this.Hide();

            }
            else if (ANSWER1.Checked == false && ANSWER2.Checked == true && ANSWER3.Checked == false)
            {
                counter++;
                COUNTER.Text = counter.ToString();

            }
            else if (ANSWER1.Checked == false && ANSWER2.Checked == false && ANSWER3.Checked == true)
            {

                counter++;
                COUNTER.Text = counter.ToString();

            }
        }
    }
}