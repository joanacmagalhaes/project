using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NatureEventV2
{
    public partial class Contact : Page
    {
        //Password of your gmail address
        const string fromPassword = "GKJakwXXZWGRs6D";
        const string fromAddress = "infonaturevent@gmail.com";

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void SendMail()
        {
            string toAddress = TextBoxEmail.Text;
            // Passing the values and make a email formate to display
            string subject = TextBoxAsunto.Text;
            string body = "From: " + TextNombre.Text + "\n";
            body += "Email: " + TextBoxEmail.Text + "\n";
            body += "Subject: " + TextBoxAsunto.Text + "\n";
            body += "Question: \n" + TextAreaMensaje.Text + "\n";
            // smtp settings
            SmtpClient smtp = new SmtpClient();
            {
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.EnableSsl = true;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Credentials = new NetworkCredential(fromAddress, fromPassword);
                smtp.Timeout = 20000;
            }
          
            // Passing values to smtp object
            smtp.Send(fromAddress, toAddress, subject, body);
          
        }


        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                //here on button click what will done 
                SendMail();
                this.TextMensajeInfo.Text = "<div class='alert alert-success alert-dismissible'><a href='#' class='close' data-dismiss='alert' aria-label='close'>&times;</a> <strong>Exito!</strong> Se ha enviado el mensaje a NatureEvent.</div>";
                this.TextMensajeInfo.Visible = true;
                this.TextAreaMensaje.Text = "";
                this.TextBoxAsunto.Text = "";
                this.TextBoxEmail.Text = "";
                this.TextNombre.Text = "";
            }
            catch (Exception ex) {
                this.TextMensajeInfo.Text = "<div class='alert alert-warning alert-dismissible'><a href='#' class='close' data-dismiss='alert' aria-label='close'>&times;</a> <strong>Fallo!</strong> Ha ocurrido un error en la conexión del servidor, prueba más tarde.</div>";
            }
        }
    }
}