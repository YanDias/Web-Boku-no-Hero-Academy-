using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Domain;
using Repository;

namespace Api.Controllers
{
    [Route("api/Imc")]
    [ApiController]
    public class ImcController : ControllerBase
    {
        private readonly AlunoDAO _alunoDAO;
        public ImcController(AlunoDAO alunoDAO)
        {
            _alunoDAO= alunoDAO;
        }
        [HttpPost]
        [Route("Cadastrar")]
        public IActionResult Cadastrar([FromBody]IMCAlunos imc)
        {
            if (ModelState.IsValid)
            {
                imc.Aluno = _alunoDAO.BuscarPorId(imc.Aluno.AlunoId);

                if (_alunoDAO.CadastrarIMC(imc))
                {
                    return Created("", imc);
                }
                return Conflict(new { msg = "Erro ao Cadastrar" });
            }
            return BadRequest(ModelState);
        }

    }
}