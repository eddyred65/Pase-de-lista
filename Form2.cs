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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            // Obtener valores de los campos
            string correo = txtCorreo.Text;
            string nombreCompleto = txtNombreCompleto.Text;
            string contraseña = txtContraseña.Text;
            string confirmarContraseña = txtConfirmarContraseña.Text;

            // Validar campos
            if (ValidarCampos(correo, nombreCompleto, contraseña, confirmarContraseña))
            {
            
                PantallaLogin pantallaLogin = new PantallaLogin();
                pantallaLogin.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Por favor, complete todos los campos correctamente.");
            }
        }

        private void btnRetroceso_Click(object sender, EventArgs e)
        {
            // Redirigir a la pantalla de inicio de sesión (pantalla 1)
            PantallaLogin pantallaLogin = new PantallaLogin();
            pantallaLogin.Show();
            this.Hide();
        }

        private bool ValidarCampos(string correo, string nombreCompleto, string contraseña, string confirmarContraseña)
        {
            // Implementar lógica de validación según los requerimientos
        

            // Validar formato de correo
            if (!ValidarFormatoCorreo(correo))
            {
                MessageBox.Show("El formato de correo no es válido.");
                return false;
            }

            // Validar longitud de nombre completo
            if (nombreCompleto.Length > 60)
            {
                MessageBox.Show("El nombre completo no debe superar los 60 caracteres.");
                return false;
            }

            // Validar formato y longitud de contraseña
            if (!ValidarFormatoContraseña(contraseña))
            {
                MessageBox.Show("La contraseña no cumple con los requisitos.");
                return false;
            }

            // Validar coincidencia de contraseñas
            if (contraseña != confirmarContraseña)
            {
                MessageBox.Show("Las contraseñas no coinciden.");
                return false;
            }

            // Todos los campos son válidos
            return true;
        }
    }
}
