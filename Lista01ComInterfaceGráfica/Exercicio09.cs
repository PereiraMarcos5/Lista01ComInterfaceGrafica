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
    public partial class Exercicio09 : Form
    {
        int numero1 = 0;
        int numero2 = 0;

    
        public Exercicio09()
        {
            InitializeComponent();
        }


        private void txtNumero01_ValueChanged(object sender, EventArgs e)
        {
            numero1 = Convert.ToInt32(txtNumero01.Text);
        }

        private void txtNumero02_ValueChanged(object sender, EventArgs e)
        {
            numero2 = Convert.ToInt32(txtNumero02.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ResultBox.Text = (string.Format("Numero1:{0}\r\nNumero2:{1}", numero2 + 1, numero1 + 1));
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtNumero02_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }

        }
        
    }
}
