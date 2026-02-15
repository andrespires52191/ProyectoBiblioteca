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
    public partial class InsertarPrestamos : Form
    {
        public Controlador miControlador { get; set; }

        public InsertarPrestamos()
        {
            InitializeComponent();
        }

        public static InsertarPrestamos formulario;
        public static InsertarPrestamos GetInstance()
        {
            if (formulario == null || formulario.IsDisposed)
            {
                formulario = new InsertarPrestamos();
            }
            return formulario;
        }

        private int id;
        public int Id { get => id; set => id = value; }

        // ID DEL LIBRO (Vía ComboBox)
        // Obtiene el SelectedValue (el ID) aunque el usuario vea el Título
        public int IdLibro
        {
            get => cbLibro.SelectedValue == null ? -1 : Convert.ToInt32(cbLibro.SelectedValue);
            set => cbLibro.SelectedValue = value;
        }

        public int IdUsuario
        {
            get => cbUsuario.SelectedValue == null ? -1 : Convert.ToInt32(cbUsuario.SelectedValue);
            set => cbUsuario.SelectedValue = value;
        }

        public DateTime FechaInicio
        {
            get => dtpFechaInicio.Value;
            set => dtpFechaInicio.Value = value;
        }

        public DateTime FechaFin
        {
            get => dtpFechaFin.Value;
            set => dtpFechaFin.Value = value;
        }

        public event EventHandler<ClickarBotonIdEventArgs> anadirPrestamo;

        public class ClickarBotonIdEventArgs : EventArgs
        {
            public int Id { get; }
            public ClickarBotonIdEventArgs(int id) => Id = id;
        }

        private void bAnadir_Click(object sender, EventArgs e)
        {
            try
            {
                if (IdLibro < 0)
                    throw new Exception("No hay libros disponibles para prestar.");
                if (IdUsuario < 0)
                    throw new Exception("No hay usuarios disponibles.");

                miControlador.AnadirPrestamo(IdUsuario, IdLibro, FechaInicio, FechaFin);
                MessageBox.Show("Préstamo añadido correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                RefrescarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Configurar el ComboBox de libros
        // DisplayMember: Lo que el usuario ve
        // ValueMember: Lo que el programa guarda
        internal void CargarLibros(DataTable dataTable)
        {
            cbLibro.DataSource = null;
            cbLibro.DisplayMember = "titulo";
            cbLibro.ValueMember = "id";
            cbLibro.DataSource = dataTable;
        }

        internal void CargarUsuarios(DataTable dataTable)
        {
            cbUsuario.DataSource = null;
            cbUsuario.DisplayMember = "nombre";
            cbUsuario.ValueMember = "id";
            cbUsuario.DataSource = dataTable;
        }

        public void RefrescarDatos()
        {
            if (miControlador == null) return;

            CargarLibros(miControlador.CargarLibrosDisponibles());
            CargarUsuarios(miControlador.CargarUsuarios());

            cbLibro.SelectedIndex = cbLibro.Items.Count > 0 ? 0 : -1;
            cbUsuario.SelectedIndex = cbUsuario.Items.Count > 0 ? 0 : -1;

            FechaInicio = DateTime.Now;
            FechaFin = DateTime.Now;
        }

        private void InsertarPrestamos_Load(object sender, EventArgs e)
        {
            RefrescarDatos();
        }
    }
}
