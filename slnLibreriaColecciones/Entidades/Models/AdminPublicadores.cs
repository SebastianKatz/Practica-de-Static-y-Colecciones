using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Models
{
    public static class AdminPublicadores
    {
        public static List<Publicador> publicadores = new List<Publicador>()
        {
            new Publicador(1, "Katz", "Sebastian", new DateTime(1999,01,12), "Buenos Aires"),
            new Publicador(2, "Katz", "Sebastian", new DateTime(1999,01,12), "Buenos Aires"),
            new Publicador(3, "Katz", "Sebastian", new DateTime(1999,01,12), "Buenos Aires")
        };

        public static List<Publicador> Listar()
        {
            return publicadores;
        }

        public static void insertar(int id, string apellido, string nombre, DateTime fechaNac, string ciudad)
        {
            publicadores.Add(new Publicador(id, apellido, nombre, fechaNac, ciudad));
        }

        public static void eliminar(int Id)
        {
            foreach (Publicador item in publicadores)
            {
                if (item.Id == Id)
                {
                    publicadores.Remove(item);
                    break;
                }
            }
        }
    }


}
