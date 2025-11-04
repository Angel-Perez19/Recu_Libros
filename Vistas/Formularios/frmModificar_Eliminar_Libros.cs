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
    public partial class frmModificar_Eliminar_Libros : Form
    {
        public frmModificar_Eliminar_Libros()
        {
            InitializeComponent();
            MostrarLibros();
            CargarComboBoxEditoriales();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int libroId = Convert.ToInt32(dgvViztazoGeneral.CurrentRow.Cells["codigoLibro"].Value);
            string libroTitulo = dgvViztazoGeneral.CurrentRow.Cells["titulo"].Value.ToString();
            var confirmResult = MessageBox.Show($"¿Está seguro de que desea eliminar el libro '{libroTitulo}'?",
                                                 "Confirmar Eliminación",
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Warning);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    Libros libro = new Libros();
                    libro.CodigoLibro = libroId;
                    libro.EliminarLibro();
                    MessageBox.Show("Libro eliminado exitosamente.", "Éxito, SQL Si Furulo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTitulo.Clear();
                    msktxtAnio.Clear();
                    msktxtISBN.Clear();
                    cbEditoriales.SelectedIndex = -1;
                    MostrarLibros();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el libro: " + ex.Message, "Error, Culpa de SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void MostrarLibros()
        {
            dgvViztazoGeneral.DataSource = null;
            try
            {
                dgvViztazoGeneral.DataSource = Libros.MostrarLibros();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los libros: " + ex.Message, "Error, Culpa de SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }
        private void CargarComboBoxEditoriales()
        {
            try
            {
                cbEditoriales.DataSource = Libros.CargarEditoriales();
                cbEditoriales.DisplayMember = "nombre"; // Nombre
                cbEditoriales.ValueMember = "codigoEditorial";      //id
                cbEditoriales.SelectedIndex = -1; // Para que no seleccione nada al inicio
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar editoriales: " + ex.Message, "Error, Culpa de la base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //Si hay un error es culpa de SQL XD
            }
        }
        private void dgvViztazoGeneral_DoubleClick(object sender, EventArgs e)
        {
            if (dgvViztazoGeneral.CurrentRow != null)
            {
                txtTitulo.Text = dgvViztazoGeneral.CurrentRow.Cells["titulo"].Value.ToString();
                msktxtAnio.Text = dgvViztazoGeneral.CurrentRow.Cells["anioEdicion"].Value.ToString();
                msktxtISBN.Text = dgvViztazoGeneral.CurrentRow.Cells["ISBN"].Value.ToString();
                cbEditoriales.SelectedValue = Convert.ToInt32(dgvViztazoGeneral.CurrentRow.Cells["codigoEditorial"].Value);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitulo.Text) ||
                string.IsNullOrWhiteSpace(msktxtAnio.Text) ||
                string.IsNullOrWhiteSpace(msktxtISBN.Text) ||
                cbEditoriales.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, complete todos los campos antes de modificar el libro.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Libros libro = new Libros();
            libro.CodigoLibro = Convert.ToInt32(dgvViztazoGeneral.CurrentRow.Cells["codigoLibro"].Value);
            libro.Titulo = txtTitulo.Text;
            libro.AnioEdicion = Convert.ToInt32(msktxtAnio.Text);
            libro.ISBN1 = msktxtISBN.Text;
            libro.CodigoEditorial = Convert.ToInt32(cbEditoriales.SelectedValue);
            try
            {
                if (libro.ModificarLibro())
                {
                    MessageBox.Show("Libro modificado exitosamente.", "Éxito, SQL Si Furulo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MostrarLibros();
                    txtTitulo.Clear();
                    msktxtAnio.Clear();
                    msktxtISBN.Clear();
                    cbEditoriales.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show("Error al modificar el libro.", "Error, Culpa de SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error, Culpa de SQL" + ex , "Error Culpa de SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            frmGestionLibros Main = new frmGestionLibros();
            Main.Show();
            Main.FormClosed += (s, args) => this.Close();
            this.Hide();
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            Libros libro = new Libros();
            dgvViztazoGeneral.DataSource = Libros.BuscarLibroModif(txtBusqueda.Text);

        }
    }
}
