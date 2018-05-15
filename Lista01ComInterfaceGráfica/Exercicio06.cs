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
    public partial class Exercicio06 : Form
    {
        double Nota1 = 0;
        double Nota2 = 0;
        double Nota3 = 0;
        double Nota4 = 0;

        public Exercicio06()
        {
            InitializeComponent();
        }

        private void Exercicio_Load(object sender, EventArgs e)
        {


        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            Nota4 = Convert.ToDouble(txtNota4.Value);
        }


        private void txtNota1_ValueChanged(object sender, EventArgs e)
        {
            Nota1 = Convert.ToDouble(txtNota1.Value);
        }

        private void txtNota2_ValueChanged(object sender, EventArgs e)
        {
            Nota2 = Convert.ToDouble(txtNota2.Value);
        }

        private void txtNota3_ValueChanged(object sender, EventArgs e)
        {
            Nota3 = Convert.ToDouble(txtNota3.Value);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            double Média = Nota1 + Nota2 + Nota3 + Nota4 /4;
            textBox1.Text = Convert.ToString("Média: " + Média);
        }

        private void txtNota4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }
    }
}
