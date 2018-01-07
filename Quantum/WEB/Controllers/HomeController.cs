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
    }
}