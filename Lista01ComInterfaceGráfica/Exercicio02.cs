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
    public partial class Exercicio02 : Form
    {
        int QuantDelitrosConsumidos = 0;
        int QuantAnosCons = 0;
        double Valor = 0;

        public Exercicio02()
        {
            InitializeComponent();
        }

        private void quantLitros_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtResultado_TextChanged(object sender, EventArgs e)
        {
            int Resultado = (QuantDelitrosConsumidos);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Valor = Convert.ToDouble(txtValor.Text);
            int TotalLitros = QuantAnosCons * 365 * QuantDelitrosConsumidos;
            double Custo = TotalLitros * Valor;
            txtResultado.Text=(string.Format("Quantidade de Litros Consumidos por Ano:{0}\r\nQuantidade De Anos: {1}\r\nValor: {2}\r\nLitros de Àgua Consumidos: {3}\r\nValor Total a Pagar:R${4}"
                , QuantDelitrosConsumidos, QuantAnosCons, Valor, TotalLitros, Custo));
        }

        private void NupQuantLitros_ValueChanged(object sender, EventArgs e)
        {
            QuantDelitrosConsumidos = Convert.ToInt32(NupQuantLitros.Value);

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            QuantAnosCons = Convert.ToInt32(NUPAnos.Value);

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            Valor = Convert.ToDouble(txtValor.Text);
        }
    }
}
