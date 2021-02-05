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
    public partial class LevelQ3_2 : Form
    {
        
        public LevelQ3_2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Function.Undo();
            this.Hide();
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

                LevelQ3_3 l = new LevelQ3_3();
                l.Show();
                this.Hide();
            }
        }
    }
}
