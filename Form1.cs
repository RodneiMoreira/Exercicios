using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadoraPJ
{
    public partial class Form1 : Form
    {
        string operador;
        double num1, num2, resultado;
        Boolean ban_btn = true, ban_num = true, ban_ope = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            operador = "+";
            num1 = Double.Parse(painel.Text); //converte texto em numero
            painel.Clear();

            //painel.Text = num1.ToString() + D //converte um numero a em texto (String);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            painel.Text = painel.Text + ".";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            operador = "-";
            num1 = Double.Parse(painel.Text); //converte texto em numero
            painel.Clear();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            painel.Text = painel.Text + "5";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            painel.Text = painel.Text + "6";
        }

        private void button19_Click(object sender, EventArgs e)
        {

        }

        private void painel_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            if (ban_num == true)
            {
                painel.Clear();
                painel.Text = "0";
                ban_num = false;

            }
            else
            {
                painel.Text = painel.Text + "0";
            }

        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            if (ban_num == true)
            {
                painel.Clear();
                painel.Text = "1";
                ban_num = false;

            }
            else
            {
                painel.Text = painel.Text + "1";
            }
        }

       
        private void btn_2_Click(object sender, EventArgs e)

        {
            if (ban_num == true)
            {
                painel.Clear();
                painel.Text = "2";
                ban_num = false;

            }
            else
            {
                painel.Text = painel.Text + "2";
            }
        }
        private void btn_3_Click(object sender, EventArgs e)
        {
            if (ban_num == true)
            {
                painel.Clear();
                painel.Text = "3";
                ban_num = false;

            }
            else
            {
                painel.Text = painel.Text + "3";
            }
        }
        private void btn_4_Click(object sender, EventArgs e)
        {
            if (ban_num == true)
            {
                painel.Clear();
                painel.Text = "4";
                ban_num = false;

            }
            else
            {
                painel.Text = painel.Text + "4";
            }
        }
        private void btn_7_Click(object sender, EventArgs e)
        {
            if (ban_num == true)
            {
                painel.Clear();
                painel.Text = "7";
                ban_num = false;

            }
            else
            {
                painel.Text = painel.Text + "7";
            }
        }
        private void btn_8_Click(object sender, EventArgs e)
        {
            if (ban_num == true)
            {
                painel.Clear();
                painel.Text = "8";
                ban_num = false;

            }
            else
            {
                painel.Text = painel.Text + "8";
            }
        }
        private void btn_9_Click(object sender, EventArgs e)
        {
            if (ban_num == true)
            {
                painel.Clear();
                painel.Text = "9";
                ban_num = false;

            }
            else
            {
                painel.Text = painel.Text + "9";
            }
        }
        private void btn_C_Click(object sender, EventArgs e)
        {
            painel.Clear();
        }

        private void btn_igual_Click(object sender, EventArgs e)
        {
            num2 = Double.Parse(painel.Text); //converte texto em numero

            switch (operador)
            {

                case "+":
                    resultado = num1 + num2;
                    break;

                case "-":
                    resultado = num1 - num2;
                    break;

                case "*":
                    resultado = num1 * num2;
                    break;

                case "/":
                    resultado = num1 / num2;
                    break;
            }

            resultado = num1 + num2;

            painel.Text = resultado.ToString();
        }

        private void btn_multiplicar_Click(object sender, EventArgs e)
        {
            operador = "X";
            num1 = Double.Parse(painel.Text); //converte texto em numero
            painel.Clear();
        }

        private void btn_dividir_Click(object sender, EventArgs e)
        {
            operador = "/";
            num1 = Double.Parse(painel.Text); //converte texto em numero
            painel.Clear();
        }

        private void btn_remover_Click(object sender, EventArgs e)
        {
            if (painel.TextLength > 1)
            {
                painel.Text = painel.Text.Remove(painel.Text.Length - 1, 1);
            }
        }
    }
}