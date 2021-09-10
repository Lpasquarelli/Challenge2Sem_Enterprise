using HS_BANK_ENTERPRISE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HS_BANK_ENTERPRISE.Services.Transferencias
{
    public interface ITransferenciasService
    {
        public IEnumerable<Movimentacao> GetMovimentacoesByConta(int id);
        public Movimentacao Create(Movimentacao movimentacao);
        public IEnumerable<Movimentacao> Get();
    }
}
