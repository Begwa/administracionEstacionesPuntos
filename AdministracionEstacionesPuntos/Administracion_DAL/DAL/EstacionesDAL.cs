using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administracion_DAL.DAL
{
    public class estacionesDAL
    {
        private static List<EstacionServicio> estaciones = new List<EstacionServicio>()
        {
            new EstacionServicio()
            {
                Nombre="Estacion de Servicio Copec",
                Direccion="Manuel Antonio Matta 2114",
                Codigo=2114,
                CapacidadMaxima=20
            },
            new EstacionServicio()
            {
                Nombre="Estacion de Servicio Agua Santa",
                Direccion="Agua Santa 700, Viña del Mar, Valparaiso",
                Codigo=700,
                CapacidadMaxima=15
            },
            new EstacionServicio()
            {
                Nombre="Estacion de Servicio Eirl",
                Direccion="Errázuriz 1306, Valparaiso",
                Codigo=1306,
                CapacidadMaxima=25
            }
        };

        public void Add(EstacionServicio e)
        {
            estaciones.Add(e);
        }

        public List<EstacionServicio> GetAll()
        {
            return estaciones;
        }

        public void Remove(int codigo)
        {
            EstacionServicio estacion = estaciones.Find(e => e.Codigo == codigo);
            estaciones.Remove(estacion);
        }
    }
}
