using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BoxBack.Infra.Data.Migrations
{
    public partial class v11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoleGroups",
                keyColumns: new[] { "GroupId", "RoleId" },
                keyValues: new object[] { new Guid("23e63d9c-283b-496b-b7d8-7dac2ef7a822"), "b0f96d85-3647-4651-9f78-b7529b577ec0" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1081248d-f976-48cd-ad12-d1ab7a951d7f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1a86e3c7-ad7e-41cf-b439-dc1eb0f0db05");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1f11b82d-8149-4b08-b910-d65b0cd1d9d8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "21299628-27c9-426e-b4f7-806d605f43d2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "26513c23-87ec-444d-9c51-d663f5bfdd05");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2afcfacd-63e0-4c15-8594-be42fa39c325");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3a0cd7e1-0d2f-4002-8202-19a6abe5c9f5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4b806712-9502-46f0-b4f6-5f9abc67b0cb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "528ba46c-0356-431e-a86e-6186955029a7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5b8cd6e6-cfdc-4516-b7cd-de831996ed25");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6638e42f-6acc-4801-97bd-5865c61c2ee6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "66751c3c-1ad9-47cd-bf7e-945b524a4dc1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "68eec4dc-0a76-4aa1-98a3-1dcc7ffa2d39");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "690b1860-2708-46b9-b910-014509f884dc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "82657fa4-7f23-4e09-ba61-24f1894f0770");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8af80ad7-8a34-467c-a6e2-f451c813883b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8d64ee64-22ab-44a4-b1df-67382b289895");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9019b807-c03d-49c8-b3eb-1a0520e7a272");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "942c0974-2f70-4c4d-83a7-5693004cb6f6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a38cf126-fd07-44e0-88e3-ca6b78181b30");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b1094847-33fe-4872-b694-c7fc9c9ac3cb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd012c34-165e-4159-acec-0d1de4dbde51");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c8323299-a311-43fa-804f-deed0c202bb0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d2fbac7c-7502-4004-8aa2-686812ee8022");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dda1ef7c-c033-4822-bfac-300788a30538");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f27e0f7c-ef53-4f93-bcd5-c195d0cd0cfd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fe0e455f-7e3d-45f6-b6de-a0cd37215209");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fe8b1c90-8d16-414f-a749-daff85a61f07");

            migrationBuilder.DeleteData(
                table: "AspNetUserGroups",
                keyColumns: new[] { "GroupId", "UserId" },
                keyValues: new object[] { new Guid("23e63d9c-283b-496b-b7d8-7dac2ef7a822"), "8e445865-a24d-4543-a6c6-9443d048cdb9" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b0f96d85-3647-4651-9f78-b7529b577ec0", "8e445865-a24d-4543-a6c6-9443d048cdb9" });

            migrationBuilder.DeleteData(
                table: "AspNetGroups",
                keyColumn: "Id",
                keyValue: new Guid("23e63d9c-283b-496b-b7d8-7dac2ef7a822"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b0f96d85-3647-4651-9f78-b7529b577ec0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "UserId",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9");

            migrationBuilder.CreateTable(
                name: "Despesas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    FormaPagamento = table.Column<int>(type: "integer", nullable: false),
                    SistemaParcelamento = table.Column<int>(type: "integer", nullable: false),
                    TotalParcelas = table.Column<int>(type: "integer", nullable: false),
                    DataOperacao = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    ValorPrincipal = table.Column<decimal>(type: "numeric(12,9)", nullable: false, defaultValue: 0m),
                    Iof = table.Column<decimal>(type: "numeric(7,6)", nullable: false, defaultValue: 0m),
                    Seguro = table.Column<decimal>(type: "numeric(7,6)", nullable: false, defaultValue: 0m),
                    Tarifa = table.Column<decimal>(type: "numeric(7,6)", nullable: false, defaultValue: 0m),
                    CustoEfetivoTotalAno = table.Column<decimal>(type: "numeric(8,6)", nullable: false, defaultValue: 0m),
                    CustoEfetivoTotalMes = table.Column<decimal>(type: "numeric(8,6)", nullable: false, defaultValue: 0m),
                    CustoEfetivoTotalDia = table.Column<decimal>(type: "numeric(8,6)", nullable: false, defaultValue: 0m),
                    ValorEntrada = table.Column<decimal>(type: "numeric(12,9)", nullable: false, defaultValue: 0m),
                    ValorParcelado = table.Column<decimal>(type: "numeric(12,9)", nullable: false, defaultValue: 0m),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    CreatedBy = table.Column<string>(type: "text", nullable: true),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    UpdatedBy = table.Column<string>(type: "text", nullable: true),
                    TenantId = table.Column<Guid>(type: "uuid", nullable: false, defaultValue: new Guid("d8fe3845-3f2e-4b4e-aeb6-53222d60ff45"))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Despesas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DespesasParcelas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    DataVencimento = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    ParcelaNumero = table.Column<int>(type: "integer", nullable: false),
                    DiasEntreParcelas = table.Column<int>(type: "integer", nullable: false),
                    SaldoInicial = table.Column<decimal>(type: "numeric(12,9)", nullable: false, defaultValue: 0m),
                    SaldoFinal = table.Column<decimal>(type: "numeric(12,9)", nullable: false, defaultValue: 0m),
                    Juros = table.Column<decimal>(type: "numeric(10,6)", nullable: false, defaultValue: 0m),
                    Amortizacao = table.Column<decimal>(type: "numeric(10,6)", nullable: false, defaultValue: 0m),
                    ValorParcela = table.Column<decimal>(type: "numeric(12,9)", nullable: false, defaultValue: 0m),
                    DespesaId = table.Column<Guid>(type: "uuid", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    CreatedBy = table.Column<string>(type: "text", nullable: true),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    UpdatedBy = table.Column<string>(type: "text", nullable: true),
                    TenantId = table.Column<Guid>(type: "uuid", nullable: false, defaultValue: new Guid("d8fe3845-3f2e-4b4e-aeb6-53222d60ff45"))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DespesasParcelas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DespesasParcelas_Despesas_DespesaId",
                        column: x => x.DespesaId,
                        principalTable: "Despesas",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "Tenants",
                keyColumn: "Id",
                keyValue: new Guid("d8fe3845-3f2e-4b4e-aeb6-53222d60ff45"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 2, 8, 55, 55, 524, DateTimeKind.Unspecified).AddTicks(8655), new TimeSpan(0, -3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 2, 2, 8, 55, 55, 524, DateTimeKind.Unspecified).AddTicks(8680), new TimeSpan(0, -3, 0, 0, 0)) });

            migrationBuilder.CreateIndex(
                name: "IX_DespesasParcelas_DespesaId",
                table: "DespesasParcelas",
                column: "DespesaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DespesasParcelas");

            migrationBuilder.DropTable(
                name: "Despesas");

            migrationBuilder.InsertData(
                table: "AspNetGroups",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsDeleted", "Name", "TenantId", "UniqueKey", "UpdatedAt", "UpdatedBy" },
                values: new object[] { new Guid("23e63d9c-283b-496b-b7d8-7dac2ef7a822"), new DateTimeOffset(new DateTime(2023, 2, 1, 8, 56, 14, 937, DateTimeKind.Unspecified).AddTicks(2556), new TimeSpan(0, -3, 0, 0, 0)), "8e445865-a24d-4543-a6c6-9443d048cdb9", false, "Master", new Guid("d8fe3845-3f2e-4b4e-aeb6-53222d60ff45"), "ors0eAr4DPkvrwhy5gVnQAqRDnJUO43j9HzbkPyZ/7Q=", new DateTimeOffset(new DateTime(2023, 2, 1, 8, 56, 14, 937, DateTimeKind.Unspecified).AddTicks(2566), new TimeSpan(0, -3, 0, 0, 0)), "8e445865-a24d-4543-a6c6-9443d048cdb9" });

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
                table: "AspNetUsers",
                columns: new[] { "UserId", "AccessFailedCount", "Avatar", "Bio", "ConcurrencyStamp", "DataAniversario", "Email", "EmailConfirmed", "FullName", "Funcao", "Genero", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Setor", "Status", "TelefoneCelular", "TenantId", "TwoFactorEnabled", "UserName" },
                values: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 0, "", null, "ca431822-360a-4ee6-b978-66564d429fc7", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "alan.rezendeeee@hotmail.com", true, "ALAN LEITE DE REZENDE", 0, 0, false, null, "ALAN.REZENDEEEE@HOTMAIL.COM", "ALAN.REZENDEEEE@HOTMAIL.COM", "AQAAAAEAACcQAAAAEFGbgHKOKiDDs5fvXN8kHviorntHToMKurnVJNmsFQNInxhQOyZTwJ2w0SpbyCdZbA==", null, false, "c9514850-61dd-4cc1-b909-88b79b035643", 0, 0, 0L, new Guid("d8fe3845-3f2e-4b4e-aeb6-53222d60ff45"), false, "alan.rezendeeee@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Tenants",
                keyColumn: "Id",
                keyValue: new Guid("d8fe3845-3f2e-4b4e-aeb6-53222d60ff45"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 1, 8, 56, 14, 936, DateTimeKind.Unspecified).AddTicks(990), new TimeSpan(0, -3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 2, 1, 8, 56, 14, 936, DateTimeKind.Unspecified).AddTicks(1014), new TimeSpan(0, -3, 0, 0, 0)) });

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
        }
    }
}
