<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Carrito.aspx.cs" Inherits="WebForm.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Carrito de Compras</title>
   <!-- <link href="Estilos_Carrito.css" rel="stylesheet" /> -->
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css" integrity="sha384-JcKb8q3iqJ61gNV9KGb8thSsNjpSL0n8PARn9HuZOnIxN0hoP+VmmDGMN5t9UJ0Z" crossorigin="anonymous">
    <script src="https://kit.fontawesome.com/d749d06842.js" crossorigin="anonymous"></script>

</head>

<body> 
    <style> 
        table{
            margin-top: 80px;
            margin-left:auto;
            margin-right:auto;
            border-collapse:collapse;
        }
        .clase-tabla{
            padding-left:80px;
            padding-right:80px;
            padding-top:10px;
            padding-bottom:10px;
        }
    </style>
    <!--Boton de seguir comprando -->
    <div>
        <ul>
            <li class="navbar nav-item"><a class="btn btn-primary" href="Catalogo.aspx"><i class="fas fa-backward"></i>    Seguir comprando</a></li>
        </ul>
    </div>

    <!-- Grilla para mostar articulos que se agregaron al carrito -->
    <form id="form1" runat="server">
        <div id="main-container">
            <table> 
                <tr class="clase-tabla">
                    <th class="clase-tabla"><asp:Label Text="text" runat="server" ID="lblNombreArticulo" /> <br />
                    <h6 style="color:green">Envio Gratis</h6></th>
                    <th class="clase-tabla"><a class="btn btn-primary rounded" style="width:20px;height:25px;padding-right:25px;padding-left:10px;padding-bottom:25px;"><i class="fas fa-plus-circle"></i></a><asp:Label style="padding-left:10px;" Text="1" runat="server" ID="lblCantidad"/></th>
                    <th class="clase-tabla"><asp:Label Text="text" runat="server" ID="lblPrecioArticulo"/></th>
                    <!-- <th><a class="btn btn-link" href="Catalogo.aspx"><i class="fas fa-cart-arrow-down">     Comprar</i> </a></th> -->
                    <th class="clase-tabla"><a class="btn btn-link" href="Catalogo.aspx" ><i class="fas fa-trash-alt" style="color:red;"></i></a></th>
                </tr>
            </table>
        </div>
    </form>
    
</body>

</html>
