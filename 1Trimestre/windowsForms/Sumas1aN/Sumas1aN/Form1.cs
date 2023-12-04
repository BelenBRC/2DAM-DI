using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sumas1aN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Añadir los números del 2 al 100 al combobox
            for (int i = 2; i <= 100; i++)
            {
                comboBox1.Items.Add(i);
            }
            //Asignar por defecto el número 2
            comboBox1.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBoxResultadosParciales_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(comboBox1.SelectedItem);
            int suma = 0;
            string resultadoParcial = "";
            string resultado = "La suma TOTAL es ";

            //Limpiar el listbox
            listBoxResultado.Items.Clear();

            //Realizar el cálculo de 1 hasta el número seleccionado
            for (int i = 1; i <= numero; i++)
            {
                suma += i;
                if (checkBoxResultadosParciales.Checked)
                {
                    resultadoParcial = "Sumando " + i + "\tSuma parcial: " + suma;
                    listBoxResultado.Items.Add(resultadoParcial);
                }
            }

            //Mostrar el resultado total
            listBoxResultado.Items.Add("");
            listBoxResultado.Items.Add(resultado + suma);
        }
    }
}
