using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_Escolar.Clases;

namespace Proyecto_Escolar
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public bool logueado = false;

        private void button1_Click(object sender, EventArgs e)
        {
            string resultado = Datos.IniciarSesion(txtNombre.Text, txtContrasena.Text);
            if (resultado != "")
            {
                logueado = true;
                MessageBox.Show("Bienvenido", "Mensaje", MessageBoxButtons.OK);
                this.Close();
            }
            else
            {
                MessageBox.Show("Acceso denegado, inténtelo nuevamente", "Error", MessageBoxButtons.OK);
                txtNombre.Text = "";
                txtContrasena.Text = "";
                txtNombre.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
