using System.ComponentModel.DataAnnotations.Schema;
using BoxBack.Domain.Enums;
using System.Collections.Generic;

namespace BoxBack.Domain.Models
{
    public class Pessoa : EntityAuditTenant
    {        
        public Pessoa(string nomeFantasia, TipoPessoaEnum tipoPessoa)
        {
            NomeFantasia = nomeFantasia;
            TipoPessoa = tipoPessoa;
        }

        // Constructor empty for EF
        public Pessoa() {}

        public string NomeFantasia { get; set; }
        public TipoPessoaEnum? TipoPessoa { get; set; }


        // Relationships
        [ForeignKey("TenantId")]
        public Tenant Tenant { get; set; }

        public ICollection<Despesa> Despesas { get; set; }
    }
}
