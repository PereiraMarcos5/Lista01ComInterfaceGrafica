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
    public partial class Exercicio10 : Form
    {
        public Exercicio10()
        {
            InitializeComponent();
        }
        
        decimal dataNasc = 0;
        decimal dataAtual = 0;

        private void dataNascimento_ValueChanged(object sender, EventArgs e)
        {
            dataNasc = Convert.ToDecimal(dataNascimento.Text); 
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dataAtual_ValueChanged(object sender, EventArgs e)
        {
            dataAtual = Convert.ToDecimal(DataAtual.Text); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
         textBox1.Text = (string.Format("Data Nascimento:{0}\r\nDataAtual", dataNasc, dataAtual));
        }
    }
}
