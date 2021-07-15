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
    estacionesDAL estacionesDAL = new estacionesDAL();

    private void CargarTabla(List<EstacionServicio> estaciones)
    {
        estacionesGrid.DataSource = estaciones;
        estacionesGrid.DataBind();
    }

    public partial class VerEstacionServicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarTabla(estacionesDAL.GetAll());
            }
        }
    }
}