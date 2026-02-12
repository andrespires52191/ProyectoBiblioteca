using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilaLibros
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private int id;

        public int Id { get => id; set => id = value; }
        public string Titulo { get => lTitulo.Text; set => lTitulo.Text = value; }
        public string Escritor { get => lEscritor.Text; set => lEscritor.Text = value; }
        public string Anyo { get => lAnyo.Text; set => lAnyo.Text = value; }
        public bool Disponible
        {
            get => lDisponible.Text == "Sí";
            set => lDisponible.Text = (value) ? "Sí" : "No";
        }
        public event EventHandler<ClickarBotonIdEventArgs> verLibro;
        public event EventHandler<ClickarBotonIdEventArgs> borrarLibro;

        public class ClickarBotonIdEventArgs : EventArgs
        {
            public int Id { get; }
            public ClickarBotonIdEventArgs(int id) => Id = id;
        }

        private void pbVer_Click(object sender, EventArgs e)
        {
            verLibro?.Invoke(this, new ClickarBotonIdEventArgs((int)id));
        }

        private void pbBorrar_Click(object sender, EventArgs e)
        {
            borrarLibro?.Invoke(this, new ClickarBotonIdEventArgs((int)id));
        }
    }
}
