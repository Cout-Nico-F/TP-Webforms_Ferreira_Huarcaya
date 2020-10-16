<%@ Page Title="" Language="C#" MasterPageFile="~/B.Master" AutoEventWireup="true" CodeBehind="Catalogo.aspx.cs" Inherits="WebForm.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <!-- Buscador -->
   <!-- No pude hacer que funcione por ahora-->
     <!-- <div id="ctn-bars-search">
                    <input type="text" id="inputSearch" placeholder="¿Que deseas buscar?"/>
                </div>
                <ul id="box-search">
                    <li><a href="#"> <i class="fas fa-search"></i>SONY</a></li>
                    <li><a href="#"> <i class="fas fa-search"></i>SAMSUNG</a></li>
                    <li><a href="#"> <i class="fas fa-search"></i>MOTOROLA</a></li>
                    <li><a href="#"> <i class="fas fa-search"></i>PLAYSTATION 5</a></li>
                </ul>
    <div id="cover-ctn-search"></div> -->
     <style>
       
    </style>
    <div id="contador"> 
     <% Random rnd = new Random();
    int num = rnd.Next(50,200);%>
    <h6><i class="fas fa-eye"></i><%=num %></h6>
     </div>                  
                
    <div id="carouselExampleFade" class="carousel slide" data-ride="carousel">
        <div class="carousel-inner">
            <div class="carousel-item active">
                <img src="https://www.soydemac.com/wp-content/uploads/2019/07/Suscripci%C3%B3n_Apple_Music_1_mes.jpg" class="d-block w-30 imagenes_carousel" alt="Apple" id="imagen-apple" >
            </div>
            <div class="carousel-item">
                <img src="https://picodotdev.github.io/blog-bitix/2019/06/sobre-la-playstation-4-playstation-5-y-google-stadia/images/ps4_hud09ad69cbefaa90df21dc76903e1fa77_76515_1040x0_resize_q90_box.jpg" class="d-block w-30 imagenes_carousel" alt="Image that refers to the power of the PS5 " id="imagen-ps5">
            </div>
             <div class="carousel-item">
                <img src="https://www.rugbiers.cl/wp-content/uploads/2017/09/Banner-Sony-Xperia-1200x180.jpg" class="d-block w-30 imagenes_carousel" id="imagen-sony" alt="Sony Make believe"  >
            </div> 
            <div class="carousel-item"> 
                <img src="https://img.global.news.samsung.com/co/wp-content/uploads/2019/02/Regional_Galaxy_Banner2_704x160.jpg" class="d-block w-30 imagenes_carousel"alt="samsung" id="imagen-samsung" />
            </div>
        </div>
        <a class="carousel-control-prev" href="#carouselExampleFade" role="button" data-slide="prev">
            <span class="carousel-control-prev-icon" aria-hidden="true"></span>
            <span class="sr-only">Previous</span>
        </a>
        <a class="carousel-control-next" href="#carouselExampleFade" role="button" data-slide="next">
            <span class="carousel-control-next-icon" aria-hidden="true"></span>
            <span class="sr-only">Next</span>
        </a>
    </div>
    <hr />
    <hr />
    <div class="row">
        <%foreach (Modelo.Articulo item in lista)
            { %>
        <div class="col-xs-12 col-sm-4 col-md-3" style="margin-bottom: 1vw;">
            <div class="card text-center h-100 textoDiv" >
                <div class="card-body d-flex flex-column">
                    <%if ((string)item.ImagenUrl == "")
                        {%>
                        <img class="mt-auto card-img-top" src="<%=item.ImagenUrl%>" alt="No contiene una url" style="max-height: 8vw; max-width: 8vw; margin: 3vw;" />
                    <%} %>
                    <%else{%>
                         <img class="mt-auto card-img-top zoom imagen_transparente" src="<%=item.ImagenUrl%>" alt="No contiene una url" style="max-height: 8vw; max-width: 8vw; margin: 3vw;" />
                    <% }%>
                    <h4 class="card-title"><%= item.Nombre %> <span class="badge badge-secondary">Nuevo</span></h4>
                    <p class="card-text"><%= item.Marca %></p>
                    <p class="card-text">( <%= item.Descripcion %> )</p>
                    <p class="card-text">$<%= item.Precio %></p>
                    <!--debugger <p class="card-text"><%= item.Id %></p> -->
                    <a class="btn btn-primary btn-sm" href="Carrito.aspx?idArticulo=<%=item.Id %>" role="button"><i class="material-icons">shopping_cart</i> Agregar al carrito</a>
                    <br />
                    <a  class="btn btn-primary btn-sm" href="Detalles.aspx?idArticulo=<%= item.Id %>" role="button"><i class="material-icons">remove_red_eye</i> detalles</a>
            
                </div>
            </div>
        </div>
        <% } %>
    </div>
    <hr />
        <div class="container-fluid" id="footer">
            <div class="row" >
                <div id="posicion-tarjeta"> 
                <div id="tarjeta" >
                    <p>
                        <i class="far fa-credit-card"></i>
                    </p>
                    <h3>Pagá con tarjeta o en efectivo</h3>
                    <h6 >
                        Tenés cuotas sin interés con tarjeta o efectivo en puntos de pago. ¡Y siempre es seguro!
                    </h6>
                </div>
                    </div>
                <div id="posicion-travel"> 
                <div id="envio">
                    <p>
                        <i class="fas fa-route"></i>
                    </p>
                    <h3>Envío gratis</h3>
                    <h6>Tenés envios gratis en miles de productos</h6>
                </div>
                    </div>
                <div id="posicion-seguridad"> 
                <div id="seguridad">
                    <p>
                        <i class="fas fa-shield-alt"></i>
                    </p>
                    <h3>Seguridad, de principio a fin</h3>
                    <h6>No te gustá? Devolvelo sin problemas,siempre estas protegido</h6>
                </div>
              </div>
            </div>
        </div>
    <hr />
    <div id="pie-footer">
        <div class="container">
            <div class="row">
                <div class="col-md-12">
                    <p id="titulo-footer">
                        Copyright @2020 All rights reserved for Nicolas Ferreira and Alonso Huarcaya
                    </p>
                </div>
            </div>
        </div>
    </div>
    <br />
    <!--
    <footer style="background-color:transparent">
    <div class="container">
        <div class="info-slide" style="background-color:white;padding-left:0px;padding-right:">
            <div class="img-container">
                <i class="material-icons" style="background-color:white;">payment</i>
                <h1 style="text-align:left; background-color:white">Pagá con tarjeta o en efectivo</h1>
                <p style="text-align:left; background-color:white">tenés cuotas sin interés con tarjeta o efectivo en puntos de pago. ¡Y siempre es seguro!</p>
            </div>
        </div>
        <div class="info-slide" style="background-color:white">
            <div class="img-container">
                <i class="material-icons" style="background-color:white;">card_travel</i>
                <h1 style="text-align:center; background-color:white">Envío gratis</h1>
                <p style="text-align:center; background-color:white">Tenés envios gratis en miles de productos</p>
            </div>
        </div>
        <div class="info-slide" style="background-color:white">
            <div class="img-container">
                <i class="material-icons" style="background-color:white;">security</i>
                <h1 style="text-align:right; background-color:white">Seguridad, de principio a fin</h1>
                <p style="text-align:right; background-color:white">No te gustá? Devolvelo sin problemas,siempre estas protegido</p>
            </div>
        </div>
    </div>
    </footer> -->
</asp:Content>

