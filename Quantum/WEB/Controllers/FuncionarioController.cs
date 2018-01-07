using System.Web.Mvc;
using WEB.DAL.Repositorios;

namespace WEB.Controllers
{
    public class FuncionarioController : Controller
    {
        [HttpGet]
        public JsonResult Listar()
        {
            FuncionarioRepositorio _funcionarios = new FuncionarioRepositorio();
            var lista =_funcionarios.GetAll();
            return Json(lista, JsonRequestBehavior.AllowGet);
        }
    }
}