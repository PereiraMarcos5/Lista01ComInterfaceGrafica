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
    public partial class Exercicio07 : Form
    {
        public Exercicio07()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string arvore = (@" 
        *
       ***
      *****
     ******* 
    *********
   ***********
  *************
    ");

         richTextBox1.Text = arvore;
        }
    }
}
