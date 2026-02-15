namespace ProyectoBiblioteca.vista
{
    partial class Confirmar
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
            this.bBorrar = new System.Windows.Forms.Button();
            this.bCancelar = new System.Windows.Forms.Button();
            this.lPregunta = new System.Windows.Forms.Label();
            this.lDetalle = new System.Windows.Forms.Label();
            this.tlpPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpPrincipal
            // 
            this.tlpPrincipal.ColumnCount = 5;
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.479431F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.39716F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.24682F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.39716F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.479431F));
            this.tlpPrincipal.Controls.Add(this.bBorrar, 1, 5);
            this.tlpPrincipal.Controls.Add(this.bCancelar, 3, 5);
            this.tlpPrincipal.Controls.Add(this.lPregunta, 1, 1);
            this.tlpPrincipal.Controls.Add(this.lDetalle, 1, 3);
            this.tlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tlpPrincipal.Name = "tlpPrincipal";
            this.tlpPrincipal.RowCount = 7;
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.32394F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.60563F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.26761F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.60563F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.26761F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.60563F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.32394F));
            this.tlpPrincipal.Size = new System.Drawing.Size(658, 246);
            this.tlpPrincipal.TabIndex = 0;
            // 
            // bBorrar
            // 
            this.bBorrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(98)))));
            this.bBorrar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.bBorrar.ForeColor = System.Drawing.Color.White;
            this.bBorrar.Location = new System.Drawing.Point(52, 173);
            this.bBorrar.Name = "bBorrar";
            this.bBorrar.Size = new System.Drawing.Size(240, 37);
            this.bBorrar.TabIndex = 0;
            this.bBorrar.Text = "Borrar";
            this.bBorrar.UseVisualStyleBackColor = false;
            this.bBorrar.Click += new System.EventHandler(this.bBorrar_Click);
            // 
            // bCancelar
            // 
            this.bCancelar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.bCancelar.Location = new System.Drawing.Point(365, 173);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(240, 37);
            this.bCancelar.TabIndex = 1;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // lPregunta
            // 
            this.lPregunta.AutoSize = true;
            this.tlpPrincipal.SetColumnSpan(this.lPregunta, 3);
            this.lPregunta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lPregunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lPregunta.Location = new System.Drawing.Point(52, 30);
            this.lPregunta.Name = "lPregunta";
            this.lPregunta.Size = new System.Drawing.Size(553, 43);
            this.lPregunta.TabIndex = 2;
            this.lPregunta.Text = "¿Estás seguro de que quieres eliminar este X?";
            // 
            // lDetalle
            // 
            this.lDetalle.AutoSize = true;
            this.tlpPrincipal.SetColumnSpan(this.lDetalle, 3);
            this.lDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lDetalle.Location = new System.Drawing.Point(52, 100);
            this.lDetalle.Name = "lDetalle";
            this.lDetalle.Size = new System.Drawing.Size(553, 43);
            this.lDetalle.TabIndex = 3;
            this.lDetalle.Text = "Si eliminas este X su información será trasladada a la papelera.";
            // 
            // Confirmar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(658, 246);
            this.Controls.Add(this.tlpPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Confirmar";
            this.Text = "Confirmar";
            this.Load += new System.EventHandler(this.Confirmar_Load);
            this.tlpPrincipal.ResumeLayout(false);
            this.tlpPrincipal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpPrincipal;
        private System.Windows.Forms.Button bBorrar;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.Label lPregunta;
        private System.Windows.Forms.Label lDetalle;
    }
}