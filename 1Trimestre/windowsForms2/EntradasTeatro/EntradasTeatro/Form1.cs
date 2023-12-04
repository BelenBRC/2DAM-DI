using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntradasTeatro
{
    public partial class Form1 : Form
    {
        private int    entradas = 1;
        private double precioEntradaSinDescuentos = 15;
        private double precioEntrada1 = 0, precioEntrada2 = 0, precioEntrada3 = 0, precioEntrada4 = 0, precioEntrada5 = 0;
        private double precioTotal = 0;

        private double descuentoEdad5a14 = 0.35, descuentoEdad15a19 = 0.25, descuentoEdad20a45 = 0.1, descuentoEdad46a65 = 0.25, descuentoEdadMas66 = 0.35, descuentoDiscapacidad = 0.50;

        private void buttonCalcular3_Click(object sender, EventArgs e)
        {
            calcularPrecioEntradas();
        }

        private void buttonCalcular4_Click(object sender, EventArgs e)
        {
            calcularPrecioEntradas();
        }

        private void buttonCalcular5_Click(object sender, EventArgs e)
        {
            calcularPrecioEntradas();
        }

        private void buttonCalcular2_Click(object sender, EventArgs e)
        {
            calcularPrecioEntradas();
        }

        private void buttonCalcular1_Click(object sender, EventArgs e)
        {
            calcularPrecioEntradas();
        }

        private double descuentoTotalEntrada1 = 0, descuentoTotalEntrada2 = 0, descuentoTotalEntrada3 = 0, descuentoTotalEntrada4 = 0, descuentoTotalEntrada5 = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void calcularPrecioEntradas()
        {
            //Calcular el descuento de la entrada 1
            if (radioButton1E1.Checked)
            {
                descuentoTotalEntrada1+= descuentoEdad5a14;
            }
            else if (radioButton2E1.Checked)
            {
                descuentoTotalEntrada1 += descuentoEdad15a19;
            }
            else if (radioButton3E1.Checked)
            {
                descuentoTotalEntrada1 += descuentoEdad20a45;
            }
            else if (radioButton4E1.Checked)
            {
                descuentoTotalEntrada1 += descuentoEdad46a65;
            }
            else if (radioButton5E1.Checked)
            {
                descuentoTotalEntrada1 += descuentoEdadMas66;
            }

            if (checkBox1.Checked)
            {
                descuentoTotalEntrada1 += descuentoDiscapacidad;
            }

            //Calcular el precio tras descuentos
            precioEntrada1 = precioEntradaSinDescuentos - (precioEntradaSinDescuentos * descuentoTotalEntrada1);

            //Acumular el precio total
            precioTotal += precioEntrada1;

            if(entradas>1)
            {
                //Calcular el descuento de la entrada 2
                if (radioButton1E2.Checked)
                {
                    descuentoTotalEntrada2 += descuentoEdad5a14;
                }
                else if (radioButton2E2.Checked)
                {
                    descuentoTotalEntrada2 += descuentoEdad15a19;
                }
                else if (radioButton3E2.Checked)
                {
                    descuentoTotalEntrada2 += descuentoEdad20a45;
                }
                else if (radioButton4E2.Checked)
                {
                    descuentoTotalEntrada2 += descuentoEdad46a65;
                }
                else if (radioButton5E2.Checked)
                {
                    descuentoTotalEntrada2 += descuentoEdadMas66;
                }

                if (checkBox2.Checked)
                {
                    descuentoTotalEntrada2 += descuentoDiscapacidad;
                }

                //Calcular el precio tras descuentos
                precioEntrada2 = precioEntradaSinDescuentos - (precioEntradaSinDescuentos * descuentoTotalEntrada2);

                //Acumular el precio total
                precioTotal += precioEntrada2;
            }
            if (entradas > 2)
            {
                //Calcular el descuento de la entrada 3
                if (radioButton1E3.Checked)
                {
                    descuentoTotalEntrada3 += descuentoEdad5a14;
                }
                else if (radioButton2E3.Checked)
                {
                    descuentoTotalEntrada3 += descuentoEdad15a19;
                }
                else if (radioButton3E3.Checked)
                {
                    descuentoTotalEntrada3 += descuentoEdad20a45;
                }
                else if (radioButton4E3.Checked)
                {
                    descuentoTotalEntrada3 += descuentoEdad46a65;
                }
                else if (radioButton5E3.Checked)
                {
                    descuentoTotalEntrada3 += descuentoEdadMas66;
                }

                if (checkBox3.Checked)
                {
                    descuentoTotalEntrada3 += descuentoDiscapacidad;
                }

                //Calcular el precio tras descuentos
                precioEntrada3 = precioEntradaSinDescuentos - (precioEntradaSinDescuentos * descuentoTotalEntrada3);

                //Acumular el precio total
                precioTotal += precioEntrada3;
            }
            if (entradas > 3)
            {
                //Calcular el descuento de la entrada 4
                if (radioButton1E4.Checked)
                {
                    descuentoTotalEntrada4 += descuentoEdad5a14;
                }
                else if (radioButton2E4.Checked)
                {
                    descuentoTotalEntrada4 += descuentoEdad15a19;
                }
                else if (radioButton3E4.Checked)
                {
                    descuentoTotalEntrada4 += descuentoEdad20a45;
                }
                else if (radioButton4E4.Checked)
                {
                    descuentoTotalEntrada4 += descuentoEdad46a65;
                }
                else if (radioButton5E4.Checked)
                {
                    descuentoTotalEntrada4 += descuentoEdadMas66;
                }

                if (checkBox4.Checked)
                {
                    descuentoTotalEntrada4 += descuentoDiscapacidad;
                }

                //Calcular el precio tras descuentos
                precioEntrada4 = precioEntradaSinDescuentos - (precioEntradaSinDescuentos * descuentoTotalEntrada4);

                //Acumular el precio total
                precioTotal += precioEntrada4;
            }

            if(entradas > 4)
            {
                //Calcular el precio de la entrada 5
                if (radioButton1E5.Checked)
                {
                    descuentoTotalEntrada5 += descuentoEdad5a14;
                }
                else if (radioButton2E5.Checked)
                {
                    descuentoTotalEntrada5 += descuentoEdad15a19;
                }
                else if (radioButton3E5.Checked)
                {
                    descuentoTotalEntrada5 += descuentoEdad20a45;
                }
                else if (radioButton4E5.Checked)
                {
                    descuentoTotalEntrada5 += descuentoEdad46a65;
                }
                else if (radioButton5E5.Checked)
                {
                    descuentoTotalEntrada5 += descuentoEdadMas66;
                }

                if (checkBox5.Checked)
                {
                    descuentoTotalEntrada5 += descuentoDiscapacidad;
                }

                //Calcular el precio tras descuentos
                precioEntrada5 = precioEntradaSinDescuentos - (precioEntradaSinDescuentos * descuentoTotalEntrada5);

                //Acumular el precio total
                precioTotal += precioEntrada5;
            }

            //Ocultar todos los paneles de entradas y botones
            groupBoxEntrada1.Visible = false;
            groupBoxEntrada2.Visible = false;
            groupBoxEntrada3.Visible = false;
            groupBoxEntrada4.Visible = false;
            groupBoxEntrada5.Visible = false;
            buttonAniadir1.Visible = false;
            buttonAniadir2.Visible = false;
            buttonAniadir3.Visible = false;
            buttonAniadir4.Visible = false;
            buttonCalcular1.Visible = false;
            buttonCalcular2.Visible = false;
            buttonCalcular3.Visible = false;
            buttonCalcular4.Visible = false;
            buttonCalcular5.Visible = false;

            //Mostrar el panel de resumen de compra
            panelResumenCompra.Visible = true;

            //Ocultar las etiquetas de las entradas 2 - 4
            labelEntrada2.Visible = false;
            labelDescuento2.Visible = false;
            labelPrecio2.Visible = false;
            labelEntrada3.Visible = false;
            labelDescuento3.Visible = false;
            labelPrecio3.Visible = false;
            labelEntrada4.Visible = false;
            labelDescuento4.Visible = false;
            labelPrecio4.Visible = false;
            labelEntrada5.Visible = false;
            labelDescuento5.Visible = false;
            labelPrecio5.Visible = false;

            //Mostrar tantas líneas de resumen como entradas haya
            if (entradas > 0)
            {
                labelEntrada1.Visible = true;
                labelDescuento1.Visible = true;
                labelDescuento1.Text = (descuentoTotalEntrada1 * 100).ToString() + "%";
                labelPrecio1.Visible = true;
                labelPrecio1.Text = precioEntrada1.ToString("0.00") + "€";
            }
            if (entradas > 1)
            {
                labelEntrada2.Visible = true;
                labelDescuento2.Visible = true;
                labelDescuento2.Text = (descuentoTotalEntrada2 * 100).ToString() + "%";
                labelPrecio2.Visible = true;
                labelPrecio2.Text = precioEntrada2.ToString("0.00") + "€";
            }
            if (entradas > 2)
            {
                labelEntrada3.Visible = true;
                labelDescuento3.Visible = true;
                labelDescuento3.Text = (descuentoTotalEntrada3 * 100).ToString() + "%";
                labelPrecio3.Visible = true;
                labelPrecio3.Text = precioEntrada3.ToString("0.00") + "€";
            }
            if (entradas > 3)
            {
                labelEntrada4.Visible = true;
                labelDescuento4.Visible = true;
                labelDescuento4.Text = (descuentoTotalEntrada4 * 100).ToString() + "%";
                labelPrecio4.Visible = true;
                labelPrecio4.Text = precioEntrada4.ToString("0.00") + "€";
            }
            if (entradas > 4)
            {
                labelEntrada5.Visible = true;
                labelDescuento5.Visible = true;
                labelDescuento5.Text = (descuentoTotalEntrada5 * 100).ToString() + "%";
                labelPrecio5.Visible = true;
                labelPrecio5.Text = precioEntrada5.ToString("0.00") + "€";
            }

            //Mostrar el precio total
            labelTotal.Text = precioTotal.ToString("0.00") + "€";
            labelTotal.Visible = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Hacer visible el panel de la entrada 2
            groupBoxEntrada2.Visible = true;
            buttonAniadir2.Visible = true;
            buttonCalcular2.Visible = true;
            //Hacer invisibles los botones de la entrada 1
            buttonAniadir1.Visible = false;
            buttonCalcular1.Visible = false;
            //Actualizar el número de entradas
            entradas++;
        }

        private void buttonAniadir2_Click(object sender, EventArgs e)
        {
            //Hacer visible el panel de la entrada 3
            groupBoxEntrada3.Visible = true;
            buttonAniadir3.Visible = true;
            buttonCalcular3.Visible = true;
            //Hacer invisibles los botones de la entrada 2
            buttonAniadir2.Visible = false;
            buttonCalcular2.Visible = false;
            //Actualizar el número de entradas
            entradas++;
        }

        private void buttonAniadir3_Click(object sender, EventArgs e)
        {
            //Hacer visible el panel de la entrada 4
            groupBoxEntrada4.Visible = true;
            buttonAniadir4.Visible = true;
            buttonCalcular4.Visible = true;
            //Hacer invisibles los botones de la entrada 3
            buttonAniadir3.Visible = false;
            buttonCalcular3.Visible = false;
            //Actualizar el número de entradas
            entradas++;
        }

        private void buttonAniadir4_Click(object sender, EventArgs e)
        {
            //Hacer visible el panel de la entrada 5
            groupBoxEntrada5.Visible = true;
            buttonCalcular5.Visible = true;
            //Hacer invisibles los botones de la entrada 4
            buttonAniadir4.Visible = false;
            buttonCalcular4.Visible = false;
            //Actualizar el número de entradas
            entradas++;
        }
    }
}
