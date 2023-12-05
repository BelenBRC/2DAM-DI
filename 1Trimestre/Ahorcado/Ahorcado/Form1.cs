using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ahorcado
{
    public partial class Form1 : Form
    {
        private string palabraActual;
        private List<Label> labels;
        private string charDefecto = "__";
        private int oportunidades = 8;

        //Imágenes del ahorcado asociadas a oportunidades
        private Dictionary<int, Image> imagenes = new Dictionary<int, Image>()
        {
            { 8, Properties.Resources.Harry0 },
            { 7, Properties.Resources.Harry1 },
            { 6, Properties.Resources.Harry2 },
            { 5, Properties.Resources.Harry3 },
            { 4, Properties.Resources.Harry4 },
            { 3, Properties.Resources.Harry5 },
            { 2, Properties.Resources.Harry6 },
            { 1, Properties.Resources.Harry7 },
            { 0, Properties.Resources.HarryLose }
        };

        private Font harryPotter;
        private Font harryPotterPeque;
        public Form1()
        {
            InitializeComponent();
            InicializarFuente();

            labels = new List<Label>();

            //Ocultar panel de juego y de administrador
            panelJuego.Visible = false;
            panelAdministrador.Visible = false;

            //Establecer función a los botones
            establecerFuncionBotones();
        }

        private void InicializarFuente()
        {
            try
            {
                string ruta = Path.Combine(Environment.CurrentDirectory, "HARRYP_.TTF");
                harryPotter = new Font(new FontFamily("Harry P"), 25);
                harryPotterPeque = new Font(new FontFamily("Harry P"), 15);

                labelListaPalabras.Font = harryPotter;
                tituloJuego.Font = harryPotter;
                botonSalir.Font = harryPotter;
                buttonAdministrador.Font = harryPotter;
                buttonA.Font = harryPotter;
                buttonB.Font = harryPotter;
                buttonC.Font = harryPotter;
                buttonD.Font = harryPotter;
                buttonE.Font = harryPotter;
                buttonF.Font = harryPotter;
                buttonG.Font = harryPotter;
                buttonH.Font = harryPotter;
                buttonI.Font = harryPotter;
                buttonJ.Font = harryPotter;
                buttonK.Font = harryPotter;
                buttonL.Font = harryPotter;
                buttonM.Font = harryPotter;
                buttonN.Font = harryPotter;
                buttonÑ.Font = harryPotter;
                buttonO.Font = harryPotter;
                buttonP.Font = harryPotter;
                buttonQ.Font = harryPotter;
                buttonR.Font = harryPotter;
                buttonS.Font = harryPotter;
                buttonT.Font = harryPotter;
                buttonU.Font = harryPotter;
                buttonV.Font = harryPotter;
                buttonW.Font = harryPotter;
                buttonX.Font = harryPotter;
                buttonY.Font = harryPotter;
                buttonZ.Font = harryPotter;
         
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar la fuente");
                Application.Exit();
            }
        }

        //******************************** ACCIONES DE BOTONES ********************************//

        private void botonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            panelJuego.Visible = true;
            panelInicio.Visible = false;

            reestablecerControlesJuego();
        }

        private void buttonAdministrador_Click(object sender, EventArgs e)
        {
            panelAdministrador.Visible = true;
            panelInicio.Visible = false;
        }

        private void buttonVolverInicio_Click(object sender, EventArgs e)
        {
            panelInicio.Visible = true;
            panelJuego.Visible = false;
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            panelInicio.Visible = true;
            panelAdministrador.Visible = false;
        }

        private void botonSalir_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //******************************** PALABRAS ********************************//
        //Lee una palabra random del archivo de texto palabras.txt del directorio actual
        private void leerPalabra()
        {
            string ruta = Path.Combine(System.Environment.CurrentDirectory, "palabras.txt");
            using (TextReader lector = new StreamReader(ruta, Encoding.UTF8))
            {
                Random random = new Random();
                var allWords = lector.ReadToEnd().Split('\n');
                try
                {
                    palabraActual = allWords[random.Next(0, allWords.Length - 1)];
                    palabraActual = palabraActual.Trim().ToUpper();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo leer el archivo de palabras");
                }
            }
        }

        //Coloca la palabra en el label de la palabra a adivinar
        private void colocarPalabra()
        {
            groupBoxPalabraAdivinar.Controls.Clear();
            labels.Clear();
            try
            {
                char[] letras = palabraActual.ToCharArray();
                int longitud = letras.Length;
                int refer = groupBoxPalabraAdivinar.Width / longitud;

                for (int i = 0; i < longitud; i++)
                {
                    Label label = new Label();
                    label.Text = charDefecto;
                    label.Location = new Point(10 + i * refer, groupBoxPalabraAdivinar.Height - 30);
                    label.Parent = groupBoxPalabraAdivinar;
                    label.BringToFront();
                    labels.Add(label);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo colocar la palabra");
            }
        }

        //******************************** BOTONES DE LETRAS ********************************//
        private void buttonLetra_Click(object sender, EventArgs e)
        {
            Button letra = (Button)sender;
            char letraActual = letra.Text.ToCharArray()[0];
            letra.Enabled = false;
            letra.BackColor = Color.Gray;
            
            palabraActual = palabraActual.ToUpper();

            if (palabraActual.ToUpper().Contains(letraActual))
            {
                //TODO: Mostrar mensaje ¡Fantástico, Potter
                for (int i = 0; i < palabraActual.Length; i++)
                {
                    if (palabraActual[i] == letraActual)
                    {
                        labels[i].Text = letraActual.ToString();
                        labels[i].Font = harryPotterPeque;
                    }
                }

                //Comprobamos si se ha ganado
                bool ganado = true;
                foreach (Label label in labels)
                {
                    if (label.Text == charDefecto)
                    {
                        ganado = false;
                    }
                }

                if (ganado)
                {
                    MessageBox.Show("¡Fantástico, Potter!");
                    //TODO: Mostrar mensaje de victoria en un label
                    imagenAhorcado.Image = Properties.Resources.HarryWin;
                }
            }
            else
            {
                MessageBox.Show("Avada Kedavra");
                oportunidades--;
                imagenAhorcado.Image = imagenes[oportunidades];
                //TODO: Mostrar mensaje de hechizo de herida en función de oportunidades en un label

                if (oportunidades == 0)
                {
                    MessageBox.Show("¡Has perdido!");
                    imagenAhorcado.Image = Properties.Resources.HarryLose;

                    //Mostrar palabra
                    for (int i = 0; i < palabraActual.Length; i++)
                    {
                        labels[i].Text = palabraActual[i].ToString();
                        labels[i].Font = harryPotterPeque;
                    }
                }
            }
        }

        private void reestablecerControlesJuego()
        {
            //Activar todos los botones
            buttonA.Enabled = true;
            buttonB.Enabled = true;
            buttonC.Enabled = true;
            buttonD.Enabled = true;
            buttonE.Enabled = true;
            buttonF.Enabled = true;
            buttonG.Enabled = true;
            buttonH.Enabled = true;
            buttonI.Enabled = true;
            buttonJ.Enabled = true;
            buttonK.Enabled = true;
            buttonL.Enabled = true;
            buttonM.Enabled = true;
            buttonN.Enabled = true;
            buttonÑ.Enabled = true;
            buttonO.Enabled = true;
            buttonP.Enabled = true;
            buttonQ.Enabled = true;
            buttonR.Enabled = true;
            buttonS.Enabled = true;
            buttonT.Enabled = true;
            buttonU.Enabled = true;
            buttonV.Enabled = true;
            buttonW.Enabled = true;
            buttonX.Enabled = true;
            buttonY.Enabled = true;
            buttonZ.Enabled = true;

            //Reestablecer color de los botones
            buttonA.BackColor = Color.White;
            buttonB.BackColor = Color.White;
            buttonC.BackColor = Color.White;
            buttonD.BackColor = Color.White;
            buttonE.BackColor = Color.White;
            buttonF.BackColor = Color.White;
            buttonG.BackColor = Color.White;
            buttonH.BackColor = Color.White;
            buttonI.BackColor = Color.White;
            buttonJ.BackColor = Color.White;
            buttonK.BackColor = Color.White;
            buttonL.BackColor = Color.White;
            buttonM.BackColor = Color.White;
            buttonN.BackColor = Color.White;    
            buttonÑ.BackColor = Color.White;
            buttonO.BackColor = Color.White;
            buttonP.BackColor = Color.White;
            buttonQ.BackColor = Color.White;
            buttonR.BackColor = Color.White;
            buttonS.BackColor = Color.White;
            buttonT.BackColor = Color.White;
            buttonU.BackColor = Color.White;
            buttonV.BackColor = Color.White;
            buttonW.BackColor = Color.White;
            buttonX.BackColor = Color.White;
            buttonY.BackColor = Color.White;
            buttonZ.BackColor = Color.White;

            oportunidades = 8;

            //Reestablecer imagen
            imagenAhorcado.Image = Properties.Resources.Harry0;

            //Reestablecer palabra
            leerPalabra();
            colocarPalabra();
        }

        //Establecer a todos los botones la función buttonLetra_Click
        private void establecerFuncionBotones()
        {
            buttonA.Click += new EventHandler(buttonLetra_Click);
            buttonB.Click += new EventHandler(buttonLetra_Click);
            buttonC.Click += new EventHandler(buttonLetra_Click);
            buttonD.Click += new EventHandler(buttonLetra_Click);
            buttonE.Click += new EventHandler(buttonLetra_Click);
            buttonF.Click += new EventHandler(buttonLetra_Click);
            buttonG.Click += new EventHandler(buttonLetra_Click);
            buttonH.Click += new EventHandler(buttonLetra_Click);
            buttonI.Click += new EventHandler(buttonLetra_Click);
            buttonJ.Click += new EventHandler(buttonLetra_Click);
            buttonK.Click += new EventHandler(buttonLetra_Click);
            buttonL.Click += new EventHandler(buttonLetra_Click);
            buttonM.Click += new EventHandler(buttonLetra_Click);
            buttonN.Click += new EventHandler(buttonLetra_Click);
            buttonÑ.Click += new EventHandler(buttonLetra_Click);
            buttonO.Click += new EventHandler(buttonLetra_Click);
            buttonP.Click += new EventHandler(buttonLetra_Click);
            buttonQ.Click += new EventHandler(buttonLetra_Click);
            buttonR.Click += new EventHandler(buttonLetra_Click);
            buttonS.Click += new EventHandler(buttonLetra_Click);
            buttonT.Click += new EventHandler(buttonLetra_Click);
            buttonU.Click += new EventHandler(buttonLetra_Click);
            buttonV.Click += new EventHandler(buttonLetra_Click);
            buttonW.Click += new EventHandler(buttonLetra_Click);
            buttonX.Click += new EventHandler(buttonLetra_Click);
            buttonY.Click += new EventHandler(buttonLetra_Click);
            buttonZ.Click += new EventHandler(buttonLetra_Click);
        }

    }
}
