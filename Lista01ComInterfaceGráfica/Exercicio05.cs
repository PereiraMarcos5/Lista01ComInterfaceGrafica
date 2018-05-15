﻿using System;
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
    public partial class Exercicio05 : Form
    {
        string NomeCarro = "";
        double ValorCarro = 0;
        double ValorParcela = 0;
        int QuantidadeMeses = 0;

        public Exercicio05()
        {
            InitializeComponent();
        }

        private void txtNomeCarro_TextChanged(object sender, EventArgs e)
        {
            NomeCarro = (txtNomeCarro.Text);
        }

        private void txtValorCarro_TextChanged(object sender, EventArgs e)
        {
            ValorCarro = Convert.ToDouble(txtValorCarro.Text);
        }

        private void txtValorParcela_TextChanged(object sender, EventArgs e)
        {
            ValorParcela = Convert.ToDouble(txtValorParcela.Text);
        }

        private void NupQuantMeses_ValueChanged(object sender, EventArgs e)
        {
            QuantidadeMeses = Convert.ToInt32(NupQuantMeses.Value);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            txtResultado.Text = (string.Format("Nome do Carro:{0}\r\nValor do Carro:{1}\r\nValor cada parcela:{2}\r\nQuantidade de parcelas:{3}\r\nQuantidade de Meses:{4}\r\nValor total do Financiamento:{5}\r\nDifernça entre o Valor toatl e o Financiamento:{6}"
                ,NomeCarro, ValorCarro, ValorParcela));
        }
    }
}
