namespace ProyectoBiblioteca.vista
{
    partial class InsertarLibros
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
            this.pbLibro = new System.Windows.Forms.PictureBox();
            this.tlpDatos = new System.Windows.Forms.TableLayoutPanel();
            this.lDisponible = new System.Windows.Forms.Label();
            this.rbSi = new System.Windows.Forms.RadioButton();
            this.rbNo = new System.Windows.Forms.RadioButton();
            this.lTitulo = new System.Windows.Forms.Label();
            this.lEscritor = new System.Windows.Forms.Label();
            this.lAnio = new System.Windows.Forms.Label();
            this.lSinopsis = new System.Windows.Forms.Label();
            this.tbTitulo = new System.Windows.Forms.TextBox();
            this.tbEscritor = new System.Windows.Forms.TextBox();
            this.tbSinopsis = new System.Windows.Forms.TextBox();
            this.nudAnio = new System.Windows.Forms.NumericUpDown();
            this.bAnadir = new System.Windows.Forms.Button();
            this.tlpPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLibro)).BeginInit();
            this.tlpDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnio)).BeginInit();
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
            this.tlpPrincipal.Controls.Add(this.pbLibro, 2, 3);
            this.tlpPrincipal.Controls.Add(this.tlpDatos, 1, 5);
            this.tlpPrincipal.Controls.Add(this.bAnadir, 2, 7);
            this.tlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tlpPrincipal.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tlpPrincipal.MinimumSize = new System.Drawing.Size(680, 468);
            this.tlpPrincipal.Name = "tlpPrincipal";
            this.tlpPrincipal.RowCount = 9;
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.870116F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.73777F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.870113F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.20794F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.870113F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.96595F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.870114F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.73777F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.870113F));
            this.tlpPrincipal.Size = new System.Drawing.Size(680, 468);
            this.tlpPrincipal.TabIndex = 0;
            // 
            // lAnadir
            // 
            this.lAnadir.AutoSize = true;
            this.tlpPrincipal.SetColumnSpan(this.lAnadir, 3);
            this.lAnadir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lAnadir.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAnadir.Location = new System.Drawing.Point(136, 22);
            this.lAnadir.Margin = new System.Windows.Forms.Padding(0);
            this.lAnadir.Name = "lAnadir";
            this.lAnadir.Size = new System.Drawing.Size(408, 50);
            this.lAnadir.TabIndex = 0;
            this.lAnadir.Text = "Añadir Libro";
            // 
            // pbLibro
            // 
            this.pbLibro.BackgroundImage = global::ProyectoBiblioteca.Properties.Resources.icono_libro;
            this.pbLibro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbLibro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbLibro.Location = new System.Drawing.Point(272, 94);
            this.pbLibro.Margin = new System.Windows.Forms.Padding(0);
            this.pbLibro.Name = "pbLibro";
            this.pbLibro.Size = new System.Drawing.Size(136, 94);
            this.pbLibro.TabIndex = 1;
            this.pbLibro.TabStop = false;
            // 
            // tlpDatos
            // 
            this.tlpDatos.BackColor = System.Drawing.Color.Azure;
            this.tlpDatos.ColumnCount = 3;
            this.tlpPrincipal.SetColumnSpan(this.tlpDatos, 3);
            this.tlpDatos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33332F));
            this.tlpDatos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tlpDatos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tlpDatos.Controls.Add(this.lDisponible, 0, 6);
            this.tlpDatos.Controls.Add(this.rbSi, 1, 6);
            this.tlpDatos.Controls.Add(this.rbNo, 2, 6);
            this.tlpDatos.Controls.Add(this.lTitulo, 0, 0);
            this.tlpDatos.Controls.Add(this.lEscritor, 0, 1);
            this.tlpDatos.Controls.Add(this.lAnio, 0, 2);
            this.tlpDatos.Controls.Add(this.lSinopsis, 0, 3);
            this.tlpDatos.Controls.Add(this.tbTitulo, 1, 0);
            this.tlpDatos.Controls.Add(this.tbEscritor, 1, 1);
            this.tlpDatos.Controls.Add(this.tbSinopsis, 1, 3);
            this.tlpDatos.Controls.Add(this.nudAnio, 1, 2);
            this.tlpDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpDatos.Location = new System.Drawing.Point(136, 210);
            this.tlpDatos.Margin = new System.Windows.Forms.Padding(0);
            this.tlpDatos.Name = "tlpDatos";
            this.tlpDatos.Padding = new System.Windows.Forms.Padding(2);
            this.tlpDatos.RowCount = 7;
            this.tlpDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 11F));
            this.tlpDatos.Size = new System.Drawing.Size(408, 158);
            this.tlpDatos.TabIndex = 2;
            // 
            // lDisponible
            // 
            this.lDisponible.AutoSize = true;
            this.lDisponible.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lDisponible.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDisponible.Location = new System.Drawing.Point(4, 134);
            this.lDisponible.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lDisponible.Name = "lDisponible";
            this.lDisponible.Size = new System.Drawing.Size(130, 22);
            this.lDisponible.TabIndex = 22;
            this.lDisponible.Text = "Diponible";
            // 
            // rbSi
            // 
            this.rbSi.AutoSize = true;
            this.rbSi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.rbSi.Location = new System.Drawing.Point(138, 136);
            this.rbSi.Margin = new System.Windows.Forms.Padding(2);
            this.rbSi.Name = "rbSi";
            this.rbSi.Size = new System.Drawing.Size(39, 18);
            this.rbSi.TabIndex = 20;
            this.rbSi.TabStop = true;
            this.rbSi.Text = "Sí";
            this.rbSi.UseVisualStyleBackColor = true;
            // 
            // rbNo
            // 
            this.rbNo.AutoSize = true;
            this.rbNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.rbNo.Location = new System.Drawing.Point(272, 136);
            this.rbNo.Margin = new System.Windows.Forms.Padding(2);
            this.rbNo.Name = "rbNo";
            this.rbNo.Size = new System.Drawing.Size(46, 18);
            this.rbNo.TabIndex = 21;
            this.rbNo.TabStop = true;
            this.rbNo.Text = "No";
            this.rbNo.UseVisualStyleBackColor = true;
            // 
            // lTitulo
            // 
            this.lTitulo.AutoSize = true;
            this.lTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTitulo.Location = new System.Drawing.Point(4, 2);
            this.lTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lTitulo.Name = "lTitulo";
            this.lTitulo.Size = new System.Drawing.Size(130, 22);
            this.lTitulo.TabIndex = 1;
            this.lTitulo.Text = "Título";
            // 
            // lEscritor
            // 
            this.lEscritor.AutoSize = true;
            this.lEscritor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lEscritor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lEscritor.Location = new System.Drawing.Point(4, 24);
            this.lEscritor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lEscritor.Name = "lEscritor";
            this.lEscritor.Size = new System.Drawing.Size(130, 22);
            this.lEscritor.TabIndex = 2;
            this.lEscritor.Text = "Escritor";
            // 
            // lAnio
            // 
            this.lAnio.AutoSize = true;
            this.lAnio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lAnio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAnio.Location = new System.Drawing.Point(4, 46);
            this.lAnio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lAnio.Name = "lAnio";
            this.lAnio.Size = new System.Drawing.Size(130, 22);
            this.lAnio.TabIndex = 3;
            this.lAnio.Text = "Año de edición";
            // 
            // lSinopsis
            // 
            this.lSinopsis.AutoSize = true;
            this.lSinopsis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lSinopsis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSinopsis.Location = new System.Drawing.Point(4, 68);
            this.lSinopsis.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lSinopsis.Name = "lSinopsis";
            this.lSinopsis.Size = new System.Drawing.Size(130, 22);
            this.lSinopsis.TabIndex = 4;
            this.lSinopsis.Text = "Sinopsis";
            // 
            // tbTitulo
            // 
            this.tlpDatos.SetColumnSpan(this.tbTitulo, 2);
            this.tbTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTitulo.Location = new System.Drawing.Point(138, 4);
            this.tbTitulo.Margin = new System.Windows.Forms.Padding(2);
            this.tbTitulo.Name = "tbTitulo";
            this.tbTitulo.Size = new System.Drawing.Size(266, 24);
            this.tbTitulo.TabIndex = 7;
            // 
            // tbEscritor
            // 
            this.tlpDatos.SetColumnSpan(this.tbEscritor, 2);
            this.tbEscritor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbEscritor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEscritor.Location = new System.Drawing.Point(138, 26);
            this.tbEscritor.Margin = new System.Windows.Forms.Padding(2);
            this.tbEscritor.Name = "tbEscritor";
            this.tbEscritor.Size = new System.Drawing.Size(266, 24);
            this.tbEscritor.TabIndex = 8;
            // 
            // tbSinopsis
            // 
            this.tlpDatos.SetColumnSpan(this.tbSinopsis, 2);
            this.tbSinopsis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbSinopsis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSinopsis.Location = new System.Drawing.Point(138, 70);
            this.tbSinopsis.Margin = new System.Windows.Forms.Padding(2);
            this.tbSinopsis.Multiline = true;
            this.tbSinopsis.Name = "tbSinopsis";
            this.tlpDatos.SetRowSpan(this.tbSinopsis, 3);
            this.tbSinopsis.Size = new System.Drawing.Size(266, 62);
            this.tbSinopsis.TabIndex = 10;
            // 
            // nudAnio
            // 
            this.tlpDatos.SetColumnSpan(this.nudAnio, 2);
            this.nudAnio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudAnio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.nudAnio.Location = new System.Drawing.Point(138, 48);
            this.nudAnio.Margin = new System.Windows.Forms.Padding(2);
            this.nudAnio.Name = "nudAnio";
            this.nudAnio.Size = new System.Drawing.Size(266, 24);
            this.nudAnio.TabIndex = 13;
            // 
            // bAnadir
            // 
            this.bAnadir.BackColor = System.Drawing.Color.Azure;
            this.bAnadir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bAnadir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAnadir.Location = new System.Drawing.Point(272, 390);
            this.bAnadir.Margin = new System.Windows.Forms.Padding(0);
            this.bAnadir.Name = "bAnadir";
            this.bAnadir.Size = new System.Drawing.Size(136, 50);
            this.bAnadir.TabIndex = 3;
            this.bAnadir.Text = "Añadir";
            this.bAnadir.UseVisualStyleBackColor = false;
            this.bAnadir.Click += new System.EventHandler(this.bAnadir_Click);
            // 
            // InsertarLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(680, 468);
            this.Controls.Add(this.tlpPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "InsertarLibros";
            this.Text = "InsertarLibros";
            this.Resize += new System.EventHandler(this.InsertarLibros_Resize);
            this.tlpPrincipal.ResumeLayout(false);
            this.tlpPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLibro)).EndInit();
            this.tlpDatos.ResumeLayout(false);
            this.tlpDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpPrincipal;
        private System.Windows.Forms.Label lAnadir;
        private System.Windows.Forms.PictureBox pbLibro;
        private System.Windows.Forms.Button bAnadir;
        private System.Windows.Forms.TableLayoutPanel tlpDatos;
        private System.Windows.Forms.Label lDisponible;
        private System.Windows.Forms.RadioButton rbSi;
        private System.Windows.Forms.RadioButton rbNo;
        private System.Windows.Forms.Label lTitulo;
        private System.Windows.Forms.Label lEscritor;
        private System.Windows.Forms.Label lAnio;
        private System.Windows.Forms.Label lSinopsis;
        private System.Windows.Forms.TextBox tbTitulo;
        private System.Windows.Forms.TextBox tbEscritor;
        private System.Windows.Forms.TextBox tbSinopsis;
        private System.Windows.Forms.NumericUpDown nudAnio;
    }
}