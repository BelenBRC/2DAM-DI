using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MaterialSkin;
using MaterialSkin.Controls;

namespace MaterialDesign
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();

            // Creación del material theme manager y agregamos el formulario al manage (this)
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;

            // Configurar la paleta de colores
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue400, Primary.Blue500, Primary.Blue500,
                Accent.LightBlue200,
                TextShade.WHITE);
        }

        private void materialCheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
