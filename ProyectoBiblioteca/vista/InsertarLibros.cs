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
        public Controlador miControlador { get; set; }

        public InsertarLibros()
        {
            InitializeComponent();
        }

        public static InsertarLibros formulario;
        public static InsertarLibros GetInstance()
        {
            if (formulario == null)
            {
                formulario = new InsertarLibros();
            }
            return formulario;
        }

        private int id;
        public int Id { get => id; set => id = value; }

        public string Titulo
        {
            get => lTitulo.Text;
            set => lTitulo.Text = value;
        }

        public string Escritor
        {
            // Si está vacío al obtenerlo, devuelve "Anonimo"
            get => string.IsNullOrWhiteSpace(lEscritor.Text) ? "Anonimo" : lEscritor.Text;
            set => lEscritor.Text = value;
        }

        // Se utiliza int? (nullable) porque el año puede ser NULL
        public int? Ano_Adicion
        {
            get {
                if (string.IsNullOrWhiteSpace(lAnio.Text)) return null;
                if (int.TryParse(lAnio.Text, out int anio)) return anio;
                return null;
            }
            set => lAnio.Text = value?.ToString() ?? "";
        }

        public string Sinopsis
        {
            get => lSinopsis.Text;
            set => lSinopsis.Text = value;
        }

        public int Disponible
        {
            get => rbSi.Checked ? 1 : 0;
            set
            {
                if (value == 1)
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
            // TODO : Tengo que probarlo todo y luego mejorarlo

            /*
             // 1. Validar Título (Not Null y texto)
            if (string.IsNullOrWhiteSpace(Titulo))
            {
                MessageBox.Show("El título es obligatorio.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // 2. Validar Título Único (Llamada al controlador/modelo)
            // Asumiendo que tu controlador tiene un método para verificar esto
            if (miControlador != null && miControlador.ExisteTitulo(Titulo))
            {
                MessageBox.Show("Este título ya existe en la biblioteca.", "Error de duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // 3. Validar Año (Si se ha escrito algo)
            if (!string.IsNullOrWhiteSpace(lAnio.Text))
            {
                int anioActual = DateTime.Now.Year;
                if (!int.TryParse(lAnio.Text, out int anioValido))
                {
                    MessageBox.Show("El año debe ser un número entero.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                // Siglo IX (801) hasta Año Actual
                if (anioValido < 801 || anioValido > anioActual)
                {
                    MessageBox.Show($"El año debe estar entre el 801 y el {anioActual}.", "Rango inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }

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
             */

            return true;
        }

        private void bAnadir_Click(object sender, EventArgs e)
        {
            // TODO : Tendrá que validar los datos y luego ya que pase/cree el ID y mande los datos
            if (validarDatos())
            {
                anadirLibro?.Invoke(this, new ClickarBotonIdEventArgs((int)id));
            }
        }
    }
}
