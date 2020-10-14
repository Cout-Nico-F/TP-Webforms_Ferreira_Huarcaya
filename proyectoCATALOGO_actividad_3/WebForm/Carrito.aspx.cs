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
        public Articulo idArticulos;
        public List<Articulo> listaArticulo { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["listadoArticulos"] != null) //para ver si contiene algo
            {
                try
                {
                    Articulo seleccion = ((List<Articulo>)Session["listadoArticulos"])[4]; //Del listado quiero el primero
                    lblNombreArticulo.Text = seleccion.Nombre;
                    lblPrecioArticulo.Text = seleccion.Precio.ToString();
                }
                catch (Exception ex)
                {

                    Session.Add("ErrorEncontrado", ex.ToString());
                    Response.Redirect("Error.aspx");
                }
            }
            
            
           
        }
        
    }
}