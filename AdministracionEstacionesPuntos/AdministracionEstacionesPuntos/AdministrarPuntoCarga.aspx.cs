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
    public partial class AdministrarPuntoCarga : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<PuntoCarga> puntos = new PuntosCargaDAL().GetAll();
                tipoDdl.DataSource = puntos;
                tipoDdl.DataTextField = "Tipo";
                tipoDdl.DataBind();
            }
        }

        protected void IngresarBtn_Click(object sender, EventArgs e)
        {

        }
    }
}