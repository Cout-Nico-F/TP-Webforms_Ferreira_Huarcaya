<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Catalogo.aspx.cs" Inherits="WebForm.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Placeholder with style</h1>
        <p>Aca se va a ver algo y va a estar bueno</p>
    </div>
                <div class="card text-center" style ="width:20rem;">
                    <img class="card-img-top" src="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/006.png" alt="Alternate Text" /> 
                    <div class="cards-body">
                        <h5 class="card-title">Charizard</h5>
                        <p class="card-text"> Hola, soy de fuego</p>
                    </div>
                </div>
    <div class="card text-center" style="width: 26rem; border: dashed; border-color: brown ; padding-bottom: 2rem; background-color: antiquewhite">
  <div class="card-body">
      <img class="card-img-top" src="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/006.png" alt="Alternate Text" /> 
    <h5 class="card-title">Charizard</h5>
    <p class="card-text">Hola, soy de fuego</p>
    <a href="Default.aspx" class="btn btn-primary">Buy!</a>
  </div>
</div>
    

 <!-- Codigo Alternativo -->

 <!-- De las 2 maneras funciona pero no tienen estilo (deberia tenerlo) -->
 <!-- <asp:Image Id ="Samsung" ImageUrl="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/006.png" runat="server" /> -->
<!-- <img src="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/006.png" alt="Alternate Text" /> -->

    <!-- Codigo que entraria en un hipotetica pagina mas minimalista donde se vea la informacion 
        mas simple 
    <div>
        <asp:GridView ID = "dgv_ListaWeb" runat="server"></asp:GridView> 
    </div> -->

</asp:Content>

