namespace ProyectoBiblioteca.vista
{
    partial class VisualizarInicio
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
            this.tlpInferior = new System.Windows.Forms.TableLayoutPanel();
            this.pbInferior2 = new System.Windows.Forms.PictureBox();
            this.pbInferior3 = new System.Windows.Forms.PictureBox();
            this.pbInferior1 = new System.Windows.Forms.PictureBox();
            this.tlpSuperior = new System.Windows.Forms.TableLayoutPanel();
            this.pbSuperio = new System.Windows.Forms.PictureBox();
            this.tlpPrincipal.SuspendLayout();
            this.tlpInferior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbInferior2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInferior3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInferior1)).BeginInit();
            this.tlpSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSuperio)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpPrincipal
            // 
            this.tlpPrincipal.ColumnCount = 1;
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPrincipal.Controls.Add(this.tlpInferior, 0, 2);
            this.tlpPrincipal.Controls.Add(this.tlpSuperior, 0, 0);
            this.tlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tlpPrincipal.Margin = new System.Windows.Forms.Padding(2);
            this.tlpPrincipal.Name = "tlpPrincipal";
            this.tlpPrincipal.RowCount = 3;
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpPrincipal.Size = new System.Drawing.Size(800, 450);
            this.tlpPrincipal.TabIndex = 1;
            // 
            // tlpInferior
            // 
            this.tlpInferior.ColumnCount = 7;
            this.tlpInferior.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpInferior.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpInferior.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpInferior.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpInferior.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpInferior.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpInferior.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tlpInferior.Controls.Add(this.pbInferior2, 3, 0);
            this.tlpInferior.Controls.Add(this.pbInferior3, 5, 0);
            this.tlpInferior.Controls.Add(this.pbInferior1, 1, 0);
            this.tlpInferior.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpInferior.Location = new System.Drawing.Point(2, 320);
            this.tlpInferior.Margin = new System.Windows.Forms.Padding(2);
            this.tlpInferior.Name = "tlpInferior";
            this.tlpInferior.RowCount = 1;
            this.tlpInferior.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpInferior.Size = new System.Drawing.Size(796, 128);
            this.tlpInferior.TabIndex = 6;
            this.tlpInferior.Paint += new System.Windows.Forms.PaintEventHandler(this.tlpInferior_Paint);
            // 
            // pbInferior2
            // 
            this.pbInferior2.BackgroundImage = global::ProyectoBiblioteca.Properties.Resources.feria_miniatura_2;
            this.pbInferior2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbInferior2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbInferior2.Location = new System.Drawing.Point(281, 3);
            this.pbInferior2.Name = "pbInferior2";
            this.pbInferior2.Size = new System.Drawing.Size(232, 122);
            this.pbInferior2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbInferior2.TabIndex = 6;
            this.pbInferior2.TabStop = false;
            // 
            // pbInferior3
            // 
            this.pbInferior3.BackgroundImage = global::ProyectoBiblioteca.Properties.Resources.feria_miniatura_3;
            this.pbInferior3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbInferior3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbInferior3.Location = new System.Drawing.Point(539, 3);
            this.pbInferior3.Name = "pbInferior3";
            this.pbInferior3.Size = new System.Drawing.Size(232, 122);
            this.pbInferior3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbInferior3.TabIndex = 8;
            this.pbInferior3.TabStop = false;
            // 
            // pbInferior1
            // 
            this.pbInferior1.BackgroundImage = global::ProyectoBiblioteca.Properties.Resources.feria_miniatura_1;
            this.pbInferior1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbInferior1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbInferior1.Location = new System.Drawing.Point(23, 3);
            this.pbInferior1.Name = "pbInferior1";
            this.pbInferior1.Size = new System.Drawing.Size(232, 122);
            this.pbInferior1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbInferior1.TabIndex = 7;
            this.pbInferior1.TabStop = false;
            // 
            // tlpSuperior
            // 
            this.tlpSuperior.ColumnCount = 3;
            this.tlpSuperior.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpSuperior.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSuperior.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpSuperior.Controls.Add(this.pbSuperio, 1, 0);
            this.tlpSuperior.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSuperior.Location = new System.Drawing.Point(2, 2);
            this.tlpSuperior.Margin = new System.Windows.Forms.Padding(2);
            this.tlpSuperior.Name = "tlpSuperior";
            this.tlpSuperior.RowCount = 1;
            this.tlpSuperior.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSuperior.Size = new System.Drawing.Size(796, 304);
            this.tlpSuperior.TabIndex = 7;
            this.tlpSuperior.Paint += new System.Windows.Forms.PaintEventHandler(this.tlpSuperior_Paint);
            // 
            // pbSuperio
            // 
            this.pbSuperio.BackgroundImage = global::ProyectoBiblioteca.Properties.Resources.feria_libro;
            this.pbSuperio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbSuperio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbSuperio.Location = new System.Drawing.Point(23, 3);
            this.pbSuperio.Name = "pbSuperio";
            this.pbSuperio.Size = new System.Drawing.Size(750, 298);
            this.pbSuperio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSuperio.TabIndex = 5;
            this.pbSuperio.TabStop = false;
            // 
            // VisualizarInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tlpPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VisualizarInicio";
            this.Text = "VisualizarInicio";
            this.tlpPrincipal.ResumeLayout(false);
            this.tlpInferior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbInferior2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInferior3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInferior1)).EndInit();
            this.tlpSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbSuperio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpPrincipal;
        private System.Windows.Forms.PictureBox pbSuperio;
        private System.Windows.Forms.TableLayoutPanel tlpInferior;
        private System.Windows.Forms.PictureBox pbInferior2;
        private System.Windows.Forms.PictureBox pbInferior3;
        private System.Windows.Forms.PictureBox pbInferior1;
        private System.Windows.Forms.TableLayoutPanel tlpSuperior;
    }
}