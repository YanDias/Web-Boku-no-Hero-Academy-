using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Repository;

namespace AcademyWeb.Controllers
{

    public class ExercicioController : Controller
    {



        private readonly ExercicioDAO _exercicioDAO;
        private readonly TreinoDAO _treinoDAO;
        private readonly ProfessorDAO _professorDAO;
        private readonly AlunoDAO _alunoDAO;
        private readonly ListaTreinoDAO _listaTreinoDAO;

        public ExercicioController(ExercicioDAO exercicioDAO, TreinoDAO treinoDAO, AlunoDAO alunoDAO, ProfessorDAO professorDAO, ListaTreinoDAO listaTreinoDAO)
        {

            _exercicioDAO = exercicioDAO;
            _alunoDAO = alunoDAO;
            _professorDAO = professorDAO;
            _listaTreinoDAO = listaTreinoDAO;
            _treinoDAO = treinoDAO; 
                }
        public IActionResult CadastrarTreino()
        {
            ViewBag.Alunos = new SelectList(_alunoDAO.ListarTodos(),
             "AlunoId", "Nome");

            ViewBag.Professores = new SelectList(_professorDAO.ListarTodos(),
             "IdProfessor", "Nome");

            ViewBag.Lista = new SelectList(_listaTreinoDAO.ListarTodos(), "IdListaTreino", "NomeLista");


            return View();
        }
        [HttpPost]
        public IActionResult CadastrarTreino(Treino tr, int drpAlunos, int drpProfessores, int drpLista)
        {
            ViewBag.Alunos = new SelectList(_alunoDAO.ListarTodos(),
             "AlunoId", "Nome");

            ViewBag.Professores = new SelectList(_professorDAO.ListarTodos(),
             "IdProfessor", "Nome");

            ViewBag.Lista = new SelectList(_listaTreinoDAO.ListarTodos(), "IdListaTreino", "NomeLista");
            
            
            
            
                tr.Aluno = _alunoDAO.BuscarPorId(drpAlunos);
                tr.Professor = _professorDAO.BuscarPorId(drpProfessores);
                tr.ListaTreino = _listaTreinoDAO.BuscarPorId(drpLista);

                _treinoDAO.Cadastrar(tr);
                return RedirectToAction("IndexProfessor","Professor");
            
            
        }
        [HttpPost]
        public IActionResult CadastrarExercicio(Exercicio exercicio, int drpLista)
        {
            ViewBag.Lista = new SelectList(_listaTreinoDAO.ListarTodos(), "IdListaTreino", "NomeLista");
            exercicio.ListaTreino = _listaTreinoDAO.BuscarPorId(drpLista);
            

                _exercicioDAO.Cadastrar(exercicio);
            ModelState.AddModelError
              ("", "Adicione Mais exercicios a lista Desejada ou Prossiga para o cadastro de Treino");
            return View();
            
            
        }
        
        [HttpPost]
        public IActionResult Index(int drpAlunos)
        {
            ViewBag.Busca = new SelectList(_alunoDAO.ListarTodos(),
             "AlunoId", "Nome");
            Aluno a = _alunoDAO.BuscarPorId(drpAlunos);
            
            List<Treino> tr = new List<Treino>();
            tr = _treinoDAO.ListarPorAluno(a);
            
            if (tr != null) { 
            ViewBag.Validar = 1;

            return View(tr);
            }
            else
            {
                ModelState.AddModelError
               ("", "Erro");
                return View();
            }
        }
        public IActionResult Index()
        {
            ViewBag.Busca = new SelectList(_alunoDAO.ListarTodos(),
             "AlunoId", "Nome");
            return View();
        }

        public IActionResult CadastrarExercicio()
        {
            ViewBag.Lista = new SelectList(_listaTreinoDAO.ListarTodos(), "IdListaTreino", "NomeLista");

            return View();
        }
        
        [HttpPost]
        public IActionResult CadastrarLista(ListaTreino lt)
        {
            if (ModelState.IsValid)
            {
                _listaTreinoDAO.Cadastrar(lt);
                return RedirectToAction("CadastrarExercicio"); 
            }
            ModelState.AddModelError
               ("", "Erro");
            return View();
                
        }
        public IActionResult CadastrarLista()
        {
            return View();
        }

        public IActionResult idLista(int id)
        {
            ListaTreino lt = _listaTreinoDAO.BuscarPorId(id);
            
            return RedirectToAction("viewExercicio",lt);
        }
       
        public IActionResult viewExercicio(ListaTreino lt)
        {
            List<Exercicio> ex = new List<Exercicio>();
            ex = _exercicioDAO.ListarporLista(lt);
            return View(ex);
        }
    }
}