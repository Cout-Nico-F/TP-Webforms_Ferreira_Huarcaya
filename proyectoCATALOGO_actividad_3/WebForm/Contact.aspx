<%@ Page Title="Contact" Language="C#" MasterPageFile="~/B.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="WebForm.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div style="color:white;"> 
    <h3>Contactanos!</h3>
    <form action="https://formspree.io/f/mwkwvbdb" method="POST">
            <div class="form-group">
                <input type="text" class="form-control" placeholder="Nombre Completo" name="Nombre_Completo">
            </div>
            <div class="form-group">
                <input type="text" class="form-control" placeholder="Apellidos" name="Apellidos">
            </div>
        <br />
        <div class="form-group">
            <!-- <label  for="exampleFormControlInput1">Direccion de correo electronico</label>
            <input type="email" class="form-control" id="exampleFormControlInput1" placeholder="name@example.com" name="Email"> -->
            <asp:Label Text="Correo electronico" runat="server" /><br />
            <asp:TextBox ID="txtEmail" runat="server" style="color:black;width:300px;" Placeholder="MaxiSaar_AOE@gmail.com" MaxLength="30" TextMode="Email" />
        </div>

        <div class="form-group">
            <label for="exampleFormControlTextarea1">Comentarios</label>
            <textarea class="form-control" id="exampleFormControlTextarea1" rows="3"></textarea>
        </div>

        <asp:Button ID="btnCorreo" Text="Enviar" runat="server" OnClick="BtnCorreo_Click" style="color:black;background-color:cadetblue;" />

        <br />
       
    </form>
   </div>
    <br />
    <br />

    <div style="color:white;">
        <address>
            Programacion 3 - UTN/FRGP<br />
            Buenos Aires, Argentina<br />
            <abbr title="Telefono">Tel:</abbr>
            0800-PROgramming
        </address>
    </div>
    <div style="color:white;">
        <address>
            <strong>Soporte:</strong>   <a href="mailto:Support@example.com">Soporte@ejemplo.com</a><br />
            <strong>Marketing:</strong> <a href="mailto:Marketing@example.com">Marketing@ejemplo.com</a>
        </address>
    </div>
</asp:Content>
