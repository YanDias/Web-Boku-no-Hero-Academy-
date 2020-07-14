using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Repository;

namespace AcademyWeb.Controllers
{
    public class LoginController : Controller

    {
        private readonly ProfessorDAO _professorDAO;
        private readonly AlunoDAO _alunoDAO;
        public LoginController(ProfessorDAO professorDAO, AlunoDAO alunoDAO)
        {

            _professorDAO = professorDAO;
            _alunoDAO = alunoDAO;
        }

        [HttpPost]
        public IActionResult LoginProfessor(Professor pr)
        {

            if (ModelState.IsValid)
            {
                if (_professorDAO.ValidarSenha(pr) != null)
                {
                    Professor p = _professorDAO.ValidarSenha(pr);
                    TempData["Professor"] = p.Nome;
                    return RedirectToAction("IndexProfessor", "Professor", TempData["Professor"]);
                }
                else
                {
                    ModelState.AddModelError("", "Falha no login!");
                    return View();
                }
            }
            else
            {
                ModelState.AddModelError
                   ("", "Login Incorreto ");
                return RedirectToAction("About", "Home");
            }
        }
        public IActionResult LoginProfessor()
        {
            return View();
        }


        [HttpPost]
        public IActionResult LoginAluno(Aluno a)
        {

            if (ModelState.IsValid)
            {
                if (_alunoDAO.ValidarSenha(a) != null)
                {
                    Aluno al = _alunoDAO.ValidarSenha(a);
                    TempData["Aluno"] = a.Nome;
                    return RedirectToAction("IndexAluno", "Aluno", TempData["Aluno"]);

                }
                else
                {
                    ModelState.AddModelError("", "Falha no login!");
                    return View();
                }
            }
            else
            {
                ModelState.AddModelError
                   ("", "Login Incorreto ");
                return RedirectToAction("About", "Home");
            }
        }
        public IActionResult LoginAluno()
        {
            return View();
        }
    }
}