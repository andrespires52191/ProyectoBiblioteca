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
        public InsertarPrestamos()
        {
            InitializeComponent();
        }

        public static InsertarPrestamos formulario;

        public static InsertarPrestamos GetInstance()
        {
            if (formulario == null)
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
            get => cbLibro.SelectedValue != null ? (int)cbLibro.SelectedValue : 0;
            set => cbLibro.SelectedValue = value;
        }

        public int IdUsuario
        {
            get => cbUsuario.SelectedValue != null ? (int)cbUsuario.SelectedValue : 0;
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
            anadirPrestamo?.Invoke(this, new ClickarBotonIdEventArgs((int)id));
        }
    }
}
