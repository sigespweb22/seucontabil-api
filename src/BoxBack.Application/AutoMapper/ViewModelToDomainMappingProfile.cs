using System;
using System.Linq;
using AutoMapper;
using BoxBack.Application.ViewModels;
using BoxBack.Domain.Models;
using BoxBack.Domain.ModelsServices;

namespace BoxBack.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<ApplicationUserGroupViewModel, ApplicationUserGroup>();
            CreateMap<ApplicationUserGroupUpdateViewModel, ApplicationUserGroup>();
            CreateMap<ApplicationUserViewModel, ApplicationUserGroup>()
                .ForMember(dst => dst.UserId, src => src.MapFrom(x => x.Id));
            CreateMap<ApplicationUserViewModel, ApplicationUser>()
                .ForMember(dst => dst.ApplicationUserGroups, src => src.MapFrom(x => x.ApplicationUserGroups))
                .ForMember(dst => dst.UserName, src => src.MapFrom(x => x.Email))
                .ForMember(dst => dst.NormalizedUserName, src => src.MapFrom(x => x.Email.ToUpper()))
                .ForMember(dst => dst.NormalizedEmail, src => src.MapFrom(x => x.Email.ToUpper()))
                .ForMember(dst => dst.EmailConfirmed, src => src.MapFrom(x => x.EmailConfirmed))
                .ForMember(dst => dst.LockoutEnabled, src => src.MapFrom(x => x.LockoutEnabled))
                .ForMember(dst => dst.Avatar, src => src.MapFrom(x => x.Avatar))
                .ForMember(dst => dst.Status, src => src.MapFrom(x => x.Status));
            CreateMap<ApplicationUserUpdateViewModel, ApplicationUserGroup>()
                .ForMember(dst => dst.UserId, src => src.MapFrom(x => x.Id));
            CreateMap<ApplicationUserUpdateViewModel, ApplicationUser>()
                .ForMember(dst => dst.ApplicationUserGroups, src => src.MapFrom(x => x.ApplicationUserGroups))
                .ForMember(dst => dst.UserName, src => src.MapFrom(x => x.Email))
                .ForMember(dst => dst.NormalizedUserName, src => src.MapFrom(x => x.Email.ToUpper()))
                .ForMember(dst => dst.NormalizedEmail, src => src.MapFrom(x => x.Email.ToUpper()))
                .ForMember(dst => dst.EmailConfirmed, src => src.MapFrom(x => x.EmailConfirmed))
                .ForMember(dst => dst.LockoutEnabled, src => src.MapFrom(x => x.LockoutEnabled))
                .ForMember(dst => dst.Avatar, src => src.MapFrom(x => x.Avatar))
                .ForMember(dst => dst.Status, src => src.MapFrom(x => x.Status));
            CreateMap<ApplicationRoleViewModel, ApplicationRole>();
            CreateMap<ApplicationGroupViewModel, ApplicationGroup>();
            CreateMap<ApplicationGroupUpdateViewModel, ApplicationGroup>();
            CreateMap<ApplicationRoleGroupUpdateViewModel, ApplicationRoleGroup>();
            CreateMap<ApplicationRoleGroupViewModel, ApplicationRoleGroup>();
            CreateMap<ApplicationRoleViewModel, ApplicationRole>();
            CreateMap<ClienteViewModel, Cliente>();
            CreateMap<UsuarioContaViewModel, ApplicationUser>();
            CreateMap<UsuarioInfoViewModel, ApplicationUser>();
            CreateMap<BCClienteModelService, Cliente>()
               .ForMember(dst => dst.Id,  src => src.MapFrom(x => Guid.NewGuid()))
               .ForMember(dst => dst.TipoPessoa,  src => src.MapFrom(x => x.TipoPessoa == null ? null : x.TipoPessoa))
               .ForMember(dst => dst.NomeFantasia,  src =>
                                                    src.MapFrom(x => x.PessoaFisica == null ? x.PessoaJuridica.NomeFantasia : x.PessoaFisica.Nome))
               .ForMember(dst => dst.RazaoSocial,  src =>
                                                   src.MapFrom(x => x.PessoaFisica == null ? x.PessoaJuridica.RazaoSocial : x.PessoaFisica.Nome))
               .ForMember(dst => dst.InscricaoEstadual,  src => 
                                                         src.MapFrom(x => x.PessoaJuridica.InscricaoEstadual == null ? null : x.PessoaJuridica.InscricaoEstadual))
               .ForMember(dst => dst.CNPJ,  src => src.MapFrom(x => x.PessoaJuridica.Documento == null ? null : x.PessoaJuridica.Documento))
               .ForMember(dst => dst.TelefonePrincipal,  src => src.MapFrom(x => x.Contatos.Count() <= 0 ? null : x.Contatos.Select(x => x.Telefone).FirstOrDefault()))
               .ForMember(dst => dst.EmailPrincipal, src => src.MapFrom(x => x.Contatos.Count() <= 0 ? null : x.Contatos.Select(x => x.Email).FirstOrDefault()))
               .ForMember(dst => dst.Rua, src => src.MapFrom(x => x.Endereco == null ? null : x.Endereco.Logradouro))
               .ForMember(dst => dst.Numero, src => src.MapFrom(x => x.Endereco == null ? null : x.Endereco.Numero == null ? null : x.Endereco.Numero))
               .ForMember(dst => dst.Complemento, src => src.MapFrom(x => x.Endereco == null ? null : x.Endereco.Logradouro == null ? null : x.Endereco.Complemento))
               .ForMember(dst => dst.Cidade, src => src.MapFrom(x => x.Endereco == null ? null : x.Endereco.Cidade == null ? null : x.Endereco.Cidade))
               .ForMember(dst => dst.Estado, src => src.MapFrom(x => x.Endereco == null ? null : x.Endereco.Uf == null ? null : x.Endereco.Uf))
               .ForMember(dst => dst.Cep, src => src.MapFrom(x => x.Endereco == null ? null : x.Endereco.Cep == null ? null : x.Endereco.Cep))
               .ForMember(dst => dst.Cpf, src => src.MapFrom(x => x.PessoaJuridica == null ? x.PessoaFisica.Documento == null ? null : x.PessoaFisica.Documento : null));
            CreateMap<DespesaViewModel, Despesa>()
                .ForMember(dest => dest.SistemaParcelamento, opt => opt.MapFrom(src => 
                                                                    string.IsNullOrEmpty(src.SistemaParcelamento) ? default(string) : src.SistemaParcelamento))
                .ForMember(dest => dest.DataOperacao, opt => opt.Condition((src, dest, srcValue) => {
                    var dateValue = (DateTimeOffset?)srcValue;
                    return dateValue.HasValue;
                }))
                .ForMember(dest => dest.ValorPrincipal, opt => opt.MapFrom(src => src.ValorPrincipal.Equals(0) ? default(decimal?) : src.ValorPrincipal))
                .ForMember(dest => dest.ValorPrincipal, opt => opt.MapFrom(src => src.ValorEntrada.Equals(0) ? default(decimal?) : src.ValorEntrada))
                .ForMember(dest => dest.Iof, opt => opt.MapFrom(src => src.Iof.Equals(0) ? default(decimal?) : src.ValorEntrada))
                .ForMember(dest => dest.Seguro, opt => opt.MapFrom(src => src.Seguro.Equals(0) ? default(decimal?) : src.Seguro))
                .ForMember(dest => dest.Tarifa, opt => opt.MapFrom(src => src.
                Tarifa.Equals(0) ? default(decimal?) : src.Tarifa))
                .ForMember(dest => dest.CustoEfetivoTotalAno, opt => opt.MapFrom(src => src.CustoEfetivoTotalAno.Equals(0) ? default(decimal?) : src.CustoEfetivoTotalAno))
                .ForMember(dest => dest.CustoEfetivoTotalMes, opt => opt.MapFrom(src => src.CustoEfetivoTotalMes.Equals(0) ? default(decimal?) : src.CustoEfetivoTotalMes))
                .ForMember(dest => dest.CustoEfetivoTotalDia, opt => opt.MapFrom(src => src.CustoEfetivoTotalDia.Equals(0) ? default(decimal?) : src.CustoEfetivoTotalDia))
                .ForMember(dest => dest.TotalParcelas, opt => opt.MapFrom(src => src.TotalParcelas.Equals(0) ? default(decimal?) : src.TotalParcelas))
                .ForMember(dest => dest.ClienteId, opt => opt.MapFrom(src => src.Cliente.Id))
                .ForMember(dest => dest.PessoaId, opt => opt.MapFrom(src => src.Pessoa.Id))
                .ForMember(dest => dest.Cliente, opt => opt.Ignore())
                .ForMember(dest => dest.Pessoa, opt => opt.Ignore());
            CreateMap<DespesaParcelaViewModel, DespesaParcela>();
        }
    }
}