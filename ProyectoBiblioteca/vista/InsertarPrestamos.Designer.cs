namespace ProyectoBiblioteca.vista
{
    partial class InsertarPrestamos
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
            this.lAnadir = new System.Windows.Forms.Label();
            this.tlpDatos = new System.Windows.Forms.TableLayoutPanel();
            this.lLibro = new System.Windows.Forms.Label();
            this.lUsuario = new System.Windows.Forms.Label();
            this.lFechaInicio = new System.Windows.Forms.Label();
            this.lFechaFin = new System.Windows.Forms.Label();
            this.cbLibro = new System.Windows.Forms.ComboBox();
            this.cbUsuario = new System.Windows.Forms.ComboBox();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.bAnadir = new System.Windows.Forms.Button();
            this.tlpPrincipal.SuspendLayout();
            this.tlpDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpPrincipal
            // 
            this.tlpPrincipal.BackColor = System.Drawing.Color.White;
            this.tlpPrincipal.ColumnCount = 5;
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpPrincipal.Controls.Add(this.lAnadir, 1, 1);
            this.tlpPrincipal.Controls.Add(this.tlpDatos, 1, 3);
            this.tlpPrincipal.Controls.Add(this.bAnadir, 2, 5);
            this.tlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tlpPrincipal.Name = "tlpPrincipal";
            this.tlpPrincipal.RowCount = 7;
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.48878F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.48878F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.48878F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.06734F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.48878F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.48878F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.48878F));
            this.tlpPrincipal.Size = new System.Drawing.Size(907, 376);
            this.tlpPrincipal.TabIndex = 0;
            // 
            // lAnadir
            // 
            this.lAnadir.AutoSize = true;
            this.tlpPrincipal.SetColumnSpan(this.lAnadir, 3);
            this.lAnadir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lAnadir.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lAnadir.Location = new System.Drawing.Point(181, 39);
            this.lAnadir.Margin = new System.Windows.Forms.Padding(0);
            this.lAnadir.Name = "lAnadir";
            this.lAnadir.Size = new System.Drawing.Size(543, 39);
            this.lAnadir.TabIndex = 0;
            this.lAnadir.Text = "Añadir Préstamo";
            // 
            // tlpDatos
            // 
            this.tlpDatos.BackColor = System.Drawing.Color.Azure;
            this.tlpDatos.ColumnCount = 3;
            this.tlpPrincipal.SetColumnSpan(this.tlpDatos, 3);
            this.tlpDatos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpDatos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpDatos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpDatos.Controls.Add(this.lLibro, 0, 0);
            this.tlpDatos.Controls.Add(this.lUsuario, 0, 1);
            this.tlpDatos.Controls.Add(this.lFechaInicio, 0, 2);
            this.tlpDatos.Controls.Add(this.lFechaFin, 0, 3);
            this.tlpDatos.Controls.Add(this.cbLibro, 1, 0);
            this.tlpDatos.Controls.Add(this.cbUsuario, 1, 1);
            this.tlpDatos.Controls.Add(this.dtpFechaInicio, 1, 2);
            this.tlpDatos.Controls.Add(this.dtpFechaFin, 1, 3);
            this.tlpDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpDatos.Location = new System.Drawing.Point(181, 117);
            this.tlpDatos.Margin = new System.Windows.Forms.Padding(0);
            this.tlpDatos.Name = "tlpDatos";
            this.tlpDatos.Padding = new System.Windows.Forms.Padding(5);
            this.tlpDatos.RowCount = 4;
            this.tlpDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpDatos.Size = new System.Drawing.Size(543, 139);
            this.tlpDatos.TabIndex = 2;
            // 
            // lLibro
            // 
            this.lLibro.AutoSize = true;
            this.lLibro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lLibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lLibro.Location = new System.Drawing.Point(8, 5);
            this.lLibro.Name = "lLibro";
            this.lLibro.Size = new System.Drawing.Size(171, 32);
            this.lLibro.TabIndex = 0;
            this.lLibro.Text = "Libro";
            // 
            // lUsuario
            // 
            this.lUsuario.AutoSize = true;
            this.lUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lUsuario.Location = new System.Drawing.Point(8, 37);
            this.lUsuario.Name = "lUsuario";
            this.lUsuario.Size = new System.Drawing.Size(171, 32);
            this.lUsuario.TabIndex = 1;
            this.lUsuario.Text = "Usuario";
            // 
            // lFechaInicio
            // 
            this.lFechaInicio.AutoSize = true;
            this.lFechaInicio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lFechaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lFechaInicio.Location = new System.Drawing.Point(8, 69);
            this.lFechaInicio.Name = "lFechaInicio";
            this.lFechaInicio.Size = new System.Drawing.Size(171, 32);
            this.lFechaInicio.TabIndex = 2;
            this.lFechaInicio.Text = "Fecha de inicio";
            // 
            // lFechaFin
            // 
            this.lFechaFin.AutoSize = true;
            this.lFechaFin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lFechaFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lFechaFin.Location = new System.Drawing.Point(8, 101);
            this.lFechaFin.Name = "lFechaFin";
            this.lFechaFin.Size = new System.Drawing.Size(171, 33);
            this.lFechaFin.TabIndex = 3;
            this.lFechaFin.Text = "Fecha de fin";
            // 
            // cbLibro
            // 
            this.tlpDatos.SetColumnSpan(this.cbLibro, 2);
            this.cbLibro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbLibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.cbLibro.FormattingEnabled = true;
            this.cbLibro.Location = new System.Drawing.Point(185, 8);
            this.cbLibro.Name = "cbLibro";
            this.cbLibro.Size = new System.Drawing.Size(350, 30);
            this.cbLibro.TabIndex = 4;
            // 
            // cbUsuario
            // 
            this.tlpDatos.SetColumnSpan(this.cbUsuario, 2);
            this.cbUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.cbUsuario.FormattingEnabled = true;
            this.cbUsuario.Location = new System.Drawing.Point(185, 40);
            this.cbUsuario.Name = "cbUsuario";
            this.cbUsuario.Size = new System.Drawing.Size(350, 30);
            this.cbUsuario.TabIndex = 5;
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpFechaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.dtpFechaInicio.Location = new System.Drawing.Point(185, 72);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(171, 28);
            this.dtpFechaInicio.TabIndex = 6;
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpFechaFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.dtpFechaFin.Location = new System.Drawing.Point(185, 104);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(171, 28);
            this.dtpFechaFin.TabIndex = 7;
            // 
            // bAnadir
            // 
            this.bAnadir.BackColor = System.Drawing.Color.Azure;
            this.bAnadir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bAnadir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.bAnadir.Location = new System.Drawing.Point(362, 295);
            this.bAnadir.Margin = new System.Windows.Forms.Padding(0);
            this.bAnadir.Name = "bAnadir";
            this.bAnadir.Size = new System.Drawing.Size(181, 39);
            this.bAnadir.TabIndex = 3;
            this.bAnadir.Text = "Añadir";
            this.bAnadir.UseVisualStyleBackColor = false;
            this.bAnadir.Click += new System.EventHandler(this.bAnadir_Click);
            // 
            // InsertarPrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 376);
            this.Controls.Add(this.tlpPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InsertarPrestamos";
            this.Text = "InsertarPrestamos";
            this.tlpPrincipal.ResumeLayout(false);
            this.tlpPrincipal.PerformLayout();
            this.tlpDatos.ResumeLayout(false);
            this.tlpDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpPrincipal;
        private System.Windows.Forms.Label lAnadir;
        private System.Windows.Forms.TableLayoutPanel tlpDatos;
        private System.Windows.Forms.Button bAnadir;
        private System.Windows.Forms.Label lLibro;
        private System.Windows.Forms.Label lUsuario;
        private System.Windows.Forms.Label lFechaInicio;
        private System.Windows.Forms.Label lFechaFin;
        private System.Windows.Forms.ComboBox cbLibro;
        private System.Windows.Forms.ComboBox cbUsuario;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
    }
}