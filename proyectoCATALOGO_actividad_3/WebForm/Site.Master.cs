using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForm
{
    public partial class SiteMaster : MasterPage
    {
        public List<Modelo.Articulo> articulosEnCarrito = null;
        public string debuger;
        protected void Page_Load(object sender, EventArgs e)
        {
            articulosEnCarrito = (List<Modelo.Articulo>)Session["listaCarrito"];
            debuger = articulosEnCarrito.Count().ToString();
        }
    }
}