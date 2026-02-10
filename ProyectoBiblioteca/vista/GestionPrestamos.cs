using FilaPrestamos;
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
                UserControl1 ucFila = new UserControl1();
                ucFila.Id = (int)row.Field<long>("id");
                ucFila.Usuario = row.Field<long>("id_usuario").ToString();
                ucFila.Libro = row.Field<long>("id_libro").ToString();
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
            MessageBox.Show(e.Id.ToString());
        }
    }
}
