using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Repository;

namespace WebAcademy.Controllers
{
    public class AlunoController : Controller
    {
        private readonly ExercicioDAO _exercicioDAO;
        private readonly TreinoDAO _treinoDAO;
            private readonly AlunoDAO _alunoDAO;
            private readonly AulaDAO _aulaDAO;
        private readonly AvisosDAO _avisosDAO;
            private readonly IHostingEnvironment _hosting;

            public AlunoController(AlunoDAO alunoDAO, IHostingEnvironment hosting, AulaDAO aulaDAO, ExercicioDAO exercicioDAO,TreinoDAO treinoDAO, AvisosDAO avisosDAO)
            {
                _alunoDAO = alunoDAO;
                _hosting = hosting;
                _aulaDAO = aulaDAO;
                _exercicioDAO = exercicioDAO;
                _treinoDAO = treinoDAO;
            _avisosDAO = avisosDAO;
            }

            [HttpPost]
            public IActionResult Cadastrar(Aluno a, IFormFile fupImagem)
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
                    a.Imagem = arquivo;
                }
                else
                {
                    a.Imagem = "semimagem.jfif";
                }

                if (_alunoDAO.Cadastrar(a))
                {
                    return RedirectToAction("GerenciamentoAluno");
                }
                ModelState.AddModelError
                    ("", "Esse Aluno já existe!");
            }
            return View(a);
        }
        public IActionResult IndexAluno()
            {
                ViewBag.DataHora = DateTime.Now;
                return View(_avisosDAO.ListarTodos());
            }

        
        public IActionResult Cadastrar()
        {

            return View();
        }
        public IActionResult GerenciamentoAluno()
        {
            ViewBag.DataHora = DateTime.Now;
            return View(_alunoDAO.ListarTodos());

        }
        public IActionResult Alterar(int id)
        {
           return View
               (_alunoDAO.BuscarPorId(id));
        }


        [HttpPost]
        public IActionResult Alterar(Aluno al, IFormFile fupImagem)
        {
           
            if (fupImagem != null)
            {
            
                string arquivo = Guid.NewGuid().ToString() +
                    Path.GetExtension(fupImagem.FileName);
                string caminho = Path.Combine(_hosting.WebRootPath,
                    "Academyimagens", arquivo);
                fupImagem.CopyTo(
                    new FileStream(caminho, FileMode.Create));
                al.Imagem = arquivo;
            }
            else
            {
                al.Imagem = "semimagem.jfif";
            }


            _alunoDAO.Alterar(al);
            return RedirectToAction("IndexAluno");

        }
        public IActionResult ViewAula()
        {
            ViewBag.DataHora = DateTime.Now;
            return View(_aulaDAO.ListarTodos());

        }
        public IActionResult AlterarAula(int id)
        {
            Aula a = _aulaDAO.BuscarPorId(id);
            int v = a.Vagas;

            if (v > 0)
            {
                a.Vagas = v - 1;
                _aulaDAO.AlterarAula(a);
                return RedirectToAction("ViewAula");
            }

            return RedirectToAction("ViewAula");
        }
        public IActionResult ViewTreino()

        { 
            
            return View();
        }
        
        public IActionResult ValidarAluno(Aluno a)

        {
            
            Aluno b = _alunoDAO.ValidarSenha(a);
            if(b != null)
            {
                return RedirectToAction("EditarPerfil",b);
                
            }
            else {
                
                return RedirectToAction("EditarPerfil",1);
            }
        }
        public IActionResult EditarPerfil(Aluno a, int v)

        {
            if (v == 1) { 
            ModelState.AddModelError
                    ("", "Login Invalido");
                return View();
            }
            return View(a);
        }

        

    }
    
}