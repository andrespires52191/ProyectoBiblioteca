using FilaUsuarios;
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
    public partial class GestionUsuarios : Form
    {
        public Controlador miControlador { get; set; }

        public GestionUsuarios()
        {
            InitializeComponent();
        }

        public static GestionUsuarios formulario;
        internal static GestionUsuarios GetInstance()
        {
            if (formulario == null || formulario.IsDisposed)
            {
                formulario = new GestionUsuarios();
            }
            return formulario;
        }

        public void Cargar(DataTable datos)
        {
            tlpDatosInterior.Controls.Clear();
            int nuevaFila = 0;

            foreach (DataRow row in datos.Rows)
            {
                UserControl1 ucFila = new UserControl1();
                ucFila.Id = Convert.ToInt32(row["id"]);

                string nombre = row["nombre"].ToString();
                string ap1 = row["apellido_1"].ToString();
                string ap2 = row["apellido_2"] != DBNull.Value ? row["apellido_2"].ToString() : "";
                
                ucFila.NombreCompleto = $"{nombre} {ap1} {ap2}".Trim().Replace("  ", " ");

                ucFila.Telefono = row["telefono"].ToString();
                ucFila.verUsuario += ucFila_verUsuario;
                ucFila.borrarUsuario += ucFila_borrarUsuario;
                ucFila.Dock = DockStyle.Fill;
                tlpDatosInterior.RowCount = tlpDatosInterior.RowCount + 1;
                tlpDatosInterior.RowStyles.Insert(nuevaFila, new RowStyle(SizeType.AutoSize));
                tlpDatosInterior.Controls.Add(ucFila, 0, nuevaFila);
                nuevaFila++;
            }        
        }

        private void ucFila_verUsuario(object sender, UserControl1.ClickarBotonIdEventArgs e)
        {
            try
            {
                using (Fondo frmFondo = new Fondo())
                {
                    frmFondo.StartPosition = FormStartPosition.Manual;
                    Point puntoEnPantalla = this.PointToScreen(Point.Empty);
                    frmFondo.Location = new Point(puntoEnPantalla.X, puntoEnPantalla.Y);
                    frmFondo.Size = this.ClientSize;
                    frmFondo.Owner = this;
                    frmFondo.Show();

                    using (ModificarUsuarios frmModificar = new ModificarUsuarios())
                    {
                        frmModificar.miControlador = this.miControlador;
                        frmModificar.IdUsuario = e.Id;
                        frmModificar.Owner = frmFondo;
                        frmModificar.StartPosition = FormStartPosition.CenterParent;

                        frmModificar.ShowDialog();
                    }

                    frmFondo.Close();
                }

                // Recargar lista
                Cargar(miControlador.CargarUsuarios());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucFila_borrarUsuario(object sender, UserControl1.ClickarBotonIdEventArgs e)
        {
            try
            {
                using (Fondo frmFondo = new Fondo())
                {
                    frmFondo.StartPosition = FormStartPosition.Manual;
                    Point puntoEnPantalla = this.PointToScreen(Point.Empty);
                    frmFondo.Location = new Point(puntoEnPantalla.X, puntoEnPantalla.Y);
                    frmFondo.Size = this.ClientSize;
                    frmFondo.Owner = this;
                    frmFondo.Show();

                    using (Confirmar frmConfirmar = new Confirmar())
                    {
                        // Pasar los textos específicos para Usuarios
                        frmConfirmar.TextoPregunta = "¿Estás seguro de que quieres eliminar este usuario?";
                        frmConfirmar.TextoDetalle = "Si eliminas este usuario su información será trasladada a la papelera.";

                        frmConfirmar.Owner = frmFondo;

                        // Aumentar el ancho de la ventana
                        frmConfirmar.Width += 100;

                        frmConfirmar.StartPosition = FormStartPosition.CenterParent;

                        if (frmConfirmar.ShowDialog() == DialogResult.OK)
                        {
                            miControlador.EliminarUsuario(e.Id);
                            Cargar(miControlador.CargarUsuarios());
                            MessageBox.Show("Usuario borrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    frmFondo.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
