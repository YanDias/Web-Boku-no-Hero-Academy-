using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using Repository;

namespace WebAcademy.Controllers
{
    public class ProfessorController : Controller
    {
        private readonly ProfessorDAO _professorDAO;
        private readonly IHostingEnvironment _hosting;

        public ProfessorController(ProfessorDAO professorDAO, IHostingEnvironment hosting)
        {
            _professorDAO = professorDAO;
            _hosting = hosting;
        }

        [HttpPost]
        public IActionResult Cadastrar(Professor p, IFormFile fupImagem)
        {


            if (ModelState.IsValid)
            {
                //Cadastrar a imagem
                if (fupImagem != null)
                {
                    //paste: ecommerceimagens
                    string arquivo = Guid.NewGuid().ToString() +
                        Path.GetExtension(fupImagem.FileName);
                    string caminho = Path.Combine(_hosting.WebRootPath,
                        "Academyimagens", arquivo);
                    fupImagem.CopyTo(
                        new FileStream(caminho, FileMode.Create));
                    p.Imagem = arquivo;
                }
                else
                {
                    p.Imagem = "semimagem.jfif";
                }

                if (_professorDAO.Cadastrar(p))
                {
                    return RedirectToAction("Index");
                }
                ModelState.AddModelError
                    ("", "Esse produto já existe!");
            }
            return View(p);
        }
        public IActionResult Index()
        {
            ViewBag.Nome = TempData["Professor"];
            TempData.Keep("Professor");
            ViewBag.DataHora = DateTime.Now;
            return View(_professorDAO.ListarTodos());
        }



        public IActionResult Cadastrar()
        {

            return View();
        }

        public IActionResult IndexProfessor()
        {

            return View();
        }
    }
}