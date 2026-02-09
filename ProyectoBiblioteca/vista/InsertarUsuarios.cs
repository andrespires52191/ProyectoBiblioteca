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
    public partial class InsertarUsuarios : Form
    {
        public Controlador miControlador { get; set; }

        public InsertarUsuarios()
        {
            InitializeComponent();
        }

        public static InsertarUsuarios formulario;
        public static InsertarUsuarios GetInstance()
        {
            if (formulario == null)
            {
                formulario = new InsertarUsuarios();
            }
            return formulario;
        }

        private int id;
        public int Id { get => id; set => id = value; }

        public string Nombre
        {
            get => lNombre.Text;
            set => lNombre.Text = value;
        }

        public string Apellido1
        {
            get => lPrimerApellido.Text;
            set => lPrimerApellido.Text = value;
        }

        public string Apellido2
        {
            get => lSegundoApellido.Text;
            set => lSegundoApellido.Text = value;
        }

        public int Telefono
        {
            get
            {
                int.TryParse(lTelefono.Text, out int resultado);
                return resultado;
            }
            set => lTelefono.Text = value.ToString();
        }

        public event EventHandler<ClickarBotonIdEventArgs> anadirUsuario;

        public class ClickarBotonIdEventArgs : EventArgs
        {
            public int Id { get; }
            public ClickarBotonIdEventArgs(int id) => Id = id;
        }

        private void bAnadir_Click(object sender, EventArgs e)
        {
            // TODO : Tendrá que validar los datos y luego ya que pase/cree el ID y mande los datos
            anadirUsuario?.Invoke(this, new ClickarBotonIdEventArgs((int)id));
        }
    }
}
