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
                String nombre_usuario = "(no disponible)";
                try
                {
                    DataRow usuario = miControlador.BuscarUsuario((int)row.Field<long>("id_usuario")).Rows[0];
                    nombre_usuario = usuario.Field<string>("nombre") + " " +
                        usuario.Field<string>("apellido_1") + " " +
                        usuario.Field<string>("apellido_2");
                }
                catch { }

                String titulo_libro = "(no disponible)";
                try
                {
                    DataRow libro = miControlador.BuscarLibro((int)row.Field<long>("id_libro")).Rows[0];
                    titulo_libro = libro.Field<string>("titulo");

                }
                catch { }

                UserControl1 ucFila = new UserControl1();
                ucFila.Id = (int)row.Field<long>("id");
                ucFila.Usuario = nombre_usuario;
                ucFila.Libro = titulo_libro;
                ucFila.FechaIni = row.Field<string>("fecha_inicio");
                ucFila.FechaFin = row.Field<string>("fecha_fin");
                ucFila.verPrestamo += ucFila_verPrestamo;
                ucFila.devolverPrestamo += ucFila_devolverPrestamo;
                ucFila.Dock = DockStyle.Fill;
                tlpDatosInterior.RowCount = tlpDatosInterior.RowCount + 1;
                tlpDatosInterior.RowStyles.Insert(nuevaFila, new RowStyle(SizeType.AutoSize));
                tlpDatosInterior.Controls.Add(ucFila, 0, nuevaFila);
                nuevaFila++;
            }
        }

        private void ucFila_verPrestamo(object sender, UserControl1.ClickarBotonIdEventArgs e)
        {
            MessageBox.Show(e.Id.ToString());
        }

        private void ucFila_devolverPrestamo(object sender, UserControl1.ClickarBotonIdEventArgs e)
        {
            try
            {
                miControlador.DevolverPrestamo(e.Id);
                MessageBox.Show("Prestamo devuelto correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
