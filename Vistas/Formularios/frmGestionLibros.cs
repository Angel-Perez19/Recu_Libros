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
    public partial class frmGestionLibros : Form
    {
        public frmGestionLibros()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregarLibros Main = new frmAgregarLibros();
            Main.Show();
            Main.FormClosed += (s, args) => this.Close();
            this.Hide();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            frmModificar_Eliminar_Libros Main = new frmModificar_Eliminar_Libros();
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
