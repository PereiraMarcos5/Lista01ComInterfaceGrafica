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
    public partial class Exercicio03 : Form
    {

        int Number1 = 0;
        int Number2 = 0;
        int Soma = 0;
        int Subtração = 0;
        double Multiplicaçao = 0;
        double Divisão = 0;
        

        public Exercicio03()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        { 
        }

        public void Processos()
        {
            Soma = Number1 + Number2;
            Subtração = Number1 - Number2;
            Multiplicaçao = Number1 * Number2;
            Divisão = Number1 / Number2;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Processos();
            txtResultado.Text = (string.Format("Soma dos Valores:{0}\r\nSubtração dos Valores:{1}\r\nMultiplicação dos Valores:{2}\r\nDivisão dos Valores{3}"
            ,Soma, Subtração, Multiplicaçao, Divisão));

        }

        private void txtNumber1_ValueChanged(object sender, EventArgs e)
        {
            Number1 = Convert.ToInt32(txtNumber1.Value);
        }

        private void txtNumber2_ValueChanged(object sender, EventArgs e)
        {
            Number2 = Convert.ToInt32(txtNumber2.Value);
        }
    }
}

