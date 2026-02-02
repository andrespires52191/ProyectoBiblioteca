namespace FilaUsuarios
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
            this.tlpPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.tlpBotones = new System.Windows.Forms.TableLayoutPanel();
            this.lNombre = new System.Windows.Forms.Label();
            this.lApellido1 = new System.Windows.Forms.Label();
            this.lApellido2 = new System.Windows.Forms.Label();
            this.bVer = new System.Windows.Forms.PictureBox();
            this.bBorrar = new System.Windows.Forms.PictureBox();
            this.tlpPrincipal.SuspendLayout();
            this.tlpBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bVer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bBorrar)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpPrincipal
            // 
            this.tlpPrincipal.AutoSize = true;
            this.tlpPrincipal.ColumnCount = 4;
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpPrincipal.Controls.Add(this.tlpBotones, 3, 0);
            this.tlpPrincipal.Controls.Add(this.lNombre, 0, 0);
            this.tlpPrincipal.Controls.Add(this.lApellido1, 1, 0);
            this.tlpPrincipal.Controls.Add(this.lApellido2, 2, 0);
            this.tlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tlpPrincipal.Margin = new System.Windows.Forms.Padding(0);
            this.tlpPrincipal.Name = "tlpPrincipal";
            this.tlpPrincipal.RowCount = 1;
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPrincipal.Size = new System.Drawing.Size(600, 40);
            this.tlpPrincipal.TabIndex = 0;
            // 
            // tlpBotones
            // 
            this.tlpBotones.AutoSize = true;
            this.tlpBotones.ColumnCount = 2;
            this.tlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBotones.Controls.Add(this.bVer, 0, 0);
            this.tlpBotones.Controls.Add(this.bBorrar, 1, 0);
            this.tlpBotones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpBotones.Location = new System.Drawing.Point(498, 0);
            this.tlpBotones.Margin = new System.Windows.Forms.Padding(0);
            this.tlpBotones.Name = "tlpBotones";
            this.tlpBotones.RowCount = 1;
            this.tlpBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBotones.Size = new System.Drawing.Size(102, 40);
            this.tlpBotones.TabIndex = 4;
            // 
            // lNombre
            // 
            this.lNombre.AutoSize = true;
            this.lNombre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lNombre.Location = new System.Drawing.Point(3, 0);
            this.lNombre.Name = "lNombre";
            this.lNombre.Size = new System.Drawing.Size(160, 40);
            this.lNombre.TabIndex = 1;
            this.lNombre.Text = "Nombre";
            this.lNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lApellido1
            // 
            this.lApellido1.AutoSize = true;
            this.lApellido1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lApellido1.Location = new System.Drawing.Point(169, 0);
            this.lApellido1.Name = "lApellido1";
            this.lApellido1.Size = new System.Drawing.Size(160, 40);
            this.lApellido1.TabIndex = 2;
            this.lApellido1.Text = "Apellido1";
            this.lApellido1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lApellido2
            // 
            this.lApellido2.AutoSize = true;
            this.lApellido2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lApellido2.Location = new System.Drawing.Point(335, 0);
            this.lApellido2.Name = "lApellido2";
            this.lApellido2.Size = new System.Drawing.Size(160, 40);
            this.lApellido2.TabIndex = 3;
            this.lApellido2.Text = "Apellido2";
            this.lApellido2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bVer
            // 
            this.bVer.BackgroundImage = global::FilaUsuarios.Properties.Resources.boton_ver;
            this.bVer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bVer.Location = new System.Drawing.Point(3, 3);
            this.bVer.Name = "bVer";
            this.bVer.Size = new System.Drawing.Size(45, 34);
            this.bVer.TabIndex = 0;
            this.bVer.TabStop = false;
            this.bVer.Click += new System.EventHandler(this.bVer_Click);
            // 
            // bBorrar
            // 
            this.bBorrar.BackgroundImage = global::FilaUsuarios.Properties.Resources.boton_borrar;
            this.bBorrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bBorrar.Location = new System.Drawing.Point(54, 3);
            this.bBorrar.Name = "bBorrar";
            this.bBorrar.Size = new System.Drawing.Size(45, 34);
            this.bBorrar.TabIndex = 1;
            this.bBorrar.TabStop = false;
            this.bBorrar.Click += new System.EventHandler(this.bBorrar_Click);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpPrincipal);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(600, 40);
            this.tlpPrincipal.ResumeLayout(false);
            this.tlpPrincipal.PerformLayout();
            this.tlpBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bVer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bBorrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpPrincipal;
        private System.Windows.Forms.TableLayoutPanel tlpBotones;
        private System.Windows.Forms.Label lNombre;
        private System.Windows.Forms.Label lApellido1;
        private System.Windows.Forms.Label lApellido2;
        private System.Windows.Forms.PictureBox bVer;
        private System.Windows.Forms.PictureBox bBorrar;
    }
}
