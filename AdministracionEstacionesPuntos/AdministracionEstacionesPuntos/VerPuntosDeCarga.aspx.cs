using Administracion_DAL;
using Administracion_DAL.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AdministracionEstacionesPuntos
{
    public partial class VerPuntosDeCarga : System.Web.UI.Page
    {
        PuntosCargaDAL puntosCargaDAL = new PuntosCargaDAL();


        private void CargarTabla(List<PuntoCarga> puntos)
        {
            puntosGrid.DataSource = puntos;
            puntosGrid.DataBind();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                CargarTabla(puntosCargaDAL.GetAll());
            }
        }
    }
}