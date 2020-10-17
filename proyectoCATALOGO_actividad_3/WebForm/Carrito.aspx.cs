using Modelo;
using Negocios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.Ajax.Utilities;

namespace WebForm
{
    public partial class WebForm2 : System.Web.UI.Page

    {
        private int idArticulo;
        private ArticulosNegocio negocio = null;
        private List<Articulo> listaArticulos = null;
        public List<Articulo> listaCarrito = null;
        private Articulo articuloCarrito = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (listaCarrito == null)
            {
                listaCarrito = new List<Articulo>();
            }

            if (Session["listaCarrito"] == null)
            {
                Session.Add("listaCarrito", listaCarrito);
            }

            if (Request.QueryString["idArticulo"] != null)
            {
                AgregarArticulo();
            }
            if (Request.QueryString["idArticulo_Borrar"] != null)
            {
                QuitarArticulo();
            }
            listaCarrito = (List<Articulo>) Session["listaCarrito"];
        }

        public void AgregarArticulo()
        {
            negocio = new ArticulosNegocio();
            idArticulo = Convert.ToInt32(Request.QueryString["idArticulo"]);
            listaArticulos = negocio.ListarArticulos();

            articuloCarrito = Buscar(listaArticulos, idArticulo);

            //cargar la lista de articulosCarrito desde la session amenos que sea null, entonces creamos la lista vacia.
            
            listaCarrito = (List<Articulo>)Session["listaCarrito"];

            listaCarrito.Add(articuloCarrito);
            //guardar la lista de articulosCarrito a la session nuevamente
            Session["listaCarrito"] = listaCarrito;
        }

        public void QuitarArticulo()
        {
            negocio = new ArticulosNegocio();
            idArticulo = Convert.ToInt32(Request.QueryString["idArticulo_Borrar"]);
            listaArticulos = negocio.ListarArticulos();

            articuloCarrito = Buscar(listaArticulos, idArticulo);
            listaCarrito = (List<Articulo>)Session["listaCarrito"];

            listaCarrito.Remove(articuloCarrito); // El problema esta aca. por alguina razon me devuelve null. como si no encontrara el articulo en la lista.

            //guardar la lista de articulosCarrito a la session nuevamente
            Session["listaCarrito"] = listaCarrito;
        }

        /// <summary>
        /// Busca en una lista de articulos dada, el Id ingresado. En ese orden.<para />
        ///<remarks>
        /// Si no la encuentra retorna un Articulo con null;<para />
        /// </remarks>
        /// para crear documentacion podes ver estos link <see href="http://qbit.com.mx/blog/2012/04/24/etiquetas-para-documentar-codigo-en-c-net/"/><para />
        /// <see href="https://docs.microsoft.com/en-us/dotnet/csharp/codedoc"/>
        /// </summary>
        /// <example>
        /// </example>
        /// <param name="listaArticulos"></param>
        /// <param name="idArticulo"></param>
        /// <returns>Class Modelo.Articulo</returns>
        private Articulo Buscar(List<Articulo> lista, Int32 id)
        {
            foreach (Articulo item in lista)
            {
                if (item.Id == id)
                {
                    articuloCarrito = item;
                    return articuloCarrito;
                }
            }
            return articuloCarrito;
        }
    }

}