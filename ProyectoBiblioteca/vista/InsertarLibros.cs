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
            get => tbTitulo.Text;
            set => tbTitulo.Text = value;
        }

        public string Escritor
        {
            get => tbEscritor.Text;
            set => tbEscritor.Text = value;
        }

        public int Ano_Edicion
        {
            get => (int)nudAnio.Value;
            set => nudAnio.Value = value;
        }

        public string Sinopsis
        {
            get => tbSinopsis.Text;
            set => tbSinopsis.Text = value;
        }

        public bool Disponible
        {
            get
            {
                return rbSi.Checked;
            }
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
            //anadirLibro?.Invoke(this, new ClickarBotonIdEventArgs((int)id));
            miControlador.AnadirLibro(Titulo, Escritor, Ano_Edicion, Sinopsis, Disponible);
        }
    }
}
