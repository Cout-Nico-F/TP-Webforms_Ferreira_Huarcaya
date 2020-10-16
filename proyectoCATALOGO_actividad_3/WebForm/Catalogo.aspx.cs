using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocios;
using Modelo;
using System.Configuration;
using Microsoft.Ajax.Utilities;

namespace WebForm
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public List<Articulo> lista { get; set; }
        public Articulo Buscar { get; set; }

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

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            ArticulosNegocio negocio = new ArticulosNegocio();
            List<Articulo> listaBuscar;
            int art;
            try
            {
                listaBuscar = negocio.ListarArticulos();
                art = Convert.ToInt32(txt_Busqueda.Text);
                Console.WriteLine(art);
                Buscar = listaBuscar.Find(x => x.Nombre.ToUpper().Contains(txt_Busqueda.Text.ToUpper()) || x.Marca.Descripcion.Contains(txt_Busqueda.Text.ToUpper()));
                Session.Add("listadoArticulos",Buscar);
                Response.Redirect("Catalogo.aspx?idArticulo=" + Buscar);

            }
            catch (Exception ex)
            {

                Response.Redirect("Error.aspx");
            }
        }
    }
}