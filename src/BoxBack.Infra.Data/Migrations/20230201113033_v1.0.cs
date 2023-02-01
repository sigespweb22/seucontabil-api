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
                    { "01b8e3d0-abfb-436f-abdd-43028caf5e3c", new[] { 1, 2, 3, 4, 5 }, "fa6fa449-decc-490a-ac2e-95ab9a6d2023", "Pode realizar todas as ações/operações em todos os grupos", "CanGroupAll", "CANGROUPALL", "ac-group-page" },
                    { "0ebcb26e-978a-4871-a8a0-2c344a1e8450", new[] { 5 }, "4af7e282-ef37-4856-af0c-d7c268bf76cd", "Pode deletar um grupo", "CanGroupDelete", "CANGROUPDELETE", "ac-group-page" },
                    { "1494bf4f-fb40-4a69-9e83-c1cda1911598", new[] { 1 }, "46163539-6286-4ffa-a63d-e325c7a74108", "Pode listar os dados de todos os clientes", "CanClienteList", "CANCLIENTELIST", "ac-cliente-page" },
                    { "16ff5dd9-06d0-483b-8a69-126a3f91b8f2", new[] { 1, 2, 3, 4, 5 }, "62637350-2c77-418e-8e94-10c8b332f854", "Pode visualizar todos os indicadores da dashboard comercial", "CanClienteAll", "CANCLIENTEALL", "ac-cliente-page" },
                    { "182fdb11-cd82-4b79-a976-87dbfc9c6975", new[] { 1 }, "7ed057b4-3a2a-44d5-bc9c-ccdf4a54be62", "Pode listar os dados de todos os grupos", "CanGroupList", "CANGROUPLIST", "ac-group-page" },
                    { "191b5a76-c90d-42c8-963e-c58da20cc4ab", new[] { 1, 2, 3, 4, 5 }, "15408c0f-6613-43a0-a31a-f9181411aaa4", "Pode realizar todas as ações/operações em dashboard publica", "CanDashboardPublicaAll", "CANDASHBOARDPUBLICAALL", "ac-dashboardPublica-page" },
                    { "24ad1afd-f54f-49c5-b0db-32b0553a1b70", new[] { 4 }, "033468dc-6116-46b3-a683-14d801a0876b", "Pode atualizar os dados de um grupo", "CanGroupUpdate", "CANGROUPUPDATE", "ac-group-page" },
                    { "30d2dc11-60ae-4316-a3df-fee08e1be225", new[] { 1, 2, 3, 4, 5 }, "9bf277cb-38d1-4c87-9eff-b2dc222057dd", "Pode realizar todas as ações/operações em todos as roles/permissões", "CanRoleAll", "CANROLEALL", "ac-role-page" },
                    { "3a0de3b8-3d69-4a48-991f-20ded951df60", new[] { 1 }, "6af82471-1e1e-499a-86d8-b6cc63b39a3c", "Pode listar os dados de todos os usuários", "CanUserList", "CANUSERLIST", "ac-user-page" },
                    { "3dc6ec2b-5f14-40cf-a633-63a9bbb6f4db", new[] { 4 }, "400a636a-3017-4b41-a4b6-49baef0f0555", "Pode atualizar os dados de uma roles/permissão", "CanRoleUpdate", "CANROLEUPDATE", "ac-role-page" },
                    { "4952a4db-f856-443d-b8f3-68525177515b", new[] { 5 }, "786e12fb-1721-4679-b15b-f3221be4bead", "Pode deletar um cliente", "CanClienteDelete", "CANCLIENTEDELETE", "ac-cliente-page" },
                    { "4f51b03a-0f44-49d4-a5f3-cb11075fc83e", new[] { 1 }, "de899eb4-50ce-4008-8f21-9383ef52e0fc", "Pode listar os dados de todas as roles/permissões", "CanRoleList", "CANROLELIST", "ac-role-page" },
                    { "52ee3a20-6119-418b-a668-af50cb60dfa1", new[] { 3 }, "e4604f9f-e510-4544-924e-7a3e013f7523", "Pode criar um usuário", "CanUserCreate", "CANUSERCREATE", "ac-user-page" },
                    { "61b2d3cf-ff1b-4659-b88b-c2776b109818", new[] { 1 }, "c45e2210-7a2b-416c-8114-c3ff351c8e53", "Pode listar o título do sistema", "CanTitleSystemList", "CANTITLESYSTEMLIST", "ac-titleSystem-page" },
                    { "64a5687b-9d19-47f6-b9d2-ae9faf8cc7e1", new[] { 5 }, "870e8bf7-9819-4b85-a12b-acd6d074324e", "Pode deletar um usuário", "CanUserDelete", "CANUSERDELETE", "ac-user-page" },
                    { "6d14bce0-73ba-43c7-a8f3-504afdeb150f", new[] { 2 }, "70badadc-8ffb-4aeb-8eef-887b6b7222cd", "Pode listar os dados de um usuários", "CanUserRead", "CANUSERREAD", "ac-user-page" },
                    { "7f6bf538-6614-4543-9159-76c7b6bf57f8", new[] { 2 }, "b59e385b-5650-4b8b-8178-800ffcbb5a2f", "Pode listar os dados de uma roles/permissão", "CanRoleRead", "CANROLEREAD", "ac-role-page" },
                    { "80f14930-ca06-4fd0-8328-50adb29d3b14", new[] { 4 }, "4ed2a396-5b44-4924-8a4b-022e3c35f84c", "Pode atualizar os dados de um cliente", "CanClienteUpdate", "CANCLIENTEUPDATE", "ac-cliente-page" },
                    { "8c24089f-a619-4308-b518-d54b7cd39b39", new[] { 2 }, "89b9845e-863f-4c9c-b70f-ebe87495ee04", "Pode listar os dado de um grupo", "CanGroupRead", "CANGROUPREAD", "ac-group-page" },
                    { "8d864376-4494-4dd0-aff2-0e04934d1361", new[] { 3 }, "b804a0f6-ba3f-4727-aa80-1131927cbbda", "Pode criar um grupo", "CanGroupCreate", "CANGROUPCREATE", "ac-group-page" },
                    { "9bc76d6a-8f8a-4401-b320-eaa486ead148", new[] { 5 }, "1f7d88c8-c9b3-4fa3-bb8c-188432e43835", "Pode deletar uma role/permissão", "CanRoleDelete", "CANROLEDELETE", "ac-role-page" },
                    { "9cfb692f-657b-4f2f-91dd-e37d39d0bfe2", new[] { 1, 2, 3, 4, 5 }, "82ac1dec-dc13-4525-9ef7-f221292c6325", "Pode realizar todas as ações/operações em todos os usuários", "CanUserAll", "CANUSERALL", "ac-user-page" },
                    { "aa1343e2-de1a-4d6a-b5c4-9455b2b2c90f", new[] { 4 }, "873533fe-a1c4-4c64-b1ce-ae084fb37b2e", "Pode atualizar os dados de um usuário", "CanUserUpdate", "CANUSERUPDATE", "ac-user-page" },
                    { "ac9e58b4-29c2-434d-b1e9-0846ef5adf33", new[] { 3 }, "a94beaf8-2332-4790-9bde-c69c54a65047", "Pode criar uma role/permissão", "CanRoleCreate", "CANROLECREATE", "ac-role-page" },
                    { "b0f96d85-3647-4651-9f78-b7529b577ec0", new[] { 0 }, "4629cea3-3b65-43b9-9c4e-7cc68fe4e4e4", "Pode realizar todas as ações/operações, bem como ter acesso a todos os dados e funcionalidades", "Master", "MASTER", "all" },
                    { "c835e33b-3737-47a7-8929-a25c2b8161b5", new[] { 1, 2, 3, 4, 5 }, "9e67024f-b11c-40bd-b76c-35c5e2c3e42a", "Pode realizar todas as ações/operações em todas as dashboards", "CanDashboardAll", "CANDASHBOARDALL", "ac-dashboard-page" },
                    { "cc342f4d-a3c7-4b32-a0fb-1361236c06e0", new[] { 1 }, "0206436e-d277-4534-b580-679b1618b077", "Pode listar o título dos negócios", "CanTitleBussinesList", "CANTITLEBUSSINESLIST", "ac-titleBussines-page" },
                    { "e474b0e9-ef5c-4195-a3fe-672e5bda0dba", new[] { 2 }, "89e2a71c-bd9a-444d-8031-ebacb27452a6", "Pode listar os dado de um cliente", "CanClienteRead", "CANCLIENTEREAD", "ac-cliente-page" },
                    { "effce3dc-f914-4995-a8b3-85e192ab0d89", new[] { 3 }, "6667ae00-ebe0-46b2-91e7-4fa602e0f658", "Pode criar um cliente", "CanClienteCreate", "CANCLIENTECREATE", "ac-cliente-page" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserClaims",
                columns: new[] { "Id", "ClaimType", "ClaimValue", "UserId" },
                values: new object[,]
                {
                    { 1, "Todos Role", "Todos Role", "1e526008-75f7-4a01-9942-d178f2b38888" },
                    { 2, "Relatorios Role", "Relatorios Role", "1e526008-75f7-4a01-9942-d178f2b38888" }
                });

            migrationBuilder.InsertData(
                table: "Tenants",
                columns: new[] { "Id", "ApiKey", "Cnpj", "CreatedAt", "CreatedBy", "EmailPrincipal", "IsDeleted", "Nome", "NomeExibicao", "NomeFantasia", "RazaoSocial", "UpdatedAt", "UpdatedBy", "WhatsAppPrincipal" },
                values: new object[] { new Guid("d8fe3845-3f2e-4b4e-aeb6-53222d60ff45"), new Guid("57d390e7-2b87-47fe-9bc8-0bae3a388499"), "27.195.267/0001-38", new DateTimeOffset(new DateTime(2023, 2, 1, 8, 30, 33, 221, DateTimeKind.Unspecified).AddTicks(1434), new TimeSpan(0, -3, 0, 0, 0)), "8e445865-a24d-4543-a6c6-9443d048cdb9", "tiago@rossokurtz.com.br", false, "Rosso e Kurtz Contadores Associados", "Rosso e Kurtz", null, null, new DateTimeOffset(new DateTime(2023, 2, 1, 8, 30, 33, 221, DateTimeKind.Unspecified).AddTicks(1474), new TimeSpan(0, -3, 0, 0, 0)), "8e445865-a24d-4543-a6c6-9443d048cdb9", null });

            migrationBuilder.InsertData(
                table: "AspNetGroups",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsDeleted", "Name", "TenantId", "UniqueKey", "UpdatedAt", "UpdatedBy" },
                values: new object[] { new Guid("23e63d9c-283b-496b-b7d8-7dac2ef7a822"), new DateTimeOffset(new DateTime(2023, 2, 1, 8, 30, 33, 223, DateTimeKind.Unspecified).AddTicks(8259), new TimeSpan(0, -3, 0, 0, 0)), "8e445865-a24d-4543-a6c6-9443d048cdb9", false, "Master", new Guid("d8fe3845-3f2e-4b4e-aeb6-53222d60ff45"), "ors0eAr4DPkvrwhy5gVnQAqRDnJUO43j9HzbkPyZ/7Q=", new DateTimeOffset(new DateTime(2023, 2, 1, 8, 30, 33, 223, DateTimeKind.Unspecified).AddTicks(8285), new TimeSpan(0, -3, 0, 0, 0)), "8e445865-a24d-4543-a6c6-9443d048cdb9" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "UserId", "AccessFailedCount", "Avatar", "Bio", "ConcurrencyStamp", "DataAniversario", "Email", "EmailConfirmed", "FullName", "Funcao", "Genero", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Setor", "Status", "TenantId", "TwoFactorEnabled", "UserName" },
                values: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 0, "", null, "ca431822-360a-4ee6-b978-66564d429fc7", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alan.rezende@boxtecnologia.com.br", true, "ALAN LEITE DE REZENDE", 0, 0, false, null, "ALAN.REZENDE@BOXTECNOLOGIA.COM.BR", "ALAN.REZENDE@BOXTECNOLOGIA.COM.BR", "AQAAAAEAACcQAAAAEFGbgHKOKiDDs5fvXN8kHviorntHToMKurnVJNmsFQNInxhQOyZTwJ2w0SpbyCdZbA==", null, false, "c9514850-61dd-4cc1-b909-88b79b035643", 0, 0, new Guid("d8fe3845-3f2e-4b4e-aeb6-53222d60ff45"), false, "alan.rezende@boxtecnologia.com.br" });

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
                values: new object[,]
                {
                    { "2c5e174e-3b0e-446f-86af-483d56fd7210", "8e445865-a24d-4543-a6c6-9443d048cdb9" },
                    { "b3a5b61d-7ff4-43cb-bad4-a945b150fc72", "8e445865-a24d-4543-a6c6-9443d048cdb9" }
                });

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
