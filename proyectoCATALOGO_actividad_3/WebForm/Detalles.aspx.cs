using Modelo;
using Negocios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForm
{
    public partial class Detalles : System.Web.UI.Page
    {
        public int idArticulo;
        ArticulosNegocio negocio = null;
        List<Articulo> listaArticulos = null;
        Articulo articuloDetalle = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            negocio = new ArticulosNegocio();
            idArticulo =Convert.ToInt32( Request.QueryString["itemArticulo"] );
            listaArticulos = negocio.ListarArticulos();

            articuloDetalle = Buscar(listaArticulos,idArticulo);
        }

        private Articulo Buscar(List<Articulo> lista , Int32 id )
        {
            foreach (Articulo item in lista)
            {
                if (item.Id.Equals(id))
                {
                    articuloDetalle = item;
                    return articuloDetalle;
                }
            }
            return articuloDetalle;
        }

    }
}