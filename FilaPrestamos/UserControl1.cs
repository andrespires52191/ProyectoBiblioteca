using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilaPrestamos
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private int id;

        public int Id { get => id; set => id = value; }
        public string Usuario { get => lUsuario.Text; set => lUsuario.Text = value; }
        public string Libro { get => lLibro.Text; set => lLibro.Text = value; }
        public string FechaIni { get => lFechaIni.Text; set => lFechaIni.Text = value; }
        public string FechaFin { get => lFechaFin.Text; set => lFechaFin.Text = value; }

        public event EventHandler<ClickarBotonIdEventArgs> verPrestamo;
        public event EventHandler<ClickarBotonIdEventArgs> devolverPrestamo;

        public class ClickarBotonIdEventArgs : EventArgs
        {
            public int Id { get; }
            public ClickarBotonIdEventArgs(int id) => Id = id;
        }

        private void pbVer_Click(object sender, EventArgs e)
        {
            verPrestamo?.Invoke(this, new ClickarBotonIdEventArgs((int)id));
        }

        private void pbDevolver_Click(object sender, EventArgs e)
        {
            devolverPrestamo?.Invoke(this, new ClickarBotonIdEventArgs((int)id));
        }
    }
}
