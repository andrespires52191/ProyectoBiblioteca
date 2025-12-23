namespace ProyectoBiblioteca
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.tlpLateral = new System.Windows.Forms.TableLayoutPanel();
            this.bUsuarios = new System.Windows.Forms.Button();
            this.bLibros = new System.Windows.Forms.Button();
            this.bPrestamos = new System.Windows.Forms.Button();
            this.tlpTitulo = new System.Windows.Forms.TableLayoutPanel();
            this.lTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.tlpLateral.SuspendLayout();
            this.tlpTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbLogo
            // 
            this.pbLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbLogo.BackgroundImage")));
            this.pbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbLogo.InitialImage = null;
            this.pbLogo.Location = new System.Drawing.Point(0, 0);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(0);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(137, 180);
            this.pbLogo.TabIndex = 3;
            this.pbLogo.TabStop = false;
            this.pbLogo.Click += new System.EventHandler(this.pbLogo_Click);
            // 
            // tlpLateral
            // 
            this.tlpLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(99)))));
            this.tlpLateral.ColumnCount = 1;
            this.tlpLateral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpLateral.Controls.Add(this.pbLogo, 0, 0);
            this.tlpLateral.Controls.Add(this.bUsuarios, 0, 2);
            this.tlpLateral.Controls.Add(this.bLibros, 0, 3);
            this.tlpLateral.Controls.Add(this.bPrestamos, 0, 4);
            this.tlpLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.tlpLateral.Location = new System.Drawing.Point(0, 0);
            this.tlpLateral.Margin = new System.Windows.Forms.Padding(0);
            this.tlpLateral.Name = "tlpLateral";
            this.tlpLateral.RowCount = 6;
            this.tlpLateral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tlpLateral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpLateral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpLateral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpLateral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpLateral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpLateral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpLateral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpLateral.Size = new System.Drawing.Size(137, 545);
            this.tlpLateral.TabIndex = 4;
            // 
            // bUsuarios
            // 
            this.bUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bUsuarios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(99)))));
            this.bUsuarios.Location = new System.Drawing.Point(5, 235);
            this.bUsuarios.Margin = new System.Windows.Forms.Padding(5);
            this.bUsuarios.Name = "bUsuarios";
            this.bUsuarios.Size = new System.Drawing.Size(127, 40);
            this.bUsuarios.TabIndex = 4;
            this.bUsuarios.Text = "Usuarios";
            this.bUsuarios.UseVisualStyleBackColor = true;
            this.bUsuarios.Click += new System.EventHandler(this.bUsuarios_Click);
            // 
            // bLibros
            // 
            this.bLibros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bLibros.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bLibros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(99)))));
            this.bLibros.Location = new System.Drawing.Point(5, 285);
            this.bLibros.Margin = new System.Windows.Forms.Padding(5);
            this.bLibros.Name = "bLibros";
            this.bLibros.Size = new System.Drawing.Size(127, 40);
            this.bLibros.TabIndex = 5;
            this.bLibros.Text = "Libros";
            this.bLibros.UseVisualStyleBackColor = true;
            this.bLibros.Click += new System.EventHandler(this.bLibros_Click);
            // 
            // bPrestamos
            // 
            this.bPrestamos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bPrestamos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bPrestamos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(99)))));
            this.bPrestamos.Location = new System.Drawing.Point(5, 335);
            this.bPrestamos.Margin = new System.Windows.Forms.Padding(5);
            this.bPrestamos.Name = "bPrestamos";
            this.bPrestamos.Size = new System.Drawing.Size(127, 40);
            this.bPrestamos.TabIndex = 6;
            this.bPrestamos.Text = "Préstamos";
            this.bPrestamos.UseVisualStyleBackColor = true;
            this.bPrestamos.Click += new System.EventHandler(this.bPrestamos_Click);
            // 
            // tlpTitulo
            // 
            this.tlpTitulo.ColumnCount = 1;
            this.tlpTitulo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpTitulo.Controls.Add(this.lTitulo, 0, 0);
            this.tlpTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpTitulo.Location = new System.Drawing.Point(137, 0);
            this.tlpTitulo.Name = "tlpTitulo";
            this.tlpTitulo.RowCount = 1;
            this.tlpTitulo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpTitulo.Size = new System.Drawing.Size(669, 62);
            this.tlpTitulo.TabIndex = 6;
            // 
            // lTitulo
            // 
            this.lTitulo.AutoSize = true;
            this.lTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(99)))));
            this.lTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lTitulo.Font = new System.Drawing.Font("Noto Sans", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTitulo.ForeColor = System.Drawing.Color.White;
            this.lTitulo.Location = new System.Drawing.Point(0, 0);
            this.lTitulo.Margin = new System.Windows.Forms.Padding(0);
            this.lTitulo.Name = "lTitulo";
            this.lTitulo.Size = new System.Drawing.Size(669, 62);
            this.lTitulo.TabIndex = 0;
            this.lTitulo.Text = "Biblioteca";
            this.lTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 545);
            this.Controls.Add(this.tlpTitulo);
            this.Controls.Add(this.tlpLateral);
            this.IsMdiContainer = true;
            this.Name = "Principal";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.tlpLateral.ResumeLayout(false);
            this.tlpTitulo.ResumeLayout(false);
            this.tlpTitulo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.TableLayoutPanel tlpLateral;
        private System.Windows.Forms.TableLayoutPanel tlpTitulo;
        private System.Windows.Forms.Label lTitulo;
        private System.Windows.Forms.Button bUsuarios;
        private System.Windows.Forms.Button bLibros;
        private System.Windows.Forms.Button bPrestamos;
    }
}

