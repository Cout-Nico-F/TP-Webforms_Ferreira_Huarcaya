<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Error.aspx.cs" Inherits="WebForm.Error" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <style>
        body {
    margin: 0px;
    font-family: "Muli",sans-serif;
    background-color: rgb(34, 131, 183  );
}

h1 {
    margin: 0px;
}

.error-message {
    display: flex;
    flex-direction: row;
    align-items: center;
    justify-content: center;
    height: calc(100vh - 100px);
    width: 1850px;
}

.error-message-container {
    text-align: center;
    color: white;
}

h2 {
    font-size: 60px;
    text-align: center;
    flex-direction: row;
}
h1{
    font-size:150px;
    position:relative;
    flex-direction:row;
    left:-450px;
}

.clase {
    font-size: 18px;
}

.animated {
    animation-duration: 2.5s;
    animation-fill-mode: both;
    animation-iteration-count: infinite;
}

@keyframes bounce {
    0%,20%,50%,80%,100% {
        transform: translateY(0);
    }

    40% {
        transform: translateY(-30px);
    }

    60% {
        transform: translateY(-15px);
    }
}

.bounce {
    animation-name: bounce;
}

.footer {
    display: flex;
    align-items: center;
    min-height: 100px;
    width: 100%;
}

    .footer a {
        color: white;
        cursor: pointer;
        font-size: 14px;
        padding-left: 30px;
        text-decoration: none;
    }

    .footer:hover {
        text-decoration: underline;
    }

@media only screen and (max-width:600px) {
    .footer {
        align-items: flex-start;
        flex-direction: column;
    }
}

    </style>
    <form id="form1" runat="server">
        <div>
            <section class="error-message">
                <section class="error-message-container">
                    <h1>:(</h1>
                    <h2 class="animated bounce"> Lo sentimos...Cometimos un error</h2>
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
