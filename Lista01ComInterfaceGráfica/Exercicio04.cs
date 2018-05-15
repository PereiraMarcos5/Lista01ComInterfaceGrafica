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
    public partial class Exercicio04 : Form
    {
        int Tabuada = 0;
        public Exercicio04()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tabuada = Convert.ToInt32(txtTabuada.Value);

            for (int i = 0; i <= 10; i++)
            {
                
                MessageBox.Show(Tabuada + "*" + i + "=" + Tabuada * i);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
