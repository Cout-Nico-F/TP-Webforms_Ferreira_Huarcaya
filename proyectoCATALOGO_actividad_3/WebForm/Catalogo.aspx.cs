using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocios;
using Modelo;

namespace WebForm
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public List<Articulo> lista { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            ArticulosNegocio artNeg = new ArticulosNegocio();
            try
            {
                lista = artNeg.ListarArticulos();
                Session.Add("listadoArticulos",lista);
            }
            catch (Exception ex)
            {

                Session.Add("ErrorEncontrado", ex.ToString());
                Response.Redirect("Error.aspx");
            }
           

        }
        
    }
}