using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administracion_DAL
{
    public class EstacionServicio
    {
        private string nombre;
        private string direccion;
        private int codigo;
        private int capacidadMaxima;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public int Codigo { get => codigo; set => codigo = value; }
        public int CapacidadMaxima { get => capacidadMaxima; set => capacidadMaxima = value; }
    }
}
