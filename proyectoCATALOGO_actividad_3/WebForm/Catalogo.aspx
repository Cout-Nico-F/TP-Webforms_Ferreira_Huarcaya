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
    
    <div id="carouselExampleFade" class="carousel slide" data-ride="carousel">
        <div class="carousel-inner">
            <div class="carousel-item active">
                <img src="https://images.samsung.com/is/image/samsung/p5/latin/tvs/qled-tv/highlights/2020-qled-tv-f00-highlights-kv-mo-v23.jpg?$ORIGIN_JPG$" class="d-block w-30 imagenes_carousel" alt="Samsung QLED 8K" style="height:600px;" >
            </div>
            <div class="carousel-item">
                <img src="https://media.playstation.com/is/image/SCEA/playstation-5-immersion-campaign-homepage-marquee-desktop-02-ps5-19aug20-en-us?$native_xl_nt$" class="d-block w-30 imagenes_carousel" alt="Image that refers to the power of the PS5 "style="height:600px;">
            </div>
             <div class="carousel-item">
                <img src="https://media.playstation.com/is/image/SCEA/crash-bandicoot-4-its-about-time-launch-homepage-marquee-desktop-01-ps4-02oct20-en-us?$native_xxl_t$" class="d-block w-30 imagenes_carousel" alt="Crash Bandicoot" style="margin: auto; height:600px;" >
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
                    <a class="btn btn-primary btn-sm" href="Detalles.aspx?idArticulo=<%= item.Id %>" role="button"><i class="material-icons">remove_red_eye</i> detalles</a>
                </div>
            </div>
        </div>
        <% } %>
    </div>
    <style>
        #footer{
            background-color:transparent;
            width:200px;
            height:auto;
            color:white;
        }
        #pie-footer{
            background-color:black;
            width:100px;
            height:auto;
        }
        #titulo-footer{
            color:white;
            text-align:center;
            top:10px;
        }
        #tarjeta{
            font-size:40px;
            margin-top:0px;
            font-weight:800;
            color:white;
            text-align:center;
        }
        #envio{
            font-size:40px;
            margin-top:0px;
            font-weight:800;
            color:white;
            text-align:center;
        }
        #seguridad{
            font-size:40px;
            margin-top:0px;
            font-weight:800;
            color:white;
            text-align:center;
        }
    </style>
       
    <hr />
    <div>
        <div class="container-fluid" id="footer">
            <div class="row">
                <div class="col-4" id="tarjeta" >
                    <p >
                        <i class="far fa-credit-card"></i>
                    </p>
                    <h3>Pagá con tarjeta o en efectivo</h3>
                    <h6 >
                        Tenés cuotas sin interés con tarjeta o efectivo en puntos de pago. ¡Y siempre es seguro!
                    </h6>
                </div>
                <div class="col-4" id="envio">
                    <p>
                        <i class="fas fa-route"></i>
                    </p>
                    <h3>Envío gratis</h3>
                    <h6>Tenés envios gratis en miles de productos</h6>
                </div>
                <div class="col-4" id="seguridad">
                    <p>
                        <i class="fas fa-shield-alt"></i>
                    </p>
                    <h3>Seguridad, de principio a fin</h3>
                    <h6>No te gustá? Devolvelo sin problemas,siempre estas protegido</h6>
                </div>
            </div>
        </div>
    </div>
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

