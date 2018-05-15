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
    public partial class Exercicio01 : Form
    {
        int number = 0;
        int Antecessor = 0;
        int Sucessor = 0;
        public Exercicio01()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
        number = Convert.ToInt32(numericUpDown1.Value);
        Antecessor = (number - 1);
        Sucessor = (number + 1);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
         textBox1.Text=("Antecessor: " + Antecessor);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = ("Sucessor: " + Sucessor);
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
