namespace FilaLibros
{
    partial class UserControl1
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

        #region Código generado por el Diseñador de componentes

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lTitulo = new System.Windows.Forms.Label();
            this.lEscritor = new System.Windows.Forms.Label();
            this.lAnyo = new System.Windows.Forms.Label();
            this.lDisponible = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pbVer = new System.Windows.Forms.PictureBox();
            this.pbDevolver = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbVer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDevolver)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.Controls.Add(this.lTitulo, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lEscritor, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lAnyo, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lDisponible, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 4, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1200, 77);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lTitulo
            // 
            this.lTitulo.AutoSize = true;
            this.lTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lTitulo.Location = new System.Drawing.Point(6, 0);
            this.lTitulo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lTitulo.Name = "lTitulo";
            this.lTitulo.Size = new System.Drawing.Size(388, 77);
            this.lTitulo.TabIndex = 0;
            this.lTitulo.Text = "Título";
            this.lTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lEscritor
            // 
            this.lEscritor.AutoSize = true;
            this.lEscritor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lEscritor.Location = new System.Drawing.Point(406, 0);
            this.lEscritor.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lEscritor.Name = "lEscritor";
            this.lEscritor.Size = new System.Drawing.Size(188, 77);
            this.lEscritor.TabIndex = 1;
            this.lEscritor.Text = "Escritor";
            this.lEscritor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lAnyo
            // 
            this.lAnyo.AutoSize = true;
            this.lAnyo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lAnyo.Location = new System.Drawing.Point(606, 0);
            this.lAnyo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lAnyo.Name = "lAnyo";
            this.lAnyo.Size = new System.Drawing.Size(188, 77);
            this.lAnyo.TabIndex = 2;
            this.lAnyo.Text = "Año";
            this.lAnyo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lDisponible
            // 
            this.lDisponible.AutoSize = true;
            this.lDisponible.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lDisponible.Location = new System.Drawing.Point(806, 0);
            this.lDisponible.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lDisponible.Name = "lDisponible";
            this.lDisponible.Size = new System.Drawing.Size(188, 77);
            this.lDisponible.TabIndex = 3;
            this.lDisponible.Text = "Disponible";
            this.lDisponible.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.pbVer, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.pbDevolver, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(1000, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(200, 77);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // pbVer
            // 
            this.pbVer.BackgroundImage = global::FilaLibros.Properties.Resources.boton_ver;
            this.pbVer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbVer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbVer.Location = new System.Drawing.Point(0, 0);
            this.pbVer.Margin = new System.Windows.Forms.Padding(0);
            this.pbVer.Name = "pbVer";
            this.pbVer.Size = new System.Drawing.Size(100, 77);
            this.pbVer.TabIndex = 0;
            this.pbVer.TabStop = false;
            this.pbVer.Click += new System.EventHandler(this.pbVer_Click);
            // 
            // pbDevolver
            // 
            this.pbDevolver.BackgroundImage = global::FilaLibros.Properties.Resources.boton_borrar;
            this.pbDevolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbDevolver.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbDevolver.Location = new System.Drawing.Point(100, 0);
            this.pbDevolver.Margin = new System.Windows.Forms.Padding(0);
            this.pbDevolver.Name = "pbDevolver";
            this.pbDevolver.Size = new System.Drawing.Size(100, 77);
            this.pbDevolver.TabIndex = 1;
            this.pbDevolver.TabStop = false;
            this.pbDevolver.Click += new System.EventHandler(this.pbBorrar_Click);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(1200, 77);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbVer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDevolver)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lTitulo;
        private System.Windows.Forms.Label lEscritor;
        private System.Windows.Forms.Label lAnyo;
        private System.Windows.Forms.Label lDisponible;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.PictureBox pbVer;
        private System.Windows.Forms.PictureBox pbDevolver;
    }
}
