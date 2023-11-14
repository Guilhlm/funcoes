using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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

        public void escolhaoperador(int numero, string operadorescolhido)
        {
            lbtempo.Text = numero.ToString();

            lboperador.Text = operadorescolhido.ToString();

            txt1.Text = "";

        }


        //calculos operacionais

        public double calculomath(double num1, double num2, string operador)
        {
            double resultado = 0;

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
            else if (operador == "%")
            {
                resultado = num1 * num2 / 100;
            }
            else if (operador == "resto")
            {
                resultado = num1 % num2;
            }
            
            return resultado;
        }

        private void btn_inverter (object sender, EventArgs e)
        {
            double negativo = double.Parse(txt1.Text);

            negativo = negativo * (-1);

            txt1.Text = negativo.ToString();

        }

        //botoes de operaçao + - * /

        private void button1_Click(object sender, EventArgs e)
        {

            if (txt1.Text != "")
            {

                int numero1 = int.Parse(txt1.Text);
                int numero2 = 0;

                Button botao = (Button)sender;

                string operadorselecionado = botao.Text;

                //int total = calculomath(numero1, numero2, operadorselecionado); //int total = resultadosoma(numero1, numero2);

                //lbresultado.Text = total.ToString();

                escolhaoperador(numero1, operadorselecionado);
            }
            else
            {
                lbtempo.Text = "error";
    
            }

        }

        //botoes numericos

        private void btnuber0_Click(object sender, EventArgs e)
        {
            Button valorbotao = (Button)sender;

            txt1.Text += valorbotao.Text; //txt1.Text = txt1.Text + valorbotao.Text;

        }

        //botao de clear

        private void btndelete_Click(object sender, EventArgs e)
        {
            txt1.Text = "";
           
        }

        private void btndeleteall_click(object sender, EventArgs e)
        {
            txt1.Text = "";
            lbtempo.Text = "";
            lboperador.Text = "";
            lbresultado.Text = "";
        }


        private void btnigual_click (object sender, EventArgs e)
        {

            int primeiro_numero = int.Parse(lbtempo.Text);

            int segundo_numero = int.Parse(txt1.Text);

            string operador = lboperador.Text;

           double total = calculomath(primeiro_numero, segundo_numero, operador);

            txt1.Text = total.ToString();

        }


    }
}

