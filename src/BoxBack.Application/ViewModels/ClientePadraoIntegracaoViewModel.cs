using System;
using System.Collections.Generic;


namespace BoxBack.Application.ViewModels
{
    public class ClientePadraoIntegracaoViewModel
    {
        public Guid? Id { get; set; }

        public string NomeFantasia { get; set; }
        public string CNPJ { get; set; }
        public string Cpf { get; set; }
        public string RazaoSocial { get; set; }
        public string CreatedAt { get; set; }
        public string UpdatedAt { get; set; }

        public ICollection<ClienteContratoPadraoIntegracaoViewModel> Contratos { get; set; }
    }
}