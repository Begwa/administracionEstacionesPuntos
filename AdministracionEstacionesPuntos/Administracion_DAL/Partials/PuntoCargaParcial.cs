using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administracion_DAL
{
    public partial class PuntoCarga
    {
        public String TipoTxt
        {
            get
            {
                String texto = "";
                switch (Tipo)
                {
                    case 1: texto = "MedidorTrafico";
                        break;
                    case 2: texto = "MedidorConsumo";
                        break;
                }
                return texto;
            }
        }
    }
}
