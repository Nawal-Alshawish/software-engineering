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
    public partial class LevelQ1_2 : Form
    {
       
        public LevelQ1_2()
        {
            InitializeComponent();
        }

        private void ANSWER3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BOK_Click(object sender, EventArgs e)
        {

            if (ANSWER1.Checked == true && ANSWER2.Checked == false && ANSWER3.Checked == false)
            {
                Function.counter++;

                COUNTER.Text = Function.counter.ToString();



            }
            else if (ANSWER1.Checked == false && ANSWER2.Checked == true && ANSWER3.Checked == false)
            {
                Function.counter++;

                COUNTER.Text = Function.counter.ToString();

            }
            else if (ANSWER1.Checked == false && ANSWER2.Checked == false && ANSWER3.Checked == true)
            {
                
                LevelQ1_3 l = new LevelQ1_3();
                l.Show();
                this.Hide();
            }
        }

        private void COUNTER_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Function.Undo();
            this.Hide();
        }
    }
}
