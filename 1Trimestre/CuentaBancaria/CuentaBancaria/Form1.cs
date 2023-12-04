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

namespace CuentaBancaria
{
    public partial class Form1 : Form
    {
        Cuenta cuentaCorriente1 = new Cuenta("ES12 9834 2345 84 1134509856", "Juan Romero Casado", 1000, 3);
        Cuenta cuentaCorriente2 = new Cuenta("ES21 9878 2356 93 7896534258", "María López Pérez", 25789.24, 2);
        Cuenta cuentaCorriente3 = new Cuenta("ES67 8752 1456 25 9678451235", "Noemí Burgueño Ríos", 148.78, 3);
        Cuenta cuentaCorriente4 = new Cuenta("ES94 3829 1839 32 1859487758", "Javier García López", 1345, 2.5);
        Cuenta cuentaCorriente5 = new Cuenta("ES12 4564 3444 22 3422433242", "Laura Ruiz Socas", 7895.75, 1.5);

        Cuenta_Ahorro cuentaAhorro1 = new Cuenta_Ahorro("ES87 9876 2345 12 1234567890", "Pedro Martínez López", 5012.13, 1.5, 10);
        Cuenta_Ahorro cuentaAhorro2 = new Cuenta_Ahorro("ES98 6724 1538 97 4863297518", "Ana García Pérez", 10230, 2, 5);
        Cuenta_Ahorro cuentaAhorro3 = new Cuenta_Ahorro("ES65 9878 2356 93 7896534258", "María López Pérez", 25789.24, 2, 10);
        Cuenta_Ahorro cuentaAhorro4 = new Cuenta_Ahorro("ES78 9123 4567 89 1234567890", "Roberto Iniesta Boza", 7894.01, 3, 4.5);
        Cuenta_Ahorro cuentaAhorro5 = new Cuenta_Ahorro("E62 4556 7664 22 97656433234", "Tomás Valero Lara", 97.45, 5, 12);

        ArrayList cuentasCorrientes = new ArrayList();
        ArrayList cuentasAhorro = new ArrayList();
        
        bool aniadirCuenta = false;


        public Form1()
        {
            InitializeComponent();

            //Colocar en el combobox los números de cuenta corriente
            comboBoxCuenta.Items.Add(cuentaCorriente1.getNumCuenta());
            comboBoxCuenta.Items.Add(cuentaCorriente2.getNumCuenta());
            comboBoxCuenta.Items.Add(cuentaCorriente3.getNumCuenta());
            comboBoxCuenta.Items.Add(cuentaCorriente4.getNumCuenta());
            comboBoxCuenta.Items.Add(cuentaCorriente5.getNumCuenta());

            //Añadir a los arrays las cuentas corrientes
            cuentasCorrientes.Add(cuentaCorriente1);
            cuentasCorrientes.Add(cuentaCorriente2);
            cuentasCorrientes.Add(cuentaCorriente3);
            cuentasCorrientes.Add(cuentaCorriente4);
            cuentasCorrientes.Add(cuentaCorriente5);

            cuentasAhorro.Add(cuentaAhorro1);
            cuentasAhorro.Add(cuentaAhorro2);
            cuentasAhorro.Add(cuentaAhorro3);
            cuentasAhorro.Add(cuentaAhorro4);
            cuentasAhorro.Add(cuentaAhorro5);

            //Colocar en el combobox los números de cuenta corriente
            insertarDatosCuentaCorrienteCombobox();
        }

        private void insertarDatosCuentaCorrienteCombobox()
        {
            comboBoxCuenta.Items.Clear();
            for (int i = 0; i < cuentasCorrientes.Count; i++)
            {
                comboBoxCuenta.Items.Add(((Cuenta)cuentasCorrientes[i]).getNumCuenta());
            }
        }

        private void insertarDatosCuentaAhorroCombobox()
        {
            comboBoxCuenta.Items.Clear();
            for (int i = 0; i < cuentasAhorro.Count; i++)
            {
                comboBoxCuenta.Items.Add(((Cuenta_Ahorro)cuentasAhorro[i]).getNumCuenta());
            }
        }

