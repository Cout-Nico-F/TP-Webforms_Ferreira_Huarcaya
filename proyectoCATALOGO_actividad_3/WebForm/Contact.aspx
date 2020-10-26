<%@ Page Title="Contact" Language="C#" MasterPageFile="~/B.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="WebForm.Contact" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>

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
            <!--<asp:ScriptManager ID="smEmail" runat="server"></asp:ScriptManager>-->
            <asp:ScriptManagerProxy ID="smpEmail" runat="server"></asp:ScriptManagerProxy>
            <!--Error: System.InvalidOperationException: Sólo se puede agregar una instancia de ScriptManager a la página 
              No funcionan las soluciones que encontre en internet supongo que como las dos masters utilizan scriptmanager hay algun 
              -->
            <asp:Label Text="Correo electronico" runat="server" /><br />
            <asp:TextBox ID="txtEmail" runat="server" style="color:black;width:300px;" Placeholder="MaxiSaar_AOE@gmail.com" MaxLength="30" TextMode="Email" />
            <asp:RequiredFieldValidator ID="rfvEmail" runat="server" ErrorMessage="Campo Obligatorio" ControlToValidate="txtEmail"></asp:RequiredFieldValidator>
            <ajaxToolkit:ValidatorCalloutExtender ID="vce_rfcEmail" runat="server" TargetControlID="rfvEmail"></ajaxToolkit:ValidatorCalloutExtender>
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
