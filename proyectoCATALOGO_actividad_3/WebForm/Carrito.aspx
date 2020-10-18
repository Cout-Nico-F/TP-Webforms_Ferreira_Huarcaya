<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Carrito.aspx.cs" Inherits="WebForm.WebForm2"%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Carrito de Compras</title>
    <!-- <link href="Estilos_Carrito.css" rel="stylesheet" /> -->
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css" integrity="sha384-JcKb8q3iqJ61gNV9KGb8thSsNjpSL0n8PARn9HuZOnIxN0hoP+VmmDGMN5t9UJ0Z" crossorigin="anonymous"/>
    <script src="https://kit.fontawesome.com/d749d06842.js" crossorigin="anonymous"></script>

</head>
<body style= " background-image: url(https://www.solofondos.com/wp-content/uploads/2015/11/21omxpw.jpg); background-attachment: fixed; background-position: center;">
    <!--Boton de seguir comprando -->
    <div>
        <ul>
            <li class="navbar nav-item"><a class="btn btn-primary" href="Catalogo.aspx"><i class="fas fa-backward"></i>Seguir comprando</a></li>
        </ul>
        <ul>
            <li>
                <asp:Label ID="lbl_Fecha" Text="" runat="server" /></li>
          </ul>
    </div>

            <div class="jumbotron w-75" style="margin-left: 9%">
            <h3 style="font-family:Verdana">Subtotal : $<asp:Label ID="lbl_Subtotal" Text="" runat="server" /></h3>
            <h3 style="font-family:Verdana">Precio Total + IVA (19%) : $<asp:Label ID="lbl_Total" Text="" runat="server" /></h3>
        </div>


    <% foreach (var item in listaCarrito)//aca recorremos la lista y dibujamos 1 jumbotron por cada item agregado al carro.
        {
            if (item != null)
            {%>
            <div class="container d-flex flex">   
            <div class="jumbotron w-50">
            <h3><%=item.Nombre %>, <%=item.Marca %></h3>
            <p class="lead">$<%=item.Precio %></p>
            <p class="lead">Cantidad : 1</p> <!-- Todavia no suma las cantidades pero lo va a hacer -->

            <hr class="my-2" />
            <hr />
            <a class="btn btn-primary btn-lg" href="Carrito.aspx?idArticulo_Borrar=<%= item.Id %>" role="button">Quitar</a> <% //este boton va a encargarse de borrar el item buscandolo por id en la lista de items y sacandolo de la lista en session %>
            </div>
            </div>
            <%}
                else
                {%>
                <div class="jumbotron">
                <p>No tenes ningun articulo en tu carrito? Ahora es buen momento para elegir tu proxima compra!</p>
                </div>
              <%}%>
            
            <%}%>
        <br />
</body>

</html>
