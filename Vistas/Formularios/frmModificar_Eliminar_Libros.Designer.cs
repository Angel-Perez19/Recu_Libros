namespace Vistas.Formularios
{
    partial class frmModificar_Eliminar_Libros
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblLibro = new System.Windows.Forms.Label();
            this.dgvViztazoGeneral = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.msktxtAnio = new System.Windows.Forms.MaskedTextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.msktxtISBN = new System.Windows.Forms.MaskedTextBox();
            this.cbEditoriales = new System.Windows.Forms.ComboBox();
            this.lblEditorial = new System.Windows.Forms.Label();
            this.lblAnio = new System.Windows.Forms.Label();
            this.lblISBN = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.lblBusqueda = new System.Windows.Forms.Label();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViztazoGeneral)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLibro
            // 
            this.lblLibro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLibro.AutoSize = true;
            this.lblLibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 48.25F);
            this.lblLibro.Location = new System.Drawing.Point(204, 9);
            this.lblLibro.Name = "lblLibro";
            this.lblLibro.Size = new System.Drawing.Size(700, 74);
            this.lblLibro.TabIndex = 1;
            this.lblLibro.Text = "Modifica o Elimina Aqui";
            // 
            // dgvViztazoGeneral
            // 
            this.dgvViztazoGeneral.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvViztazoGeneral.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvViztazoGeneral.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViztazoGeneral.Location = new System.Drawing.Point(53, 343);
            this.dgvViztazoGeneral.Name = "dgvViztazoGeneral";
            this.dgvViztazoGeneral.Size = new System.Drawing.Size(572, 256);
            this.dgvViztazoGeneral.TabIndex = 13;
            this.dgvViztazoGeneral.DoubleClick += new System.EventHandler(this.dgvViztazoGeneral_DoubleClick);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEliminar.Location = new System.Drawing.Point(448, 95);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(177, 80);
            this.btnEliminar.TabIndex = 14;
            this.btnEliminar.Text = "Eliminar Libro";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // msktxtAnio
            // 
            this.msktxtAnio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.msktxtAnio.Location = new System.Drawing.Point(54, 276);
            this.msktxtAnio.Mask = "0000";
            this.msktxtAnio.Name = "msktxtAnio";
            this.msktxtAnio.Size = new System.Drawing.Size(368, 20);
            this.msktxtAnio.TabIndex = 22;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTitulo.Location = new System.Drawing.Point(54, 182);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(368, 20);
            this.txtTitulo.TabIndex = 21;
            // 
            // msktxtISBN
            // 
            this.msktxtISBN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.msktxtISBN.Location = new System.Drawing.Point(662, 182);
            this.msktxtISBN.Mask = "0000000000000";
            this.msktxtISBN.Name = "msktxtISBN";
            this.msktxtISBN.Size = new System.Drawing.Size(395, 20);
            this.msktxtISBN.TabIndex = 20;
            // 
            // cbEditoriales
            // 
            this.cbEditoriales.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbEditoriales.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEditoriales.FormattingEnabled = true;
            this.cbEditoriales.Location = new System.Drawing.Point(643, 285);
            this.cbEditoriales.Name = "cbEditoriales";
            this.cbEditoriales.Size = new System.Drawing.Size(396, 21);
            this.cbEditoriales.TabIndex = 19;
            // 
            // lblEditorial
            // 
            this.lblEditorial.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEditorial.AutoSize = true;
            this.lblEditorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F);
            this.lblEditorial.Location = new System.Drawing.Point(654, 220);
            this.lblEditorial.Name = "lblEditorial";
            this.lblEditorial.Size = new System.Drawing.Size(158, 44);
            this.lblEditorial.TabIndex = 18;
            this.lblEditorial.Text = "Editorial";
            // 
            // lblAnio
            // 
            this.lblAnio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAnio.AutoSize = true;
            this.lblAnio.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F);
            this.lblAnio.Location = new System.Drawing.Point(46, 227);
            this.lblAnio.Name = "lblAnio";
            this.lblAnio.Size = new System.Drawing.Size(86, 44);
            this.lblAnio.TabIndex = 17;
            this.lblAnio.Text = "Año";
            // 
            // lblISBN
            // 
            this.lblISBN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblISBN.AutoSize = true;
            this.lblISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F);
            this.lblISBN.Location = new System.Drawing.Point(654, 131);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(305, 44);
            this.lblISBN.TabIndex = 16;
            this.lblISBN.Text = "ISBN (13 digitos)";
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F);
            this.lblTitulo.Location = new System.Drawing.Point(46, 131);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(269, 44);
            this.lblTitulo.TabIndex = 15;
            this.lblTitulo.Text = "Titulo del Libro";
            // 
            // btnRegresar
            // 
            this.btnRegresar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegresar.BackColor = System.Drawing.Color.Red;
            this.btnRegresar.Location = new System.Drawing.Point(448, 198);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(179, 55);
            this.btnRegresar.TabIndex = 23;
            this.btnRegresar.Text = "Regresar al Menú";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnModificar.BackColor = System.Drawing.Color.Blue;
            this.btnModificar.Location = new System.Drawing.Point(448, 259);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(179, 55);
            this.btnModificar.TabIndex = 24;
            this.btnModificar.Text = "Modificar el Libro";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBusqueda.AutoSize = true;
            this.lblBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F);
            this.lblBusqueda.Location = new System.Drawing.Point(654, 343);
            this.lblBusqueda.Name = "lblBusqueda";
            this.lblBusqueda.Size = new System.Drawing.Size(400, 44);
            this.lblBusqueda.TabIndex = 25;
            this.lblBusqueda.Text = "Busqueda por Nombre";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBusqueda.Location = new System.Drawing.Point(663, 403);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(363, 20);
            this.txtBusqueda.TabIndex = 26;
            this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged);
            // 
            // frmModificar_Eliminar_Libros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Fuchsia;
            this.ClientSize = new System.Drawing.Size(1076, 629);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.lblBusqueda);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.msktxtAnio);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.msktxtISBN);
            this.Controls.Add(this.cbEditoriales);
            this.Controls.Add(this.lblEditorial);
            this.Controls.Add(this.lblAnio);
            this.Controls.Add(this.lblISBN);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.dgvViztazoGeneral);
            this.Controls.Add(this.lblLibro);
            this.Name = "frmModificar_Eliminar_Libros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Libros";
            ((System.ComponentModel.ISupportInitialize)(this.dgvViztazoGeneral)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLibro;
        private System.Windows.Forms.DataGridView dgvViztazoGeneral;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.MaskedTextBox msktxtAnio;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.MaskedTextBox msktxtISBN;
        private System.Windows.Forms.ComboBox cbEditoriales;
        private System.Windows.Forms.Label lblEditorial;
        private System.Windows.Forms.Label lblAnio;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label lblBusqueda;
        private System.Windows.Forms.TextBox txtBusqueda;
    }
}