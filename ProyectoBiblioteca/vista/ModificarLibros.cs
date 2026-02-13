using ProyectoBiblioteca.controlador;
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
    public partial class ModificarLibros : Form
    {
        public Controlador miControlador { get; set; }

        public ModificarLibros()
        {
            InitializeComponent();
        }

        // Propiedad para guardar el ID que viene desde el UserControl pasando por GestionLibros
        public int IdLibro { get; set; }

        private void pbGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string titulo = tbTitulo.Text;
                string escritor = tbEscritor.Text;
                int anio = (int)nudAnio.Value;
                string sinopsis = tbSinopsis.Text;
                bool disponible = rbSi.Checked;

                miControlador.ModificarLibro(IdLibro, titulo, escritor, anio, sinopsis, disponible);
                MessageBox.Show("Libro modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                // Cuando se cierre esta ventana, se quitará el fondo gris de GestionLibros
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pbEliminar_Click(object sender, EventArgs e)
        {
            // TODO : Hacer lo de eliminar desde aquí también (y traspasarlo a EliminarFila)
        }

        private void pbCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ModificarLibros_Load(object sender, EventArgs e)
        {
            try
            {
                // Obtener los datos mediante el ID
                DataTable dt = miControlador.BuscarLibro(IdLibro);

                if (dt != null && dt.Rows.Count > 0)
                {
                    DataRow libro = dt.Rows[0];

                    tbTitulo.Text = libro["titulo"].ToString();
                    tbEscritor.Text = libro["escritor"].ToString();

                    // Gestión de nulos para el año
                    if (libro["ano_edicion"] != DBNull.Value)
                    {
                        nudAnio.Value = Convert.ToDecimal(libro["ano_edicion"]);
                    }

                    tbSinopsis.Text = libro["sinopsis"].ToString();

                    bool disponible = Convert.ToBoolean(libro["disponible"]);
                    rbSi.Checked = disponible;
                    rbNo.Checked = !disponible;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el libro: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
