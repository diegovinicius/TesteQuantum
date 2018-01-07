using System.Linq;
using System.Web.Mvc;
using WEB.DAL;
using WEB.DAL.Repositorios;

namespace WEB.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            FuncionarioRepositorio _funcionarios = new FuncionarioRepositorio();
            _funcionarios.GetAll();

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
    }
}