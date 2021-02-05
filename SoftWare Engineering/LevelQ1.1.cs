using System;
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
    public partial class LevelQ1 : Form
    {
        
        public LevelQ1()
        {
            InitializeComponent();
        }

        private void BOK_Click(object sender, EventArgs e)
        {
            if (ANSWER1.Checked == true && ANSWER2.Checked == false && ANSWER3.Checked == false)
            {
                

                LevelQ1_2 l = new LevelQ1_2();
                l.Show();
                this.Hide();
                
             }
            else if (ANSWER1.Checked == false && ANSWER2.Checked == true && ANSWER3.Checked == false)
            {
                Function.counter++;
                
                COUNTER.Text = Function.counter.ToString();

            }
            else if (ANSWER1.Checked == false && ANSWER2.Checked == false && ANSWER3.Checked == true)
            {
                Function.counter++;

                COUNTER.Text = Function.counter.ToString();

            }

        }
       
        private void LevelQ1_Load(object sender, EventArgs e)
        {

        }

        private void STAR1_Click(object sender, EventArgs e)
        {

        }

        private void STAR2_Click(object sender, EventArgs e)
        {

        }

        private void STAR3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void COUNTER_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Function.Undo();
            this.Hide();
        }

        private void ANSWER3_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
