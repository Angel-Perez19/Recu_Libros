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
    }
}
