using FilaPrestamos;
using ProyectoBiblioteca.controlador;
using ProyectoBiblioteca.modelo;
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
    public partial class GestionPrestamos : Form
    {
        public Controlador miControlador { get; set; }

        public GestionPrestamos()
        {
            InitializeComponent();
        }

        public static GestionPrestamos formulario;
        internal static GestionPrestamos GetInstance()
        {
            if (formulario == null || formulario.IsDisposed)
            {
                formulario = new GestionPrestamos();
            }
            return formulario;
        }

        public void Cargar(DataTable datos)
        {
            tlpDatosInterior.Controls.Clear();
            int nuevaFila = 0;
            foreach (DataRow row in datos.Rows)
            {
                int idUsuario = Convert.ToInt32(row["id_usuario"]);
                int idLibro = Convert.ToInt32(row["id_libro"]);
                String nombre_usuario = "(no disponible)";

                DataTable dtUs = miControlador.BuscarUsuario(idUsuario);
                if (dtUs.Rows.Count > 0)
                {
                    DataRow r = dtUs.Rows[0];
                    nombre_usuario = $"{r["nombre"]} {r["apellido_1"]} {r["apellido_2"]}";
                }

                string titulo_libro = "Libro no encontrado";
                DataTable dtLib = miControlador.BuscarLibro(idLibro);
                if (dtLib.Rows.Count > 0)
                {
                    titulo_libro = dtLib.Rows[0]["titulo"].ToString();
                }

                UserControl1 ucFila = new UserControl1();
                ucFila.Id = Convert.ToInt32(row["id"]);
                ucFila.Usuario = nombre_usuario;
                ucFila.Libro = titulo_libro;
                ucFila.FechaIni = row["fecha_inicio"].ToString();
                ucFila.FechaFin = row["fecha_fin"].ToString();
                ucFila.devolverPrestamo += ucFila_devolverPrestamo;
                ucFila.Dock = DockStyle.Fill;
                tlpDatosInterior.RowCount = tlpDatosInterior.RowCount + 1;
                tlpDatosInterior.RowStyles.Insert(nuevaFila, new RowStyle(SizeType.AutoSize));
                tlpDatosInterior.Controls.Add(ucFila, 0, nuevaFila);
                nuevaFila++;
            }
        }

        private void ucFila_devolverPrestamo(object sender, UserControl1.ClickarBotonIdEventArgs e)
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
                        // Textos personalizados para Préstamos
                        frmConfirmar.TextoPregunta = "¿Quieres realizar esta devolución?";
                        frmConfirmar.TextoDetalle = "Si devuelves este préstamo el libro pasará a estar disponible.";

                        frmConfirmar.Owner = frmFondo;

                        // Aumentar el ancho de la ventana
                        frmConfirmar.Width += 50;

                        frmConfirmar.StartPosition = FormStartPosition.CenterParent;

                        if (frmConfirmar.ShowDialog() == DialogResult.OK)
                        {
                            miControlador.DevolverPrestamo(e.Id);
                            Cargar(miControlador.CargarPrestamos());
                            MessageBox.Show("Préstamo devuelto correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Refrescar combos de InsertarPrestamos
                            InsertarPrestamos inst = InsertarPrestamos.GetInstance();
                            if (inst != null && !inst.IsDisposed)
                                inst.RefrescarDatos();
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
