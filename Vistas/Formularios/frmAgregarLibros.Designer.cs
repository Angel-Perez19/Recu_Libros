namespace Vistas.Formularios
{
    partial class frmAgregarLibros
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.tbcLibros = new System.Windows.Forms.TabControl();
            this.tbVer = new System.Windows.Forms.TabPage();
            this.tbAgregar = new System.Windows.Forms.TabPage();
            this.cbEditoriales = new System.Windows.Forms.ComboBox();
            this.lblEditorial = new System.Windows.Forms.Label();
            this.lblAnio = new System.Windows.Forms.Label();
            this.lblISBN = new System.Windows.Forms.Label();
            this.msktxtISBN = new System.Windows.Forms.MaskedTextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.msktxtAnio = new System.Windows.Forms.MaskedTextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.dgvMostrarLibroAgregado = new System.Windows.Forms.DataGridView();
            this.cbAutor = new System.Windows.Forms.ComboBox();
            this.lblAutor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvViztazoGeneral = new System.Windows.Forms.DataGridView();
            this.lblVerInfo = new System.Windows.Forms.Label();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.btnRegresarMenuV2 = new System.Windows.Forms.Button();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.tbcLibros.SuspendLayout();
            this.tbVer.SuspendLayout();
            this.tbAgregar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarLibroAgregado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViztazoGeneral)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLibro
            // 
            this.lblLibro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLibro.AutoSize = true;
            this.lblLibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 48.25F);
            this.lblLibro.Location = new System.Drawing.Point(363, 15);
            this.lblLibro.Name = "lblLibro";
            this.lblLibro.Size = new System.Drawing.Size(619, 74);
            this.lblLibro.TabIndex = 0;
            this.lblLibro.Text = "Agrega tu Libro Aqui";
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F);
            this.lblTitulo.Location = new System.Drawing.Point(169, 89);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(269, 44);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Titulo del Libro";
            // 
            // tbcLibros
            // 
            this.tbcLibros.Controls.Add(this.tbVer);
            this.tbcLibros.Controls.Add(this.tbAgregar);
            this.tbcLibros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcLibros.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.tbcLibros.Location = new System.Drawing.Point(0, 0);
            this.tbcLibros.Name = "tbcLibros";
            this.tbcLibros.SelectedIndex = 0;
            this.tbcLibros.Size = new System.Drawing.Size(1319, 670);
            this.tbcLibros.TabIndex = 2;
            // 
            // tbVer
            // 
            this.tbVer.BackColor = System.Drawing.Color.Gray;
            this.tbVer.Controls.Add(this.btnRegresarMenuV2);
            this.tbVer.Controls.Add(this.lblBuscar);
            this.tbVer.Controls.Add(this.txtBusqueda);
            this.tbVer.Controls.Add(this.lblVerInfo);
            this.tbVer.Controls.Add(this.dgvViztazoGeneral);
            this.tbVer.Location = new System.Drawing.Point(4, 38);
            this.tbVer.Name = "tbVer";
            this.tbVer.Padding = new System.Windows.Forms.Padding(3);
            this.tbVer.Size = new System.Drawing.Size(1311, 628);
            this.tbVer.TabIndex = 1;
            this.tbVer.Text = "Ver Información";
            // 
            // tbAgregar
            // 
            this.tbAgregar.Controls.Add(this.dtpFecha);
            this.tbAgregar.Controls.Add(this.label1);
            this.tbAgregar.Controls.Add(this.lblAutor);
            this.tbAgregar.Controls.Add(this.cbAutor);
            this.tbAgregar.Controls.Add(this.dgvMostrarLibroAgregado);
            this.tbAgregar.Controls.Add(this.btnRegresar);
            this.tbAgregar.Controls.Add(this.btnAgregar);
            this.tbAgregar.Controls.Add(this.msktxtAnio);
            this.tbAgregar.Controls.Add(this.txtTitulo);
            this.tbAgregar.Controls.Add(this.msktxtISBN);
            this.tbAgregar.Controls.Add(this.cbEditoriales);
            this.tbAgregar.Controls.Add(this.lblEditorial);
            this.tbAgregar.Controls.Add(this.lblAnio);
            this.tbAgregar.Controls.Add(this.lblISBN);
            this.tbAgregar.Controls.Add(this.lblTitulo);
            this.tbAgregar.Controls.Add(this.lblLibro);
            this.tbAgregar.Location = new System.Drawing.Point(4, 38);
            this.tbAgregar.Name = "tbAgregar";
            this.tbAgregar.Padding = new System.Windows.Forms.Padding(3);
            this.tbAgregar.Size = new System.Drawing.Size(1311, 628);
            this.tbAgregar.TabIndex = 0;
            this.tbAgregar.Text = "Agregar Libro";
            this.tbAgregar.UseVisualStyleBackColor = true;
            // 
            // cbEditoriales
            // 
            this.cbEditoriales.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbEditoriales.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEditoriales.FormattingEnabled = true;
            this.cbEditoriales.Location = new System.Drawing.Point(784, 225);
            this.cbEditoriales.Name = "cbEditoriales";
            this.cbEditoriales.Size = new System.Drawing.Size(396, 37);
            this.cbEditoriales.TabIndex = 5;
            // 
            // lblEditorial
            // 
            this.lblEditorial.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEditorial.AutoSize = true;
            this.lblEditorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F);
            this.lblEditorial.Location = new System.Drawing.Point(777, 178);
            this.lblEditorial.Name = "lblEditorial";
            this.lblEditorial.Size = new System.Drawing.Size(158, 44);
            this.lblEditorial.TabIndex = 4;
            this.lblEditorial.Text = "Editorial";
            // 
            // lblAnio
            // 
            this.lblAnio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAnio.AutoSize = true;
            this.lblAnio.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F);
            this.lblAnio.Location = new System.Drawing.Point(169, 185);
            this.lblAnio.Name = "lblAnio";
            this.lblAnio.Size = new System.Drawing.Size(86, 44);
            this.lblAnio.TabIndex = 3;
            this.lblAnio.Text = "Año";
            // 
            // lblISBN
            // 
            this.lblISBN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblISBN.AutoSize = true;
            this.lblISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F);
            this.lblISBN.Location = new System.Drawing.Point(777, 89);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(305, 44);
            this.lblISBN.TabIndex = 2;
            this.lblISBN.Text = "ISBN (13 digitos)";
            // 
            // msktxtISBN
            // 
            this.msktxtISBN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.msktxtISBN.Location = new System.Drawing.Point(785, 140);
            this.msktxtISBN.Mask = "0000000000000";
            this.msktxtISBN.Name = "msktxtISBN";
            this.msktxtISBN.Size = new System.Drawing.Size(395, 35);
            this.msktxtISBN.TabIndex = 6;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTitulo.Location = new System.Drawing.Point(177, 140);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(368, 35);
            this.txtTitulo.TabIndex = 7;
            // 
            // msktxtAnio
            // 
            this.msktxtAnio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.msktxtAnio.Location = new System.Drawing.Point(177, 234);
            this.msktxtAnio.Mask = "0000";
            this.msktxtAnio.Name = "msktxtAnio";
            this.msktxtAnio.Size = new System.Drawing.Size(368, 35);
            this.msktxtAnio.TabIndex = 8;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAgregar.BackColor = System.Drawing.Color.Lime;
            this.btnAgregar.Location = new System.Drawing.Point(575, 130);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(179, 99);
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegresar.BackColor = System.Drawing.Color.Red;
            this.btnRegresar.Location = new System.Drawing.Point(575, 248);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(179, 99);
            this.btnRegresar.TabIndex = 10;
            this.btnRegresar.Text = "Regresar al Menú";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // dgvMostrarLibroAgregado
            // 
            this.dgvMostrarLibroAgregado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvMostrarLibroAgregado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvMostrarLibroAgregado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrarLibroAgregado.Location = new System.Drawing.Point(40, 367);
            this.dgvMostrarLibroAgregado.Name = "dgvMostrarLibroAgregado";
            this.dgvMostrarLibroAgregado.Size = new System.Drawing.Size(1239, 242);
            this.dgvMostrarLibroAgregado.TabIndex = 11;
            // 
            // cbAutor
            // 
            this.cbAutor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbAutor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAutor.FormattingEnabled = true;
            this.cbAutor.Location = new System.Drawing.Point(177, 317);
            this.cbAutor.Name = "cbAutor";
            this.cbAutor.Size = new System.Drawing.Size(368, 37);
            this.cbAutor.TabIndex = 12;
            // 
            // lblAutor
            // 
            this.lblAutor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAutor.AutoSize = true;
            this.lblAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F);
            this.lblAutor.Location = new System.Drawing.Point(169, 270);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(110, 44);
            this.lblAutor.TabIndex = 13;
            this.lblAutor.Text = "Autor";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F);
            this.label1.Location = new System.Drawing.Point(777, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 44);
            this.label1.TabIndex = 14;
            this.label1.Text = "Fecha";
            // 
            // dgvViztazoGeneral
            // 
            this.dgvViztazoGeneral.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvViztazoGeneral.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvViztazoGeneral.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViztazoGeneral.Location = new System.Drawing.Point(36, 234);
            this.dgvViztazoGeneral.Name = "dgvViztazoGeneral";
            this.dgvViztazoGeneral.Size = new System.Drawing.Size(1239, 368);
            this.dgvViztazoGeneral.TabIndex = 12;
            // 
            // lblVerInfo
            // 
            this.lblVerInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblVerInfo.AutoSize = true;
            this.lblVerInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 48.25F);
            this.lblVerInfo.Location = new System.Drawing.Point(244, 15);
            this.lblVerInfo.Name = "lblVerInfo";
            this.lblVerInfo.Size = new System.Drawing.Size(883, 74);
            this.lblVerInfo.TabIndex = 13;
            this.lblVerInfo.Text = "Ver Informacion General Aqui";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(60, 178);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(567, 35);
            this.txtBusqueda.TabIndex = 14;
            this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged);
            // 
            // lblBuscar
            // 
            this.lblBuscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 48.25F);
            this.lblBuscar.Location = new System.Drawing.Point(37, 89);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(855, 74);
            this.lblBuscar.TabIndex = 15;
            this.lblBuscar.Text = "Buscar por Nombre de Autor";
            // 
            // btnRegresarMenuV2
            // 
            this.btnRegresarMenuV2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegresarMenuV2.BackColor = System.Drawing.Color.Red;
            this.btnRegresarMenuV2.Location = new System.Drawing.Point(1025, 104);
            this.btnRegresarMenuV2.Name = "btnRegresarMenuV2";
            this.btnRegresarMenuV2.Size = new System.Drawing.Size(179, 99);
            this.btnRegresarMenuV2.TabIndex = 16;
            this.btnRegresarMenuV2.Text = "Regresar al Menú";
            this.btnRegresarMenuV2.UseVisualStyleBackColor = false;
            this.btnRegresarMenuV2.Click += new System.EventHandler(this.btnRegresarMenuV2_Click);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpFecha.Location = new System.Drawing.Point(791, 320);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(399, 35);
            this.dtpFecha.TabIndex = 15;
            // 
            // frmAgregarLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(1319, 670);
            this.Controls.Add(this.tbcLibros);
            this.Name = "frmAgregarLibros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar y Ver Libros";
            this.tbcLibros.ResumeLayout(false);
            this.tbVer.ResumeLayout(false);
            this.tbVer.PerformLayout();
            this.tbAgregar.ResumeLayout(false);
            this.tbAgregar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarLibroAgregado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViztazoGeneral)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblLibro;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TabControl tbcLibros;
        private System.Windows.Forms.TabPage tbAgregar;
        private System.Windows.Forms.TabPage tbVer;
        private System.Windows.Forms.Label lblEditorial;
        private System.Windows.Forms.Label lblAnio;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.ComboBox cbEditoriales;
        private System.Windows.Forms.MaskedTextBox msktxtISBN;
        private System.Windows.Forms.DataGridView dgvMostrarLibroAgregado;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.MaskedTextBox msktxtAnio;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.ComboBox cbAutor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvViztazoGeneral;
        private System.Windows.Forms.Button btnRegresarMenuV2;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Label lblVerInfo;
        private System.Windows.Forms.DateTimePicker dtpFecha;
    }
}