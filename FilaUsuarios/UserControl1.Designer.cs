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
            this.bVer = new System.Windows.Forms.PictureBox();
            this.bBorrar = new System.Windows.Forms.PictureBox();
            this.lNombreCompleto = new System.Windows.Forms.Label();
            this.lTelefono = new System.Windows.Forms.Label();
            this.tlpPrincipal.SuspendLayout();
            this.tlpBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bVer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bBorrar)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpPrincipal
            // 
            this.tlpPrincipal.AutoSize = true;
            this.tlpPrincipal.ColumnCount = 3;
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpPrincipal.Controls.Add(this.tlpBotones, 2, 0);
            this.tlpPrincipal.Controls.Add(this.lNombreCompleto, 0, 0);
            this.tlpPrincipal.Controls.Add(this.lTelefono, 1, 0);
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
            this.tlpBotones.Location = new System.Drawing.Point(500, 0);
            this.tlpBotones.Margin = new System.Windows.Forms.Padding(0);
            this.tlpBotones.Name = "tlpBotones";
            this.tlpBotones.RowCount = 1;
            this.tlpBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBotones.Size = new System.Drawing.Size(100, 40);
            this.tlpBotones.TabIndex = 5;
            // 
            // bVer
            // 
            this.bVer.BackgroundImage = global::FilaUsuarios.Properties.Resources.boton_ver;
            this.bVer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bVer.Location = new System.Drawing.Point(3, 3);
            this.bVer.Name = "bVer";
            this.bVer.Size = new System.Drawing.Size(44, 34);
            this.bVer.TabIndex = 0;
            this.bVer.TabStop = false;
            this.bVer.Click += new System.EventHandler(this.bVer_Click);
            // 
            // bBorrar
            // 
            this.bBorrar.BackgroundImage = global::FilaUsuarios.Properties.Resources.boton_borrar;
            this.bBorrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bBorrar.Location = new System.Drawing.Point(53, 3);
            this.bBorrar.Name = "bBorrar";
            this.bBorrar.Size = new System.Drawing.Size(44, 34);
            this.bBorrar.TabIndex = 1;
            this.bBorrar.TabStop = false;
            this.bBorrar.Click += new System.EventHandler(this.bBorrar_Click);
            // 
            // lNombreCompleto
            // 
            this.lNombreCompleto.AutoSize = true;
            this.lNombreCompleto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lNombreCompleto.Location = new System.Drawing.Point(3, 0);
            this.lNombreCompleto.Name = "lNombreCompleto";
            this.lNombreCompleto.Size = new System.Drawing.Size(344, 40);
            this.lNombreCompleto.TabIndex = 1;
            this.lNombreCompleto.Text = "NombreCompleto";
            this.lNombreCompleto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lTelefono
            // 
            this.lTelefono.AutoSize = true;
            this.lTelefono.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lTelefono.Location = new System.Drawing.Point(353, 0);
            this.lTelefono.Name = "lTelefono";
            this.lTelefono.Size = new System.Drawing.Size(144, 40);
            this.lTelefono.TabIndex = 2;
            this.lTelefono.Text = "Telefono";
            this.lTelefono.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
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
        private System.Windows.Forms.Label lNombreCompleto;
        private System.Windows.Forms.Label lTelefono;
        private System.Windows.Forms.TableLayoutPanel tlpBotones;
        private System.Windows.Forms.PictureBox bVer;
        private System.Windows.Forms.PictureBox bBorrar;
    }
}
