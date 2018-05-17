using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista01ComInterfaceGráfica
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Exercicio01().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Exercicio02().Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            new Exercicio03().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Exercicio04().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Exercicio05().Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new Exercicio06().Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            new Exercicio07().Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new Exercicio08().Show();
        }
        private void button8_Click(object sender, EventArgs e)
        {
            new Exercicio09().Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            new Exercicio10().Show();
        }
    }
}
