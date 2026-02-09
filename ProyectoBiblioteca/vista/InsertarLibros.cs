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
            get => lEscritor.Text;
            set => lEscritor.Text = value;
        }

        public int Ano_Adicion
        {
            get {
                int anio;
                int.TryParse(lAnio.Text, out anio);
                return anio;

            }
            set {
                lAnio.Text = value.ToString();
            }
        }

        public string Sinopsis
        {
            get => lSinopsis.Text;
            set => lSinopsis.Text = value;
        }

        public int Disponible
        {
            get
            {
                if (rbSi.Checked)
                {
                    return 1;
                }
                else
                    return 0;
            }
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

        private void bAnadir_Click(object sender, EventArgs e)
        {
            anadirLibro?.Invoke(this, new ClickarBotonIdEventArgs((int)id));
        }
    }
}
