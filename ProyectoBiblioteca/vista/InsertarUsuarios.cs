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
            if (formulario == null || formulario.IsDisposed)
            {
                formulario = new InsertarUsuarios();
            }
            return formulario;
        }

        private int id;
        public int Id { get => id; set => id = value; }

        public string Nombre
        {
            get => tbNombre.Text.Trim();
            set => tbNombre.Text = value;
        }

        public string Apellido1
        {
            get => tbPrimerApellido.Text.Trim();
            set => tbPrimerApellido.Text = value;
        }

        public string Apellido2
        {
            get => tbSegundoApellido.Text.Trim();
            set => tbSegundoApellido.Text = value;
        }

        public string Telefono
        {
            get => tbTelefono.Text.Trim();
            set => tbTelefono.Text = value;
        }

        public event EventHandler<ClickarBotonIdEventArgs> anadirUsuario;

        public class ClickarBotonIdEventArgs : EventArgs
        {
            public int Id { get; }
            public ClickarBotonIdEventArgs(int id) => Id = id;
        }

        private void bAnadir_Click(object sender, EventArgs e)
        {
            try
            {
                miControlador.AnadirUsuario(Nombre, Apellido1, Apellido2, Telefono);
                MessageBox.Show("Usuario añadido correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void limpiar()
        {
            Id = -1;
            Nombre = "";
            Apellido1 = "";
            Apellido2 = "";
            Telefono = "";
        }
    }
}
