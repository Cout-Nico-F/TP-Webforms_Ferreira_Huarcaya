<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="WebForm.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h3>Contactanos!</h3>
    <form>

   <div class="row">
    <div class="col">
     <input type="text" class="form-control" placeholder="Nombre Completo">
    </div>
       <br />
    <div class="col">
      <input type="text" class="form-control" placeholder="Apellidos">
    </div>
  </div> 

  <div class="form-group">
    <label for="exampleFormControlInput1">Direccion de correo electronico</label>
    <input type="email" class="form-control" id="exampleFormControlInput1" placeholder="name@example.com">
  </div>
      
    <div class="form-group">
    <label for="exampleFormControlSelect1">Sexo</label>
    <select class="form-control" id="exampleFormControlSelect1">
      <option>Hombre</option>
      <option>Mujer</option>
      <option>Otro</option>
    </select>
  </div>

    <div class="form-group">
        <label for="exampleFormControlTextarea1">Comentarios</label>
        <textarea class="form-control" id="exampleFormControlTextarea1" rows="3"></textarea>
    </div>

    <button type="button" class="btn btn-success">Enviar</button>

        </form>
    <br />
    <br />

    <div>
    <address>
        UTN/FRGP<br />
        Buenos Aires, Argentina<br />
        <abbr title="Phone">Tel:</abbr>
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
