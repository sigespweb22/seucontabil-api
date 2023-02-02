using System.Linq;
using AutoMapper;
using BoxBack.Application.ViewModels;
using BoxBack.Domain.Models;
using BoxBack.Application.ViewModels.Selects;

namespace BoxBack.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<ApplicationUserGroup, ApplicationUserGroupViewModel>()
                .ForMember(dst => dst.Name, src => src.MapFrom(x => x.ApplicationGroup.Name));
            CreateMap<ApplicationUser, ApplicationUserViewModel>()
                .ForMember(dst => dst.Email, src => src.MapFrom(x => x.Email))
                .ForMember(dst => dst.FullName, src => src.MapFrom(x => x.FullName))
                .ForMember(dst => dst.UserName, src => src.MapFrom(x => x.UserName))
                .ForMember(dst => dst.Avatar, src => src.MapFrom(x => x.Avatar))
                .ForMember(dst => dst.ApplicationUserGroups, src => src.MapFrom(x => x.ApplicationUserGroups));
            CreateMap<ApplicationRole, ApplicationRoleViewModel>();
            CreateMap<ApplicationGroup, ApplicationGroupViewModel>()
                .ForMember(dst => dst.Status, src => src.MapFrom(x => x.IsDeleted ? "INACTIVE" : "ACTIVE"))
                .ForMember(dst => dst.ApplicationRoleGroupsNames, src => src.MapFrom(x => x.ApplicationRoleGroups.Select(x => x.ApplicationRole.Name)));
            CreateMap<ApplicationGroup, ApplicationGroupUpdateViewModel>();
            CreateMap<Cliente, ClienteViewModel>()
                .ForMember(dst => dst.Status, src => src.MapFrom(x => x.IsDeleted ? "INACTIVE" : "ACTIVE"));
            CreateMap<ApplicationGroup, ApplicationGroupSelect2ViewModel>()
                .ForMember(dst => dst.Name, src => src.MapFrom(x => x.Name))
                .ForMember(dst => dst.GroupId, src => src.MapFrom(x => x.Id));
            CreateMap<ApplicationRoleGroup, ApplicationRoleGroupUpdateViewModel>();
            CreateMap<ApplicationRoleGroup, ApplicationRoleGroupViewModel>()
                .ForMember(dst => dst.Name, src => src.MapFrom(x => x.ApplicationRole.Name));;
            CreateMap<ApplicationRole, ApplicationRoleSelect2ViewModel>()
                .ForMember(dst => dst.Name, src => src.MapFrom(x => x.Name))
                .ForMember(dst => dst.RoleId, src => src.MapFrom(x => x.Id));
            CreateMap<ApplicationUser, UsuarioContaViewModel>()
                .ForMember(dst => dst.ApplicationUserGroups, src => src.MapFrom(x => x.ApplicationUserGroups));
            CreateMap<ApplicationUser, UsuarioInfoViewModel>();
            CreateMap<Despesa, DespesaViewModel>()
                .ForMember(dst => dst.Status, src => src.MapFrom(x => x.IsDeleted ?  "INACTIVE" : "ACTIVE"));
        }
    }
}