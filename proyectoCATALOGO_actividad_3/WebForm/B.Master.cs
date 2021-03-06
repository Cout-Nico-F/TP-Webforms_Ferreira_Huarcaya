﻿using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace WebForm
{
    public partial class B : System.Web.UI.MasterPage
    {
        public List<Modelo.Articulo> listaCarrito = null;
        public string debuger;
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

            listaCarrito = (List<Modelo.Articulo>)Session["listaCarrito"];
            debuger = listaCarrito.Count().ToString();
        }

        protected void bnt_Iniciar_Click(object sender, EventArgs e)
        {
       
        }
    }
}