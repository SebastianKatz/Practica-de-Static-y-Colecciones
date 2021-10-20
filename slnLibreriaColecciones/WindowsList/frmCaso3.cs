using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades.Models;

namespace WindowsList
{
    public partial class frmCaso3 : Form
    {
        public frmCaso3()
        {
            InitializeComponent();
        }

        private void frmCaso3_Load(object sender, EventArgs e)
        {
            gridPublicadores.DataSource = AdminPublicadores.Listar();
        }
        private void actualizarGrid()
        {
            gridPublicadores.DataSource = null;
            gridPublicadores.DataSource = AdminPublicadores.Listar();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            AdminPublicadores.insertar(Convert.ToInt32(txtID.Text), txtApellido.Text, txtNombre.Text, Convert.ToDateTime(txtFecha.Text), txtCiudad.Text);
            actualizarGrid();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            AdminPublicadores.eliminar(Convert.ToInt32(txtBuscarPoriD.Text));
            actualizarGrid();
        }
    }
}
