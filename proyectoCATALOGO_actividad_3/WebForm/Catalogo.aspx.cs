using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocios;

namespace WebForm
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //cargar();
        }
        /*private void cargar() 
            //Sirve para actualizar cosa que no se si se puede hacer en tiempo real 
            //Tendria que probarlo
        {
            ArticulosNegocio negocio = new ArticulosNegocio();
            dgv_ListaWeb.DataSource = negocio.ListarArticulos();
            dgv_ListaWeb.DataBind();
            dgv_ListaWeb.Columns[3].Visible = false;
        }*/
    }
}