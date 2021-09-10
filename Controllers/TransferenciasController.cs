using HS_BANK_ENTERPRISE.Models;
using HS_BANK_ENTERPRISE.Services.Transferencias;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HS_BANK_ENTERPRISE.Controllers
{
    [ApiController]
    [Route("api/v1/[Controller]")]
    public class TransferenciasController : ControllerBase
    {
        private readonly ITransferenciasService _transferenciasService;

        public TransferenciasController(ITransferenciasService transferenciasService)
        {
            _transferenciasService = transferenciasService;
        }

        /// <summary>
        /// Traz todas as Movimentações Registradas.
        /// </summary>
        [HttpGet("ReadAll")]
        public ActionResult<IEnumerable<Movimentacao>> Get()
        {
            var retorno = _transferenciasService.Get();

            if (retorno == null)
            {
                return NotFound();
            }

            return Ok(retorno);

        }

        /// <summary>
        /// Traz as Movimentações Registradas por uma conta Origem Especifica.
        /// </summary>
        [HttpGet("ReadById/{numeroConta}")]
        public ActionResult<IEnumerable<Movimentacao>> GetByID(int numeroConta)
        {
            var retorno = _transferenciasService.GetMovimentacoesByConta(numeroConta);
            if (retorno == null)
            {
                return NotFound();
            }

            return Ok(retorno);

        }

        /// <summary>
        /// Cria uma nova Movimentação.
        /// </summary>
        [HttpPost("Create")]
        public ActionResult<Movimentacao> Create(Movimentacao movimentacao)
        {
            var retorno = _transferenciasService.Create(movimentacao);
            if (retorno == null)
            {
                return NotFound();
            }

            return Ok(retorno);

        }
    }
}
