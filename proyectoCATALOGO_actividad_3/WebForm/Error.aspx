<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Error.aspx.cs" Inherits="WebForm.Error" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <section class="error-message">
                <section class="error-message-container">
                    <h1 class="animated bounce"> Lo sentimos...Cometimos un error</h1>
                    <asp:Label Text="text" runat="server" ID="lblError" CssClass="clase"/>
                </section>
            </section>
            
        </div>
        <footer class="footer">
            <a href="/">Terminos de uso</a>
            <a href="/">Declaracion de Privacidad</a>
            <a href="/">Centro de ayuda</a>
        </footer>
    </form>
</body>
</html>
