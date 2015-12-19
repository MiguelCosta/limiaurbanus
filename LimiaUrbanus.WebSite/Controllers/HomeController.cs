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

        public ActionResult EnviarEmail(string email, string assunto, string mensagem)
        {
            System.Console.WriteLine(email);
            System.Console.WriteLine(assunto);
            System.Console.WriteLine(mensagem);
            // todo redirecionar para uma página de sucesso e depois
            // colocar o botão voltar para o URL onde se fez o pedido
            return Redirect(Request.UrlReferrer.PathAndQuery);
        }
    }
}
