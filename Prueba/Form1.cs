using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnComparar_Click(object sender, EventArgs e)
        {
            int numero;
            numero = Convert.ToInt32(textNumero.Text);
            if (numero % 2 == 0)
            {
                lblresultado.Text = ("Par=  " + numero);
            }
            else
            {
                lblresultado.Text = ("Impar= " + numero);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textNumero.Clear();
        }

        private void lblresultado_Click(object sender, EventArgs e)
        {

        }

        private void textNumero_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
