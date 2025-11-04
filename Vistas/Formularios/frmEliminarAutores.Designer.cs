namespace Vistas.Formularios
{
    partial class frmEliminarAutores
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
            this.lblEliminarAutor = new System.Windows.Forms.Label();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.lblBusqueda = new System.Windows.Forms.Label();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisor)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVisor
            // 
            this.dgvVisor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvVisor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVisor.Location = new System.Drawing.Point(70, 255);
            this.dgvVisor.Name = "dgvVisor";
            this.dgvVisor.Size = new System.Drawing.Size(890, 298);
            this.dgvVisor.TabIndex = 1;
            this.dgvVisor.DoubleClick += new System.EventHandler(this.dgvVisor_DoubleClick);
            // 
            // lblEliminarAutor
            // 
            this.lblEliminarAutor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEliminarAutor.AutoSize = true;
            this.lblEliminarAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEliminarAutor.Location = new System.Drawing.Point(354, 9);
            this.lblEliminarAutor.Name = "lblEliminarAutor";
            this.lblEliminarAutor.Size = new System.Drawing.Size(357, 37);
            this.lblEliminarAutor.TabIndex = 2;
            this.lblEliminarAutor.Text = "Eliminar a tu Autor Aqui";
            // 
            // lblMensaje
            // 
            this.lblMensaje.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.Location = new System.Drawing.Point(354, 64);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(377, 37);
            this.lblMensaje.TabIndex = 3;
            this.lblMensaje.Text = "Doble Click para Eliminar";
            // 
            // btnRegresar
            // 
            this.btnRegresar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnRegresar.Font = new System.Drawing.Font("MV Boli", 30.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnRegresar.Location = new System.Drawing.Point(428, 139);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(627, 97);
            this.btnRegresar.TabIndex = 13;
            this.btnRegresar.Text = "Regresar a Menú de Autores";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBusqueda.AutoSize = true;
            this.lblBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusqueda.Location = new System.Drawing.Point(12, 120);
            this.lblBusqueda.Name = "lblBusqueda";
            this.lblBusqueda.Size = new System.Drawing.Size(143, 37);
            this.lblBusqueda.TabIndex = 14;
            this.lblBusqueda.Text = "Busquea";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.25F);
            this.txtBusqueda.Location = new System.Drawing.Point(30, 176);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(364, 41);
            this.txtBusqueda.TabIndex = 15;
            this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged);
            // 
            // frmEliminarAutores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1067, 584);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.lblBusqueda);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.lblEliminarAutor);
            this.Controls.Add(this.dgvVisor);
            this.Name = "frmEliminarAutores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Elimina a tu autor aqui";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVisor;
        private System.Windows.Forms.Label lblEliminarAutor;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Label lblBusqueda;
        private System.Windows.Forms.TextBox txtBusqueda;
    }
}