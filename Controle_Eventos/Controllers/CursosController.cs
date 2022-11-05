using Controle_Eventos.Repositories;
using Controle_Eventos.Repositorys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Controle_Eventos.Controllers
{
    public class CursosController : Controller
    {

        RepositoryCurso _RepositoryCurso = new RepositoryCurso();
        RepositoryEvento _RepositoryEvento = new RepositoryEvento();
        RepositoryTipoCurso _RepositoryTipoCurso = new RepositoryTipoCurso();
        RepositoryTipoUsuario _RepositoryTipoUsuario = new RepositoryTipoUsuario();
        // GET: Cursos

        public void CarregaViewBag()
        {
            ViewBag.listaEvento = _RepositoryEvento.SelecionarTodos();
            ViewBag.tipoCurso = _RepositoryTipoCurso.SelecionarTodos();
            ViewBag.tipoUsuario = _RepositoryTipoUsuario.SelecionarTodos();
        }
        public ActionResult Novo(string mensagem = null, bool erro = false)
        {
            CarregaViewBag();
            if (mensagem != null)
            {
                if (erro)
                {
                    ViewData["MensagemErro"] = mensagem;
                }
                else
                {
                    ViewData["Mensagem"] = mensagem;
                }
            }
           
            return View();
        }

        [HttpPost]
        public ActionResult Novo(CURSOS curso)
        {
            CarregaViewBag();
            try
            {
                curso = _RepositoryCurso.Incluir(curso);
                return View();
            }
            catch (Exception)
            {
                return View();
            }
        }
    }
}