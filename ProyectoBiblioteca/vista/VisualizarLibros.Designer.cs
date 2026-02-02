namespace ProyectoBiblioteca.vista
{
    partial class VisualizarLibros
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
            this.pbVerBorrar = new System.Windows.Forms.PictureBox();
            this.pbInsertar = new System.Windows.Forms.PictureBox();
            this.tlpPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbVerBorrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInsertar)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpPrincipal
            // 
            this.tlpPrincipal.BackgroundImage = global::ProyectoBiblioteca.Properties.Resources.fondo_libros;
            this.tlpPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tlpPrincipal.ColumnCount = 3;
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.99998F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.00002F));
            this.tlpPrincipal.Controls.Add(this.pbVerBorrar, 1, 1);
            this.tlpPrincipal.Controls.Add(this.pbInsertar, 1, 3);
            this.tlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tlpPrincipal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tlpPrincipal.Name = "tlpPrincipal";
            this.tlpPrincipal.RowCount = 5;
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 92F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 92F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpPrincipal.Size = new System.Drawing.Size(1067, 554);
            this.tlpPrincipal.TabIndex = 5;
            // 
            // pbVerBorrar
            // 
            this.pbVerBorrar.BackgroundImage = global::ProyectoBiblioteca.Properties.Resources.boton_visualizar_borrar;
            this.pbVerBorrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbVerBorrar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbVerBorrar.Location = new System.Drawing.Point(337, 152);
            this.pbVerBorrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbVerBorrar.Name = "pbVerBorrar";
            this.pbVerBorrar.Size = new System.Drawing.Size(392, 84);
            this.pbVerBorrar.TabIndex = 22;
            this.pbVerBorrar.TabStop = false;
            this.pbVerBorrar.Click += new System.EventHandler(this.pbVerBorrar_Click);
            // 
            // pbInsertar
            // 
            this.pbInsertar.BackgroundImage = global::ProyectoBiblioteca.Properties.Resources.boton_insertar;
            this.pbInsertar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbInsertar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbInsertar.Location = new System.Drawing.Point(337, 318);
            this.pbInsertar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbInsertar.Name = "pbInsertar";
            this.pbInsertar.Size = new System.Drawing.Size(392, 84);
            this.pbInsertar.TabIndex = 21;
            this.pbInsertar.TabStop = false;
            // 
            // VisualizarLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.tlpPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "VisualizarLibros";
            this.Text = "VisualizarLibros";
            this.tlpPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbVerBorrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInsertar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpPrincipal;
        private System.Windows.Forms.PictureBox pbVerBorrar;
        private System.Windows.Forms.PictureBox pbInsertar;
    }
}