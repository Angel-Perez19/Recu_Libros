namespace Vistas.Formularios
{
    partial class frmAgregarAutores
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
            this.dgvVisor = new System.Windows.Forms.DataGridView();
            this.lblAgregarAutor = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtNacionalidad = new System.Windows.Forms.TextBox();
            this.lblNacionalidad = new System.Windows.Forms.Label();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisor)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVisor
            // 
            this.dgvVisor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvVisor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVisor.Location = new System.Drawing.Point(45, 346);
            this.dgvVisor.Name = "dgvVisor";
            this.dgvVisor.Size = new System.Drawing.Size(890, 228);
            this.dgvVisor.TabIndex = 0;
            // 
            // lblAgregarAutor
            // 
            this.lblAgregarAutor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAgregarAutor.AutoSize = true;
            this.lblAgregarAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgregarAutor.Location = new System.Drawing.Point(314, 9);
            this.lblAgregarAutor.Name = "lblAgregarAutor";
            this.lblAgregarAutor.Size = new System.Drawing.Size(345, 37);
            this.lblAgregarAutor.TabIndex = 1;
            this.lblAgregarAutor.Text = "Agrega a tu Autor Aquí";
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(42, 83);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNombre.Location = new System.Drawing.Point(44, 112);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(416, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // txtNacionalidad
            // 
            this.txtNacionalidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNacionalidad.Location = new System.Drawing.Point(45, 183);
            this.txtNacionalidad.Name = "txtNacionalidad";
            this.txtNacionalidad.Size = new System.Drawing.Size(416, 20);
            this.txtNacionalidad.TabIndex = 4;
            // 
            // lblNacionalidad
            // 
            this.lblNacionalidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNacionalidad.AutoSize = true;
            this.lblNacionalidad.Location = new System.Drawing.Point(42, 149);
            this.lblNacionalidad.Name = "lblNacionalidad";
            this.lblNacionalidad.Size = new System.Drawing.Size(69, 13);
            this.lblNacionalidad.TabIndex = 5;
            this.lblNacionalidad.Text = "Nacionalidad";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(528, 112);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(407, 20);
            this.dtpFechaNacimiento.TabIndex = 6;
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(525, 83);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(108, 13);
            this.lblFechaNacimiento.TabIndex = 7;
            this.lblFechaNacimiento.Text = "Fecha de Nacimiento";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnAgregar.Font = new System.Drawing.Font("MV Boli", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(514, 154);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(198, 70);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Agregar Autor";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLimpiarCampos.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnLimpiarCampos.Font = new System.Drawing.Font("MV Boli", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarCampos.Location = new System.Drawing.Point(749, 154);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(186, 70);
            this.btnLimpiarCampos.TabIndex = 9;
            this.btnLimpiarCampos.Text = "Limpiar Campos";
            this.btnLimpiarCampos.UseVisualStyleBackColor = false;
            this.btnLimpiarCampos.Click += new System.EventHandler(this.btnLimpiarCampos_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegresar.BackColor = System.Drawing.Color.Red;
            this.btnRegresar.Font = new System.Drawing.Font("MV Boli", 30.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnRegresar.Location = new System.Drawing.Point(45, 231);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(890, 97);
            this.btnRegresar.TabIndex = 12;
            this.btnRegresar.Text = "Regresar a Menú de Autores";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // frmAgregarAutores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(982, 611);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnLimpiarCampos);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblFechaNacimiento);
            this.Controls.Add(this.dtpFechaNacimiento);
            this.Controls.Add(this.lblNacionalidad);
            this.Controls.Add(this.txtNacionalidad);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblAgregarAutor);
            this.Controls.Add(this.dgvVisor);
            this.Name = "frmAgregarAutores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAgregarAutores";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVisor;
        private System.Windows.Forms.Label lblAgregarAutor;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtNacionalidad;
        private System.Windows.Forms.Label lblNacionalidad;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnLimpiarCampos;
        private System.Windows.Forms.Button btnRegresar;
    }
}