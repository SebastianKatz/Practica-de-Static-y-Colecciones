using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Models
{
    public abstract class Persona
    {
        public Persona(int id, string apellido, string nombre, DateTime fechaNac, string ciudad)
        {
            Id = id;
            Apellido = apellido;
            Nombre = nombre;
            FechaNac = fechaNac;
            Ciudad = ciudad;
        }

        public int Id { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaNac { get; set; }
        public string Ciudad { get; set; }
    }
}
