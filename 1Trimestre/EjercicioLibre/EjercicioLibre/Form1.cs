using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioLibre
{
    public partial class Form1 : Form
    {
        ArrayList aeropuertos = new ArrayList();

        public Form1()
        {
            InitializeComponent();
            aniadirAeropuertos();
        }

        private void aniadirAeropuertos()
        {
            //Array con nombres ciudades aeropuertos
            aeropuertos.Add("Madrid");
            aeropuertos.Add("Barcelona");
            aeropuertos.Add("Valencia");
            aeropuertos.Add("Sevilla");
            aeropuertos.Add("Bilbao");
            aeropuertos.Add("Alicante");
            aeropuertos.Add("Malaga");
            aeropuertos.Add("Granada");
            aeropuertos.Add("Santander");
            aeropuertos.Add("Santiago");
            aeropuertos.Add("Vigo");
            aeropuertos.Add("Oviedo");
            aeropuertos.Add("Zaragoza");
            aeropuertos.Add("Tenerife");
            aeropuertos.Add("Las Palmas");
            aeropuertos.Add("Ibiza");

            //Añadir al combobox
            foreach (string aeropuerto in aeropuertos)
            {
                comboBox1.Items.Add(aeropuerto);
            }

            comboBox1.SelectedIndex = 0;

            //Añadir al combobox
            foreach (string aeropuerto in aeropuertos)
            {
                comboBoxDestinos.Items.Add(aeropuerto);
            }

            comboBoxDestinos.SelectedIndex = 0;

            //Estblecer el máximo de pasajeros
            numericUpDownPasajeros.Maximum = 10;
            numericUpDownPasajeros.Minimum = 1;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxTodosLosDestinos.Checked)
            {
                comboBoxDestinos.Visible = false;
                labelDestino.Visible = false;
            }
            else
            {
                comboBoxDestinos.Visible = true;
                labelDestino.Visible = true;
            }
        }

        private void checkBoxVuelosIdaVuelta_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxVuelosIdaVuelta.Checked)
            {
                dateTimePickerRegreso.Visible = true;
                labelRegreso.Visible = true;
            }
            else
            {
                dateTimePickerRegreso.Visible = false;
                labelRegreso.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Resetear todos los campos
            comboBox1.SelectedIndex = 0;
            comboBoxDestinos.SelectedIndex = 0;
            numericUpDownPasajeros.Value = 1;
            checkBoxVuelosIdaVuelta.Checked = false;
            checkBoxTodosLosDestinos.Checked = true;
            dateTimePickerIda.Value = DateTime.Now;
            labelRegreso.Visible = false;
            dateTimePickerRegreso.Visible = false;
            comboBoxDestinos.Visible = false;
            labelDestino.Visible = false;
            checkBox1.Checked = false;
        }

        private void dateTimePickerIda_ValueChanged(object sender, EventArgs e)
        {
            //Establecer la fecha mínima de regreso en un día más que la de ida
            dateTimePickerRegreso.MinDate = dateTimePickerIda.Value.AddDays(1);
            dateTimePickerRegreso.Value = dateTimePickerIda.Value.AddDays(1);
        }
    }
}
