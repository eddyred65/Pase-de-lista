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
    public partial class PantallaLogin : Form
    {
        public PantallaLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnIniciarsesion_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contraseña = txtContraseña.Text;

            if (!string.IsNullOrEmpty(usuario) && !string.IsNullOrEmpty(contraseña))
            {
                // Verificar las credenciales (puedes conectar con una base de datos)
                if (VerificarCredenciales(usuario, contraseña))
                {
                    // Credenciales correctas, redirigir a la pantalla 4
                    Pantalla4 pantalla4 = new Pantalla4();
                    pantalla4.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Credenciales incorrectas. Inténtelo de nuevo.");
                }
            }
            else
            {
                MessageBox.Show("Ingrese tanto el usuario como la contraseña.");
            }

        }

        private void txtcontraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            // Redirigir a la pantalla 2 (Crear Cuenta)
            PantallaCrearCuenta pantallaCrearCuenta = new PantallaCrearCuenta();
            pantallaCrearCuenta.Show();
            this.Hide();
        }
        private bool VerificarCredenciales(string usuario, string contraseña)
        {
            // Lógica para verificar las credenciales (puedes conectar con una base de datos)
            // Devuelve true si las credenciales son válidas, de lo contrario, false.
            // Aquí debes implementar tu propia lógica de autenticación.
            // Por ejemplo, podrías tener una clase de servicio que maneje la autenticación.
            // Esta es solo una implementación de ejemplo, no debe usarse en un entorno de producción.

            // ¡Asegúrate de implementar correctamente la lógica de verificación de credenciales!
            return (usuario == "usuario" && contraseña == "contraseña");
        }

        private void btnRecuperarContraeña_Click(object sender, EventArgs e)
        {

        }
    }
}
