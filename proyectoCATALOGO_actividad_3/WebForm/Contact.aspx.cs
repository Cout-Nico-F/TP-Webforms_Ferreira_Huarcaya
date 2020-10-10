﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;
using System.Net;

namespace WebForm
{
    public partial class Contact : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCorreo_Click(object sender, EventArgs e)
        {

            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587); //dos parametro host y puerto
            //smtp.Credentials = new NetworkCredential("webform.proyecto01@gmail.com", "Webform123");
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential("webform.proyecto01@gmail.com", "Webform123");

            MailMessage mensaje = new MailMessage();
            mensaje.From = new MailAddress("webform.proyecto01@gmail.com","Gracias por contactarnos");
            mensaje.To.Add(new MailAddress("webform.proyecto01@gmail.com")); //aca se pone el mail al cual se va a enviar el correo predefinido 
            mensaje.Subject = "Mensaje de contacto";

            smtp.Send(mensaje);

            // Econtre una manera de poder enviar un correo personalizado a un cliente
            // no esta terminado todavia pero funciona
            // Me encontre con este error System.Net.Mail.SmtpException: 'El servidor SMTP requiere una conexión segura o el cliente no se autenticó. La respuesta del servidor fue: 5.7.0 Authentication Required
            // solamente tenia que cambiar el orden de smtp.Credentials y ponerlo despues de 
            //smtp.UseDefaultCrendentials porque esto vuelve nulo la credencial
            //Hay que econtrar una manera poder tomar el mail que escriba la persona de un label o textbox lo transforme en texto se reemplace en mensaje.To.Add


        }
    }
}