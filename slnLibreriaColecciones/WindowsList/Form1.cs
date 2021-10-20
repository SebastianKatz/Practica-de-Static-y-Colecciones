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
    public partial class Form1 : Form
    {
        List<Autor> autores = new List<Autor>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            autores.Add(new Autor(1, "Katz", "Sebastian", Convert.ToDateTime("12/01/1999"), "Buenos Aires", "Argentina"));
            actualizarGrid();
        }
        private void actualizarGrid()
        {
            gridAutores.DataSource = null;
            gridAutores.DataSource = autores;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            autores.Add(new Autor(Convert.ToInt32(txtID.Text), txtApellido.Text, txtNombre.Text, Convert.ToDateTime(txtFecha.Text), txtCiudad.Text, txtNacionalidad.Text));
            actualizarGrid();
        }

        private void btnCiudad_Click(object sender, EventArgs e)
        {
            List<Autor> autores_ciudad = new List<Autor>() { };
            string buscar = txtCiudad.Text;
            foreach (Autor item in autores)
            {
                if (item.Ciudad == buscar)
                    autores_ciudad.Add(item);
            }
            gridAutores.DataSource = null;
            gridAutores.DataSource = autores_ciudad;
        }
    }
}
