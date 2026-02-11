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

        public void limpiar()
        {
            tbTitulo.Text = "";
            tbEscritor.Text = "";
            nudAnio.Value = 0;
            tbSinopsis.Text = "";
            rbSi.Checked = true;
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

        // TODO : Implementar lo de "int?"

        // Se utiliza "int?" (nullable) porque el año puede ser NULL
        /*
        public int Ano_Edicion
        {
            get {
                if (string.IsNullOrWhiteSpace(nudAnio.Text)) return null;
                if (int.TryParse(nudAnio.Text, out int anio)) return anio;
                return null;
            }
            set => nudAnio.Text = value?.ToString() ?? "";
        }
        */

        public int Ano_Edicion
        {
            get => (int)nudAnio.Value;
            set => nudAnio.Value = value;
        }

        public string Sinopsis
        {
            get => tbSinopsis.Text.Trim();
            set => tbSinopsis.Text = value;
        }

        public bool Disponible
        {
            get => rbSi.Checked;
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

        private bool validarDatos()
        {
            // 1. Validar Título (Not Null y texto)
            if (string.IsNullOrWhiteSpace(Titulo))
            {
                MessageBox.Show("El título es obligatorio.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // TODO : Llamada al modelo
            // 2. Validar Título Único (Llamada al controlador/modelo)
            /*
            if (miControlador != null && miControlador.ExisteTitulo(Titulo))
            {
                MessageBox.Show("Este título ya existe en la biblioteca.", "Error de duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            */

            // TODO : Configurar el NumericUpDown para que se pueda escribir más que el nº 100
            // 3. Validar Año (Si se ha escrito algo)
            /*
            if (!string.IsNullOrWhiteSpace(lAnio.Text))
            {
                int anioActual = DateTime.Now.Year;

                if (!int.TryParse(lAnio.Text, out int anioValido))
                {
                    MessageBox.Show("El año debe ser un número entero.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                // Desde 1700 hasta Año Actual
                if (anioValido < 1700 || anioValido > anioActual)
                {
                    MessageBox.Show($"El año debe estar entre el 1700 y el {anioActual}.", "Rango inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            */

            // 4. Validar Sinopsis (Máximo 1000 caracteres)
            if (Sinopsis.Length > 1000)
            {
                MessageBox.Show("La sinopsis no puede superar los 1000 caracteres.", "Texto demasiado largo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // 5. Validar Disponible (Not null - Uno de los dos debe estar marcado)
            if (!rbSi.Checked && !rbNo.Checked)
            {
                MessageBox.Show("Debe seleccionar si el libro está disponible o no.", "Error de selección", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            

            return true;
        }

        private void bAnadir_Click(object sender, EventArgs e)
        {
            // TODO: Los errores de validación se generan como excepciones en el controlador
            // y el mensaje de la excepción lo mostramos al usuario.
            // haria falta mover y adaptar validarDatos() dentro del controlador.
            try
            {
                //anadirLibro?.Invoke(this, new ClickarBotonIdEventArgs((int)id));
                miControlador.AnadirLibro(Titulo, Escritor, Ano_Edicion, Sinopsis, Disponible);
                MessageBox.Show("Libro añadido corretamente.");
                limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
