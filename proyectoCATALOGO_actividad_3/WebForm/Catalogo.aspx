<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Catalogo.aspx.cs" Inherits="WebForm.WebForm1" %>

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
                    <a class="btn btn-primary btn-sm" href="Carrito.aspx?idArticulo= <%=item.Id %>" role="button"><i class="material-icons">shopping_cart</i> Agregar al carrito</a>
                    <br />
                    <a class="btn btn-primary btn-sm" href="Detalles.aspx?idArticulo=<%= item.Id %>" role="button"><i class="material-icons">remove_red_eye</i> detalles</a>
                </div>
            </div>
        </div>
        <% } %>
    </div>

       <div id="carouselExampleFade" class="carousel slide" data-ride="carousel">
        <div class="carousel-inner">
            <div class="carousel-item active">
                <img src="https://images.samsung.com/is/image/samsung/p5/latin/tvs/qled-tv/highlights/2020-qled-tv-f00-highlights-kv-mo-v23.jpg?$ORIGIN_JPG$" class="d-block w-30 imagenes_carousel" alt="..." >
            </div>
            <div class="carousel-item">
                <img src="https://media.playstation.com/is/image/SCEA/playstation-5-immersion-campaign-homepage-marquee-desktop-02-ps5-19aug20-en-us?$native_xl_nt$" class="d-block w-30 imagenes_carousel" alt="Image that refers to the power of the PS5 ">
            </div>
             <div class="carousel-item">
                <img src="https://media.playstation.com/is/image/SCEA/crash-bandicoot-4-its-about-time-launch-homepage-marquee-desktop-01-ps4-02oct20-en-us?$native_xxl_t$" class="d-block w-30 imagenes_carousel" alt="Crash Bandicoot" style="margin: auto;">
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
    <footer style="background-color:white">
    <div class="container">
        <div class="info-slide">
            <div class="img-container">
                <i class="material-icons" style="background-color:white;">payment</i>
                <h1 style="text-align:left; background-color:white">Pagá con tarjeta o en efectivo</h1>
                <p style="text-align:left; background-color:white">tenés cuotas sin interés con tarjeta o efectivo en puntos de pago. ¡Y siempre es seguro!</p>
            </div>
        </div>
        <div class="info-slide">
            <div class="img-container">
                <i class="material-icons" style="background-color:white;">card_travel</i>
                <h1 style="text-align:center; background-color:white">Envío gratis</h1>
                <p style="text-align:center; background-color:white">Tenés envios gratis en miles de productos</p>
            </div>
        </div>
        <div class="info-slide">
            <div class="img-container">
                <i class="material-icons" style="background-color:white;">security</i>
                <h1 style="text-align:right; background-color:white">Seguridad, de principio a fin</h1>
                <p style="text-align:right; background-color:white">No te gustá? Devolvelo sin problemas,siempre estas protegido</p>
            </div>
        </div>
    </div>
    </footer>

</asp:Content>

