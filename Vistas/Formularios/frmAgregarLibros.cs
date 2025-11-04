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
    public partial class frmAgregarLibros : Form
    {
        public frmAgregarLibros()
        {
            InitializeComponent();
            CargarComboBoxEditoriales();
            CargarComboBoxAutores();
            CargarVistazoGeneral();
        }

        private void CargarVistazoGeneral()
        {
            dgvViztazoGeneral.DataSource = null;
            try
            {
                dgvViztazoGeneral.DataSource = Libros.CargarVistazoGeneral();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el vistazo general de libros: " + ex.Message, "Error, Culpa de SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dgvMostrarLibroAgregado.DataSource = null;
            try
            {
                dgvMostrarLibroAgregado.DataSource = Libros.CargarVistazoGeneral();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el vistazo general de libros: " + ex.Message, "Error, Culpa de SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void CargarComboBoxAutores()
        {
            try
            {
                cbAutor.DataSource = Autores.CargarAutores();
                cbAutor.DisplayMember = "Nombre del Autor"; // Nombre
                cbAutor.ValueMember = "Numero de Autor";      //id
                cbAutor.SelectedIndex = -1; // Para que no seleccione nada al inicio
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar autores: " + ex.Message, "Error, Culpa de la base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //Si hay un error es culpa de SQL XD
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            frmGestionLibros Main = new frmGestionLibros();
            Main.Show();
            Main.FormClosed += (s, args) => this.Close();
            this.Hide();
        }

        private void btnRegresarMenuV2_Click(object sender, EventArgs e)
        {
            frmGestionLibros Main = new frmGestionLibros();
            Main.Show();
            Main.FormClosed += (s, args) => this.Close();
            this.Hide();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Validaciones
            if (txtTitulo.Text.Any(char.IsDigit))
            {
                MessageBox.Show("El título no puede contener números.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cbEditoriales.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, seleccione una editorial.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cbAutor.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, seleccione un autor.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dtpFecha.Value > DateTime.Now)
            {
                MessageBox.Show("La fecha no puede ser en el futuro.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtTitulo.Text) ||
                string.IsNullOrWhiteSpace(msktxtAnio.Text) ||
                string.IsNullOrWhiteSpace(msktxtISBN.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Crear instancia de Libros y asignar propiedades
            Libros libro = new Libros();
            libro.Titulo = txtTitulo.Text;
            libro.AnioEdicion = Convert.ToInt32(msktxtAnio.Text);
            libro.ISBN1 = msktxtISBN.Text;
            libro.CodigoEditorial = Convert.ToInt32(cbEditoriales.SelectedValue);
            libro.CodigoAutor = Convert.ToInt32(cbAutor.SelectedValue);
            libro.Fecha = dtpFecha.Value;

            // Insertar libro y obtener el ID
            int codigoLibro = libro.InsertarLibro();

            if (codigoLibro > 0)
            {
                // Ahora insertar en la segunda tabla con el ID obtenido
                if (libro.InsertarLibroINNERJOIN(codigoLibro))
                {
                    MessageBox.Show("Libro agregado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTitulo.Clear();
                    msktxtAnio.Clear();
                    msktxtISBN.Clear();
                    cbEditoriales.SelectedIndex = -1;
                    cbAutor.SelectedIndex = -1;
                    dtpFecha.Value = DateTime.Now;
                    CargarVistazoGeneral();
                }
                else
                {
                    MessageBox.Show("Error al agregar la relación con el autor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Error al agregar el libro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // BUSQUEDA
        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            string termino = txtBusqueda.Text.Trim();
            if (!string.IsNullOrEmpty(termino))
            {
                dgvViztazoGeneral.DataSource = Autores.BuscarAutor(termino);
            }
            else
            {
                CargarVistazoGeneral();
            }
        }
    }
}
