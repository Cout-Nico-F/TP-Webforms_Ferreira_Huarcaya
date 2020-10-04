<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebForm._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Catalogo Productos Electronicos</h1>
        <p class="lead">Neque porro quisquam est qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit</p>
        <p><a href="Catalogo.aspx" class="btn btn-warning btn-lg"> Ver Catalogo &raquo;</a></p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Ferreira</h2>
            <p>
                Donec ut massa a lacus dignissim tristique. Suspendisse id lorem pharetra, rhoncus orci eu, tempus lorem. Quisque aliquet imperdiet enim eleifend aliquet. Integer lacinia mi sit amet fermentum imperdiet. Etiam interdum leo nec erat efficitur tempor. Etiam vel ultrices 
            </p>
            <p>
                <a class="btn btn-warning" href="About.aspx">Learn Less &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Huarcaya</h2>
            <p>
                Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Duis odio turpis, rutrum fringilla felis ut, egestas mattis nulla. Mauris eget iaculis massa. Proin finibus neque sagittis magna porta dignissim quis vitae nunc. Duis efficitur pharetra 
            </p>
            <p>
                <a class="btn btn-warning" href="About.aspx">Learn Less &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Web Not Hosting</h2>
            <p>
                Nunc commodo leo tincidunt fringilla ultricies. Nullam sed enim ut erat mattis blandit at et neque. Aliquam erat volutpat. Nulla feugiat rutrum tempor.            </p>
            <p>
                <a class="btn btn-warning" href="https://go.microsoft.com/fwlink/?LinkId=301950">Learn Trash &raquo;</a>
            </p>
        </div>
    </div>

</asp:Content>
