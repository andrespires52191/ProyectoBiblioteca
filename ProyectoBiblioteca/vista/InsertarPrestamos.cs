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
            if (formulario == null)
            {
                formulario = new InsertarPrestamos();
            }
            return formulario;
        }

    }
}
