<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Detalles.aspx.cs" Inherits="WebForm.Detalles" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css" integrity="sha384-JcKb8q3iqJ61gNV9KGb8thSsNjpSL0n8PARn9HuZOnIxN0hoP+VmmDGMN5t9UJ0Z" crossorigin="anonymous"/>
    <title> DETALLES DE ARTICULOS </title>
</head>
<body>
    <h2>Hola me llamo Detalles</h2>

    <!-- Card -->
<div class="card booking-card">

  <!-- Card image -->
  <div class="view overlay">
    <img class="card-img-top" src="https://mdbootstrap.com/img/Photos/Horizontal/Food/8-col/img (5).jpg" alt="Card image cap">
    <a href="#!">
      <div class="mask rgba-white-slight"></div>
    </a>
  </div>

  <!-- Card content -->
  <div class="card-body">

    <!-- Title -->
    <h4 class="card-title font-weight-bold"><a><%= articuloDetalle.Nombre %></a></h4>
    <!-- Data -->
    <ul class="list-unstyled list-inline rating mb-0">
      <li class="list-inline-item mr-0"><i class="fas fa-star amber-text"> </i></li>
      <li class="list-inline-item mr-0"><i class="fas fa-star amber-text"></i></li>
      <li class="list-inline-item mr-0"><i class="fas fa-star amber-text"></i></li>
      <li class="list-inline-item mr-0"><i class="fas fa-star amber-text"></i></li>
      <li class="list-inline-item"><i class="fas fa-star-half-alt amber-text"></i></li>
      <li class="list-inline-item"><p class="text-muted">4.5 (413)</p></li>
    </ul>
    <p class="mb-2">$ <%= articuloDetalle.Precio %>  <%= articuloDetalle.Marca %></p>
    <!-- Text -->
    <p class="card-text"><%= articuloDetalle.Descripcion %></p>
    <hr class="my-4">
    <p class="lead"><strong><!--  --></strong></p>
    <ul class="list-unstyled list-inline d-flex justify-content-between mb-0">
      <li class="list-inline-item mr-0">
        <div class="chip mr-0">5:30PM</div>
      </li>
      <li class="list-inline-item mr-0">
        <div class="chip deep-purple white-text mr-0">7:30PM</div>
      </li>
      <li class="list-inline-item mr-0">
        <div class="chip mr-0">8:00PM</div>
      </li>
      <li class="list-inline-item mr-0">
        <div class="chip mr-0">9:00PM</div>
      </li>
    </ul>
    <!-- Button -->
    <a href="#" class="btn btn-flat deep-purple-text p-1 mx-0 mb-0">Button</a>

  </div>

</div>
<!-- Card -->   
    <form id="form1" runat="server">
        <div>
        </div>
    </form>
</body>
</html>
