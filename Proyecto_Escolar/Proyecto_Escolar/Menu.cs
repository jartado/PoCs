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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        public bool UsuarioLogueado = false;

        private void Menu_Load_1(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
            if (login.logueado == true)
            {
                this.Show();
                UsuarioLogueado = true;
            }
            else
            {
                this.Close();
            }
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (UsuarioLogueado == true)
            {
                DialogResult respuesta;
                respuesta = MessageBox.Show("Desea salir?", "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
