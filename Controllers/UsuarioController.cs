using HS_BANK_ENTERPRISE.Models;
using HS_BANK_ENTERPRISE.Services.Usuarios;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HS_BANK_ENTERPRISE.Controllers
{
    [ApiController]
    [Route("api/v1/[Controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuariosService _service;

        public UsuarioController(IUsuariosService service)
        {
            _service = service;
        }
        /// <summary>
        /// Cria Todos os Usuario registrados.
        /// </summary>
        [HttpGet("GetAll")]
        public ActionResult<IEnumerable<Usuario>> GetAll()
        {
            var retorno = _service.GetAll();

            if(retorno == null)
            {
                return NotFound();
            }

            return Ok(retorno);
        }

        /// <summary>
        /// Traz um Usuario especifico.
        /// </summary>
        [HttpGet("ByID/{id}")]
        public ActionResult<IEnumerable<Usuario>> GetByID(int id)
        {
            var retorno = _service.GetByID(id);

            if (retorno == null)
            {
                return NotFound();
            }

            return Ok(retorno);
        }

        /// <summary>
        /// Cria um Usuario especifico.
        /// </summary>
        [HttpPost("Create")]
        public ActionResult<Usuario> Create([FromBody]Usuario usuario)
        {
            var retorno = _service.Create(usuario);

            if (retorno == null)
            {
                return NotFound();
            }

            return Ok(retorno);
        }

        /// <summary>
        /// Altera um Usuario especifico.
        /// </summary>
        [HttpPost("Update")]
        public ActionResult<Usuario> Update([FromBody] Usuario usuario)
        {
            var retorno = _service.Update(usuario);

            if (retorno == null)
            {
                return NotFound();
            }

            return Ok(retorno);
        }

        /// <summary>
        /// Deleta um Usuario especifico.
        /// </summary>
        [HttpDelete("Delete")]
        public ActionResult Delete([FromBody] int id)
        {
            var retorno = _service.Delete(id);

            if (retorno == false)
            {
                return BadRequest("Não foi possivel Apagar o Usuario Informado");
            }

            return Ok("Usuario Apagado");
        }
    }
}
