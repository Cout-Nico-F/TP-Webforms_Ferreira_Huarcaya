using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Modelo;
using Negocios;

namespace WebForm
{
    public partial class WebForm2 : System.Web.UI.Page

    {
        public List<Articulo> listaArticulo { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            ArticulosNegocio negocio = new ArticulosNegocio();
            try
            {
                listaArticulo = negocio.ListarArticulos();
            }
            catch (Exception ex)
            {
                Session.Add("ErrorEncontrado",ex.ToString());
                Response.Redirect("Error.aspx");
            }
        }
    }
}