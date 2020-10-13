using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.Ajax.Utilities;
using Modelo;
using Negocios;

namespace WebForm
{
    public partial class WebForm2 : System.Web.UI.Page

    {
        public int idArticulos;
        public List<Articulo> listaArticulo { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            idArticulos = Convert.ToInt32(Request.QueryString["idArticulo"]);
            idArticulos = BuscarIdArticulos(listaArticulo,idArticulos);
            if(idArticulos == -1)
            {
                Response.Redirect("Error.aspx"); //no esta bien hecho no se me ocurre una manera 
            }
            try
            {
                Articulo seleccion = ((List<Articulo>)Session["listadoArticulos"])[idArticulos]; //Del listado quiero el primero
                lblNombreArticulo.Text = seleccion.Nombre;
                lblPrecioArticulo.Text = seleccion.Precio.ToString();
            }
            catch (Exception ex)
            {

                Session.Add("ErrorEncontrado", ex.ToString());
                Response.Redirect("Error.aspx");
            }
            
           
        }
        private int BuscarIdArticulos(List<Articulo> lista,int id)
        {
            foreach(Articulo item in lista)
            {
                if (item.Id == id)
                {
                    id = item.Id;
                    return id;
                }
                
            }
            return -1;
        }
        
    }
}