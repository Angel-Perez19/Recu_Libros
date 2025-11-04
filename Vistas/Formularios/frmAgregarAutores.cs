using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelos.Entidades;

namespace Vistas.Formularios
{
    public partial class frmAgregarAutores : Form
    {
        public frmAgregarAutores()
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

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            frmGestionAutores Main = new frmGestionAutores();
            Main.Show();
            Main.FormClosed += (s, args) => this.Close();
            this.Hide();
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            txtNacionalidad.Clear();
            txtNombre.Clear();
            dtpFechaNacimiento.Value = DateTime.Now;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Any(char.IsDigit))
            {
                MessageBox.Show("El nombre no puede contener números.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtNacionalidad.Text.Any(char.IsDigit))
            {
                MessageBox.Show("La nacionalidad no puede contener números.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtNacionalidad.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dtpFechaNacimiento.Value > DateTime.Now)
            {
                MessageBox.Show("La fecha de nacimiento no puede ser en el futuro.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dtpFechaNacimiento.Value > DateTime.Now.AddYears(-25))
            {
                MessageBox.Show("El autor debe tener al menos 25 años de edad.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                Autores autor = new Autores();
                autor.Nombre = txtNombre.Text;
                autor.FechaNacimiento = dtpFechaNacimiento.Value;
                autor.Nacionalidad = txtNacionalidad.Text;

                if (autor.InsertarAutor())
                {
                    MessageBox.Show("Autor Agregado Exitosamente.", "SQL Si Furulo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MostrarAutores();
                }
                else
                {
                    MessageBox.Show("Error al agregar el autor", "Error, Culpa de SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el autor" + ex.Message, "Error, Culpa de SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

