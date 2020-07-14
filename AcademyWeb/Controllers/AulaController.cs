using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.Rendering;
using Repository;

namespace WebAcademy.Controllers
{
    public class AulaController : Controller
    {
        private readonly AulaDAO _aulaDAO;
        private readonly ProfessorDAO _professorDAO;


        public AulaController(AulaDAO aulaDAO, ProfessorDAO professorDAO)
        {
            _aulaDAO = aulaDAO;
            _professorDAO = professorDAO;
        }

        [HttpPost]
        public IActionResult Cadastrar(Aula a, int drpProfessores)
        {
            ViewBag.Professores = new SelectList(_professorDAO.ListarTodos(),
            "IdProfessor", "Nome");

            if (ModelState.IsValid)
            {
                a.Professor = _professorDAO.BuscarPorId(drpProfessores);
                if (_aulaDAO.Cadastrar(a))
                {
                    return RedirectToAction("Index");
                }
                ModelState.AddModelError
                    ("", "Esse produto já existe!");
            }
            return View(a);
        }
        public IActionResult Index()
        {
            ViewBag.DataHora = DateTime.Now;
            return View(_aulaDAO.ListarTodos());
        }


        public IActionResult Cadastrar()
        {
            ViewBag.Professores =
                new SelectList(_professorDAO.ListarTodos(),
                "IdProfessor", "Nome");
            return View();
        }
        public IActionResult Alterar(int id)
        {
            Aula a = _aulaDAO.BuscarPorId(id);
            int v = a.Vagas;

            if (v > 0)
            {
                a.Vagas = v - 1;
                _aulaDAO.AlterarAula(a);
                return RedirectToAction("Index");
            }

            return RedirectToAction("Index");
        }
        public IActionResult Remover(int id)
        {
            Aula a = _aulaDAO.BuscarPorId(id);
            _aulaDAO.RemoverAula(a);
            return RedirectToAction("Index");
        }
    }
}