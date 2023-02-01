using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using BoxBack.Domain.Helpers;

namespace BoxBack.Domain.Enums
{
    // Define an extension method in a non-nested static class.
    public static class Extensions
    {
        public static string GetDescription(this PermissionEnum pe)
        {
            return EnumHelper.GetDescription(pe);
        }

        public static List<string> GetNames()
        {
            return EnumHelper.GetNames<PermissionEnum>().ToList();
        }
    }

    public enum PermissionEnum
    {
        #region Master
        [Description("Pode realizar todas as ações/operações, bem como ter acesso a todos os dados e funcionalidades")]
        Master = 0,
        #endregion

        #region Dashboard
        [Description("Pode realizar todas as ações/operações em todas as dashboards")]
        CanDashboardAll = 1,
        [Description("Pode visualizar todas as dashboards do cliente")]
        CanDashboardClienteAll = 2,
        [Description("Pode visualizar todas as dashboards de controle de acesso")]
        CanDashboardControleAcessoAll = 3,
        #endregion

        #region Dashboard Publica
        [Description("Pode realizar todas as ações/operações em dashboard publica")]
        CanDashboardPublicaAll = 4,
        CanDashboardPublicaClienteContratoList = 5,
        #endregion

        #region Usuário
        [Description("Pode realizar todas as ações/operações em todos os usuários")]
        CanUserAll = 101,
        [Description("Pode listar os dados de todos os usuários")]
        CanUserList = 102,
        [Description("Pode listar os dados de um usuários")]
        CanUserRead = 103,
        [Description("Pode criar um usuário")]
        CanUserCreate = 104,
        [Description("Pode atualizar os dados de um usuário")]
        CanUserUpdate = 105,
        [Description("Pode deletar um usuário")]
        CanUserDelete = 106,
        #endregion

        #region Roles (Permissões)
        [Description("Pode realizar todas as ações/operações em todos as roles/permissões")]
        CanRoleAll = 200,
        [Description("Pode listar os dados de todas as roles/permissões")]
        CanRoleList = 201,
        [Description("Pode listar os dados de uma roles/permissão")]
        CanRoleRead = 202,
        [Description("Pode criar uma role/permissão")]
        CanRoleCreate = 203,
        [Description("Pode atualizar os dados de uma roles/permissão")]
        CanRoleUpdate = 204,
        [Description("Pode deletar uma role/permissão")]
        CanRoleDelete = 205,
        #endregion

        #region Grupo de usuários
        [Description("Pode realizar todas as ações/operações em todos os grupos")]
        CanGroupAll = 300,
        [Description("Pode listar os dados de todos os grupos")]
        CanGroupList = 301,
        [Description("Pode listar os dado de um grupo")]
        CanGroupRead = 302,
        [Description("Pode criar um grupo")]
        CanGroupCreate = 303,
        [Description("Pode atualizar os dados de um grupo")]
        CanGroupUpdate = 304,
        [Description("Pode deletar um grupo")]
        CanGroupDelete = 305,
        #endregion

        #region Cliente
        [Description("Pode visualizar todos os indicadores da dashboard comercial")]
        CanClienteAll = 400,
        [Description("Pode listar os dados de todos os clientes")]
        CanClienteList = 401,
        [Description("Pode listar os dado de um cliente")]
        CanClienteRead = 402,
        [Description("Pode criar um cliente")]
        CanClienteCreate = 403,
        [Description("Pode atualizar os dados de um cliente")]
        CanClienteUpdate = 404,
        [Description("Pode deletar um cliente")]
        CanClienteDelete = 405,
        #endregion

        #region Title
        [Description("Pode listar o título do sistema")]
        CanTitleSystemList = 500,
        [Description("Pode listar o título dos negócios")]
        CanTitleBussinesList = 501
        #endregion
    }
}