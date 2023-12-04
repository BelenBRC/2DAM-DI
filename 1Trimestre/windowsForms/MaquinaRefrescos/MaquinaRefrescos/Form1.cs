using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaquinaRefrescos
{
    public partial class Form1 : Form
    {
        //Variables
        double precioCocaCola = 1.50, precioPepsiMax = 1.20, precioFantaNaranja = 1.50, precioFantaNaranjaZero = 1.20, precio7up = 1.50, precioNestea = 1.10, precioFantaLimon = 1.50, precioFantaLimonZero = 1.20;
        
        String mensajeBienvenida = "¡BIENVENIDO! SELECCIONE UN REFRESCO";
        String mensajeProductoSeleccionado = "PRODUCTO: ";
        String mensajeConfirmar = "PULSE INSERTAR MONEDAS PARA PAGAR";
        String mensajeInserteMonedas = "INSERTE MONEDAS: ";
        String mensajeRecojaSuCambio = "RECOJA SU CAMBIO";
        String mensajeRecojaSuProducto = "RECOJA SU PRODUCTO";
        String mensajeGracias = "¡GRACIAS POR SU COMPRA!";

        double dineroInsertado = 0.0, dineroRestante = 0.0;
        double valorMoneda2 = 2.00, valorMoneda1 = 1.00, valorMoneda50 = 0.50, valorMoneda20 = 0.20, valorMoneda10 = 0.10;
        Image imagenProducto;

        private void pictureBoxRefresco_Click(object sender, EventArgs e)
        {
            //Ocultamos la imagen del refresco
            pictureBoxRefresco.Visible = false;
            //Dar las gracias
            pantallaVending.Text = mensajeGracias;
            //Activar panel de refrescos
            activarSelectoresRefrescos();
            //Esperar 2 segundos
            System.Threading.Thread.Sleep(2000);
            pantallaVending.Text = mensajeBienvenida;
        }

        private void pictureBoxCambio_Click(object sender, EventArgs e)
        {
            //Ocultamos la imagen de cambio
            pictureBoxCambio.Visible = false;
            //Mostrar producto
            pictureBoxRefresco.Visible = true;
            //Mostrar mensaje de producto
            pantallaVending.Text = mensajeRecojaSuProducto;
        }

        private void desactivarSelectoresRefrescos()
        {
            selectorCocaCola.Enabled = false;
            selectorPepsiMax.Enabled = false;
            selectorFantaNaranja.Enabled = false;
            selectorFantaNaranjaZero.Enabled = false;
            selector7up.Enabled = false;
            selectorNestea.Enabled = false;
            selectorFantaLimon.Enabled = false;
            selectorFantaLimonZero.Enabled = false;
        }

        private void activarSelectoresRefrescos()
        {
            selectorCocaCola.Enabled = true;
            selectorPepsiMax.Enabled = true;
            selectorFantaNaranja.Enabled = true;
            selectorFantaNaranjaZero.Enabled = true;
            selector7up.Enabled = true;         
            selectorNestea.Enabled = true;
            selectorFantaLimon.Enabled = true;
            selectorFantaLimonZero.Enabled = true;
        }

        private void selectorCocaCola_Click(object sender, EventArgs e)
        {
            imagenProducto = Properties.Resources.lataCocaCola;
            confirmarProducto(mensajeProductoSeleccionado + "COCA-COLA  " + precioCocaCola + " €", precioCocaCola);
        }

        private void selectorPepsiMax_Click(object sender, EventArgs e)
        {
            imagenProducto = Properties.Resources.lataPepsi;
            confirmarProducto(mensajeProductoSeleccionado + "PEPSI MAX  " + precioPepsiMax + " €", precioPepsiMax);
        }

        private void selectorFantaNaranja_Click(object sender, EventArgs e)
        {
            imagenProducto = Properties.Resources.lataFantaNaranja;
            confirmarProducto(mensajeProductoSeleccionado + "FANTA NARANJA  " + precioFantaNaranja + " €", precioFantaNaranja);
        }

        private void selectorFantaNaranjaZero_Click(object sender, EventArgs e)
        {
            imagenProducto = Properties.Resources.lataFantaZero;
            confirmarProducto(mensajeProductoSeleccionado + "FANTA NARANJA ZERO  " + precioFantaNaranjaZero + " €", precioFantaNaranjaZero);
        }

        private void selector7up_Click(object sender, EventArgs e)
        {
            imagenProducto = Properties.Resources.lata7up;
            confirmarProducto(mensajeProductoSeleccionado + "7UP  " + precio7up + " €", precio7up);
        }

        private void selectorNestea_Click(object sender, EventArgs e)
        {
            imagenProducto = Properties.Resources.lataNestea;
            confirmarProducto(mensajeProductoSeleccionado + "NESTEA  " + precioNestea + " €", precioNestea);
        }

        private void selectorFantaLimon_Click(object sender, EventArgs e)
        {
            imagenProducto = Properties.Resources.lataFantaLimon;
            confirmarProducto(mensajeProductoSeleccionado + "FANTA LIMÓN  " + precioFantaLimon + " €", precioFantaLimon);
        }

        private void selectorFantaLimonZero_Click(object sender, EventArgs e)
        {
            imagenProducto = Properties.Resources.lataFantaLimonZero;
            confirmarProducto(mensajeProductoSeleccionado + "FANTA LIMÓN ZERO  " + precioFantaLimonZero + " €", precioFantaLimonZero);
        }

        private void comprobarDeuda()
        {
            if (dineroRestante > 0.0)
            {
                pantallaVending.Text = mensajeInserteMonedas + dineroRestante.ToString("N2") + " €";
            }
            else
            {
                //Ocultar panel de monedas
                panelMonedas.Visible = false;

                if (dineroRestante < -0.01)
                {
                    //Mostrar mensaje de cambio
                    pantallaVending.Text = mensajeRecojaSuCambio + "\n" + (-dineroRestante).ToString("N2") + " €";
                    pictureBoxCambio.Visible = true;
                }
                else
                {
                    //Mostrar mensaje de producto
                    pantallaVending.Text = mensajeRecojaSuProducto;
                    pictureBoxRefresco.Visible = true;
                }

                dineroRestante = 0.0;
                dineroInsertado = 0.0;
            }
        }

        private void pictureBoxMoneda10_Click(object sender, EventArgs e)
        {
            dineroInsertado += valorMoneda10;
            dineroRestante -= valorMoneda10;
            comprobarDeuda();
            
        }

        private void pictureBoxMoneda20_Click(object sender, EventArgs e)
        {
            dineroInsertado += valorMoneda20;
            dineroRestante -= valorMoneda20;
            comprobarDeuda();
        }

        private void pictureBoxMoneda50_Click(object sender, EventArgs e)
        {
            dineroInsertado += valorMoneda50;
            dineroRestante -= valorMoneda50;
            comprobarDeuda();
        }

        private void pictureBoxMoneda1_Click(object sender, EventArgs e)
        {
            dineroInsertado += valorMoneda1;
            dineroRestante -= valorMoneda1;
            comprobarDeuda();
        }

        private void pictureBoxMoneda2_Click(object sender, EventArgs e)
        {
            dineroInsertado += valorMoneda2;
            dineroRestante -= valorMoneda2;
            comprobarDeuda();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelMonedas.Visible = true;
            //Desactivar panel de refrescos
            desactivarSelectoresRefrescos();
            //Mensaje de inserte monedas
            pantallaVending.Text = mensajeInserteMonedas + dineroRestante + " €";
            //Desactivar el botón de insertar monedas
            buttonInsertCoin.Enabled = false;
        }

        public Form1()
        {
            InitializeComponent();

            // Configuración para que se inicie en pantalla completa
            this.WindowState = FormWindowState.Maximized;
            //this.FormBorderStyle = FormBorderStyle.None; // Oculta el borde del formulario

            //Establecer el precio de cada producto
            labelPrecioCocaCola.Text = precioCocaCola.ToString() + " €";
            labelPrecioPepsi.Text = precioPepsiMax.ToString() + " €";
            labelPrecioFantaNaranja.Text = precioFantaNaranja.ToString() + " €";
            labelPrecioFantaNaranjaZero.Text = precioFantaNaranjaZero.ToString() + " €";
            labelPrecio7up.Text = precio7up.ToString() + " €";
            labelPrecioNestea.Text = precioNestea.ToString() + " €";
            labelPrecioFantaLimon.Text = precioFantaLimon.ToString() + " €";
            labelPrecioFantaLimonZero.Text = precioFantaLimonZero.ToString() + " €";

            //Establecer el mensaje de bienvenida
            pantallaVending.Text = mensajeBienvenida;

            //Activar panel de refrescos
            panelRefrescos.Enabled = true;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonInsertCoin_Click(object sender, EventArgs e)
        {

        }

        

        private void confirmarProducto(String mensajeProducto, double precioProducto)
        {
            //Establecer la imagen del producto
            pictureBoxRefresco.Image = imagenProducto;

            //Establecer el precio del producto
            dineroInsertado = 0.0;
            dineroRestante = precioProducto;
            buttonInsertCoin.Enabled = true;

            //Mostrar mensaje confirmacion
            pantallaVending.Text = mensajeProducto + "\n" + mensajeConfirmar;
        }
    }
}
