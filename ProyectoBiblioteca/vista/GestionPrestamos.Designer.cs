namespace ProyectoBiblioteca.vista
{
    partial class GestionPrestamos
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
            this.lCabecera = new System.Windows.Forms.Label();
            this.tlpTitulos = new System.Windows.Forms.TableLayoutPanel();
            this.lUsuario = new System.Windows.Forms.Label();
            this.lLibro = new System.Windows.Forms.Label();
            this.lFechaIni = new System.Windows.Forms.Label();
            this.lFechaFin = new System.Windows.Forms.Label();
            this.lAcciones = new System.Windows.Forms.Label();
            this.tlpDatosInterior = new System.Windows.Forms.TableLayoutPanel();
            this.tlpDatosExterior.SuspendLayout();
            this.tlpTitulos.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpDatosExterior
            // 
            this.tlpDatosExterior.AutoSize = true;
            this.tlpDatosExterior.ColumnCount = 1;
            this.tlpDatosExterior.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDatosExterior.Controls.Add(this.lCabecera, 0, 0);
            this.tlpDatosExterior.Controls.Add(this.tlpTitulos, 0, 1);
            this.tlpDatosExterior.Controls.Add(this.tlpDatosInterior, 0, 2);
            this.tlpDatosExterior.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpDatosExterior.Location = new System.Drawing.Point(20, 21);
            this.tlpDatosExterior.Margin = new System.Windows.Forms.Padding(0);
            this.tlpDatosExterior.Name = "tlpDatosExterior";
            this.tlpDatosExterior.RowCount = 4;
            this.tlpDatosExterior.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpDatosExterior.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpDatosExterior.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpDatosExterior.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDatosExterior.Size = new System.Drawing.Size(662, 376);
            this.tlpDatosExterior.TabIndex = 0;
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
            this.lCabecera.Size = new System.Drawing.Size(662, 51);
            this.lCabecera.TabIndex = 0;
            this.lCabecera.Text = "Gestión de Prestamos";
            this.lCabecera.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tlpTitulos
            // 
            this.tlpTitulos.AutoSize = true;
            this.tlpTitulos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tlpTitulos.ColumnCount = 5;
            this.tlpTitulos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpTitulos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpTitulos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpTitulos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpTitulos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 102F));
            this.tlpTitulos.Controls.Add(this.lUsuario, 0, 0);
            this.tlpTitulos.Controls.Add(this.lLibro, 1, 0);
            this.tlpTitulos.Controls.Add(this.lFechaIni, 2, 0);
            this.tlpTitulos.Controls.Add(this.lFechaFin, 3, 0);
            this.tlpTitulos.Controls.Add(this.lAcciones, 4, 0);
            this.tlpTitulos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTitulos.Location = new System.Drawing.Point(0, 51);
            this.tlpTitulos.Margin = new System.Windows.Forms.Padding(0);
            this.tlpTitulos.Name = "tlpTitulos";
            this.tlpTitulos.RowCount = 1;
            this.tlpTitulos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tlpTitulos.Size = new System.Drawing.Size(662, 42);
            this.tlpTitulos.TabIndex = 1;
            // 
            // lUsuario
            // 
            this.lUsuario.AutoSize = true;
            this.lUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lUsuario.Location = new System.Drawing.Point(3, 0);
            this.lUsuario.Name = "lUsuario";
            this.lUsuario.Size = new System.Drawing.Size(174, 42);
            this.lUsuario.TabIndex = 1;
            this.lUsuario.Text = "Usuario";
            this.lUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lLibro
            // 
            this.lLibro.AutoSize = true;
            this.lLibro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lLibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lLibro.Location = new System.Drawing.Point(183, 0);
            this.lLibro.Name = "lLibro";
            this.lLibro.Size = new System.Drawing.Size(174, 42);
            this.lLibro.TabIndex = 2;
            this.lLibro.Text = "Libro";
            this.lLibro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lFechaIni
            // 
            this.lFechaIni.AutoSize = true;
            this.lFechaIni.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lFechaIni.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lFechaIni.Location = new System.Drawing.Point(363, 0);
            this.lFechaIni.Name = "lFechaIni";
            this.lFechaIni.Size = new System.Drawing.Size(94, 42);
            this.lFechaIni.TabIndex = 3;
            this.lFechaIni.Text = "Fecha Inicio";
            this.lFechaIni.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lFechaFin
            // 
            this.lFechaFin.AutoSize = true;
            this.lFechaFin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lFechaFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lFechaFin.Location = new System.Drawing.Point(463, 0);
            this.lFechaFin.Name = "lFechaFin";
            this.lFechaFin.Size = new System.Drawing.Size(94, 42);
            this.lFechaFin.TabIndex = 4;
            this.lFechaFin.Text = "Fecha Fin";
            this.lFechaFin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lAcciones
            // 
            this.lAcciones.AutoSize = true;
            this.lAcciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lAcciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lAcciones.Location = new System.Drawing.Point(563, 0);
            this.lAcciones.Name = "lAcciones";
            this.lAcciones.Size = new System.Drawing.Size(96, 42);
            this.lAcciones.TabIndex = 5;
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
            this.tlpDatosInterior.Size = new System.Drawing.Size(662, 20);
            this.tlpDatosInterior.TabIndex = 2;
            // 
            // GestionPrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(702, 418);
            this.Controls.Add(this.tlpDatosExterior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GestionPrestamos";
            this.Padding = new System.Windows.Forms.Padding(20, 21, 20, 21);
            this.Text = "GestionPrestamos";
            this.tlpDatosExterior.ResumeLayout(false);
            this.tlpDatosExterior.PerformLayout();
            this.tlpTitulos.ResumeLayout(false);
            this.tlpTitulos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpDatosExterior;
        private System.Windows.Forms.Label lCabecera;
        private System.Windows.Forms.TableLayoutPanel tlpTitulos;
        private System.Windows.Forms.TableLayoutPanel tlpDatosInterior;
        private System.Windows.Forms.Label lUsuario;
        private System.Windows.Forms.Label lLibro;
        private System.Windows.Forms.Label lFechaIni;
        private System.Windows.Forms.Label lFechaFin;
        private System.Windows.Forms.Label lAcciones;
    }
}