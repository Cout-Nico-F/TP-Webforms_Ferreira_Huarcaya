<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Catalogo.aspx.cs" Inherits="WebForm.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Placeholder with style</h1>
        <p>Aca se va a ver algo y va a estar bueno</p>
    </div>
   <div class="Container">
        <div class="row justify -content-center">
            <div class="col md-4">
                <div class="card" style ="width:18rem;">
                    <img class="card-img-top" src="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/006.png" alt="Alternate Text" /> 
                    <div class="cards-body">
                        <h5 class="card-title">Charizard</h5>
                        <p class="card-text"> Hola, soy de fuego</p>
                    </div>
                </div>
           </div>
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

