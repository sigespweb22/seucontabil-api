using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace BoxBack.Infra.Data.Migrations
{
    public partial class v10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateSequence<int>(
                name: "OrderNumbers");

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Subject = table.Column<string>(type: "text", nullable: true),
                    Actions = table.Column<int[]>(type: "integer[]", nullable: true),
                    Name = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tenants",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Cnpj = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    Nome = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    NomeExibicao = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    RazaoSocial = table.Column<string>(type: "text", nullable: true),
                    NomeFantasia = table.Column<string>(type: "text", nullable: true),
                    WhatsAppPrincipal = table.Column<string>(type: "text", nullable: true),
                    EmailPrincipal = table.Column<string>(type: "text", nullable: false),
                    ApiKey = table.Column<Guid>(type: "uuid", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    CreatedBy = table.Column<string>(type: "text", nullable: true),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    UpdatedBy = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tenants", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VerticalNavItems",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Icon = table.Column<string>(type: "text", nullable: true),
                    Path = table.Column<string>(type: "text", nullable: true),
                    Title = table.Column<string>(type: "text", nullable: true),
                    Action = table.Column<string>(type: "text", nullable: true),
                    Subject = table.Column<string>(type: "text", nullable: true),
                    Disabled = table.Column<bool>(type: "boolean", nullable: false),
                    BadgeContent = table.Column<string>(type: "text", nullable: true),
                    ExternalLink = table.Column<bool>(type: "boolean", nullable: false),
                    OpenInNewTab = table.Column<bool>(type: "boolean", nullable: false),
                    BadgeColor = table.Column<string>(type: "text", nullable: true),
                    SectionTitle = table.Column<string>(type: "text", nullable: true),
                    Position = table.Column<int>(type: "integer", nullable: false),
                    LevelMeKey = table.Column<Guid>(type: "uuid", nullable: false),
                    LevelUpKey = table.Column<Guid>(type: "uuid", nullable: false),
                    VerticalNavItemId = table.Column<Guid>(type: "uuid", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    CreatedBy = table.Column<string>(type: "text", nullable: true),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    UpdatedBy = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VerticalNavItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VerticalNavItems_VerticalNavItems_VerticalNavItemId",
                        column: x => x.VerticalNavItemId,
                        principalTable: "VerticalNavItems",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RoleId = table.Column<string>(type: "text", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetGroups",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    UniqueKey = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    CreatedBy = table.Column<string>(type: "text", nullable: true),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    UpdatedBy = table.Column<string>(type: "text", nullable: true),
                    TenantId = table.Column<Guid>(type: "uuid", nullable: false, defaultValue: new Guid("d8fe3845-3f2e-4b4e-aeb6-53222d60ff45"))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetGroups", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetGroups_Tenants_TenantId",
                        column: x => x.TenantId,
                        principalTable: "Tenants",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "text", nullable: false),
                    FullName = table.Column<string>(type: "text", nullable: true),
                    Avatar = table.Column<string>(type: "text", nullable: true),
                    Setor = table.Column<int>(type: "integer", nullable: false),
                    Funcao = table.Column<int>(type: "integer", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    Bio = table.Column<string>(type: "text", nullable: true),
                    DataAniversario = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    TelefoneCelular = table.Column<long>(type: "bigint", maxLength: 20, nullable: false, defaultValue: 99999999999L),
                    Genero = table.Column<int>(type: "integer", nullable: false),
                    TenantId = table.Column<Guid>(type: "uuid", nullable: false, defaultValue: new Guid("d8fe3845-3f2e-4b4e-aeb6-53222d60ff45")),
                    UserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: true),
                    SecurityStamp = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_Tenants_TenantId",
                        column: x => x.TenantId,
                        principalTable: "Tenants",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    NomeFantasia = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    RazaoSocial = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    InscricaoEstadual = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    CNPJ = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true),
                    TelefonePrincipal = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true),
                    EmailPrincipal = table.Column<string>(type: "text", nullable: true),
                    Observacao = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    DataFundacao = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    CodigoMunicipio = table.Column<int>(type: "integer", nullable: true),
                    Rua = table.Column<string>(type: "text", nullable: true, defaultValue: "500"),
                    Numero = table.Column<string>(type: "text", nullable: true, defaultValue: "5"),
                    Complemento = table.Column<string>(type: "text", nullable: true, defaultValue: "50"),
                    Cidade = table.Column<string>(type: "text", nullable: true, defaultValue: "255"),
                    Estado = table.Column<string>(type: "text", nullable: true, defaultValue: "4"),
                    Cep = table.Column<string>(type: "text", nullable: true, defaultValue: "20"),
                    Cpf = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true),
                    TipoPessoa = table.Column<int>(type: "integer", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    CreatedBy = table.Column<string>(type: "text", nullable: true),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    UpdatedBy = table.Column<string>(type: "text", nullable: true),
                    TenantId = table.Column<Guid>(type: "uuid", nullable: false, defaultValue: new Guid("d8fe3845-3f2e-4b4e-aeb6-53222d60ff45"))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Clientes_Tenants_TenantId",
                        column: x => x.TenantId,
                        principalTable: "Tenants",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleGroups",
                columns: table => new
                {
                    RoleId = table.Column<string>(type: "text", nullable: false),
                    GroupId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleGroups", x => new { x.RoleId, x.GroupId });
                    table.ForeignKey(
                        name: "FK_AspNetRoleGroups_AspNetGroups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "AspNetGroups",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AspNetRoleGroups_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<string>(type: "text", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserGroups",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "text", nullable: false),
                    GroupId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserGroups", x => new { x.UserId, x.GroupId });
                    table.ForeignKey(
                        name: "FK_AspNetUserGroups_AspNetGroups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "AspNetGroups",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AspNetUserGroups_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    ProviderKey = table.Column<string>(type: "text", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "text", nullable: true),
                    UserId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "text", nullable: false),
                    RoleId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "text", nullable: false),
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Value = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "Actions", "ConcurrencyStamp", "Description", "Name", "NormalizedName", "Subject" },
                values: new object[,]
                {
                    { "1081248d-f976-48cd-ad12-d1ab7a951d7f", new[] { 4 }, "6fb23e78-47ac-45b7-9c3b-c0de273cce3e", "Pode atualizar os dados de um grupo", "CanGroupUpdate", "CANGROUPUPDATE", "ac-group-page" },
                    { "1a86e3c7-ad7e-41cf-b439-dc1eb0f0db05", new[] { 1, 2, 3, 4, 5 }, "de1af80e-8e86-4c8a-ac9d-35f3fea433ed", "Pode visualizar todos os indicadores da dashboard comercial", "CanClienteAll", "CANCLIENTEALL", "ac-cliente-page" },
                    { "1f11b82d-8149-4b08-b910-d65b0cd1d9d8", new[] { 2 }, "b13a80ec-1716-4fe2-ab8a-4670d6a4116c", "Pode listar os dados de uma roles/permissão", "CanRoleRead", "CANROLEREAD", "ac-role-page" },
                    { "21299628-27c9-426e-b4f7-806d605f43d2", new[] { 5 }, "c523f829-dda5-4353-921d-807a769276c6", "Pode deletar um cliente", "CanClienteDelete", "CANCLIENTEDELETE", "ac-cliente-page" },
                    { "26513c23-87ec-444d-9c51-d663f5bfdd05", new[] { 1 }, "f7910baa-c623-4283-8f66-3a884348175b", "Pode listar os dados de todos os usuários", "CanUserList", "CANUSERLIST", "ac-user-page" },
                    { "2afcfacd-63e0-4c15-8594-be42fa39c325", new[] { 4 }, "d3e4db3c-c053-4fb4-b39e-688110d7a4d9", "Pode atualizar os dados de um usuário", "CanUserUpdate", "CANUSERUPDATE", "ac-user-page" },
                    { "3a0cd7e1-0d2f-4002-8202-19a6abe5c9f5", new[] { 2 }, "1da6dab7-9e90-409a-8911-4a0ab39449d6", "Pode listar os dado de um grupo", "CanGroupRead", "CANGROUPREAD", "ac-group-page" },
                    { "4b806712-9502-46f0-b4f6-5f9abc67b0cb", new[] { 1 }, "2c150d7f-214e-4829-84f2-ebd9942da543", "Pode listar os dados de todos os grupos", "CanGroupList", "CANGROUPLIST", "ac-group-page" },
                    { "528ba46c-0356-431e-a86e-6186955029a7", new[] { 1, 2, 3, 4, 5 }, "6ce9b0ec-ed92-498f-9a95-92dd87cd90f2", "Pode realizar todas as ações/operações em todas as dashboards", "CanDashboardAll", "CANDASHBOARDALL", "ac-dashboard-page" },
                    { "5b8cd6e6-cfdc-4516-b7cd-de831996ed25", new[] { 5 }, "4383f5bd-226f-4f1c-b32c-3d24da493221", "Pode deletar um grupo", "CanGroupDelete", "CANGROUPDELETE", "ac-group-page" },
                    { "6638e42f-6acc-4801-97bd-5865c61c2ee6", new[] { 1 }, "1ee600a9-d417-4d52-bbe1-914a35acddd2", "Pode listar os dados de todos os clientes", "CanClienteList", "CANCLIENTELIST", "ac-cliente-page" },
                    { "66751c3c-1ad9-47cd-bf7e-945b524a4dc1", new[] { 3 }, "00e242ca-9390-4219-bacc-e3508e787ebe", "Pode criar uma role/permissão", "CanRoleCreate", "CANROLECREATE", "ac-role-page" },
                    { "68eec4dc-0a76-4aa1-98a3-1dcc7ffa2d39", new[] { 5 }, "5762ad6e-8cb6-4f3f-a713-8188b9109f67", "Pode deletar um usuário", "CanUserDelete", "CANUSERDELETE", "ac-user-page" },
                    { "690b1860-2708-46b9-b910-014509f884dc", new[] { 2 }, "6a49d83c-f92d-4a23-a3fb-396d98eac331", "Pode listar os dados de um usuários", "CanUserRead", "CANUSERREAD", "ac-user-page" },
                    { "82657fa4-7f23-4e09-ba61-24f1894f0770", new[] { 2 }, "334af10d-6705-435b-a691-7d8e4bffad4a", "Pode listar os dado de um cliente", "CanClienteRead", "CANCLIENTEREAD", "ac-cliente-page" },
                    { "8af80ad7-8a34-467c-a6e2-f451c813883b", new[] { 4 }, "0dce96a4-9b4c-4d0e-81d5-7aebb95a0e19", "Pode atualizar os dados de uma roles/permissão", "CanRoleUpdate", "CANROLEUPDATE", "ac-role-page" },
                    { "8d64ee64-22ab-44a4-b1df-67382b289895", new[] { 3 }, "4c095b63-0897-4835-80dc-9594df3135e4", "Pode criar um usuário", "CanUserCreate", "CANUSERCREATE", "ac-user-page" },
                    { "9019b807-c03d-49c8-b3eb-1a0520e7a272", new[] { 1, 2, 3, 4, 5 }, "3afb76d5-f3a0-4fa5-b9b0-85f110f32d6c", "Pode realizar todas as ações/operações em todos os usuários", "CanUserAll", "CANUSERALL", "ac-user-page" },
                    { "942c0974-2f70-4c4d-83a7-5693004cb6f6", new[] { 5 }, "1bba5282-2801-4b5d-a20e-9e27cfcfe1bb", "Pode deletar uma role/permissão", "CanRoleDelete", "CANROLEDELETE", "ac-role-page" },
                    { "a38cf126-fd07-44e0-88e3-ca6b78181b30", new[] { 1, 2, 3, 4, 5 }, "8cda94c6-7f92-48e6-b0d5-fcfd0d43f6b1", "Pode realizar todas as ações/operações em todos os grupos", "CanGroupAll", "CANGROUPALL", "ac-group-page" },
                    { "b0f96d85-3647-4651-9f78-b7529b577ec0", new[] { 0 }, "4629cea3-3b65-43b9-9c4e-7cc68fe4e4e4", "Pode realizar todas as ações/operações, bem como ter acesso a todos os dados e funcionalidades", "Master", "MASTER", "all" },
                    { "b1094847-33fe-4872-b694-c7fc9c9ac3cb", new[] { 1, 2, 3, 4, 5 }, "0a2476c9-276c-44a4-900f-844b25ac3582", "Pode realizar todas as ações/operações em dashboard publica", "CanDashboardPublicaAll", "CANDASHBOARDPUBLICAALL", "ac-dashboardPublica-page" },
                    { "bd012c34-165e-4159-acec-0d1de4dbde51", new[] { 3 }, "4a08bdd6-8cf1-455e-b35e-397ac3c268a8", "Pode criar um grupo", "CanGroupCreate", "CANGROUPCREATE", "ac-group-page" },
                    { "c8323299-a311-43fa-804f-deed0c202bb0", new[] { 4 }, "e9ddb4f6-5c4f-440e-b530-d5fba5dce521", "Pode atualizar os dados de um cliente", "CanClienteUpdate", "CANCLIENTEUPDATE", "ac-cliente-page" },
                    { "d2fbac7c-7502-4004-8aa2-686812ee8022", new[] { 3 }, "0b50b786-77c9-4372-a7c1-24457c7f2aac", "Pode criar um cliente", "CanClienteCreate", "CANCLIENTECREATE", "ac-cliente-page" },
                    { "dda1ef7c-c033-4822-bfac-300788a30538", new[] { 1 }, "d5fae5df-68be-41eb-a13d-dd8639bc5daf", "Pode listar o título do sistema", "CanTitleSystemList", "CANTITLESYSTEMLIST", "ac-titleSystem-page" },
                    { "f27e0f7c-ef53-4f93-bcd5-c195d0cd0cfd", new[] { 1 }, "e50ce833-94b4-44f9-8671-f4cc52c43839", "Pode listar os dados de todas as roles/permissões", "CanRoleList", "CANROLELIST", "ac-role-page" },
                    { "fe0e455f-7e3d-45f6-b6de-a0cd37215209", new[] { 1, 2, 3, 4, 5 }, "6f259a74-1b49-4f0f-87b0-8449cbcb1ba4", "Pode realizar todas as ações/operações em todos as roles/permissões", "CanRoleAll", "CANROLEALL", "ac-role-page" },
                    { "fe8b1c90-8d16-414f-a749-daff85a61f07", new[] { 1 }, "45a40863-9f17-4c45-9c93-69cee1aa6031", "Pode listar o título dos negócios", "CanTitleBussinesList", "CANTITLEBUSSINESLIST", "ac-titleBussines-page" }
                });

            migrationBuilder.InsertData(
                table: "Tenants",
                columns: new[] { "Id", "ApiKey", "Cnpj", "CreatedAt", "CreatedBy", "EmailPrincipal", "IsDeleted", "Nome", "NomeExibicao", "NomeFantasia", "RazaoSocial", "UpdatedAt", "UpdatedBy", "WhatsAppPrincipal" },
                values: new object[] { new Guid("d8fe3845-3f2e-4b4e-aeb6-53222d60ff45"), new Guid("57d390e7-2b87-47fe-9bc8-0bae3a388499"), "27.195.267/0001-38", new DateTimeOffset(new DateTime(2023, 2, 1, 8, 56, 14, 936, DateTimeKind.Unspecified).AddTicks(990), new TimeSpan(0, -3, 0, 0, 0)), "8e445865-a24d-4543-a6c6-9443d048cdb9", "tiago@rossokurtz.com.br", false, "Rosso e Kurtz Contadores Associados", "Rosso e Kurtz", null, null, new DateTimeOffset(new DateTime(2023, 2, 1, 8, 56, 14, 936, DateTimeKind.Unspecified).AddTicks(1014), new TimeSpan(0, -3, 0, 0, 0)), "8e445865-a24d-4543-a6c6-9443d048cdb9", null });

            migrationBuilder.InsertData(
                table: "AspNetGroups",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsDeleted", "Name", "TenantId", "UniqueKey", "UpdatedAt", "UpdatedBy" },
                values: new object[] { new Guid("23e63d9c-283b-496b-b7d8-7dac2ef7a822"), new DateTimeOffset(new DateTime(2023, 2, 1, 8, 56, 14, 937, DateTimeKind.Unspecified).AddTicks(2556), new TimeSpan(0, -3, 0, 0, 0)), "8e445865-a24d-4543-a6c6-9443d048cdb9", false, "Master", new Guid("d8fe3845-3f2e-4b4e-aeb6-53222d60ff45"), "ors0eAr4DPkvrwhy5gVnQAqRDnJUO43j9HzbkPyZ/7Q=", new DateTimeOffset(new DateTime(2023, 2, 1, 8, 56, 14, 937, DateTimeKind.Unspecified).AddTicks(2566), new TimeSpan(0, -3, 0, 0, 0)), "8e445865-a24d-4543-a6c6-9443d048cdb9" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "UserId", "AccessFailedCount", "Avatar", "Bio", "ConcurrencyStamp", "DataAniversario", "Email", "EmailConfirmed", "FullName", "Funcao", "Genero", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Setor", "Status", "TenantId", "TwoFactorEnabled", "UserName" },
                values: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 0, "", null, "ca431822-360a-4ee6-b978-66564d429fc7", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alan.rezendeeee@hotmail.com", true, "ALAN LEITE DE REZENDE", 0, 0, false, null, "ALAN.REZENDEEEE@HOTMAIL.COM", "ALAN.REZENDEEEE@HOTMAIL.COM", "AQAAAAEAACcQAAAAEFGbgHKOKiDDs5fvXN8kHviorntHToMKurnVJNmsFQNInxhQOyZTwJ2w0SpbyCdZbA==", null, false, "c9514850-61dd-4cc1-b909-88b79b035643", 0, 0, new Guid("d8fe3845-3f2e-4b4e-aeb6-53222d60ff45"), false, "alan.rezendeeee@hotmail.com" });

            migrationBuilder.InsertData(
                table: "AspNetRoleGroups",
                columns: new[] { "GroupId", "RoleId" },
                values: new object[] { new Guid("23e63d9c-283b-496b-b7d8-7dac2ef7a822"), "b0f96d85-3647-4651-9f78-b7529b577ec0" });

            migrationBuilder.InsertData(
                table: "AspNetUserGroups",
                columns: new[] { "GroupId", "UserId" },
                values: new object[] { new Guid("23e63d9c-283b-496b-b7d8-7dac2ef7a822"), "8e445865-a24d-4543-a6c6-9443d048cdb9" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "b0f96d85-3647-4651-9f78-b7529b577ec0", "8e445865-a24d-4543-a6c6-9443d048cdb9" });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetGroups_TenantId",
                table: "AspNetGroups",
                column: "TenantId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleGroups_GroupId",
                table: "AspNetRoleGroups",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserGroups_GroupId",
                table: "AspNetUserGroups",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_TenantId",
                table: "AspNetUsers",
                column: "TenantId");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_CNPJ",
                table: "Clientes",
                column: "CNPJ",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_Cpf",
                table: "Clientes",
                column: "Cpf",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_TenantId",
                table: "Clientes",
                column: "TenantId");

            migrationBuilder.CreateIndex(
                name: "IX_Tenants_ApiKey",
                table: "Tenants",
                column: "ApiKey",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tenants_Cnpj",
                table: "Tenants",
                column: "Cnpj",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_VerticalNavItems_VerticalNavItemId",
                table: "VerticalNavItems",
                column: "VerticalNavItemId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetRoleGroups");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserGroups");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "VerticalNavItems");

            migrationBuilder.DropTable(
                name: "AspNetGroups");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Tenants");

            migrationBuilder.DropSequence(
                name: "OrderNumbers");
        }
    }
}
