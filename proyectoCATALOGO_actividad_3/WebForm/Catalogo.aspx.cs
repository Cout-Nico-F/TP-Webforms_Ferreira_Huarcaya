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
        public List<Articulo> Lista { get; set; }
        public Articulo Buscar { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            ArticulosNegocio artNeg = new ArticulosNegocio();
            try
            {
                if (Session["listaBuscados"] == null)
                {
                    Lista = artNeg.ListarArticulos();
                }
                else
                {
                    Lista = (List<Articulo>)Session["listaBuscados"];
                    Session["listaBuscados"] = null;
                }
                //Session.Add("listadoArticulos", Lista); //esto no se esta usando.
            }
            catch (Exception ex)
            {
                Session.Add("ErrorEncontrado", ex.ToString());
                Response.Redirect("Error.aspx");
            }

        }

        protected void Btn_buscar_Click(object sender, EventArgs e)
        {
            List<Articulo> listaBuscar = new List<Articulo>();
            if (Session["listaBuscados"] == null)
            {
                Session.Add("listaBuscados", listaBuscar);
            }

            listaBuscar = Lista;
            listaBuscar = Lista.FindAll(
                x => x.Categoria.Descripcion.ToUpper().Contains(txt_buscar.Text.ToUpper()) ||
                x.Descripcion.ToUpper().Contains(txt_buscar.Text.ToUpper()) ||
                x.Marca.Descripcion.ToUpper().Contains(txt_buscar.Text.ToUpper()) ||
                x.Nombre.ToUpper().Contains(txt_buscar.Text.ToUpper())
                );
            Session["listaBuscados"] = listaBuscar;
            Response.Redirect("Catalogo.aspx");
        }
    }
}