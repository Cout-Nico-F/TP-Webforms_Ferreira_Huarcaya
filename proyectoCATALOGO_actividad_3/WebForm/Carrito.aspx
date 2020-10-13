<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Carrito.aspx.cs" Inherits="WebForm.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Carrito de Compras</title>
    <link href="Estilos_Carrito.css" rel="stylesheet" />
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css" integrity="sha384-JcKb8q3iqJ61gNV9KGb8thSsNjpSL0n8PARn9HuZOnIxN0hoP+VmmDGMN5t9UJ0Z" crossorigin="anonymous">
    <script src="https://kit.fontawesome.com/d749d06842.js" crossorigin="anonymous"></script>

</head>

<body> 
    <!--Boton de seguir comprando -->
    <div>
        <ul>
            <li class="navbar nav-item"><a class="btn btn-primary" href="Catalogo.aspx"><i class="fas fa-backward"></i>    Seguir comprando</a></li>
        </ul>
    </div>

    <!-- Grilla para mostar articulos que se agregaron al carrito -->
    <form id="form1" runat="server">
        <div id="main-container">
            <hr />
            <table> 
                <tr>
                    <th>Articulo</th>
                    <th>Cantidad</th>
                    <th>Precio</th>
                </tr>
            </table>
            <hr/>
        </div>
    </form>
    
</body>

</html>
