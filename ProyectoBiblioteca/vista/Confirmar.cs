using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBiblioteca.vista
{
    /*
     * Esta clase cargará una ventana de confirmación, o bien de de la eliminación
     * de un objeto Libro o Usuario, o bien de la devolución en un Préstamo.
     * Se reutilizará para Libro, Usuario y Préstamo.
     */
    public partial class Confirmar : Form
    {
        // Propiedades para personalizar los mensajes
        public string TextoPregunta { get; set; }
        public string TextoDetalle { get; set; }

        public Confirmar()
        {
            InitializeComponent();
        }

        private void bConfirmar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void Confirmar_Load(object sender, EventArgs e)
        {
            // Configurar los textos dinámicamente
            lPregunta.Text = TextoPregunta ?? "¿Estás seguro?";
            lDetalle.Text = TextoDetalle ?? "Esta acción no se puede deshacer.";
        }

        // Función para poner un borde al formulario y que haya contraste entre este y el de modificar
        private void Confirmar_Paint(object sender, PaintEventArgs e)
        {
            // Crear el borde
            Color colorBorde = Color.Black;
            int grosor = 2;

            // Dibujar el rectángulo
            using (Pen pen = new Pen(colorBorde, grosor))
            {
                // Ajustar el área para que no se corte el borde
                e.Graphics.DrawRectangle(pen, 0, 0, this.Width - 1, this.Height - 1);
            }
        }
    }
}
