<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="WebForm.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h3>Contactanos!</h3>
    <form action="https://formspree.io/f/mwkwvbdb" method="POST">
            <div class="form-group">
                <input type="text" class="form-control" placeholder="Nombre Completo" name="Nombre_Completo">
            </div>
            <div class="form-group">
                <input type="text" class="form-control" placeholder="Apellidos" name="Apellidos">
            </div>

        <div class="form-group">
            <label  for="exampleFormControlInput1">Direccion de correo electronico</label>
            <input type="email" class="form-control" id="exampleFormControlInput1" placeholder="name@example.com" name="Email">
        </div>

        <div class="form-group">
            <label for="exampleFormControlSelect1">Sexo</label>
            <select class="form-control" id="exampleFormControlSelect1">
                <option>Hombre</option>
                <option>Mujer</option>
                <option>Otro</option>
            </select>
            <!--Aca tengo que averiguar como se captura este dato para enviarlo como input y ponerle un nombre para el backend -->
        </div>

        <div class="form-group">
            <label for="exampleFormControlTextarea1">Comentarios</label>
            <textarea class="form-control" id="exampleFormControlTextarea1" rows="3"></textarea>
        </div>

        <!--<button type="submit" class="btn btn-success">Enviar</button> -->
        <asp:Button ID="btnCorreo" Text="Enviar Correo" runat="server" Onclick ="btnCorreo_Click"/>
    </form>
    <br />
    <br />

    <div>
        <address>
            Programacion 3 - UTN/FRGP<br />
            Buenos Aires, Argentina<br />
            <abbr title="Telefono">Tel:</abbr>
            0800-PROgramming
        </address>
    </div>
    <div>
        <address>
            <strong>Soporte:</strong>   <a href="mailto:Support@example.com">Soporte@ejemplo.com</a><br />
            <strong>Marketing:</strong> <a href="mailto:Marketing@example.com">Marketing@ejemplo.com</a>
        </address>
    </div>
</asp:Content>
