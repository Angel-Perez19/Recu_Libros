namespace Vistas.Formularios
{
    partial class frmBienvenida
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
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.lblLibros = new System.Windows.Forms.Label();
            this.lblAutores = new System.Windows.Forms.Label();
            this.pnlLibro = new System.Windows.Forms.Panel();
            this.pbLibro = new System.Windows.Forms.PictureBox();
            this.pnlAutores = new System.Windows.Forms.Panel();
            this.pbAutores = new System.Windows.Forms.PictureBox();
            this.pnlLibro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLibro)).BeginInit();
            this.pnlAutores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAutores)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblBienvenida.AutoSize = true;
            this.lblBienvenida.Font = new System.Drawing.Font("Bradley Hand ITC", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenida.Location = new System.Drawing.Point(273, 28);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(710, 79);
            this.lblBienvenida.TabIndex = 0;
            this.lblBienvenida.Text = "¡Hola, Que deseas Hacer!";
            // 
            // lblLibros
            // 
            this.lblLibros.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLibros.AutoSize = true;
            this.lblLibros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLibros.Font = new System.Drawing.Font("Bradley Hand ITC", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLibros.Location = new System.Drawing.Point(3, 317);
            this.lblLibros.Name = "lblLibros";
            this.lblLibros.Size = new System.Drawing.Size(492, 79);
            this.lblLibros.TabIndex = 1;
            this.lblLibros.Text = "Gestionar Libros";
            this.lblLibros.Click += new System.EventHandler(this.lblLibros_Click);
            // 
            // lblAutores
            // 
            this.lblAutores.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAutores.AutoSize = true;
            this.lblAutores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAutores.Font = new System.Drawing.Font("Bradley Hand ITC", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutores.Location = new System.Drawing.Point(7, 317);
            this.lblAutores.Name = "lblAutores";
            this.lblAutores.Size = new System.Drawing.Size(531, 79);
            this.lblAutores.TabIndex = 2;
            this.lblAutores.Text = "Gestionar Autores";
            this.lblAutores.Click += new System.EventHandler(this.lblAutores_Click);
            // 
            // pnlLibro
            // 
            this.pnlLibro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlLibro.Controls.Add(this.pbLibro);
            this.pnlLibro.Controls.Add(this.lblLibros);
            this.pnlLibro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlLibro.Location = new System.Drawing.Point(52, 113);
            this.pnlLibro.Name = "pnlLibro";
            this.pnlLibro.Size = new System.Drawing.Size(511, 406);
            this.pnlLibro.TabIndex = 5;
            this.pnlLibro.Click += new System.EventHandler(this.pnlLibro_Click);
            this.pnlLibro.MouseLeave += new System.EventHandler(this.pnlLibro_MouseLeave);
            this.pnlLibro.MouseHover += new System.EventHandler(this.pnlLibro_MouseHover);
            // 
            // pbLibro
            // 
            this.pbLibro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbLibro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbLibro.Image = global::Vistas.Properties.Resources.photo_1613322004370_cb676b3ff91b;
            this.pbLibro.Location = new System.Drawing.Point(17, 15);
            this.pbLibro.Name = "pbLibro";
            this.pbLibro.Size = new System.Drawing.Size(452, 299);
            this.pbLibro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLibro.TabIndex = 3;
            this.pbLibro.TabStop = false;
            this.pbLibro.Click += new System.EventHandler(this.pbLibro_Click);
            // 
            // pnlAutores
            // 
            this.pnlAutores.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlAutores.Controls.Add(this.lblAutores);
            this.pnlAutores.Controls.Add(this.pbAutores);
            this.pnlAutores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlAutores.Location = new System.Drawing.Point(674, 114);
            this.pnlAutores.Name = "pnlAutores";
            this.pnlAutores.Size = new System.Drawing.Size(538, 405);
            this.pnlAutores.TabIndex = 6;
            this.pnlAutores.Click += new System.EventHandler(this.pnlAutores_Click);
            this.pnlAutores.MouseLeave += new System.EventHandler(this.pnlAutores_MouseLeave);
            this.pnlAutores.MouseHover += new System.EventHandler(this.pnlAutores_MouseHover);
            // 
            // pbAutores
            // 
            this.pbAutores.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbAutores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbAutores.Image = global::Vistas.Properties.Resources._16541581617924;
            this.pbAutores.Location = new System.Drawing.Point(21, 14);
            this.pbAutores.Name = "pbAutores";
            this.pbAutores.Size = new System.Drawing.Size(497, 300);
            this.pbAutores.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAutores.TabIndex = 4;
            this.pbAutores.TabStop = false;
            this.pbAutores.Click += new System.EventHandler(this.pbAutores_Click);
            // 
            // frmBienvenida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(1248, 587);
            this.Controls.Add(this.lblBienvenida);
            this.Controls.Add(this.pnlLibro);
            this.Controls.Add(this.pnlAutores);
            this.Name = "frmBienvenida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acción que quieres";
            this.pnlLibro.ResumeLayout(false);
            this.pnlLibro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLibro)).EndInit();
            this.pnlAutores.ResumeLayout(false);
            this.pnlAutores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAutores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBienvenida;
        private System.Windows.Forms.Label lblLibros;
        private System.Windows.Forms.Label lblAutores;
        private System.Windows.Forms.PictureBox pbLibro;
        private System.Windows.Forms.PictureBox pbAutores;
        private System.Windows.Forms.Panel pnlLibro;
        private System.Windows.Forms.Panel pnlAutores;
    }
}