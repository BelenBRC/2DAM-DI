using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketCompra
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            calcularImporte();
        }

        private void calcularImporte()
        {
            try
            {
                //Calcular el subtotal
                double subtotal = double.Parse(textBox1.Text) * (double)numericUpDown1.Value;
                labelSubtotal.Text = subtotal.ToString();

                //Establecer el descuento
                double descuento;
                if (subtotal < 200.0)
                {
                    descuento = 15;
                }
                else
                {
                    descuento = 35;
                }
                labelDescuento.Text = descuento.ToString();

                //Calcular el decremento del precio
                double decremento = subtotal * -(descuento / 100);
                labelDecrementoPrecio.Text = decremento.ToString();

                //Calcular el total
                double total = subtotal + decremento;
                labelTotal.Text = total.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Introduzca un número válido", "ERROR");
                textBox1.Text = "";
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            calcularImporte();
        }
    }
}
