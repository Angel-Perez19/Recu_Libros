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
            this.pbAutores = new System.Windows.Forms.PictureBox();
            this.pbLibro = new System.Windows.Forms.PictureBox();
            this.pnlLibro = new System.Windows.Forms.Panel();
            this.pnlAutores = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbAutores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLibro)).BeginInit();
            this.pnlLibro.SuspendLayout();
            this.pnlAutores.SuspendLayout();
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
            this.lblLibros.Font = new System.Drawing.Font("Bradley Hand ITC", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLibros.Location = new System.Drawing.Point(3, 317);
            this.lblLibros.Name = "lblLibros";
            this.lblLibros.Size = new System.Drawing.Size(492, 79);
            this.lblLibros.TabIndex = 1;
            this.lblLibros.Text = "Gestionar Libros";
            // 
            // lblAutores
            // 
            this.lblAutores.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAutores.AutoSize = true;
            this.lblAutores.Font = new System.Drawing.Font("Bradley Hand ITC", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutores.Location = new System.Drawing.Point(7, 317);
            this.lblAutores.Name = "lblAutores";
            this.lblAutores.Size = new System.Drawing.Size(531, 79);
            this.lblAutores.TabIndex = 2;
            this.lblAutores.Text = "Gestionar Autores";
            // 
            // pbAutores
            // 
            this.pbAutores.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbAutores.Image = global::Vistas.Properties.Resources._16541581617924;
            this.pbAutores.Location = new System.Drawing.Point(151, 72);
            this.pbAutores.Name = "pbAutores";
            this.pbAutores.Size = new System.Drawing.Size(196, 191);
            this.pbAutores.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAutores.TabIndex = 4;
            this.pbAutores.TabStop = false;
            // 
            // pbLibro
            // 
            this.pbLibro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbLibro.Image = global::Vistas.Properties.Resources.photo_1613322004370_cb676b3ff91b;
            this.pbLibro.Location = new System.Drawing.Point(161, 74);
            this.pbLibro.Name = "pbLibro";
            this.pbLibro.Size = new System.Drawing.Size(196, 191);
            this.pbLibro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLibro.TabIndex = 3;
            this.pbLibro.TabStop = false;
            // 
            // pnlLibro
            // 
            this.pnlLibro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlLibro.Controls.Add(this.pbLibro);
            this.pnlLibro.Controls.Add(this.lblLibros);
            this.pnlLibro.Location = new System.Drawing.Point(52, 113);
            this.pnlLibro.Name = "pnlLibro";
            this.pnlLibro.Size = new System.Drawing.Size(511, 406);
            this.pnlLibro.TabIndex = 5;
            this.pnlLibro.MouseLeave += new System.EventHandler(this.pnlLibro_MouseLeave);
            this.pnlLibro.MouseHover += new System.EventHandler(this.pnlLibro_MouseHover);
            // 
            // pnlAutores
            // 
            this.pnlAutores.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlAutores.Controls.Add(this.lblAutores);
            this.pnlAutores.Controls.Add(this.pbAutores);
            this.pnlAutores.Location = new System.Drawing.Point(674, 114);
            this.pnlAutores.Name = "pnlAutores";
            this.pnlAutores.Size = new System.Drawing.Size(538, 405);
            this.pnlAutores.TabIndex = 6;
            this.pnlAutores.MouseLeave += new System.EventHandler(this.pnlAutores_MouseLeave);
            this.pnlAutores.MouseHover += new System.EventHandler(this.pnlAutores_MouseHover);
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
            ((System.ComponentModel.ISupportInitialize)(this.pbAutores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLibro)).EndInit();
            this.pnlLibro.ResumeLayout(false);
            this.pnlLibro.PerformLayout();
            this.pnlAutores.ResumeLayout(false);
            this.pnlAutores.PerformLayout();
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