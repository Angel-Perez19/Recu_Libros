using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vistas.Formularios
{
    public partial class frmGestionAutores : Form
    {
        public frmGestionAutores()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregarAutores Main = new frmAgregarAutores();
            Main.Show();
            Main.FormClosed += (s, args) => this.Close();
            this.Hide();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            frmEliminarAutores Main = new frmEliminarAutores();
            Main.Show();
            Main.FormClosed += (s, args) => this.Close();
            this.Hide();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            frmBienvenida Main = new frmBienvenida();
            Main.Show();
            Main.FormClosed += (s, args) => this.Close();
            this.Hide();
        }
    }
}
