using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilaUsuarios
{
    public partial class UserControl1: UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private int id;

        public int Id { get => id; set => id = value; }

        public string Nombre
        {
            get => lNombre.Text;
            set => lNombre.Text = value;
        }

        public string Apellido1
        {
            get => lApellido1.Text;
            set => lApellido1.Text = value;
        }

        public string Apellido2
        {
            get => lApellido2.Text;
            set => lApellido2.Text = value;
        }

        public event EventHandler<ClickarBotonIdEventArgs> verUsuario;
        public event EventHandler<ClickarBotonIdEventArgs> borrarUsuario;


        public class ClickarBotonIdEventArgs : EventArgs
        {
            public int Id { get; }

            public ClickarBotonIdEventArgs(int id)
            {
                Id = id;
            }
        }

        private void bVer_Click(object sender, EventArgs e)
        {
            verUsuario?.Invoke(this, new ClickarBotonIdEventArgs((int)id));
        }

        private void bBorrar_Click(object sender, EventArgs e)
        {
            borrarUsuario?.Invoke(this, new ClickarBotonIdEventArgs((int)id));
        }
    }
}
