using System.Net.Mail;
using System.Web.Configuration;
using System.Web.Mvc;

namespace LimiaUrbanus.WebSite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Vender() => View();

        public ActionResult EnviarEmail(string email, string assunto, string mensagem, string telefone)
        {
            var username = WebConfigurationManager.AppSettings["EmailUsername"];
            var password = WebConfigurationManager.AppSettings["EmailPassword"];
            var emailTo = WebConfigurationManager.AppSettings["EmailTo"];
            SmtpClient client = new SmtpClient("limiaurbanus.pt", 25);
            client.Credentials = new System.Net.NetworkCredential(username, password);
            client.UseDefaultCredentials = false;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;

            try
            {
                var mail = new MailMessage(username, emailTo);
                var body = $"Email: {email}\nTelefone: {telefone}\nData: {System.DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")}\n\n\n{mensagem}";
                mail.Subject = assunto;
                mail.Body = body;
                client.Send(mail);
                Session["MensagemUser"] = "Mensagem enviada com sucesso, será contactado em breve. Obrigado";
            }
            catch(System.Exception ex)
            {
                System.Console.WriteLine(ex.Message);
                Session["MensagemUser"] = $"Algo inesperado aconteceu, não foi possível enviar a sua mensagem.Envie um email para geral@limiaurbanus.pt. <br/>Pedemos desculpa pelo incómodo.<br/><br/>{ex.Message}";
            }

            return Redirect(Request.UrlReferrer.PathAndQuery);
        }
    }
}
