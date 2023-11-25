using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;

namespace Projeto1
{
    public partial class Contato : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Enviar_Click(object sender, EventArgs e)
        {
            // validar dados de entrada 
            if (Nome.Text.Trim() == "")
            {
                MsgErro.Text = "Digie seu Nome";
            }
            else if (Mensagem.Text.Trim() == "")
            {
                MsgErro.Text = "Digite a mensagem";
            }
            else if (Email.Text.Trim() == "")
            {
                MsgErro.Text = "Digite seu e-mail";
            }
            else {
                String conteudo =
                    "Nome: " + Nome.Text +
                    "\n Email: " + Email.Text +
                    "\n Mensagem:" + Mensagem.Text;

                // CRIAR O EMAIL
                MailMessage mail = new MailMessage();
                MailAddress from = new MailAddress("meudominio@gmail.com");

                mail.To.Add("meudominio@gmail.com");
                mail.From = from;
                mail.Subject = "Fale Conosco";
                mail.Body = "";
                mail.IsBodyHtml = false; 

                // ENVIAR O EMAIL 
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.emilycomin.somee.com";
                smtp.Credentials = new System.Net.NetworkCredential("contato@seudominio.com.br", "suasenha");
                smtp.EnableSsl = true;
                smtp.Send(mail); 
            }
        }
    }
}