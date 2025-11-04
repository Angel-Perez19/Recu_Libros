using Modelos.Entidades;
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
    public partial class frmEliminarAutores : Form
    {
        public frmEliminarAutores()
        {
            InitializeComponent();
            MostrarAutores();
        }
        private void MostrarAutores()
        {
            dgvVisor.DataSource = null;
            try
            {
                dgvVisor.DataSource = Autores.CargarAutores();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los autores: " + ex.Message, "Error, Culpa de SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }
        private void dgvVisor_DoubleClick(object sender, EventArgs e)
        {
            if (dgvVisor.CurrentRow != null)
            {
                int autorId = Convert.ToInt32(dgvVisor.CurrentRow.Cells["Numero de Autor"].Value);
                string autorNombre = dgvVisor.CurrentRow.Cells["Nombre del Autor"].Value.ToString();
                var confirmResult = MessageBox.Show($"¿Está seguro de que desea eliminar al autor '{autorNombre}'?", 
                                                     "Confirmar Eliminación", 
                                                     MessageBoxButtons.YesNo, 
                                                     MessageBoxIcon.Warning);
                if (confirmResult == DialogResult.Yes)
                {
                    try
                    {
                        Autores autor = new Autores();
                        autor.CodigoAutor = autorId;
                        autor.EliminarAutor();
                        MessageBox.Show("Autor eliminado exitosamente.", "Éxito, SQL Si Furulo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MostrarAutores();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar el autor: " + ex.Message, "Error, Culpa de SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
