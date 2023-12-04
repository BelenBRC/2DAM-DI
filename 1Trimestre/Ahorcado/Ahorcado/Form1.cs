using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ahorcado
{
    public partial class Form1 : Form
    {
        private Font harryPotter;
        public Form1()
        {
            InitializeComponent();
            InicializarFuente();
        }

        private void InicializarFuente()
        {
            try
            {
                string ruta = Path.Combine(Environment.CurrentDirectory, "HARRYP_.TTF");
                harryPotter = new Font(new FontFamily("Harry P"), 25);
                labelListaPalabras.Font = harryPotter;
                tituloJuego.Font = harryPotter;
                buttonSalir.Font = harryPotter;
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

        private void botonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
