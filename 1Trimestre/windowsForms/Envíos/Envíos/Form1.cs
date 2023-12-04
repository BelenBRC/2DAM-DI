using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Envíos
{
    public partial class EnviosLayout : Form
    {
        public double precioCN = 0, precioPN = 2.5, precioPU = 5.15;

        public EnviosLayout()
        {
            InitializeComponent();
            setPrecioEtiquetas();
        }

        public void setPrecioEtiquetas()
        {
            labelPrecioCN.Text = precioCN.ToString() + " €";
            labelPrecioPN.Text = precioPN.ToString() + " €";
            labelPrecioPU.Text = precioPU.ToString() + " €";
        }

        private void buttonConfirmar_Click(object sender, EventArgs e)
        {
            String precioEnvio = "";
            String detallesContacto = "\n\nSe le notificará a través de:\n";

            //Guardar el precio del envío seleccionado
            if(radioButtonCN.Checked)
            {
                precioEnvio = labelPrecioCN.Text;
            }
            else if(radioButtonPN.Checked)
            {
                precioEnvio = labelPrecioPN.Text;
            }
            else if(radioButtonPU.Checked)
            {
                precioEnvio = labelPrecioPU.Text;
            }

            //Comprobar que haya al menos un checkbox seleccionado
            if(checkBoxEmail.Checked == false && checkBoxFax.Checked == false && checkBoxTelefono.Checked == false)
            {
                MessageBox.Show("Seleccione al menos un método de contacto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Comprobar que se ha introducido la información en los campos de texto de los checkbox seleccionados
                bool datosIntroducidos = true;
                if(checkBoxFax.Checked)
                {
                    if(textBoxFax.Text == "")
                    {
                        datosIntroducidos = false;
                    }
                    else
                    {
                        detallesContacto += "\tFax: " + textBoxFax.Text + "\n";
                    }
                }
                if(checkBoxTelefono.Checked)
                {
                    if(textBoxTelefono.Text == "")
                    {
                        datosIntroducidos = false;
                    }
                    else
                    {
                        detallesContacto += "\tTeléfono: " + textBoxTelefono.Text + "\n";
                    }
                }
                if(checkBoxEmail.Checked == true)
                {
                    if(textBoxEmail.Text == "")
                    {
                        datosIntroducidos = false;
                    }
                    else
                    {
                        detallesContacto += "\tEmail: " + textBoxEmail.Text + "\n";
                    }
                }

                if (!datosIntroducidos)
                {
                    MessageBox.Show("Introduzca la información de contacto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //Pedido exitoso
                    String infoEnvio = "Información de envío:\n\nSu pedido tendrá un coste adicional de " + precioEnvio + detallesContacto ;
                    MessageBox.Show(infoEnvio, "Pedido realizado con éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
            }
        }

        private void checkBoxTelefono_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxTelefono.Checked == true)
            {
                textBoxTelefono.Visible = true;
            }
            else
            {
                textBoxTelefono.Visible = false;
            }
        }

        private void checkBoxFax_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxFax.Checked == true)
            {
                textBoxFax.Visible = true;
            }
            else
            {
                textBoxFax.Visible = false;
            }
        }

        private void checkBoxEmail_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxEmail.Checked == true)
            {
                textBoxEmail.Visible = true;
            }
            else
            {
                textBoxEmail.Visible = false;
            }
        }
    }
}
