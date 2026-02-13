using FilaLibros;
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
    public partial class GestionLibros : Form
    {
        public Controlador miControlador { get; set; }

        public GestionLibros()
        {
            InitializeComponent();
        }


        public static GestionLibros formulario;
        internal static GestionLibros GetInstance()
        {
            if (formulario == null || formulario.IsDisposed)
            {
                formulario = new GestionLibros();
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
                ucFila.Id = (int)row.Field<long>("id");
                ucFila.Titulo = row.Field<string>("titulo");
                ucFila.Escritor = row.Field<string>("escritor");

                // Utilizar "long?" (nullable) porque 'ano_edicion' puede venir como NULL en la base de datos
                ucFila.Anyo = row.Field<long?>("ano_edicion")?.ToString() ?? "";

                // Convertir el 1 o 0 de la base de datos a booleano
                ucFila.Disponible = Convert.ToBoolean(row["disponible"]);

                ucFila.verLibro += ucFila_verLibro;
                ucFila.borrarLibro += ucFila_borrarLibro;
                ucFila.Dock = DockStyle.Fill;
                tlpDatosInterior.RowCount = tlpDatosInterior.RowCount + 1;
                tlpDatosInterior.RowStyles.Insert(nuevaFila, new RowStyle(SizeType.AutoSize));
                tlpDatosInterior.Controls.Add(ucFila, 0, nuevaFila);
                nuevaFila++;
            }
        }

        /*
         TODO : Me falta hacer que el panel de modificar se quede centrado
                y con mejor tamaño, con lo gris solo en la ventana,
                y añadir un botón (PictureBox) para poder salir.
         */

        private void ucFila_verLibro(object sender, UserControl1.ClickarBotonIdEventArgs e)
        {
            try
            {
                // Crear el fondo gris
                using (Fondo frmFondo = new Fondo())
                {
                    // Ajustar propiedades
                    frmFondo.StartPosition = FormStartPosition.Manual;
                    frmFondo.Location = this.Location;
                    frmFondo.Size = this.Size;
                    frmFondo.Show();

                    // Crear y mostrar la tarjeta de detalle/modificación
                    using (ModificarLibros frmModificar = new ModificarLibros())
                    {
                        // Pasar el controlador
                        frmModificar.miControlador = this.miControlador;

                        // Pasar el ID que viene en el evento
                        frmModificar.IdLibro = e.Id;

                        // La sombra es la dueña
                        frmModificar.Owner = frmFondo;

                        // ShowDialog bloquea la ejecución aquí, hasta que el usuario cierre "ModificarLibros"
                        frmModificar.ShowDialog();
                    }

                    // Una vez cerrada la ventana de modificar, hay que cerrar el fondo
                    frmFondo.Close();
                }

                // Recargar la lista después de cerrar la edición para ver los cambios
                Cargar(miControlador.CargarLibros());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucFila_borrarLibro(object sender, UserControl1.ClickarBotonIdEventArgs e)
        {
            try
            {
                miControlador.EliminarLibro(e.Id);
                Cargar(miControlador.CargarLibros());
                MessageBox.Show("Libro borrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
