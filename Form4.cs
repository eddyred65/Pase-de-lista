using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pantalla_1_Login
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            // Obtener el correo ingresado
            string correo = txtCorreo.Text;

            // Validar si el correo está registrado en la base de datos
            if (CorreoRegistrado(correo))
            {
                // Enviar correo con la contraseña (implementar esta funcionalidad)
                EnviarCorreoContraseña(correo);

                // Redirigir a la pantalla 1 "login"
                PantallaLogin pantallaLogin = new PantallaLogin();
                pantallaLogin.Show();
                this.Hide();
            }
            else
            {
                // Mostrar mensaje de error si el correo no está registrado
                MessageBox.Show("No se encuentra el correo. Por favor, verifique e intente nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRetroceso_Click(object sender, EventArgs e)
        {
            // Redirigir a la pantalla 1 "login"
            PantallaLogin pantallaLogin = new PantallaLogin();
            pantallaLogin.Show();
            this.Hide();
        }
    }
}
