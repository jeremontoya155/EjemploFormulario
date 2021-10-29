using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GestionesDeClientes
{
    public partial class Gestiones : Form
    {
        public Gestiones()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Gestiones_Load(object sender, EventArgs e)
        {
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Nombre = textNombre.Text;
            cliente.Apellido = txtApellido.Text;
            cliente.Telefono = txtTelefono.Text;
            cliente.TarjetaDeCredito = txtTarjetaDeCredito.Text;

            
            listClientes.Items.Add(cliente);

           
           

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int indice = listClientes.SelectedIndex;
            listClientes.Items.RemoveAt(indice);
        }
    }
}
