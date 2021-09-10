using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HS_BANK_ENTERPRISE.Models
{
    [Table("HS_USUARIO")]
    public class Usuario
    {
        [Key]
        [Column("ID_USUARIO")]
        public int idUsuario{ get; set; }
        [Column("DS_NOME")]
        public string nome { get; set; }
        [Column("DS_SOBRENOME")]
        public string sobrenome { get; set; }
        [Column("NR_IDADE")]
        public int idade { get; set; }
        [Column("NR_CPF")]
        public string cpf { get; set; }
        [Column("DT_NASCIMENTO")]
        public DateTime dtNascimento { get; set; }
    }
}
