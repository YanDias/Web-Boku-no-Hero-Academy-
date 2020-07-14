using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Repository;

namespace AcademyWeb.Controllers
{
    public class AvisosController : Controller
    {
        private readonly AvisosDAO _avisosDAO;

        public AvisosController(AvisosDAO avisosDAO)
        {
            _avisosDAO = avisosDAO;
           
        }

        public IActionResult Index()
        {
            return View(_avisosDAO.ListarTodos());
        }

        public IActionResult Cadastrar()
        {
           
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Avisos a)
        {

          
                if (_avisosDAO.Cadastrar(a))
                {
                    return RedirectToAction("Index");
                }
               
                ModelState.AddModelError
                    ("", "Esse produto já existe!");
            return View();
            }

        public IActionResult Remover(int id)
        {
            Avisos a = _avisosDAO.BuscarPorId(id);
            _avisosDAO.RemoverAvisos(a);
            return RedirectToAction("Index");
        }

        public IActionResult Alterar(int id)
        {
            return View
                (_avisosDAO.BuscarPorId(id));
        }

        [HttpPost]
        public IActionResult Alterar(Avisos a)
        {
           

            _avisosDAO.AlterarAvisos(a);
            return RedirectToAction("Index");

        }



    }
}