using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repository;

namespace Api.Controllers
{
    [Route("api/Aula")]
    [ApiController]
    public class AulaController : ControllerBase
    {
        private readonly AulaDAO _aulaDAO;
        public AulaController(AulaDAO aulaDAO)
        {
            _aulaDAO= aulaDAO;
        }

        //GET: /api/
        [HttpGet]
        [Route("ListarTodos")]
        public IActionResult ListarTodos()
        {
            return Ok(_aulaDAO.ListarTodos());
        }
    }
}