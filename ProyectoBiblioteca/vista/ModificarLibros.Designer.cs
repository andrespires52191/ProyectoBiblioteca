namespace ProyectoBiblioteca.vista
{
    partial class ModificarLibros
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
            this.pbGuardar = new System.Windows.Forms.PictureBox();
            this.tlpDatos = new System.Windows.Forms.TableLayoutPanel();
            this.tbSinopsis = new System.Windows.Forms.TextBox();
            this.rbNo = new System.Windows.Forms.RadioButton();
            this.rbSi = new System.Windows.Forms.RadioButton();
            this.lDisponible = new System.Windows.Forms.Label();
            this.lTitulo = new System.Windows.Forms.Label();
            this.lEscritor = new System.Windows.Forms.Label();
            this.lAnio = new System.Windows.Forms.Label();
            this.lSinopsis = new System.Windows.Forms.Label();
            this.tbTitulo = new System.Windows.Forms.TextBox();
            this.tbEscritor = new System.Windows.Forms.TextBox();
            this.nudAnio = new System.Windows.Forms.NumericUpDown();
            this.pbEliminar = new System.Windows.Forms.PictureBox();
            this.pbCancelar = new System.Windows.Forms.PictureBox();
            this.tlpPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGuardar)).BeginInit();
            this.tlpDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCancelar)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpPrincipal
            // 
            this.tlpPrincipal.ColumnCount = 5;
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.52632F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.31579F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.31579F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.31579F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.52632F));
            this.tlpPrincipal.Controls.Add(this.pbGuardar, 1, 3);
            this.tlpPrincipal.Controls.Add(this.tlpDatos, 1, 1);
            this.tlpPrincipal.Controls.Add(this.pbEliminar, 3, 3);
            this.tlpPrincipal.Controls.Add(this.pbCancelar, 4, 0);
            this.tlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tlpPrincipal.Name = "tlpPrincipal";
            this.tlpPrincipal.RowCount = 5;
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.583354F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 68.27343F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.416895F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.30943F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.416895F));
            this.tlpPrincipal.Size = new System.Drawing.Size(452, 566);
            this.tlpPrincipal.TabIndex = 0;
            // 
            // pbGuardar
            // 
            this.pbGuardar.BackgroundImage = global::ProyectoBiblioteca.Properties.Resources.boton_guardar;
            this.pbGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbGuardar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbGuardar.Location = new System.Drawing.Point(50, 473);
            this.pbGuardar.Name = "pbGuardar";
            this.pbGuardar.Size = new System.Drawing.Size(112, 58);
            this.pbGuardar.TabIndex = 11;
            this.pbGuardar.TabStop = false;
            this.pbGuardar.Click += new System.EventHandler(this.pbGuardar_Click);
            // 
            // tlpDatos
            // 
            this.tlpDatos.BackColor = System.Drawing.Color.Azure;
            this.tlpDatos.ColumnCount = 3;
            this.tlpPrincipal.SetColumnSpan(this.tlpDatos, 3);
            this.tlpDatos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpDatos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tlpDatos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tlpDatos.Controls.Add(this.tbSinopsis, 1, 3);
            this.tlpDatos.Controls.Add(this.rbNo, 2, 5);
            this.tlpDatos.Controls.Add(this.rbSi, 1, 5);
            this.tlpDatos.Controls.Add(this.lDisponible, 0, 5);
            this.tlpDatos.Controls.Add(this.lTitulo, 0, 0);
            this.tlpDatos.Controls.Add(this.lEscritor, 0, 1);
            this.tlpDatos.Controls.Add(this.lAnio, 0, 2);
            this.tlpDatos.Controls.Add(this.lSinopsis, 0, 3);
            this.tlpDatos.Controls.Add(this.tbTitulo, 1, 0);
            this.tlpDatos.Controls.Add(this.tbEscritor, 1, 1);
            this.tlpDatos.Controls.Add(this.nudAnio, 1, 2);
            this.tlpDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpDatos.Location = new System.Drawing.Point(50, 57);
            this.tlpDatos.Name = "tlpDatos";
            this.tlpDatos.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.tlpDatos.RowCount = 6;
            this.tlpDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpDatos.Size = new System.Drawing.Size(348, 380);
            this.tlpDatos.TabIndex = 12;
            // 
            // tbSinopsis
            // 
            this.tlpDatos.SetColumnSpan(this.tbSinopsis, 2);
            this.tbSinopsis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbSinopsis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSinopsis.Location = new System.Drawing.Point(125, 189);
            this.tbSinopsis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSinopsis.Multiline = true;
            this.tbSinopsis.Name = "tbSinopsis";
            this.tlpDatos.SetRowSpan(this.tbSinopsis, 2);
            this.tbSinopsis.Size = new System.Drawing.Size(200, 114);
            this.tbSinopsis.TabIndex = 15;
            // 
            // rbNo
            // 
            this.rbNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rbNo.AutoSize = true;
            this.rbNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.rbNo.Location = new System.Drawing.Point(227, 324);
            this.rbNo.Name = "rbNo";
            this.rbNo.Size = new System.Drawing.Size(98, 26);
            this.rbNo.TabIndex = 14;
            this.rbNo.TabStop = true;
            this.rbNo.Text = "No";
            this.rbNo.UseVisualStyleBackColor = true;
            // 
            // rbSi
            // 
            this.rbSi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rbSi.AutoSize = true;
            this.rbSi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.rbSi.Location = new System.Drawing.Point(125, 324);
            this.rbSi.Name = "rbSi";
            this.rbSi.Size = new System.Drawing.Size(96, 26);
            this.rbSi.TabIndex = 13;
            this.rbSi.TabStop = true;
            this.rbSi.Text = "Sí";
            this.rbSi.UseVisualStyleBackColor = true;
            // 
            // lDisponible
            // 
            this.lDisponible.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lDisponible.AutoSize = true;
            this.lDisponible.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lDisponible.Location = new System.Drawing.Point(23, 326);
            this.lDisponible.Name = "lDisponible";
            this.lDisponible.Size = new System.Drawing.Size(96, 22);
            this.lDisponible.TabIndex = 12;
            this.lDisponible.Text = "Disponible";
            // 
            // lTitulo
            // 
            this.lTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lTitulo.AutoSize = true;
            this.lTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lTitulo.Location = new System.Drawing.Point(23, 28);
            this.lTitulo.Name = "lTitulo";
            this.lTitulo.Size = new System.Drawing.Size(96, 22);
            this.lTitulo.TabIndex = 0;
            this.lTitulo.Text = "Título";
            // 
            // lEscritor
            // 
            this.lEscritor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lEscritor.AutoSize = true;
            this.lEscritor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lEscritor.Location = new System.Drawing.Point(23, 87);
            this.lEscritor.Name = "lEscritor";
            this.lEscritor.Size = new System.Drawing.Size(96, 22);
            this.lEscritor.TabIndex = 1;
            this.lEscritor.Text = "Escritor";
            // 
            // lAnio
            // 
            this.lAnio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lAnio.AutoSize = true;
            this.lAnio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lAnio.Location = new System.Drawing.Point(23, 135);
            this.lAnio.Name = "lAnio";
            this.lAnio.Size = new System.Drawing.Size(96, 44);
            this.lAnio.TabIndex = 2;
            this.lAnio.Text = "Año de edición";
            // 
            // lSinopsis
            // 
            this.lSinopsis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lSinopsis.AutoSize = true;
            this.lSinopsis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lSinopsis.Location = new System.Drawing.Point(23, 205);
            this.lSinopsis.Name = "lSinopsis";
            this.lSinopsis.Size = new System.Drawing.Size(96, 22);
            this.lSinopsis.TabIndex = 3;
            this.lSinopsis.Text = "Sinopsis";
            // 
            // tbTitulo
            // 
            this.tbTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpDatos.SetColumnSpan(this.tbTitulo, 2);
            this.tbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.tbTitulo.Location = new System.Drawing.Point(125, 25);
            this.tbTitulo.Name = "tbTitulo";
            this.tbTitulo.Size = new System.Drawing.Size(200, 28);
            this.tbTitulo.TabIndex = 4;
            // 
            // tbEscritor
            // 
            this.tbEscritor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpDatos.SetColumnSpan(this.tbEscritor, 2);
            this.tbEscritor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.tbEscritor.Location = new System.Drawing.Point(125, 84);
            this.tbEscritor.Name = "tbEscritor";
            this.tbEscritor.Size = new System.Drawing.Size(200, 28);
            this.tbEscritor.TabIndex = 5;
            // 
            // nudAnio
            // 
            this.nudAnio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpDatos.SetColumnSpan(this.nudAnio, 2);
            this.nudAnio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.nudAnio.Location = new System.Drawing.Point(125, 143);
            this.nudAnio.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.nudAnio.Name = "nudAnio";
            this.nudAnio.Size = new System.Drawing.Size(200, 28);
            this.nudAnio.TabIndex = 9;
            // 
            // pbEliminar
            // 
            this.pbEliminar.BackgroundImage = global::ProyectoBiblioteca.Properties.Resources.boton_borrar;
            this.pbEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbEliminar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbEliminar.Location = new System.Drawing.Point(286, 473);
            this.pbEliminar.Name = "pbEliminar";
            this.pbEliminar.Size = new System.Drawing.Size(112, 58);
            this.pbEliminar.TabIndex = 13;
            this.pbEliminar.TabStop = false;
            this.pbEliminar.Click += new System.EventHandler(this.pbEliminar_Click);
            // 
            // pbCancelar
            // 
            this.pbCancelar.BackgroundImage = global::ProyectoBiblioteca.Properties.Resources.boton_cancelar;
            this.pbCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbCancelar.Location = new System.Drawing.Point(404, 3);
            this.pbCancelar.Name = "pbCancelar";
            this.pbCancelar.Size = new System.Drawing.Size(45, 48);
            this.pbCancelar.TabIndex = 14;
            this.pbCancelar.TabStop = false;
            this.pbCancelar.Click += new System.EventHandler(this.pbCancelar_Click);
            // 
            // ModificarLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(452, 566);
            this.Controls.Add(this.tlpPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ModificarLibros";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ModificarLibros";
            this.Load += new System.EventHandler(this.ModificarLibros_Load);
            this.tlpPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbGuardar)).EndInit();
            this.tlpDatos.ResumeLayout(false);
            this.tlpDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCancelar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpPrincipal;
        private System.Windows.Forms.PictureBox pbGuardar;
        private System.Windows.Forms.TableLayoutPanel tlpDatos;
        private System.Windows.Forms.Label lTitulo;
        private System.Windows.Forms.Label lEscritor;
        private System.Windows.Forms.Label lAnio;
        private System.Windows.Forms.Label lSinopsis;
        private System.Windows.Forms.TextBox tbTitulo;
        private System.Windows.Forms.TextBox tbEscritor;
        private System.Windows.Forms.NumericUpDown nudAnio;
        private System.Windows.Forms.RadioButton rbNo;
        private System.Windows.Forms.RadioButton rbSi;
        private System.Windows.Forms.Label lDisponible;
        private System.Windows.Forms.TextBox tbSinopsis;
        private System.Windows.Forms.PictureBox pbEliminar;
        private System.Windows.Forms.PictureBox pbCancelar;
    }
}