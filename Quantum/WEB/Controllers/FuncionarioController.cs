using System.Linq;
using System.Web.Mvc;
using WEB.DAL.Repositorios;
using WEB.Models;

namespace WEB.Controllers
{
    public class FuncionarioController : Controller
    {
        FuncionarioRepositorio _funcionarios = new FuncionarioRepositorio();
        
        [HttpGet]
        public JsonResult Listar()
        {
            var lista =_funcionarios.GetAll().OrderBy(x=> x.Nome);
            return Json(lista, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult Buscar(int id)
        {
            var funcionario = _funcionarios.GetById(id);

            return Json(funcionario, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult Salvar(Funcionario funcionario)
        {
            _funcionarios.Save(funcionario);

            return Json("", JsonRequestBehavior.AllowGet);
        }
    }
}