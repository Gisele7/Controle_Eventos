using Controle_Eventos.Interfaces;
using Controle_Eventos.Repositorys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Controle_Eventos.Controllers
{
    public class EventosController : Controller
    {
        RepositoryEvento _RepositoryEvento = new RepositoryEvento();
        // GET: Eventos
        public ActionResult Novo()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Novo(EVENTOS eventos)
        {
            try
            {
                eventos = _RepositoryEvento.Incluir(eventos);
                return RedirectToAction("Lista");
            }
            catch (Exception)
            {
                //ViewData["Message"] = ex.Message;
                return RedirectToAction ("Lista");
            }
        }
        public ActionResult Lista()
        {
            List<EVENTOS> listaEvento = _RepositoryEvento.SelecionarTodos();
            return View(listaEvento);
        }

        public ActionResult Editar(int id)
        {
            var evento = _RepositoryEvento.SelecionarPk(id);
            return View(evento);
        }

        [HttpPost]
        public ActionResult Editar(EVENTOS eventos)
        {
            try
            {
                eventos = _RepositoryEvento.Alterar(eventos);
                return RedirectToAction("Lista");
            }
            catch (Exception)
            {
                return RedirectToAction("Lista");
            }
        }

        public ActionResult Excluir(int codEvento)
        {
            try
            {
                var evento = _RepositoryEvento.SelecionarPk(codEvento);

                    _RepositoryEvento.Excluir(evento);
                    return RedirectToAction("Lista", "Eventos", new { mensagem = "Dados excluídos com sucesso!" });
            }
            catch (Exception ex)
            {
                ViewData["MensagemErro"] = "Erro ao excluir os dados." + ex.Message;
                return RedirectToAction("Consulta", new { mensagem = "Erro ao excluir.", erro = true });
            }
        }
    }
}