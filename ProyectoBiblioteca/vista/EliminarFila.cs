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
     * Esta clase cargará una ventana de confirmación de la eliminación de una
     * fila de datos (un objeto), y se reutilizará en Libro, Usuario y Préstamo.
     */
    public partial class EliminarFila : Form
    {
        // Propiedad para saber qué se está borrando
        public string TipoEntidad { get; set; }

        public EliminarFila()
        {
            InitializeComponent();
        }

        private void bBorrar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void EliminarFila_Load(object sender, EventArgs e)
        {
            // Configurar los textos dinámicamente (dependiendo del tipo de entidad a borrar)
            lPregunta.Text = $"¿Estás seguro de que quieres eliminar este {TipoEntidad}?";
            lDetalle.Text = $"Si eliminas este {TipoEntidad} su información será trasladada a la papelera.";
        }
    }
}
