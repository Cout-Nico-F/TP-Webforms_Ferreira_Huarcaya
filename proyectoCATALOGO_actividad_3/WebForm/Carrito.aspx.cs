using Modelo;
using Negocios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.Ajax.Utilities;
using Negocios;


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
            negocio = new ArticulosNegocio();
            idArticulo = Convert.ToInt32(Request.QueryString["idArticulo"]);
            listaArticulos = negocio.ListarArticulos();

            articuloCarrito = Buscar(listaArticulos, idArticulo);

            //cargar la lista de articulosCarrito desde la session amenos que sea null, entonces creamos la lista vacia.
            if (Session["listaCarrito"] == null)
            {
                listaCarrito = new List<Articulo>();
                Session.Add("listaCarrito", listaCarrito);
            }
            else listaCarrito = (List<Articulo>)Session["listaCarrito"];

            listaCarrito.Add(articuloCarrito);
            //guardar la lista de articulosCarrito a la session nuevamente
            Session["listaCarrito"] = listaCarrito;


            //por que me guarda nulls en la lista ademas de los articulos agregados ?
            





            //if (Session["listadoArticulos"] != null) //para ver si contiene algo
            //{
            //    try
            //    {
            //        Articulo seleccion = ((List<Articulo>)Session["listadoArticulos"])[4]; //Del listado quiero el primero
            //        lblNombreArticulo.Text = seleccion.Nombre;
            //        lblPrecioArticulo.Text = seleccion.Precio.ToString();
            //    }
            //    catch (Exception ex)
            //    {
            //        Session.Add("ErrorEncontrado", ex.ToString());
            //        Response.Redirect("Error.aspx");
            //    }
            //}
        }

        //por ahora duplico esto. Sin embargo lo mas adecuado seria reutilizar un mismo metodo mas general ( tal vez en articuloNegocio? )

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
        public void Quitar()
        {
            negocio = new ArticulosNegocio();
            idArticulo = Convert.ToInt32(Request.QueryString["idArticulo"]);
            listaArticulos = negocio.ListarArticulos();

            articuloCarrito = Buscar(listaArticulos, idArticulo);

            //cargar la lista de articulosCarrito desde la session amenos que sea null, entonces creamos la lista vacia.
            if (Session["listaCarrito"] == null)
            {
                listaCarrito = new List<Articulo>();
                Session.Remove("listaCarrito");
            }
            else listaCarrito = (List<Articulo>)Session["listaCarrito"];

            listaCarrito.Remove(articuloCarrito);
            //guardar la lista de articulosCarrito a la session nuevamente
            Session["listaCarrito"] = listaCarrito;
        }
    }

}