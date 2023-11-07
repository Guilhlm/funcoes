using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace funçoes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int resultadosoma(int num1, int num2)
        {
            int resultado = 0;


            resultado = num1 + num2;

            return resultado;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int numero1 = int.Parse(txt1.Text);
            int numero2 = int.Parse(txt2.Text);

            int total = resultadosoma(numero1, numero2);


            lbresultado.Text = total.ToString();
        }

        private void botaomenos_Click(object sender, EventArgs e)
        {

            int numero1 = int.Parse(txt1.Text);
            int numero2 = int.Parse(txt2.Text);

            int resultado = numero1 - numero2;

            lbresultado.Text = resultado.ToString();
        }

        private void botaodivisao_Click(object sender, EventArgs e)
        {

            int numero1 = int.Parse(txt1.Text);
            int numero2 = int.Parse(txt2.Text);

            int resultado = numero1 / numero2;

            lbresultado.Text = resultado.ToString();
        }

        private void botaomulti_Click(object sender, EventArgs e)
        {

            int numero1 = int.Parse(txt1.Text);
            int numero2 = int.Parse(txt2.Text);

            int resultado = numero1 * numero2;

            lbresultado.Text = resultado.ToString();
        }
    }
}
