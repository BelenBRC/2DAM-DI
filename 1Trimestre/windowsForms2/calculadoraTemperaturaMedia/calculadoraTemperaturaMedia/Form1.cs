using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadoraTemperaturaMedia
{
    public partial class Form1 : Form
    {
        double temperaturaMedia = 0;
        int contador = 1;
        double temperaturaAcumulada = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private bool comprobarDoubleCorrecto(String texto)
        {
            bool numeroCorrecto = true;
            try
            {
                double numero = Convert.ToDouble(texto);
            }
            catch (FormatException)
            {
                numeroCorrecto = false;
                System.Windows.Forms.MessageBox.Show("Introduzca un formato de número adecuado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return numeroCorrecto;
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            //Comprobar que el dato es correcto
            if (comprobarDoubleCorrecto(textBoxTemperatura.Text) && textBoxTemperatura.Text != "")
            {
                //Sumar la temperatura introducida al acumulador
                temperaturaAcumulada += Convert.ToDouble(textBoxTemperatura.Text);

                //Calcular la media
                temperaturaMedia = temperaturaAcumulada / contador;

                //Truncar la media a un decimal .0 o .5
                temperaturaMedia = Math.Round(temperaturaMedia * 2, MidpointRounding.AwayFromZero) / 2;

                //Mostrar la media
                labelResultado.Text = temperaturaMedia.ToString() + " ºC";
                labelTempMedia.Visible = true;
                labelResultado.Visible = true;

                //Vaciar el textBox
                textBoxTemperatura.Text = "";

                //Inhabilitar campo de texto y botón calcular
                textBoxTemperatura.Enabled = false;
                buttonCalcular.Visible = false;
            }
        }

        private void buttonSiguiente_Click(object sender, EventArgs e)
        {
            //Poner el foco en el textBox
            textBoxTemperatura.Focus();

            //Si es el último día de la semana, activar el botón de calcular
            if (contador == 6)
            {
                buttonCalcular.Visible = true;
                buttonSiguiente.Visible = false;
            }

            //Comprobar que el texto introducido es un número y no está vacío
            if (comprobarDoubleCorrecto(textBoxTemperatura.Text) && textBoxTemperatura.Text != "")
            {
                //Incrementar el contador
                contador++;

                //Cambiar de día de la semana
                switch (contador)
                {
                    case 1:
                        labelDiaSemana.Text = "Lunes";
                        break;
                    case 2:
                        labelDiaSemana.Text = "Martes";
                        break;
                    case 3:
                        labelDiaSemana.Text = "Miércoles";
                        break;
                    case 4:
                        labelDiaSemana.Text = "Jueves";
                        break;
                    case 5:
                        labelDiaSemana.Text = "Viernes";
                        break;
                    case 6:
                        labelDiaSemana.Text = "Sábado";
                        break;
                    case 7:
                        labelDiaSemana.Text = "Domingo";
                        break;
                }

                //Sumar la temperatura introducida al acumulador
                temperaturaAcumulada += Convert.ToDouble(textBoxTemperatura.Text);
                
                //Vaciar el textBox
                textBoxTemperatura.Text = "";      
                
            }
        }

        private void buttonReiniciar_Click(object sender, EventArgs e)
        {
            //Ocultar label resultado
            labelTempMedia.Visible = false;
            labelResultado.Visible = false;

            textBoxTemperatura.Enabled = true;
            buttonCalcular.Visible = false;
            buttonSiguiente.Visible = true;

            //Reiniciar contadores y acumuladores
            contador = 1;
            temperaturaAcumulada = 0;
            temperaturaMedia = 0;

            labelDiaSemana.Text = "Lunes";
            labelResultado.Text = "";
        }
    }
}
