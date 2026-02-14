namespace ProyectoBiblioteca.vista
{
    partial class GestionUsuarios
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
            this.tlpPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.tlpDatosExterior = new System.Windows.Forms.TableLayoutPanel();
            this.tlpDatosTitulos = new System.Windows.Forms.TableLayoutPanel();
            this.lAcciones = new System.Windows.Forms.Label();
            this.lTituloNombre = new System.Windows.Forms.Label();
            this.lTelefono = new System.Windows.Forms.Label();
            this.tlpDatosInterior = new System.Windows.Forms.TableLayoutPanel();
            this.lCabecera = new System.Windows.Forms.Label();
            this.tlpPrincipal.SuspendLayout();
            this.tlpDatosExterior.SuspendLayout();
            this.tlpDatosTitulos.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpPrincipal
            // 
            this.tlpPrincipal.AutoSize = true;
            this.tlpPrincipal.ColumnCount = 1;
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpPrincipal.Controls.Add(this.tlpDatosExterior, 0, 1);
            this.tlpPrincipal.Controls.Add(this.lCabecera, 0, 0);
            this.tlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPrincipal.Location = new System.Drawing.Point(20, 20);
            this.tlpPrincipal.Name = "tlpPrincipal";
            this.tlpPrincipal.RowCount = 2;
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPrincipal.Size = new System.Drawing.Size(760, 410);
            this.tlpPrincipal.TabIndex = 3;
            // 
            // tlpDatosExterior
            // 
            this.tlpDatosExterior.AutoSize = true;
            this.tlpDatosExterior.ColumnCount = 1;
            this.tlpDatosExterior.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDatosExterior.Controls.Add(this.tlpDatosTitulos, 0, 0);
            this.tlpDatosExterior.Controls.Add(this.tlpDatosInterior, 0, 1);
            this.tlpDatosExterior.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpDatosExterior.Location = new System.Drawing.Point(0, 51);
            this.tlpDatosExterior.Margin = new System.Windows.Forms.Padding(0);
            this.tlpDatosExterior.Name = "tlpDatosExterior";
            this.tlpDatosExterior.RowCount = 3;
            this.tlpDatosExterior.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpDatosExterior.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpDatosExterior.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDatosExterior.Size = new System.Drawing.Size(760, 359);
            this.tlpDatosExterior.TabIndex = 7;
            // 
            // tlpDatosTitulos
            // 
            this.tlpDatosTitulos.AutoSize = true;
            this.tlpDatosTitulos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tlpDatosTitulos.ColumnCount = 3;
            this.tlpDatosTitulos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDatosTitulos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tlpDatosTitulos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpDatosTitulos.Controls.Add(this.lAcciones, 2, 0);
            this.tlpDatosTitulos.Controls.Add(this.lTituloNombre, 0, 0);
            this.tlpDatosTitulos.Controls.Add(this.lTelefono, 1, 0);
            this.tlpDatosTitulos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpDatosTitulos.Location = new System.Drawing.Point(0, 0);
            this.tlpDatosTitulos.Margin = new System.Windows.Forms.Padding(0);
            this.tlpDatosTitulos.Name = "tlpDatosTitulos";
            this.tlpDatosTitulos.RowCount = 1;
            this.tlpDatosTitulos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tlpDatosTitulos.Size = new System.Drawing.Size(760, 42);
            this.tlpDatosTitulos.TabIndex = 1;
            // 
            // lAcciones
            // 
            this.lAcciones.AutoSize = true;
            this.lAcciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lAcciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lAcciones.Location = new System.Drawing.Point(663, 0);
            this.lAcciones.Name = "lAcciones";
            this.lAcciones.Size = new System.Drawing.Size(94, 42);
            this.lAcciones.TabIndex = 2;
            this.lAcciones.Text = "Acciones";
            this.lAcciones.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lTituloNombre
            // 
            this.lTituloNombre.AutoSize = true;
            this.lTituloNombre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lTituloNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lTituloNombre.Location = new System.Drawing.Point(3, 0);
            this.lTituloNombre.Name = "lTituloNombre";
            this.lTituloNombre.Size = new System.Drawing.Size(504, 42);
            this.lTituloNombre.TabIndex = 0;
            this.lTituloNombre.Text = "Nombre";
            this.lTituloNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lTelefono
            // 
            this.lTelefono.AutoSize = true;
            this.lTelefono.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lTelefono.Location = new System.Drawing.Point(513, 0);
            this.lTelefono.Name = "lTelefono";
            this.lTelefono.Size = new System.Drawing.Size(144, 42);
            this.lTelefono.TabIndex = 1;
            this.lTelefono.Text = "Teléfono";
            this.lTelefono.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tlpDatosInterior
            // 
            this.tlpDatosInterior.AutoSize = true;
            this.tlpDatosInterior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tlpDatosInterior.ColumnCount = 1;
            this.tlpDatosInterior.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpDatosInterior.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpDatosInterior.Location = new System.Drawing.Point(0, 42);
            this.tlpDatosInterior.Margin = new System.Windows.Forms.Padding(0);
            this.tlpDatosInterior.MinimumSize = new System.Drawing.Size(20, 20);
            this.tlpDatosInterior.Name = "tlpDatosInterior";
            this.tlpDatosInterior.RowCount = 1;
            this.tlpDatosInterior.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpDatosInterior.Size = new System.Drawing.Size(760, 20);
            this.tlpDatosInterior.TabIndex = 2;
            // 
            // lCabecera
            // 
            this.lCabecera.AutoSize = true;
            this.lCabecera.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lCabecera.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lCabecera.Location = new System.Drawing.Point(0, 0);
            this.lCabecera.Margin = new System.Windows.Forms.Padding(0);
            this.lCabecera.Name = "lCabecera";
            this.lCabecera.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.lCabecera.Size = new System.Drawing.Size(760, 51);
            this.lCabecera.TabIndex = 4;
            this.lCabecera.Text = "Gestión de Usuarios";
            // 
            // GestionUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tlpPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GestionUsuarios";
            this.Padding = new System.Windows.Forms.Padding(20, 20, 20, 20);
            this.Text = "GestionUsuarios";
            this.tlpPrincipal.ResumeLayout(false);
            this.tlpPrincipal.PerformLayout();
            this.tlpDatosExterior.ResumeLayout(false);
            this.tlpDatosExterior.PerformLayout();
            this.tlpDatosTitulos.ResumeLayout(false);
            this.tlpDatosTitulos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpPrincipal;
        private System.Windows.Forms.Label lCabecera;
        private System.Windows.Forms.TableLayoutPanel tlpDatosExterior;
        private System.Windows.Forms.TableLayoutPanel tlpDatosTitulos;
        private System.Windows.Forms.Label lTituloNombre;
        private System.Windows.Forms.Label lTelefono;
        private System.Windows.Forms.TableLayoutPanel tlpDatosInterior;
        private System.Windows.Forms.Label lAcciones;
    }
}