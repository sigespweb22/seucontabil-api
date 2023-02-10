using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using BoxBack.Application.ViewModels.Navigation;

namespace BoxBack.Application.AppServices
{
    public class NavigationAppService
    {
        public NavigationAppService() {  }

        public async Task<IEnumerable<VerticalNavItemViewModel>> MyMenuAsync(string userId)
        {
            #region Required validations
            if (string.IsNullOrEmpty(userId))
                throw new ArgumentException("Id usuário requerido.");
            #endregion

            #region MENU Principal
            var menu = new List<VerticalNavItemViewModel>();
            #endregion

            #region MENU Dashboard
            var menuPailDashboard = new VerticalNavItemViewModel();
            menuPailDashboard = new VerticalNavItemViewModel
            {
                Title = "Dashboards",
                Icon = "HomeAnalytics",
                BadgeContent = "novo",
                BadgeColor = "primary",
                Children = new List<Son>()
            };
            menuPailDashboard.Children = new List<Son>();

            var menuFilhoDashboardPublica = new Son
            {
                Title = "Pública",
                Path = "/dashboards/publica",
                Action = "list",
                Subject = "ac-dashboard-publica-page"
            };
            menuPailDashboard.Children.Add(menuFilhoDashboardPublica);

            await Task.Run(() => menu.Add(menuPailDashboard));
            #endregion

            #region SESSÃO TÍTULO Sistema
            var moduloSistema = new VerticalNavItemViewModel
            {
                SectionTitle = "SYSTEM",
                Action = "list",
                Subject = "section-title-system"
            };

            await Task.Run(() => menu.Add(moduloSistema));
            #endregion

            #region MENU Controle Acesso
            var menuPaiControleAcesso = new VerticalNavItemViewModel
            {
                Title = "Controle Acesso",
                Icon = "TrackpadLock",
                BadgeContent = "",
                BadgeColor = "primary",
                Children = new List<Son>()
            };

            var menuFilhoUsuario = new Son
            {
                Title = "Usuários",
                Path = "/sistema/controle-acesso/usuario/list",
                Action = "list",
                Subject = "ac-user-page"
            };
            menuPaiControleAcesso.Children.Add(menuFilhoUsuario);

            var menuFilhoPermissao = new Son
            {
                Title = "Permissões",
                Path = "/sistema/controle-acesso/role/list",
                Action = "list",
                Subject = "ac-role-page"
            };
            menuPaiControleAcesso.Children.Add(menuFilhoPermissao);

            var menuFilhoGrupo = new Son
            {
                Title = "Grupos",
                Path = "/sistema/controle-acesso/grupo/list",
                Action = "list",
                Subject = "ac-group-page"
            };
            menuPaiControleAcesso.Children.Add(menuFilhoGrupo);

            await Task.Run(() => menu.Add(menuPaiControleAcesso));
            #endregion

            #region SESSÃO TÍTULO Negócios
            var moduloNegocios = new VerticalNavItemViewModel
            {
                SectionTitle = "BUSSINESS",
                Action = "list",
                Subject = "section-title-system"
            };

            await Task.Run(() => menu.Add(moduloNegocios));
            #endregion

            #region MENU Comercial
            var menuPaiComercial = new VerticalNavItemViewModel
            {
                BadgeContent = "",
                Title = "Comercial",
                Icon = "Domain",
                BadgeColor = "primary",
                Children = new List<Son>()
            };

            var menuFilhoCliente = new Son
            {
                Title = "Clientes",
                Path = "/negocios/comercial/cliente/list",
                Action = "list",
                Subject = "ac-cliente-page"
            };
            menuPaiComercial.Children.Add(menuFilhoCliente);

            await Task.Run(() => menu.Add(menuPaiComercial));
            #endregion
            
            #region SESSÃO TÍTULO Financeiro
            var moduloFinanceiro = new VerticalNavItemViewModel
            {
                SectionTitle = "FINANCEIRO",
                Action = "list",
                Subject = "section-title-financeiro"
            };

            await Task.Run(() => menu.Add(moduloFinanceiro));
            #endregion

            #region MENU Eventos
            var menuPaiEventos = new VerticalNavItemViewModel
            {
                BadgeContent = "",
                Title = "Eventos",
                Icon = "ClipboardListOutline",
                BadgeColor = "primary",
                Children = new List<Son>()
            };

            var menuFilhoEventosTodos = new Son
            {
                Title = "Todos",
                Path = "/financeiro/evento/list",
                Action = "list",
                Subject = "ac-evento-page"
            };
            menuPaiEventos.Children.Add(menuFilhoEventosTodos);

            await Task.Run(() => menu.Add(menuPaiEventos));
            #endregion

            #region MENU Despesas
            var menuPaiDespesas = new VerticalNavItemViewModel
            {
                BadgeContent = "",
                Title = "Despesas",
                Icon = "Cash",
                BadgeColor = "primary",
                Children = new List<Son>()
            };

            var menuFilhoTodas = new Son
            {
                Title = "Todas",
                Path = "/financeiro/despesa/list",
                Action = "list",
                Subject = "ac-despesa-page"
            };
            menuPaiDespesas.Children.Add(menuFilhoTodas);

            await Task.Run(() => menu.Add(menuPaiDespesas));
            #endregion

            return menu.ToList();
        }
    }
}