<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Catalogo.aspx.cs" Inherits="WebForm.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div id="carouselExampleFade" class="carousel slide" data-ride="carousel">
        <div class="carousel-inner">
            <div class="carousel-item active">
                <img src="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/150.png" class="d-block w-30" alt="..." style="margin: auto;">
            </div>
            <div class="carousel-item">
                <img src="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/149.png" class="d-block w-30" alt="..." style="margin: auto;">
            </div>
            <div class="carousel-item">
                <img src="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/148.png" class="d-block w-30" alt="..." style="margin: auto;">
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

    <div class="row">
        <%foreach (Modelo.Articulo item in lista)
            { %>
        <div class="col-xs-12 col-sm-4 col-md-3" style="margin-bottom: 1vw;">
            <div class="card text-center h-100" style="width: 26rem; border: dashed; border-color: brown; padding-bottom: 1rem; background-color: antiquewhite;">
                <div class="card-body d-flex flex-column">
                    <img class="mt-auto card-img-top" src="<%=item.ImagenUrl%>" alt="Alternate Text" style="max-height: 8vw; max-width: 8vw; margin: 3vw;" />
                    <h4 class="card-title"><%= item.Nombre %> <span class="badge badge-secondary">Nuevo</span></h4>
                    <p class="card-text"><%= item.Marca %></p>
                    <p class="card-text">( <%= item.Descripcion %> )</p>
                    <p class="card-text">$<%= item.Precio %></p>
                    <a href="Default.aspx" class="mt-auto btn btn-primary">Quiero uno!</a>
                </div>
            </div>
        </div>
        <% } %>
    </div>

</asp:Content>

