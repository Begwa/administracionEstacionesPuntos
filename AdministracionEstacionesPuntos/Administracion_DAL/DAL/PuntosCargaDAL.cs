using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administracion_DAL.DAL
{
    public class PuntosCargaDAL
    {
        private static List<PuntoCarga> puntos = new List<PuntoCarga>();

        public void Add(PuntoCarga p)
        {
            puntos.Add(p);
        }

        public List<PuntoCarga> GetAll()
        {
            return puntos;
        }

        public List<PuntoCarga> GetAll(int tipo)
        {
            return puntos.FindAll(p => p.Tipo == tipo);
        }
    }
}
