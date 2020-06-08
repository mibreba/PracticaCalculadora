using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PracticaCalculadora
{
    public partial class FormCalculadora : Form
    {

        double primero;
        double segundo;
        double resultado;
        string operacion;

        public FormCalculadora()
        {
            InitializeComponent();
        }

        ClSumar sum = new ClSumar();
        Clrestar res = new Clrestar();
        Cldividir div = new Cldividir();
        Clmultiplicar mul = new Clmultiplicar();

        private void FormCalculadora_Load(object sender, EventArgs e)
        {

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtpantalla.Text = txtpantalla.Text + "0";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtpantalla.Text = txtpantalla.Text + "9";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtpantalla.Text = txtpantalla.Text + "8";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtpantalla.Text = txtpantalla.Text + "7";

        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtpantalla.Text = txtpantalla.Text + "6";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtpantalla.Text = txtpantalla.Text + "5";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtpantalla.Text = txtpantalla.Text + "4";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtpantalla.Text = txtpantalla.Text + "3";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtpantalla.Text = txtpantalla.Text + "2";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtpantalla.Text = txtpantalla.Text + "1";
        }

        private void btncero_Click(object sender, EventArgs e)
        {
            txtpantalla.Clear();
        }

        private void btnsumar_Click(object sender, EventArgs e)
        {
            operacion = "+";
            primero = double.Parse(txtpantalla.Text);
            txtpantalla.Clear();
         }

        private void btnrestar_Click(object sender, EventArgs e)
        {
            operacion = "-";
            primero = double.Parse(txtpantalla.Text);
            txtpantalla.Clear();
        }

        private void btnmulti_Click(object sender, EventArgs e)
        {
            operacion = "*";
            primero = double.Parse(txtpantalla.Text);
            txtpantalla.Clear();
        }

        private void btndividir_Click(object sender, EventArgs e)
        {
            operacion = "/";
            primero = double.Parse(txtpantalla.Text);
            txtpantalla.Clear();
        }

        private void btnigual_Click(object sender, EventArgs e)
        {
            segundo = double.Parse(txtpantalla.Text);

            switch(operacion){

                case "+":
                 
                    resultado= sum.Sumar((primero),(segundo));
                    txtpantalla.Text = resultado.ToString();
                    break;

                case "-":
                    resultado = res.Restar((primero), (segundo));
                    txtpantalla.Text = resultado.ToString();
                    break;
                case "*":
                    resultado = mul.multiplicar((primero), (segundo));
                    txtpantalla.Text = resultado.ToString();
                    break;


                case "/":
                    resultado = div.Dividir((primero), (segundo));
                    txtpantalla.Text = resultado.ToString();
                    break;
            }
        }

        private void btnpunto_Click(object sender, EventArgs e)
        {
            txtpantalla.Text = txtpantalla.Text +".";

        }
    }


}