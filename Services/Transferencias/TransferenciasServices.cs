using HS_BANK_ENTERPRISE.Database;
using HS_BANK_ENTERPRISE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HS_BANK_ENTERPRISE.Services.Transferencias
{
    public class TransferenciasServices : ITransferenciasService
    {
        private readonly Context _Context;
        public TransferenciasServices(Context context)
        {
            _Context = context;

        }

        public Movimentacao Create(Movimentacao movimentacao)
        {
            _Context.Movimentacao.Add(movimentacao);
            
            var contaOrigem = _Context.Conta.Where(x => x.idConta == movimentacao.idContaOrigem).FirstOrDefault();
            contaOrigem.vlSaldoBitcoin -= movimentacao.vlTransferidoBitcoin;
            contaOrigem.vlSaldoDogecoin -= movimentacao.vlTransferidoDogecoin;
            contaOrigem.vlSaldoDolar -= movimentacao.vlTransferidoDolar;
            contaOrigem.vlSaldoReal -= movimentacao.vlTransferidoReal;

            _Context.Conta.Update(contaOrigem);
            var contaDestino = _Context.Conta.Where(x => x.idConta == movimentacao.idContaDestino).FirstOrDefault();
            contaDestino.vlSaldoBitcoin += movimentacao.vlTransferidoBitcoin;
            contaDestino.vlSaldoDogecoin += movimentacao.vlTransferidoDogecoin;
            contaDestino.vlSaldoDolar += movimentacao.vlTransferidoDolar;
            contaDestino.vlSaldoReal += movimentacao.vlTransferidoReal;

            _Context.Conta.Update(contaDestino);
            
            _Context.SaveChanges();

            return movimentacao;
        }
        public IEnumerable<Movimentacao> Get()
        {
            var retorno = _Context.Movimentacao.ToList();

            if (retorno == null)
            {
                return null;
            }

            return retorno;
        }
        public Movimentacao GetMovimentacaoByID(int id)
        {
            var retorno = _Context.Movimentacao.Where(x => x.idMovimentacao == id).FirstOrDefault();

            if (retorno == null)
            {
                return null;
            }

            return retorno;
        }

        public IEnumerable<Movimentacao> GetMovimentacoesByConta(int id)
        {
            var retorno = _Context.Movimentacao.Where(x => x.idContaOrigem == id).ToList();

            if (retorno == null)
            {
                return null;
            }

            return retorno;
        }
    }
}