        private void cambiarDatosComboBox()
        {
            //Vaciar los datos
            labelCampoNumeroCuenta.Text = "";
            labelCampoTitularCuenta.Text = "";
            labelCampoSaldoCuenta.Text = "";
            labelCampoTipoInteres.Text = "";
            labelCampoCuotaMantenimiento.Text = "";


            if (!aniadirCuenta)
            {
                if (radioButtonCuentaCorriente.Checked)
                {
                    insertarDatosCuentaCorrienteCombobox();
                    //Ocultar label cuota mantenimiento
                    labelCuotaMantenimiento.Visible = false;
                    labelCampoCuotaMantenimiento.Visible = false;
                }
                else
                {
                    insertarDatosCuentaAhorroCombobox();
                    //Mostrar label cuota mantenimiento
                    labelCuotaMantenimiento.Visible = true;
                    labelCampoCuotaMantenimiento.Visible = true;
                }
            }
            else if (aniadirCuenta)
            {
                //Ocultar pictureBox
                pictureBoxCuentaCorriente.Visible = false;
                pictureBoxCuentaAhorro.Visible = false;

                if(radioButtonCuentaCorriente.Checked)
                {
                    //Ocultar label cuota mantenimiento
                    labelCuotaMantenimiento.Visible = false;
                    textBoxCuotaMantenimiento.Visible = false;
                    //Mostrar pictureBox
                    pictureBoxCuentaCorriente.Visible = true;
                }
                else
                {
                    //Mostrar label cuota mantenimiento
                    labelCuotaMantenimiento.Visible = true;
                    textBoxCuotaMantenimiento.Visible = true;
                    //Mostrar pictureBox
                    pictureBoxCuentaAhorro.Visible = true;
                }
            }
            
        }

        private void radioButtonCuentaCorriente_CheckedChanged(object sender, EventArgs e)
        {
            cambiarDatosComboBox();
        }

        private void radioButtonCuentaAhorro_CheckedChanged(object sender, EventArgs e)
        {
            cambiarDatosComboBox();
        }

        private void comboBoxCuenta_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //Colocar los datos de la cuenta seleccionada en los textbox
            if (radioButtonCuentaCorriente.Checked)
            {
                //Buscar la cuenta corriente seleccionada
                for (int i = 0; i < cuentasCorrientes.Count; i++)
                {
                    if (((Cuenta)cuentasCorrientes[i]).getNumCuenta() == comboBoxCuenta.SelectedItem.ToString())
                    {
                        //Colocar los datos de la cuenta en los textbox
                        labelCampoNumeroCuenta.Text = ((Cuenta)cuentasCorrientes[i]).getNumCuenta();
                        labelCampoTitularCuenta.Text = ((Cuenta)cuentasCorrientes[i]).getNombre();
                        labelCampoSaldoCuenta.Text = ((Cuenta)cuentasCorrientes[i]).getSaldo().ToString() + " €";
                        labelCampoTipoInteres.Text = ((Cuenta)cuentasCorrientes[i]).getTipoInteres().ToString() + " %";
                    }
                }
            }
            else
            {
                //Buscar la cuenta de ahorros seleccionada
                for (int i = 0; i < cuentasAhorro.Count; i++)
                {
                    if (((Cuenta_Ahorro)cuentasAhorro[i]).getNumCuenta() == comboBoxCuenta.SelectedItem.ToString())
                    {
                        //Colocar los datos de la cuenta en los textbox
                        labelCampoNumeroCuenta.Text = ((Cuenta_Ahorro)cuentasAhorro[i]).getNumCuenta();
                        labelCampoTitularCuenta.Text = ((Cuenta_Ahorro)cuentasAhorro[i]).getNombre();
                        labelCampoSaldoCuenta.Text = ((Cuenta_Ahorro)cuentasAhorro[i]).getSaldo().ToString() + " €";
                        labelCampoTipoInteres.Text = ((Cuenta_Ahorro)cuentasAhorro[i]).getTipoInteres().ToString() + " %";
                        labelCampoCuotaMantenimiento.Text = ((Cuenta_Ahorro)cuentasAhorro[i]).getCuotaMantenimiento().ToString() + " €";
                    }
                }
            }
        }

