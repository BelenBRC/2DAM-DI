using System;
using System.Windows.Forms;

namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void password_TextChanged(object sender, EventArgs e)
        {
            //Cuando se escriba, deben aparecer los caracteres como asteriscos
            password.PasswordChar = '*';
        }

        private void cleanFields()
        {
            login.Text = "";
            password.Text = "";
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            //Este if debería acceder a la base de datos, comprobar si existe el usuario y si la contraseña corresponde a ese usuario
            //Para la prueba, lo simplificamos
            if (login.Text == "Laura" && password.Text == "hola")
            {
                MessageBox.Show("¡Bienvenid@, " + login.Text + "!", "Login correcto");
                cleanFields();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Login fallido");
                cleanFields();
            }
        }
    }
}
