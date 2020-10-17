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
        private Articulo articuloCarrito = null;
        public List<Articulo> listaCarrito = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (listaCarrito == null) //si todavia no hay lista, crearla vacia
            {
                listaCarrito = new List<Modelo.Articulo>();
            }

            if (Session["listaCarrito"] == null) //si la session todavia no tiene lista, crearla.
            {
                Session.Add("listaCarrito", listaCarrito);
            }

            if (Request.QueryString["idArticulo"] != null)//llegó un parametro de idARticulo? agregarlo
            {
                AgregarArticulo();
            }

            if (Request.QueryString["idArticulo_Borrar"] != null)//llegó un parametro de idARticulo_Borrar? borrarlo
            {
                QuitarArticulo();
            }
           
            listaCarrito = (List<Articulo>)Session["listaCarrito"];//actualizar la lista desde la session

            decimal suma = 0 ;

            foreach (var item in listaCarrito)// por cada item en la lista, sumar su precio con y sin iva por separado.
            {
                suma += item.Precio;

                lbl_Total.Text += item.Precio * (decimal)1.19;// el 1.19 es por el 19% de interes que se le aplica a productos tecnologicos
            }
            lbl_Subtotal.Text = suma.ToString("N2");
            suma *= (decimal)1.19;
            lbl_Total.Text = suma.ToString("N2");
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
            idArticulo = Convert.ToInt32(Request.QueryString["idArticulo_Borrar"]);

            listaCarrito = (List<Articulo>)Session["listaCarrito"];

            listaCarrito.Remove(listaCarrito.Find(a => idArticulo == a.Id)); //expresion lambda

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