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
    public partial class Levels : Form
    {
        public Levels()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LevelQ1 l = new LevelQ1();
            l.Show();
            this.Hide();
        }

        private void level_2_Click(object sender, EventArgs e)
        {
            LevelQ2_1 L = new LevelQ2_1();
            L.Show();
            this.Hide();
        }

        private void level_3_Click(object sender, EventArgs e)
        {
            LevelQ3_1 L = new LevelQ3_1();
            L.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void level4_Click(object sender, EventArgs e)
        {
            LevelQ4_1 l = new LevelQ4_1();
            l.Show();
            this.Hide();
        }
    }
}
