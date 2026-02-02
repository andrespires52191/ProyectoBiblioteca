using FilaUsuarios;
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
    public partial class GestionLibros : Form
    {
        public Controlador miControlador { get; set; }

        public GestionLibros()
        {
            InitializeComponent();
        }

        /*
        public void cargar(DataTable datos)
        {
            tlpDatosInterior.Controls.Clear();
            int nuevaFila = 0;
            foreach (DataRow row in datos.Rows)
            {
                UserControlLibros ucFila = new UserControl1();
                ucFila.Id = (int)row.Field<long>("id");
                ucFila.Titulo = row.Field<string>("titulo");
                ucFila.Autor = row.Field<string>("autor");
                ucFila.verLibro += ucFila_verLibro;
                ucFila.borrarLibro += ucFila_borrarLibro;
                ucFila.Dock = DockStyle.Fill;
                tlpDatosInterior.RowCount = tlpDatosInterior.RowCount + 1;
                tlpDatosInterior.RowStyles.Insert(nuevaFila, new RowStyle(SizeType.AutoSize));
                tlpDatosInterior.Controls.Add(ucFila, 0, nuevaFila);
                nuevaFila++;
            }
        }
        */
    }
}
