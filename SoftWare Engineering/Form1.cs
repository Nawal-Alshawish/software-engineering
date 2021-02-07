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
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void info_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This  Applecation  OfFers Three Levels Of Questions About SoftWare Engineering", "Infromation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void start_Click(object sender, EventArgs e)
        {
            Levels L = new Levels();
            L.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    
}
