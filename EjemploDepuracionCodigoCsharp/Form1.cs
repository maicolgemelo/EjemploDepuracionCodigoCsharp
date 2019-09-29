using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploDepuracionCodigoCsharp
{
    public partial class Form1 : Form
    {
        FuncionesRelleno funcionesRelleno = new FuncionesRelleno();
        FuncionesFibonacci funcionesFibonacci = new FuncionesFibonacci();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRellenar_Click(object sender, EventArgs e)
        {
            lvNumeros.Clear();
            lbvalores.Items.Clear();
            funcionesRelleno.setNumero(int.Parse(txtNumero.Text));

            for (int i = 0; i < int.Parse(txtNumero.Text);i++) {
                lvNumeros.Items.Add(funcionesRelleno.rellenar()[i].ToString());


            }

            foreach (int valores in funcionesRelleno.rellenar())
            {

                lbvalores.Items.Add(valores.ToString());
            }


        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {
            txtNumero.MaxLength = 3;
        }

        private void btnFibonacci_Click(object sender, EventArgs e)
        {
            lvNumeros.Clear();
            lbvalores.Items.Clear();
            funcionesFibonacci.setNumero(int.Parse(txtNumero.Text));

            for (int i = 0;i < int.Parse(txtNumero.Text);i++) {
                lvNumeros.Items.Add(funcionesFibonacci.sumatoria()[i].ToString());
                lbvalores.Items.Add(funcionesFibonacci.sumatoria()[i].ToString());

            }

           
        }

    }
}
