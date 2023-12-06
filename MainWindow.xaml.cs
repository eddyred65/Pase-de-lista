using System.Linq;
using System.Windows;

namespace TuProyecto
{
    public partial class Pantalla2 : Window
    {
        public Pantalla2()
        {
            InitializeComponent();
            InicializarComponentes();
        }

        private void InicializarComponentes()
        {
            // Inicializar eventos y otros componentes si es necesario
            btnCrearCuenta.Click += CrearCuenta_Click;
        }

        private void CrearCuenta_Click(object sender, RoutedEventArgs e)
        {
            if (ValidarCampos())
            {
                // Lógica para crear la cuenta y redirigir a la pantalla de login (Pantalla 1)
                // Puedes implementar el almacenamiento en la base de datos u otras acciones necesarias
                MessageBox.Show("Cuenta creada exitosamente");
                // Redirigir a la pantalla de login (Pantalla 1)
            //    Pantalla1 pantallaLogin = new Pantalla1();
                //pantallaLogin.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Error: Verifica que todos los campos estén llenos correctamente.");
            }
        }

        private bool ValidarCampos()
        {
            bool camposValidos = true;

            if (string.IsNullOrWhiteSpace(txtCorreo.Text) || !ValidarCorreo(txtCorreo.Text))
                camposValidos = false;

            if (string.IsNullOrWhiteSpace(txtNombreCompleto.Text) || !ValidarNombre(txtNombreCompleto.Text))
                camposValidos = false;

            if (string.IsNullOrWhiteSpace(txtContraseña.Password) || !ValidarContraseña(txtContraseña.Password))
                camposValidos = false;

            if (string.IsNullOrWhiteSpace(txtConfirmarContraseña.Password) || txtContraseña.Password != txtConfirmarContraseña.Password)
                camposValidos = false;

            return camposValidos;
        }

        private bool ValidarCorreo(string correo)
        {
            // Implementar lógica de validación de correo si es necesario
            // Este ejemplo es muy básico y solo verifica si contiene '@'
            return correo.Contains('@');
        }

        private bool ValidarNombre(string nombre)
        {
            // Implementar lógica de validación de nombre si es necesario
            // Este ejemplo es muy básico y solo verifica la longitud
            return nombre.Length <= 60;
        }

        private bool ValidarContraseña(string contraseña)
        {
            // Implementar lógica de validación de contraseña si es necesario
            // La contraseña debe contener caracteres alfanuméricos y sin espacios, con longitud de 8 a 12 caracteres
            return System.Text.RegularExpressions.Regex.IsMatch(contraseña, @"^[a-zA-Z0-9]{8,12}$");
        }
    }
}