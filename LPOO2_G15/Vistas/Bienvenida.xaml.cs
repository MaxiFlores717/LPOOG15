using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using ClasesBase;

namespace Vistas
{
    /// <summary>
    /// Interaction logic for Bienvenida.xaml
    /// </summary>
    public partial class Bienvenida : Window
    {
        public Bienvenida()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            //String sUserName = login.Usuario;
            //String sPassword = login.Contraseña;
            Admin admin = new Admin();
            Operador oper = new Operador();

            if (sUserName.Text == "Admin" && sPassword.Text == "admin")
            {
                MessageBox.Show("Inicio de sesión exitoso como Admin.");
                this.Close();
                admin.Show();
            }
            else if (sUserName.Text == "Operador" && sPassword.Text == "operador")
            {
                MessageBox.Show("Inicio de sesión exitoso como Operador.");
                this.Close();
                oper.Show();
            }
            else
            {
                MessageBox.Show("Credenciales incorrectas. Por favor, inténtelo de nuevo.");
            }
        }
    }
}

