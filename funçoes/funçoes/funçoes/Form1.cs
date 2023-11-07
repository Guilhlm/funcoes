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



        public int calculomath(int num1, int num2, string operador)
        {
            int resultado = 0;

            if (operador == "+")
            {
                resultado = num1 + num2;
            }
            else if (operador == "-")
            {
                resultado = num1 - num2;
            }
            else if (operador == "x")
            {
                resultado = num1 * num2;
            }
            else if (operador == "/")
            {
                resultado = num1 / num2;
            }
          


            return resultado;
        }




        // soma

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

            Button botao = (Button)sender;

            string operadorselecionado = botao.Text;

            //int total = resultadosoma(numero1, numero2);

            int total = calculomath(numero1, numero2, operadorselecionado);

            lbresultado.Text = total.ToString();
        }



        // menos



        public int resultadomenos(int num1, int num2)
        {
            int resultado = 0;

            resultado = num1 - num2;

            return resultado;
        }

        private void botaomenos_Click(object sender, EventArgs e)
        {

            int numero1 = int.Parse(txt1.Text);
            int numero2 = int.Parse(txt2.Text);

            //int total = resultadomenos(numero1, numero2);

            int total = calculomath(numero1, +numero2, "-");

            lbresultado.Text = total.ToString();
        }



        //divisao



        public int resultadodivisao(int num1, int num2)
        {
            int resultado = 0;

            resultado = num1 / num2;

            return resultado;

        }

        private void botaodivisao_Click(object sender, EventArgs e)
        {

            int numero1 = int.Parse(txt1.Text);
            int numero2 = int.Parse(txt2.Text);

            //int total = resultadodivisao(numero1,  numero2);

            int total = calculomath(numero1, +numero2, "/");

            lbresultado.Text = total.ToString();
        }



        // multiplicaçao


        public int resultadomultiplicacao(int num1, int num2)
        {
            int resultado = 0;

            resultado = num1 * num2;

            return resultado;
        }

        private void botaomulti_Click(object sender, EventArgs e)
        {

            int numero1 = int.Parse(txt1.Text);
            int numero2 = int.Parse(txt2.Text);

            //int total = resultadomultiplicacao(numero1, numero2);

            int total = calculomath(numero1, +numero2, "*");

            lbresultado.Text = total.ToString();
        }
    }
}
