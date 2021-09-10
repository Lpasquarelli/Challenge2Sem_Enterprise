using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
namespace HS_BANK_ENTERPRISE.Models
{
    [Table("HS_MOVIMENTACOES")]
    public class Movimentacao
    {
        [Key]
        [Column("ID_MOVIMENTACOES")]
        public int idMovimentacao { get; set; }
        [Column("ID_CONTA_ORIGEM")]
        public int idContaOrigem { get; set; }
        [Column("ID_CONTA_DESTINO")]
        public int idContaDestino { get; set; }
        [Column("VL_TRANSFERIDOREAL")]
        public decimal vlTransferidoReal { get; set; }
        [Column("VL_TRANSFERIDODOLAR")]
        public decimal vlTransferidoDolar { get; set; }
        [Column("VL_TRANSFERIDOBITCOIN")]
        public decimal vlTransferidoBitcoin { get; set; }
        [Column("VL_TRANSFERIDODOGECOIN")]
        public decimal vlTransferidoDogecoin { get; set; }
    }
}
