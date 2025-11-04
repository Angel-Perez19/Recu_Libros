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
    public partial class frmBienvenida : Form
    {
        public frmBienvenida()
        {
            InitializeComponent();
        }

        private void pnlLibro_MouseHover(object sender, EventArgs e)
        {
            pnlLibro.BackColor = Color.White;
        }

        private void pnlLibro_MouseLeave(object sender, EventArgs e)
        {
            pnlLibro.BackColor = Color.Transparent;
        }

        private void pnlAutores_MouseHover(object sender, EventArgs e)
        {
            pnlAutores.BackColor = Color.White;
        }

        private void pnlAutores_MouseLeave(object sender, EventArgs e)
        {
            pnlAutores.BackColor = Color.Transparent;
        }

        private void pbLibro_Click(object sender, EventArgs e)
        {
            frmGestionLibros Main = new frmGestionLibros();
            Main.Show();
            Main.FormClosed += (s, args) => this.Close();
            this.Hide();
        }

        private void lblLibros_Click(object sender, EventArgs e)
        {
            frmGestionLibros Main = new frmGestionLibros();
            Main.Show();
            Main.FormClosed += (s, args) => this.Close();
            this.Hide();
        }

        private void pnlLibro_Click(object sender, EventArgs e)
        {
            frmGestionLibros Main = new frmGestionLibros();
            Main.Show();
            Main.FormClosed += (s, args) => this.Close();
            this.Hide();
        }

        private void pbAutores_Click(object sender, EventArgs e)
        {
            frmGestionAutores Main = new frmGestionAutores();
            Main.Show();
            Main.FormClosed += (s, args) => this.Close();
            this.Hide();
        }

        private void lblAutores_Click(object sender, EventArgs e)
        {
            frmGestionAutores Main = new frmGestionAutores();
            Main.Show();
            Main.FormClosed += (s, args) => this.Close();
            this.Hide();
        }

        private void pnlAutores_Click(object sender, EventArgs e)
        {
            frmGestionAutores Main = new frmGestionAutores();
            Main.Show();
            Main.FormClosed += (s, args) => this.Close();
            this.Hide();
        }
    }
}
