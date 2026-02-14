namespace ProyectoBiblioteca.vista
{
    partial class GestionLibros
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
            this.tlpDatosExterior = new System.Windows.Forms.TableLayoutPanel();
            this.tlpTitulos = new System.Windows.Forms.TableLayoutPanel();
            this.lTitulo = new System.Windows.Forms.Label();
            this.lEscritor = new System.Windows.Forms.Label();
            this.lAnyo = new System.Windows.Forms.Label();
            this.lDisponible = new System.Windows.Forms.Label();
            this.lAcciones = new System.Windows.Forms.Label();
            this.tlpDatosInterior = new System.Windows.Forms.TableLayoutPanel();
            this.lCabecera = new System.Windows.Forms.Label();
            this.tlpDatosExterior.SuspendLayout();
            this.tlpTitulos.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpDatosExterior
            // 
            this.tlpDatosExterior.ColumnCount = 1;
            this.tlpDatosExterior.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDatosExterior.Controls.Add(this.tlpTitulos, 0, 1);
            this.tlpDatosExterior.Controls.Add(this.tlpDatosInterior, 0, 2);
            this.tlpDatosExterior.Controls.Add(this.lCabecera, 0, 0);
            this.tlpDatosExterior.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpDatosExterior.Location = new System.Drawing.Point(20, 20);
            this.tlpDatosExterior.Margin = new System.Windows.Forms.Padding(0);
            this.tlpDatosExterior.Name = "tlpDatosExterior";
            this.tlpDatosExterior.RowCount = 4;
            this.tlpDatosExterior.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpDatosExterior.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpDatosExterior.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpDatosExterior.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDatosExterior.Size = new System.Drawing.Size(760, 410);
            this.tlpDatosExterior.TabIndex = 0;
            // 
            // tlpTitulos
            // 
            this.tlpTitulos.AutoSize = true;
            this.tlpTitulos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tlpTitulos.ColumnCount = 5;
            this.tlpTitulos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.tlpTitulos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tlpTitulos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpTitulos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpTitulos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 101F));
            this.tlpTitulos.Controls.Add(this.lTitulo, 0, 0);
            this.tlpTitulos.Controls.Add(this.lEscritor, 1, 0);
            this.tlpTitulos.Controls.Add(this.lAnyo, 2, 0);
            this.tlpTitulos.Controls.Add(this.lDisponible, 3, 0);
            this.tlpTitulos.Controls.Add(this.lAcciones, 4, 0);
            this.tlpTitulos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTitulos.Location = new System.Drawing.Point(0, 51);
            this.tlpTitulos.Margin = new System.Windows.Forms.Padding(0);
            this.tlpTitulos.Name = "tlpTitulos";
            this.tlpTitulos.RowCount = 1;
            this.tlpTitulos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tlpTitulos.Size = new System.Drawing.Size(760, 42);
            this.tlpTitulos.TabIndex = 0;
            // 
            // lTitulo
            // 
            this.lTitulo.AutoSize = true;
            this.lTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lTitulo.Location = new System.Drawing.Point(3, 0);
            this.lTitulo.Name = "lTitulo";
            this.lTitulo.Size = new System.Drawing.Size(299, 42);
            this.lTitulo.TabIndex = 0;
            this.lTitulo.Text = "Título";
            this.lTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lEscritor
            // 
            this.lEscritor.AutoSize = true;
            this.lEscritor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lEscritor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lEscritor.Location = new System.Drawing.Point(308, 0);
            this.lEscritor.Name = "lEscritor";
            this.lEscritor.Size = new System.Drawing.Size(147, 42);
            this.lEscritor.TabIndex = 1;
            this.lEscritor.Text = "Escritor";
            this.lEscritor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lAnyo
            // 
            this.lAnyo.AutoSize = true;
            this.lAnyo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lAnyo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lAnyo.Location = new System.Drawing.Point(461, 0);
            this.lAnyo.Name = "lAnyo";
            this.lAnyo.Size = new System.Drawing.Size(94, 42);
            this.lAnyo.TabIndex = 2;
            this.lAnyo.Text = "Año";
            this.lAnyo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lDisponible
            // 
            this.lDisponible.AutoSize = true;
            this.lDisponible.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lDisponible.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lDisponible.Location = new System.Drawing.Point(561, 0);
            this.lDisponible.Name = "lDisponible";
            this.lDisponible.Size = new System.Drawing.Size(94, 42);
            this.lDisponible.TabIndex = 3;
            this.lDisponible.Text = "Disponible";
            this.lDisponible.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lAcciones
            // 
            this.lAcciones.AutoSize = true;
            this.lAcciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lAcciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lAcciones.Location = new System.Drawing.Point(661, 0);
            this.lAcciones.Name = "lAcciones";
            this.lAcciones.Size = new System.Drawing.Size(96, 42);
            this.lAcciones.TabIndex = 4;
            this.lAcciones.Text = "Acciones";
            this.lAcciones.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlpDatosInterior
            // 
            this.tlpDatosInterior.AutoSize = true;
            this.tlpDatosInterior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tlpDatosInterior.ColumnCount = 1;
            this.tlpDatosInterior.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpDatosInterior.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpDatosInterior.Location = new System.Drawing.Point(0, 93);
            this.tlpDatosInterior.Margin = new System.Windows.Forms.Padding(0);
            this.tlpDatosInterior.MinimumSize = new System.Drawing.Size(20, 20);
            this.tlpDatosInterior.Name = "tlpDatosInterior";
            this.tlpDatosInterior.RowCount = 1;
            this.tlpDatosInterior.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpDatosInterior.Size = new System.Drawing.Size(760, 20);
            this.tlpDatosInterior.TabIndex = 1;
            // 
            // lCabecera
            // 
            this.lCabecera.AutoSize = true;
            this.lCabecera.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lCabecera.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCabecera.Location = new System.Drawing.Point(0, 0);
            this.lCabecera.Margin = new System.Windows.Forms.Padding(0);
            this.lCabecera.Name = "lCabecera";
            this.lCabecera.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.lCabecera.Size = new System.Drawing.Size(760, 51);
            this.lCabecera.TabIndex = 2;
            this.lCabecera.Text = "Gestión de Libros";
            // 
            // GestionLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tlpDatosExterior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GestionLibros";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Text = "GestionLibros";
            this.tlpDatosExterior.ResumeLayout(false);
            this.tlpDatosExterior.PerformLayout();
            this.tlpTitulos.ResumeLayout(false);
            this.tlpTitulos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpDatosExterior;
        private System.Windows.Forms.TableLayoutPanel tlpTitulos;
        private System.Windows.Forms.TableLayoutPanel tlpDatosInterior;
        private System.Windows.Forms.Label lCabecera;
        private System.Windows.Forms.Label lTitulo;
        private System.Windows.Forms.Label lEscritor;
        private System.Windows.Forms.Label lAnyo;
        private System.Windows.Forms.Label lDisponible;
        private System.Windows.Forms.Label lAcciones;
    }
}