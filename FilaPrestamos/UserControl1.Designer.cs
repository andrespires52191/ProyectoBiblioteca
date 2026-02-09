namespace FilaPrestamos
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
            this.lFechaFin = new System.Windows.Forms.Label();
            this.lFechaIni = new System.Windows.Forms.Label();
            this.lUsuario = new System.Windows.Forms.Label();
            this.lLibro = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pbDevolver = new System.Windows.Forms.PictureBox();
            this.pbVer = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDevolver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVer)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.Controls.Add(this.lFechaFin, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lFechaIni, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lUsuario, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lLibro, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 4, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1200, 77);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lFechaFin
            // 
            this.lFechaFin.AutoSize = true;
            this.lFechaFin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lFechaFin.Location = new System.Drawing.Point(806, 0);
            this.lFechaFin.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lFechaFin.Name = "lFechaFin";
            this.lFechaFin.Size = new System.Drawing.Size(188, 77);
            this.lFechaFin.TabIndex = 3;
            this.lFechaFin.Text = "Fecha Fin";
            this.lFechaFin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lFechaIni
            // 
            this.lFechaIni.AutoSize = true;
            this.lFechaIni.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lFechaIni.Location = new System.Drawing.Point(606, 0);
            this.lFechaIni.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lFechaIni.Name = "lFechaIni";
            this.lFechaIni.Size = new System.Drawing.Size(188, 77);
            this.lFechaIni.TabIndex = 2;
            this.lFechaIni.Text = "Fecha Inicio";
            this.lFechaIni.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lUsuario
            // 
            this.lUsuario.AutoSize = true;
            this.lUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lUsuario.Location = new System.Drawing.Point(6, 0);
            this.lUsuario.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lUsuario.Name = "lUsuario";
            this.lUsuario.Size = new System.Drawing.Size(228, 77);
            this.lUsuario.TabIndex = 0;
            this.lUsuario.Text = "Usuario";
            this.lUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lLibro
            // 
            this.lLibro.AutoSize = true;
            this.lLibro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lLibro.Location = new System.Drawing.Point(246, 0);
            this.lLibro.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lLibro.Name = "lLibro";
            this.lLibro.Size = new System.Drawing.Size(348, 77);
            this.lLibro.TabIndex = 1;
            this.lLibro.Text = "Libro";
            this.lLibro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.pbDevolver, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.pbVer, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(1000, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(200, 77);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // pbDevolver
            // 
            this.pbDevolver.BackgroundImage = global::FilaPrestamos.Properties.Resources.flecha_devolver;
            this.pbDevolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbDevolver.Location = new System.Drawing.Point(100, 0);
            this.pbDevolver.Margin = new System.Windows.Forms.Padding(0);
            this.pbDevolver.Name = "pbDevolver";
            this.pbDevolver.Size = new System.Drawing.Size(100, 77);
            this.pbDevolver.TabIndex = 1;
            this.pbDevolver.TabStop = false;
            this.pbDevolver.Click += new System.EventHandler(this.pbDevolver_Click);
            // 
            // pbVer
            // 
            this.pbVer.BackgroundImage = global::FilaPrestamos.Properties.Resources.boton_ver;
            this.pbVer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbVer.Location = new System.Drawing.Point(0, 0);
            this.pbVer.Margin = new System.Windows.Forms.Padding(0);
            this.pbVer.Name = "pbVer";
            this.pbVer.Size = new System.Drawing.Size(100, 77);
            this.pbVer.TabIndex = 0;
            this.pbVer.TabStop = false;
            this.pbVer.Click += new System.EventHandler(this.pbVer_Click);
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
            ((System.ComponentModel.ISupportInitialize)(this.pbDevolver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lFechaFin;
        private System.Windows.Forms.Label lFechaIni;
        private System.Windows.Forms.Label lUsuario;
        private System.Windows.Forms.Label lLibro;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.PictureBox pbDevolver;
        private System.Windows.Forms.PictureBox pbVer;
    }
}
