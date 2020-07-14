using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Repository;

namespace AcademyWeb.Controllers
{
    public class ImcController : Controller

    {
     
        private readonly AlunoDAO _alunoDAO;
        public ImcController( AlunoDAO alunoDAO)
        {

            
            _alunoDAO = alunoDAO;
        }

        [HttpPost]
        public IActionResult Cadastrar(IMCAlunos imc, int drpAlunos)
        {
            ViewBag.Alunos = new SelectList(_alunoDAO.ListarTodos(),
             "AlunoId", "Nome");

            if (ModelState.IsValid)
            {
                imc.Peso = Convert.ToDouble(imc.Peso);
                imc.Altura = Convert.ToDouble(imc.Altura);
                imc.Aluno = _alunoDAO.BuscarPorId(drpAlunos);
                
                _alunoDAO.CadastrarIMC(imc);

                return RedirectToAction("Index");
            }
            else
            {
                ModelState.AddModelError
                   ("", "Invalido");
                return View(imc);
            }
        }
        public IActionResult Cadastrar()
        {
            ViewBag.Alunos = new SelectList(_alunoDAO.ListarTodos(),
             "AlunoId", "Nome");
            return View();
        }


        [HttpPost]
        public IActionResult Index(int drpAlunos)
        {
            ViewBag.Alunos = new SelectList(_alunoDAO.ListarTodos(),
             "AlunoId", "Nome");

            Aluno a = _alunoDAO.BuscarPorId(drpAlunos);
            ViewBag.Validar = 1;
            return View(_alunoDAO.ListarImcporAluno(a));
        }
        public IActionResult Index()
        {
            ViewBag.Alunos = new SelectList(_alunoDAO.ListarTodos(),
             "AlunoId", "Nome");
            return View();
        }
    }
}