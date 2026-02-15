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
    public partial class InsertarLibros : Form
    {
        // TODO : Parte de responsividad
        /*
        bool mostrado = false;
        const float FONTSIZE = 10f;
        */

        public Controlador miControlador { get; set; }

        public InsertarLibros()
        {
            InitializeComponent();

            // Configurar el NumericUpDown del año para que admita valores superiores a 100 (hasta el año actual)
            nudAnio.Maximum = DateTime.Now.Year;

            // Establecer el estado de disponibilidad "Sí" por defecto
            rbSi.Checked = true;

            // TODO : Parte de responsividad
            /*
            mostrado = true;
            limpiar();
            */

            // TODO : Probar a hacer que salga esta ventana con más alto y ancho inicial (y luego aplicar a las demás)
        }

        public static InsertarLibros formulario;
        public static InsertarLibros GetInstance()
        {
            if (formulario == null || formulario.IsDisposed)
            {
                formulario = new InsertarLibros();
            }
            return formulario;
        }

        private int id;
        public int Id { get => id; set => id = value; }

        public string Titulo
        {
            get => tbTitulo.Text.Trim();
            set => tbTitulo.Text = value;
        }

        public string Escritor
        {
            // Si está vacío al obtenerlo, devuelve "Anonimo"
            get => string.IsNullOrWhiteSpace(tbEscritor.Text.Trim()) ? "Anonimo" : tbEscritor.Text.Trim();
            set => tbEscritor.Text = value;
        }

        public int? Ano_Edicion
        {
            get => nudAnio.Value == 0 ? (int?)null : (int?)nudAnio.Value;
            set => nudAnio.Value = value ?? 0;
        }

        public string Sinopsis
        {
            get => tbSinopsis.Text.Trim();
            set => tbSinopsis.Text = value;
        }

        public bool Disponible
        {
            get => rbSi.Checked && !rbNo.Checked;
            set
            {
                if (value)
                {
                    rbSi.Checked = true;
                }
                else
                    rbNo.Checked = true;
            }
        }

        public event EventHandler<ClickarBotonIdEventArgs> anadirLibro;

        public class ClickarBotonIdEventArgs : EventArgs
        {
            public int Id { get; }
            public ClickarBotonIdEventArgs(int id) => Id = id;
        }

        private void bAnadir_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener año nullable
                int? anio = nudAnio.Value == 0 ? (int?)null : (int?)nudAnio.Value;

                // Toda la validación la hace el controlador dentro de AnadirLibro
                miControlador.AnadirLibro(Titulo, Escritor, anio, Sinopsis, Disponible);
                MessageBox.Show("Libro añadido correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiar();
            }
            catch (Exception ex)
            {
                // Mostrar error personalizado
                MessageBox.Show(ex.Message, "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void limpiar()
        {
            Titulo = "";
            Escritor = "";
            Ano_Edicion = 0;
            Sinopsis = "";
            rbSi.Checked = true;
        }

        private void InsertarLibros_Resize(object sender, EventArgs e)
        {
            // TODO : Parte de responsividad
            /*
            if (mostrado)
            {
                double proporcionAlto = (double)this.Height / this.MinimumSize.Height;
                //double proporcionAncho = (double)this.Width / this.MinimumSize.Width;
                foreach (Control control in tlpPrincipal.Controls)
                {
                    control.Font = new Font(control.Font.FontFamily, (float)(FONTSIZE * proporcionAlto));
                }
            }
            */
        }
    }
}
