using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Suma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sumando1, sumando2, suma;

            try
            {
                sumando1 = Double.Parse(num1.Text);
                try
                {
                    sumando2 = Double.Parse(num2.Text);
                    suma = sumando1 + sumando2;
                    resultado.Text = suma.ToString();
                }
                catch (Exception)
                {
                    MessageBox.Show("El segundo sumando no es un número válido");
                    return;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("El primer sumando no es un número válido");
                return;
            }
        }

        private void ButtonLimpiar_Click(object sender, EventArgs e)
        {
            num1.Text = "";
            num2.Text = "";
            resultado.Text = "";
        }
    }
}
