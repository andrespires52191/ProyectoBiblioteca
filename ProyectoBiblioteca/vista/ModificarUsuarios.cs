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
    public partial class ModificarUsuarios : Form
    {
        public Controlador miControlador { get; set; }

        public ModificarUsuarios()
        {
            InitializeComponent();
        }

        // Propiedad para recibir el ID
        public int IdUsuario { get; set; }

        private void pbGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = tbNombre.Text;
                string ap1 = tbApellido1.Text;
                string ap2 = tbApellido2.Text;
                string tel = tbTelefono.Text;

                miControlador.ModificarUsuario(IdUsuario, nombre, ap1, ap2, tel);
                MessageBox.Show("Usuario actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pbEliminar_Click(object sender, EventArgs e)
        {
            // TODO : Hacer lo de eliminar
            /*
            try
            {
                // Usar el mismo Owner que tiene ModificarUsuarios (que es el Fondo gris)
                using (EliminarFila frmConfirmar = new EliminarFila())
                {
                    frmConfirmar.TipoEntidad = "Usuario"; // Indicar que es un usuario
                    frmConfirmar.StartPosition = FormStartPosition.CenterParent;

                    // Mostrar la ventana de confirmación
                    if (frmConfirmar.ShowDialog(this.Owner) == DialogResult.OK)
                    {
                        miControlador.EliminarUsuario(this.IdUsuario);

                        // Cerrar la ventana de edición porque el usuario ya no existe
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            */
        }

        private void pbCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ModificarUsuarios_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = miControlador.BuscarUsuario(IdUsuario);
                if (dt != null && dt.Rows.Count > 0)
                {
                    DataRow usuario = dt.Rows[0];
                    tbNombre.Text = usuario["Nombre"].ToString();
                    tbApellido1.Text = usuario["Apellido_1"].ToString();
                    tbApellido2.Text = usuario["Apellido_2"].ToString();
                    tbTelefono.Text = usuario["Telefono"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
