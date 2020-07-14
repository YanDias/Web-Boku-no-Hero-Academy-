using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repository;

namespace Api.Controllers
{
   
    [Route("api/Aviso")]
    [ApiController]
    public class AvisoController : ControllerBase
    {
        private readonly AvisosDAO _avisosDAO;
        public AvisoController(AvisosDAO avisosDAO)
        {
            _avisosDAO = avisosDAO;
        }
        [HttpPost]
        [Route("CadastrarAviso")]
        public IActionResult Cadastrar([FromBody]Avisos av)
        {
            if (ModelState.IsValid)
            {
                if (_avisosDAO.Cadastrar(av))
                {
                    return Created("", av);
                }
                return Conflict(new { msg = "Erro ao Cadastrar" });
            }
            return BadRequest(ModelState);
        }

    }
}