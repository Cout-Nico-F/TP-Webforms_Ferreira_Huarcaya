<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Detalles.aspx.cs" Inherits="WebForm.Detalles" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title> Detalles <%= articuloDetalle.Nombre %> </title>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css" integrity="sha384-JcKb8q3iqJ61gNV9KGb8thSsNjpSL0n8PARn9HuZOnIxN0hoP+VmmDGMN5t9UJ0Z" crossorigin="anonymous"/>
    <link rel="stylesheet" href="https://fonts.googleapis.com/icon?family=Material+Icons">

</head>
<body>
       
<div class="container col-md-4">
  <h1 class="my-4"><%=articuloDetalle.Nombre %> 
    <small><%=articuloDetalle.Marca %></small>
  </h1>
  <div class="row">
    <div class="col-md-10">
      <img class="img-thumbnail" src="<%=articuloDetalle.ImagenUrl%>" alt=""/>
    </div>
    <div class="col-md-4">
      <h3 class="my-3">Descripcion:</h3>
      <p><%=articuloDetalle.Descripcion%></p>
      <h3 class="my-3">$<%=articuloDetalle.Precio%></h3>
    </div>
  </div>

    <a class="btn btn-primary btn-sm" href="Default.aspx" role="button"><i class="material-icons">shopping_cart</i> Agregar al carrito</a>
    <br />
    <a href="Catalogo.aspx" style="font-style:italic">Volver al catalogo</a>
    <br />
    <br />
    <% /* Esto es para poner aca la imagen de otro articulo con un link hacia su descripcion. lo dejo comentado por si nos animamos a hacerlo DESPUES de los objetivos principales
  <h3 class="my-4">Related Projects</h3>

  <div class="row">

    <div class="col-md-3 col-sm-6 mb-4">
      <a href="#">
            <img class="img-fluid" src="http://placehold.it/500x300" alt="">
          </a>
    </div>

    <div class="col-md-3 col-sm-6 mb-4">
      <a href="#">
            <img class="img-fluid" src="http://placehold.it/500x300" alt="">
          </a>
    </div>

    <div class="col-md-3 col-sm-6 mb-4">
      <a href="#">
            <img class="img-fluid" src="http://placehold.it/500x300" alt="">
          </a>
    </div>

    <div class="col-md-3 col-sm-6 mb-4">
      <a href="#">
            <img class="img-fluid" src="http://placehold.it/500x300" alt="">
          </a>
    </div>
     
  </div>
     */%>
</div>

</body>
</html>
