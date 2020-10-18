<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InicioSesion.aspx.cs" Inherits="WebForm.InicioSesion" %>


<!DOCTYPE html>
<html lang="en" xmlns:th="http://www.thymeleaf.org">
<head>
    <title>Mi primer Login</title>
    <link href="Estilos_Inicio.aspx" rel="stylesheet" />

    <!--JQUERY-->
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
    
    <!-- FRAMEWORK BOOTSTRAP para el estilo de la pagina-->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css">
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js"></script>
    
    <!-- Los iconos tipo Solid de Fontawesome-->
    <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.0.8/css/solid.css">
    <script src="https://use.fontawesome.com/releases/v5.0.7/js/all.js"></script>

    <script src="https://kit.fontawesome.com/d749d06842.js" crossorigin="anonymous"></script>

</head>
<body style="background-color:black;background-image:url(https://allegra.flowersetcfresno.com/pic/5564165_full-fondos-de-pantalla-de-age-of-empires-2-hd-age-of-empires-ii-definitive-edition-para-pc-analisis-review.jpeg);">
    <div class="modal-dialog text-center" id="posicion-form" style="position:relative;top:300px;">
        <div class="col-sm-8 main-section">
            <div class="modal-content">
                <div class="col-12 user-img">
                    <i class="fas fa-user"></i>
                </div>
                <form class="col-12" th:action="@{/login}" method="get">
                    <div class="form-group" id="user-group">
                        <input type="text" class="form-control" placeholder="Maximiliano Sar" name="username"/>
                    </div>
                    <div class="form-group" id="contrasena-group">
                        <input type="password" class="form-control" placeholder="MaxiProfeCopado1" name="password"/>
                    </div>
                    <a class="btn btn-primary" href="Catalogo.aspx"><i class="fas fa-sign-in-alt"></i>  Ingresar </a>
                </form>
                <div class="col-12 forgot">
                    <a href="#">Recordar contrasena?</a>
                </div>
               </div>
            </div>
    </div>
</body>
</html>
