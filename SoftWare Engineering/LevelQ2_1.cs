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
    public partial class LevelQ2_1 : Form
    {
       
        public LevelQ2_1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void LevelQ2_1_Load(object sender, EventArgs e)
        {

        }

        private void ANSWER1_CheckedChanged(object sender, EventArgs e)
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
                
                LevelQ2_2 L = new LevelQ2_2();
                L.Show();
                this.Hide();
            }
            else if (ANSWER1.Checked == false && ANSWER2.Checked == false && ANSWER3.Checked == true)
            {
                Function.counter++;

                COUNTER.Text = Function.counter.ToString();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

            Function.Undo();
            this.Hide();
        }
    }
}
