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
            get => cbLibro.SelectedValue != null ? Convert.ToInt32(cbLibro.SelectedValue) : 0;
            set => cbLibro.SelectedValue = value;
        }

        public int IdUsuario
        {
            get => cbUsuario.SelectedValue != null ? Convert.ToInt32(cbUsuario.SelectedValue) : 0;
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
                // TODO : El controlador tendrá que validar los datos
                miControlador.AnadirPrestamo(IdUsuario, IdLibro, FechaInicio, FechaFin);
                MessageBox.Show("Prestamo añadido correctamente.");
                limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void limpiar()
        {
            IdLibro = 0;
            IdUsuario = 0;
            FechaInicio = DateTime.Now;
            FechaFin = DateTime.Now;
        }

        internal void CargarLibros(DataTable dataTable)
        {
            cbLibro.DataSource = dataTable;
            cbLibro.DisplayMember = "titulo";
            cbLibro.ValueMember = "id";
            cbLibro.SelectedIndex = 0;
        }

        internal void CargarUsuarios(DataTable dataTable)
        {
            cbUsuario.DataSource = dataTable;
            cbUsuario.DisplayMember = "nombre";
            cbUsuario.ValueMember = "id";
            cbUsuario.SelectedIndex = 0;
        }
    }
}
