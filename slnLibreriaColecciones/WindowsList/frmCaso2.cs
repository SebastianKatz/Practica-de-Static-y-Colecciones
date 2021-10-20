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
    public partial class frmCaso2 : Form
    {
        List<Empleado> empleados = new List<Empleado>();
        public frmCaso2()
        {
            InitializeComponent();
        }

        private void frmCaso2_Load(object sender, EventArgs e)
        {
            precargarEmpleados();
        }

        private void precargarEmpleados()
        {
            Empleado empleado1 = new Empleado(1, "Lopez", "Carlos", new DateTime(1985, 11, 05), "Buenos Aires", "Argentina");
            Empleado empleado2 = new Empleado(2, "Picapiedras", "Pepe", new DateTime(1985, 11, 05), "Buenos Aires", "Argentina");
            Empleado empleado3 = new Empleado(3, "Gomez", "Lionel", new DateTime(1985, 11, 05), "Buenos Aires", "Argentina");
            empleados.Add(empleado1);
            empleados.Add(empleado2);
            empleados.Add(empleado3);

            actualizarGrid();
        }

        private void actualizarGrid()
        {
            gridEmpleados.DataSource = null;
            gridEmpleados.DataSource = empleados;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            insertarEmpleado();
        }

        private void insertarEmpleado()
        {
            empleados.Add(new Empleado(Convert.ToInt32(txtID.Text), txtApellido.Text, txtNombre.Text, Convert.ToDateTime(txtFecha.Text), txtCiudad.Text, txtNacionalidad.Text));
            actualizarGrid();
            txtID.Clear();
            txtApellido.Clear();
            txtNombre.Clear();
            txtFecha.Clear();
            txtNacionalidad.Clear();
            txtCiudad.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            foreach (Empleado item in empleados)
            {
                if (item.Id == Convert.ToInt32(txtBuscarPoriD.Text))
                {
                    empleados.Remove(item);
                    break;
                }
            }
            actualizarGrid();
        }

        private void btnID_Click(object sender, EventArgs e)
        {
            if (empleados != null)
            {
                foreach (Empleado item in empleados)
                {
                    if (item.Id == Convert.ToInt32(txtBuscarPoriD.Text))
                    {
                        MessageBox.Show("ID: " + item.Id +
                                        "\nNombre: " + item.Nombre +
                                        "\nApellido: " + item.Apellido +
                                        "\nFecha de Nacimiento: " + item.FechaNac.ToShortDateString() +
                                        "\nNacionalidad: " + item.Nacionalidad +
                                        "\nCiudad: " + item.Ciudad);
                    }
                }
            }

            if (txtBuscarPoriD.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar un ID");
            }
        }
    }
}