        private void buttonAniadirCuenta_Click(object sender, EventArgs e)
        {
            aniadirCuenta = true;

            //Ocultar labelsCampo y mostar textBox
            labelCampoNumeroCuenta.Visible = false;
            labelCampoTitularCuenta.Visible = false;
            labelCampoSaldoCuenta.Visible = false;
            labelCampoTipoInteres.Visible = false;
            labelCampoCuotaMantenimiento.Visible = false;

            textBoxNumeroCuenta.Visible = true;
            textBoxTitularCuenta.Visible = true;
            textBoxSaldoCuenta.Visible = true;
            textBoxTipoInteres.Visible = true;
            
            if(radioButtonCuentaAhorro.Checked)
            {
                labelCuotaMantenimiento.Visible = true;
                textBoxCuotaMantenimiento.Visible = true;
                //Mostrr pictureBox
                pictureBoxCuentaAhorro.Visible = true;
            }
            else
            {
                pictureBoxCuentaCorriente.Visible = true;
            }

            //Ocultar botón añadir cuenta y mostrar botón guardar cuenta y cancelar cuenta
            buttonAniadirCuenta.Visible = false;
            buttonGuardar.Visible = true;
            buttonCancelar.Visible = true;

            //Ocultar combobox label
            labelSeleccioneCuenta.Visible = false;
            comboBoxCuenta.Visible = false;
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            bool correcto = true;

            //Comprobar que los textbox no estén vacíos
            if (textBoxNumeroCuenta.Text.Trim().Equals(""))
            {
                MessageBox.Show("El número de cuenta no puede estar vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                correcto = false;
            }
            else if (textBoxTitularCuenta.Text.Trim().Equals(""))
            {
                MessageBox.Show("El titular de la cuenta no puede estar vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                correcto = false;
            }
            else if (textBoxSaldoCuenta.Text.Trim().Equals(""))
            {
                MessageBox.Show("El saldo de la cuenta no puede estar vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                correcto = false;
            }
            else if (textBoxTipoInteres.Text.Trim().Equals(""))
            {
                MessageBox.Show("El tipo de interés de la cuenta no puede estar vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                correcto = false;
            }
            else if(radioButtonCuentaAhorro.Checked && textBoxCuotaMantenimiento.Text.Trim().Equals(""))
            {
                MessageBox.Show("La cuota de mantenimiento de la cuenta no puede estar vacía", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                correcto = false;
            }

            //Comprobar que el número de cuenta no esté repetido en el tipo de cuenta seleccionado
            if (radioButtonCuentaCorriente.Checked)
            {
                for (int i = 0; i < cuentasCorrientes.Count; i++)
                {
                    if (((Cuenta)cuentasCorrientes[i]).getNumCuenta() == textBoxNumeroCuenta.Text.Trim())
                    {
                        MessageBox.Show("El número de cuenta ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        correcto = false;
                    }
                }
            }
            else
            {
                for (int i = 0; i < cuentasAhorro.Count; i++)
                {
                    if (((Cuenta_Ahorro)cuentasAhorro[i]).getNumCuenta() == textBoxNumeroCuenta.Text.Trim())
                    {
                        MessageBox.Show("El número de cuenta ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        correcto = false;
                    }
                }
            }

            //Comprobar que los datos numéricos sean correctos
            if (correcto)
            {
                try
                {
                    double saldo = Convert.ToDouble(textBoxSaldoCuenta.Text.Trim());
                    double tipoInteres = Convert.ToDouble(textBoxTipoInteres.Text.Trim());
                    double cuotaMantenimiento = 0;
                    if (radioButtonCuentaAhorro.Checked)
                    {
                        cuotaMantenimiento = Convert.ToDouble(textBoxCuotaMantenimiento.Text.Trim());
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Los datos numéricos deben ser números", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    correcto = false;
                }

                //Comprobar que los intereses y la cuota de mantenimiento sean positivos
                if (Convert.ToDouble(textBoxTipoInteres.Text.Trim()) < 0)
                {
                    MessageBox.Show("El tipo de interés debe ser positivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    correcto = false;
                }
                else if (radioButtonCuentaAhorro.Checked && Convert.ToDouble(textBoxCuotaMantenimiento.Text.Trim()) < 0)
                {
                    MessageBox.Show("La cuota de mantenimiento debe ser positiva", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    correcto = false;
                }
            }

            //Si los datos son correctos
            if (correcto)
            {
                //Comprobar en los campos numéricos y cambiar . por ,
                textBoxSaldoCuenta.Text = textBoxSaldoCuenta.Text.Replace('.', ',');
                textBoxTipoInteres.Text = textBoxTipoInteres.Text.Replace('.', ',');
                textBoxCuotaMantenimiento.Text = textBoxCuotaMantenimiento.Text.Replace('.', ',');

                //Comprobar qué tipo de cuenta es
                if(radioButtonCuentaCorriente.Checked)
                {
                    //Crear la cuenta corriente
                    Cuenta cuentaCorriente = new Cuenta(textBoxNumeroCuenta.Text.Trim(), textBoxTitularCuenta.Text.Trim(), Convert.ToDouble(textBoxSaldoCuenta.Text.Trim()), Convert.ToDouble(textBoxTipoInteres.Text.Trim()));
                    //Añadir la cuenta corriente al array
                    cuentasCorrientes.Add(cuentaCorriente);
                }
                else
                {
                    //Crear la cuenta de ahorro
                    Cuenta_Ahorro cuentaAhorro = new Cuenta_Ahorro(textBoxNumeroCuenta.Text.Trim(), textBoxTitularCuenta.Text.Trim(), Convert.ToDouble(textBoxSaldoCuenta.Text.Trim()), Convert.ToDouble(textBoxTipoInteres.Text.Trim()), Convert.ToDouble(textBoxCuotaMantenimiento.Text.Trim()));
                    //Añadir la cuenta de ahorro al array
                    cuentasAhorro.Add(cuentaAhorro);
                }

                //Vaciar los textbox
                textBoxNumeroCuenta.Text = "";
                textBoxTitularCuenta.Text = "";
                textBoxSaldoCuenta.Text = "";
                textBoxTipoInteres.Text = "";
                textBoxCuotaMantenimiento.Text = "";

                //Ocultar los textbox y mostrar los labelCampo
                labelCampoNumeroCuenta.Visible = true;
                labelCampoTitularCuenta.Visible = true;
                labelCampoSaldoCuenta.Visible = true;
                labelCampoTipoInteres.Visible = true;
                labelCampoCuotaMantenimiento.Visible = true;

                textBoxNumeroCuenta.Visible = false;
                textBoxTitularCuenta.Visible = false;
                textBoxSaldoCuenta.Visible = false;
                textBoxTipoInteres.Visible = false;
                textBoxCuotaMantenimiento.Visible = false;

                //Ocultar pictureBox
                pictureBoxCuentaCorriente.Visible = false;
                pictureBoxCuentaAhorro.Visible = false;

                //Mostrar botón añadir cuenta y ocultar botón guardar cuenta y cancelar cuenta
                buttonAniadirCuenta.Visible = true;
                buttonGuardar.Visible = false;
                buttonCancelar.Visible = false;

                //Mostrar combobox label
                labelSeleccioneCuenta.Visible = true;
                comboBoxCuenta.Visible = true;

                aniadirCuenta = false;
            }
            
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            //Vaciar los textbox
            textBoxNumeroCuenta.Text = "";
            textBoxTitularCuenta.Text = "";
            textBoxSaldoCuenta.Text = "";
            textBoxTipoInteres.Text = "";
            textBoxCuotaMantenimiento.Text = "";

            //Ocultar los textbox y mostrar los labelCampo
            labelCampoNumeroCuenta.Visible = true;
            labelCampoTitularCuenta.Visible = true;
            labelCampoSaldoCuenta.Visible = true;
            labelCampoTipoInteres.Visible = true;
            labelCampoCuotaMantenimiento.Visible = true;

            textBoxNumeroCuenta.Visible = false;
            textBoxTitularCuenta.Visible = false;
            textBoxSaldoCuenta.Visible = false;
            textBoxTipoInteres.Visible = false;
            textBoxCuotaMantenimiento.Visible = false;

            //Ocultar pictureBox
            pictureBoxCuentaCorriente.Visible = false;
            pictureBoxCuentaAhorro.Visible = false;

            //Mostrar botón añadir cuenta y ocultar botón guardar cuenta y cancelar cuenta
            buttonAniadirCuenta.Visible = true;
            buttonGuardar.Visible = false;
            buttonCancelar.Visible = false;

            //Mostrar combobox label
            labelSeleccioneCuenta.Visible = true;
            comboBoxCuenta.Visible = true;

            aniadirCuenta = false;
        }
    }
}
