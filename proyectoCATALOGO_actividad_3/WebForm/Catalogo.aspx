<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Catalogo.aspx.cs" Inherits="WebForm.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Lista de Articulos</h1>
        <p>Aca se va a ver algo y va a estar bueno</p>
    </div>

    <div class="row">
        <%foreach (Modelo.Articulo item in lista)
            { %>
                <div class="col-md-4">
                    <div class="card text-center" style="width: 26rem; border: dashed; border-color: brown; padding-bottom: 2rem; background-color: antiquewhite">
                    <div class="card-body">
                    <img class="card-img-top" src="<%=item.ImagenUrl%>" alt="Alternate Text" style="max-height: 8vw; max-width: 8vw; margin: 2vw;"/>
                    <h4 class="card-title"><%= item.Nombre %> <span class="badge badge-secondary">Nuevo</span></h4>
                    <p class="card-text"><%= item.Marca %></p>
                    <p class="card-text">( <%= item.Descripcion %> )</p>
                    <p class="card-text">$<%= item.Precio %></p>
                    <a href="Default.aspx" class="btn btn-primary">Quiero uno!</a>
                    </div>
                </div>
        </div>

        <% } %>
    </div>




    <!-- Codigo Alternativo -->

    <!-- Se usa para etiquetar como nuevo en este caso un articulo podriamos usarlo 
        <span class ="badge badge-secondary">Nuevo</span -- >

    <!-- De las 2 maneras funciona pero no tienen estilo (deberia tenerlo) -->
    <!-- <asp:Image Id ="Samsung" ImageUrl="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/006.png" runat="server" /> -->
    <!-- <img src="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/006.png" alt="Alternate Text" /> -->

    <!-- Codigo que entraria en un hipotetica pagina mas minimalista donde se vea la informacion 
        mas simple 
    <div>
        <asp:GridView ID = "dgv_ListaWeb" runat="server"></asp:GridView> 
    </div> -->

    <!-- Esto es una carrusel por ahora no esta funcionando -->
    <!-- <div id="carouselExampleIndicators" class="carousel slide" data-ride="carousel">
  <ol class="carousel-indicators">
    <li data-target="#carouselExampleIndicators" data-slide-to="0" class="active"></li>
    <li data-target="#carouselExampleIndicators" data-slide-to="1"></li>
    <li data-target="#carouselExampleIndicators" data-slide-to="2"></li>
  </ol>
  <div class="carousel-inner">
    <div class="carousel-item active">
      <img src="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/382.png" class="d-block w-100" alt="Kyogre">
    </div>
    <div class="carousel-item">
      <img src="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/383.png" class="d-block w-100" alt="Groudon">
    </div>
    <div class="carousel-item">
      <img src="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/384.png" class="d-block w-100" alt="Rayquaza">
    </div>
  </div>
  <a class="carousel-control-prev" href="#carouselExampleIndicators" role="button" data-slide="prev">
    <span class="carousel-control-prev-icon" aria-hidden="true"></span>
    <span class="sr-only">Previous</span>
  </a>
  <a class="carousel-control-next" href="#carouselExampleIndicators" role="button" data-slide="next">
    <span class="carousel-control-next-icon" aria-hidden="true"></span>
    <span class="sr-only">Next</span>
 </a>
</div> -->

</asp:Content>

