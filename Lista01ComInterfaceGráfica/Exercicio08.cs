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
    public partial class Exercicio08 : Form
    {
        public Exercicio08()
        {
            InitializeComponent();
        }
        
        double luz = 0;
        double Agua = 0;
        double Net = 0;
        double Vivo = 0;
        double Oi = 0;
        double Iptu = 0;
        double Ipva = 0;
        double Seguro = 0;
        

        private void Exercicio08_Load(object sender, EventArgs e)
        {

        }

        

        private void label1_Click_1(object sender, EventArgs e)
        {
        
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
           luz = Convert.ToDouble(textBox1.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Agua = Convert.ToDouble(textBox2.Text);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            Net = Convert.ToDouble(textBox3.Text);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            Oi = Convert.ToDouble(textBox4.Text);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            Iptu = Convert.ToDouble(textBox5.Text);
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            Ipva = Convert.ToDouble(textBox6.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double ValorTelefone = Net + Oi + Vivo;
            double Impostos = Iptu + Ipva;
            double Outros = Seguro + Agua + luz;
            double ValorTotal = ValorTelefone + Impostos + Outros;


            textBox9.Text = (string.Format("Valor de Telefone:{0}\r\nImpostos:{1}\r\nOutros:{2}\r\nValor Total:{3}"
                ,ValorTelefone, Impostos, Outros, ValorTotal));
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            Vivo = Convert.ToDouble(textBox7.Text);
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            Seguro = Convert.ToDouble(textBox8.Text);
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        }
    }
