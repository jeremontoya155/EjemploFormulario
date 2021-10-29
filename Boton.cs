using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionesDeClientes
{
    public partial class Boton : Form
    {
        public Boton()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Gestiones ventanaGestiones = new Gestiones();
            ventanaGestiones.ShowDialog();
        }
    }
}
