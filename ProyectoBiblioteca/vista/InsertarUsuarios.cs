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

    }
}
