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

            migrationBuilder.CreateTable(
                name: "Despesas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    FormaPagamento = table.Column<int>(type: "integer", nullable: false),
                    SistemaParcelamento = table.Column<int>(type: "integer", nullable: false),
                    TotalParcelas = table.Column<int>(type: "integer", nullable: false),
                    DataOperacao = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    ValorPrincipal = table.Column<decimal>(type: "numeric(12,2)", nullable: false, defaultValue: 0m),
                    Iof = table.Column<decimal>(type: "numeric(7,2)", nullable: false, defaultValue: 0m),
                    Seguro = table.Column<decimal>(type: "numeric(7,2)", nullable: false, defaultValue: 0m),
                    Tarifa = table.Column<decimal>(type: "numeric(7,2)", nullable: false, defaultValue: 0m),
                    CustoEfetivoTotalAno = table.Column<decimal>(type: "numeric(8,6)", nullable: false, defaultValue: 0m),
                    CustoEfetivoTotalMes = table.Column<decimal>(type: "numeric(8,6)", nullable: false, defaultValue: 0m),
                    CustoEfetivoTotalDia = table.Column<decimal>(type: "numeric(8,6)", nullable: false, defaultValue: 0m),
                    ValorEntrada = table.Column<decimal>(type: "numeric(12,2)", nullable: false, defaultValue: 0m),
                    ValorParcelado = table.Column<decimal>(type: "numeric(12,2)", nullable: false, defaultValue: 0m),
                    ClienteId = table.Column<Guid>(type: "uuid", nullable: false),
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
                    table.ForeignKey(
                        name: "FK_Despesas_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "Id");
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
                table: "AspNetGroups",
                keyColumn: "Id",
                keyValue: new Guid("23e63d9c-283b-496b-b7d8-7dac2ef7a822"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 2, 14, 53, 49, 87, DateTimeKind.Unspecified).AddTicks(9404), new TimeSpan(0, -3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 2, 2, 14, 53, 49, 87, DateTimeKind.Unspecified).AddTicks(9419), new TimeSpan(0, -3, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "Actions", "ConcurrencyStamp", "Description", "Name", "NormalizedName", "Subject" },
                values: new object[,]
                {
                    { "04877df7-7613-4b15-bbea-a8b39003dacf", new[] { 5 }, "29370f3b-362b-42dd-a442-68caa82fc861", "Pode deletar um usuário", "CanUserDelete", "CANUSERDELETE", "ac-user-page" },
                    { "0998fcc6-89d7-4520-a901-672b6f1f656f", new[] { 1 }, "66769de7-33d4-4527-a3f4-d7bac3bd5850", "Pode listar os dados de todas as despesas", "CanDespesaList", "CANDESPESALIST", "ac-despesa-page" },
                    { "0e5ff859-8e22-4e80-ba3c-afc219a0fb23", new[] { 5 }, "27410d01-dac7-4e55-9402-ba2b59d8f557", "Pode deletar um grupo", "CanGroupDelete", "CANGROUPDELETE", "ac-group-page" },
                    { "0eed2abd-b27d-4c66-a99c-8e77176f3462", new[] { 1, 2, 3, 4, 5 }, "250fef26-80a5-4ef3-9a5e-5e9782af8463", "Pode realizar todas as ações/operações em todas as despesas", "CanDespesaAll", "CANDESPESAALL", "ac-despesa-page" },
                    { "129d700c-09b7-4d3d-ad6b-8862c961de1d", new[] { 2 }, "dc15752c-af79-41ab-8a6f-bae7ac260134", "Pode listar os dado de um cliente", "CanClienteRead", "CANCLIENTEREAD", "ac-cliente-page" },
                    { "130bcd27-1686-4c98-b9e5-7e5d6c44384c", new[] { 4 }, "0c22fcbc-c2f9-4168-9e4c-3aaf70bd0f72", "Pode atualizar os dados de um grupo", "CanGroupUpdate", "CANGROUPUPDATE", "ac-group-page" },
                    { "23649d1a-451c-4e8b-9346-1bc63827388c", new[] { 4 }, "ff72717a-d61d-4624-abcb-2c5a734c5e4b", "Pode atualizar os dados de uma despesa", "CanDespesaUpdate", "CANDESPESAUPDATE", "ac-despesa-page" },
                    { "23de81bc-72f8-43ff-9a6d-f72b7e234056", new[] { 1, 2, 3, 4, 5 }, "87ef3cee-6fd3-4b83-8463-79a595cd4054", "Pode realizar todas as ações/operações em todos os grupos", "CanGroupAll", "CANGROUPALL", "ac-group-page" },
                    { "2d679406-2424-4c33-a276-4fbc5168b97a", new[] { 4 }, "54abddbf-d3c0-43f9-a992-30d3663da09f", "Pode atualizar os dados de uma roles/permissão", "CanRoleUpdate", "CANROLEUPDATE", "ac-role-page" },
                    { "46b7d349-b492-4999-8daa-dabbf099ed28", new[] { 1, 2, 3, 4, 5 }, "37bf42eb-6bd1-4fbf-b9a8-11ddd91d9779", "Pode realizar todas as ações/operações em todos as roles/permissões", "CanRoleAll", "CANROLEALL", "ac-role-page" },
                    { "4a11ff70-2667-4793-84cb-acdd48d29a55", new[] { 5 }, "8aa7dbe8-0a3f-4d65-8ea1-f57245acf3bb", "Pode deletar uma despesa", "CanDespesaDelete", "CANDESPESADELETE", "ac-despesa-page" },
                    { "51ceb4a1-4674-4ab8-91de-5ea293128785", new[] { 1 }, "43a89537-ecc8-4a90-98b4-10fd53816d46", "Pode listar os dados de todos os usuários", "CanUserList", "CANUSERLIST", "ac-user-page" },
                    { "61bc958b-8893-4f02-930c-14ae833cf22c", new[] { 3 }, "e86ee3c3-7979-477f-9fd2-87168d69158e", "Pode criar um usuário", "CanUserCreate", "CANUSERCREATE", "ac-user-page" },
                    { "64d9c569-97a5-46dc-af15-ca92c272a246", new[] { 2 }, "2b1ae4cb-4aa9-4ea4-be72-ec85f769bdf0", "Pode listar os dados de uma roles/permissão", "CanRoleRead", "CANROLEREAD", "ac-role-page" },
                    { "71bf3ffd-219d-4096-82cf-2cc7c37fdd8c", new[] { 5 }, "66644ea8-97da-4387-93f3-a9f5141528cc", "Pode deletar uma role/permissão", "CanRoleDelete", "CANROLEDELETE", "ac-role-page" },
                    { "8651b792-b12f-426a-943c-1563e0a4b1a5", new[] { 2 }, "aa1728cf-0cca-4bd4-871b-bf612101cc36", "Pode listar os dados de uma despesa", "CanDespesaRead", "CANDESPESAREAD", "ac-despesa-page" },
                    { "91d3fb32-a476-4452-9c7f-9b62d8f12acd", new[] { 4 }, "234b6e4d-f7e6-4b05-a02d-e7b5a6cdaf3e", "Pode atualizar os dados de um cliente", "CanClienteUpdate", "CANCLIENTEUPDATE", "ac-cliente-page" },
                    { "978e15bb-136f-4876-8883-7ace0aba0b0f", new[] { 1, 2, 3, 4, 5 }, "254d3f0d-147f-4e1b-bfe8-2717d6bfcff5", "Pode realizar todas as ações/operações em todos os clientes", "CanClienteAll", "CANCLIENTEALL", "ac-cliente-page" },
                    { "9b502053-27ae-4f62-9d9a-4f4bfc029f12", new[] { 1, 2, 3, 4, 5 }, "f66f8bb3-41e0-42e0-8caf-d18409593073", "Pode realizar todas as ações/operações em todos os usuários", "CanUserAll", "CANUSERALL", "ac-user-page" },
                    { "9db7520a-cefb-4a25-8969-e3abc1c570b6", new[] { 1 }, "285a95ff-aee5-46d4-9a91-de6281e58f9c", "Pode listar o título do sistema", "CanTitleSystemList", "CANTITLESYSTEMLIST", "ac-titleSystem-page" },
                    { "a216112c-2865-42f1-88fe-879376313ac3", new[] { 4 }, "70136ce3-8fd5-4635-a718-6bdfeb4cb9d9", "Pode atualizar os dados de um usuário", "CanUserUpdate", "CANUSERUPDATE", "ac-user-page" },
                    { "a4340d1e-c2b5-406c-9bde-3c8966696258", new[] { 1, 2, 3, 4, 5 }, "3146f408-e994-47ac-ae91-5a4dcafaf7b9", "Pode realizar todas as ações/operações em todas as dashboards", "CanDashboardAll", "CANDASHBOARDALL", "ac-dashboard-page" },
                    { "a6b5d54f-51a2-4c42-ac50-1f7c45cb866e", new[] { 1, 2, 3, 4, 5 }, "97b19668-a556-4d4b-b520-aa719aadab2e", "Pode realizar todas as ações/operações em dashboard publica", "CanDashboardPublicaAll", "CANDASHBOARDPUBLICAALL", "ac-dashboardPublica-page" },
                    { "a8403a6f-adf6-490c-a0ff-b2f90ab7e4c9", new[] { 3 }, "953b267b-6db3-4866-83f2-1a667b13db4d", "Pode criar uma role/permissão", "CanRoleCreate", "CANROLECREATE", "ac-role-page" },
                    { "b4ad96e0-c4c2-4748-b1f7-5f0e63c737cd", new[] { 3 }, "a3ff2a35-5b11-456c-ab21-a27cb0f8db80", "Pode criar um grupo", "CanGroupCreate", "CANGROUPCREATE", "ac-group-page" },
                    { "bd40056d-c0db-453b-b246-27653a6ab00e", new[] { 2 }, "2768d7df-5efd-4551-8dac-7bcea4545dae", "Pode listar os dados de um usuários", "CanUserRead", "CANUSERREAD", "ac-user-page" },
                    { "c2121091-ee67-4ab3-a230-49316a4f6fa7", new[] { 1 }, "831a6ac3-46a5-437f-89ab-d58cb7299b07", "Pode listar os dados de todas as roles/permissões", "CanRoleList", "CANROLELIST", "ac-role-page" },
                    { "d781ce48-cb98-4ebc-8f51-aff3262289b1", new[] { 5 }, "de876fb9-f7ed-4efa-9028-6b752e57d878", "Pode deletar um cliente", "CanClienteDelete", "CANCLIENTEDELETE", "ac-cliente-page" },
                    { "d7bbb015-63ac-4898-9231-b330caa97021", new[] { 3 }, "d3ee9e17-cdac-4a34-a6d1-953ff4c595ab", "Pode criar uma despesa", "CanDespesaCreate", "CANDESPESACREATE", "ac-despesa-page" },
                    { "d9a76d55-1588-4465-82c9-a2284ca3632c", new[] { 2 }, "41658dc9-b41f-486d-9204-8a45f2d8915b", "Pode listar os dado de um grupo", "CanGroupRead", "CANGROUPREAD", "ac-group-page" },
                    { "ec8b0708-5d73-4026-be76-be2d05e3dc73", new[] { 3 }, "23d3302e-966f-4810-99e9-b2a40f41e503", "Pode criar um cliente", "CanClienteCreate", "CANCLIENTECREATE", "ac-cliente-page" },
                    { "ed6adbc2-7977-41b0-a890-3d2c35e2a1f4", new[] { 1 }, "49675052-5b8e-4ab5-8c06-afcb54b98266", "Pode listar os dados de todos os grupos", "CanGroupList", "CANGROUPLIST", "ac-group-page" },
                    { "ee967e7c-4c35-4614-a361-0cf000f4559f", new[] { 1 }, "19e573d8-d1a8-455d-bec6-92579a8ff08d", "Pode listar o título dos negócios", "CanTitleBussinesList", "CANTITLEBUSSINESLIST", "ac-titleBussines-page" },
                    { "f2dea96c-bd11-49e8-a67b-58a43b8694b0", new[] { 1 }, "996b1a80-af0a-40c2-a412-7fc4f9c73fa6", "Pode listar os dados de todos os clientes", "CanClienteList", "CANCLIENTELIST", "ac-cliente-page" }
                });

            migrationBuilder.UpdateData(
                table: "Tenants",
                keyColumn: "Id",
                keyValue: new Guid("d8fe3845-3f2e-4b4e-aeb6-53222d60ff45"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 2, 14, 53, 49, 86, DateTimeKind.Unspecified).AddTicks(7309), new TimeSpan(0, -3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 2, 2, 14, 53, 49, 86, DateTimeKind.Unspecified).AddTicks(7335), new TimeSpan(0, -3, 0, 0, 0)) });

            migrationBuilder.CreateIndex(
                name: "IX_Despesas_ClienteId",
                table: "Despesas",
                column: "ClienteId");

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

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "04877df7-7613-4b15-bbea-a8b39003dacf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0998fcc6-89d7-4520-a901-672b6f1f656f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0e5ff859-8e22-4e80-ba3c-afc219a0fb23");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0eed2abd-b27d-4c66-a99c-8e77176f3462");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "129d700c-09b7-4d3d-ad6b-8862c961de1d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "130bcd27-1686-4c98-b9e5-7e5d6c44384c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "23649d1a-451c-4e8b-9346-1bc63827388c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "23de81bc-72f8-43ff-9a6d-f72b7e234056");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2d679406-2424-4c33-a276-4fbc5168b97a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "46b7d349-b492-4999-8daa-dabbf099ed28");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4a11ff70-2667-4793-84cb-acdd48d29a55");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "51ceb4a1-4674-4ab8-91de-5ea293128785");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "61bc958b-8893-4f02-930c-14ae833cf22c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "64d9c569-97a5-46dc-af15-ca92c272a246");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "71bf3ffd-219d-4096-82cf-2cc7c37fdd8c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8651b792-b12f-426a-943c-1563e0a4b1a5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "91d3fb32-a476-4452-9c7f-9b62d8f12acd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "978e15bb-136f-4876-8883-7ace0aba0b0f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9b502053-27ae-4f62-9d9a-4f4bfc029f12");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9db7520a-cefb-4a25-8969-e3abc1c570b6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a216112c-2865-42f1-88fe-879376313ac3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a4340d1e-c2b5-406c-9bde-3c8966696258");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a6b5d54f-51a2-4c42-ac50-1f7c45cb866e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a8403a6f-adf6-490c-a0ff-b2f90ab7e4c9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b4ad96e0-c4c2-4748-b1f7-5f0e63c737cd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd40056d-c0db-453b-b246-27653a6ab00e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c2121091-ee67-4ab3-a230-49316a4f6fa7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d781ce48-cb98-4ebc-8f51-aff3262289b1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d7bbb015-63ac-4898-9231-b330caa97021");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d9a76d55-1588-4465-82c9-a2284ca3632c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ec8b0708-5d73-4026-be76-be2d05e3dc73");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ed6adbc2-7977-41b0-a890-3d2c35e2a1f4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ee967e7c-4c35-4614-a361-0cf000f4559f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f2dea96c-bd11-49e8-a67b-58a43b8694b0");

            migrationBuilder.UpdateData(
                table: "AspNetGroups",
                keyColumn: "Id",
                keyValue: new Guid("23e63d9c-283b-496b-b7d8-7dac2ef7a822"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 1, 8, 56, 14, 937, DateTimeKind.Unspecified).AddTicks(2556), new TimeSpan(0, -3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 2, 1, 8, 56, 14, 937, DateTimeKind.Unspecified).AddTicks(2566), new TimeSpan(0, -3, 0, 0, 0)) });

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
                    { "b1094847-33fe-4872-b694-c7fc9c9ac3cb", new[] { 1, 2, 3, 4, 5 }, "0a2476c9-276c-44a4-900f-844b25ac3582", "Pode realizar todas as ações/operações em dashboard publica", "CanDashboardPublicaAll", "CANDASHBOARDPUBLICAALL", "ac-dashboardPublica-page" },
                    { "bd012c34-165e-4159-acec-0d1de4dbde51", new[] { 3 }, "4a08bdd6-8cf1-455e-b35e-397ac3c268a8", "Pode criar um grupo", "CanGroupCreate", "CANGROUPCREATE", "ac-group-page" },
                    { "c8323299-a311-43fa-804f-deed0c202bb0", new[] { 4 }, "e9ddb4f6-5c4f-440e-b530-d5fba5dce521", "Pode atualizar os dados de um cliente", "CanClienteUpdate", "CANCLIENTEUPDATE", "ac-cliente-page" },
                    { "d2fbac7c-7502-4004-8aa2-686812ee8022", new[] { 3 }, "0b50b786-77c9-4372-a7c1-24457c7f2aac", "Pode criar um cliente", "CanClienteCreate", "CANCLIENTECREATE", "ac-cliente-page" },
                    { "dda1ef7c-c033-4822-bfac-300788a30538", new[] { 1 }, "d5fae5df-68be-41eb-a13d-dd8639bc5daf", "Pode listar o título do sistema", "CanTitleSystemList", "CANTITLESYSTEMLIST", "ac-titleSystem-page" },
                    { "f27e0f7c-ef53-4f93-bcd5-c195d0cd0cfd", new[] { 1 }, "e50ce833-94b4-44f9-8671-f4cc52c43839", "Pode listar os dados de todas as roles/permissões", "CanRoleList", "CANROLELIST", "ac-role-page" },
                    { "fe0e455f-7e3d-45f6-b6de-a0cd37215209", new[] { 1, 2, 3, 4, 5 }, "6f259a74-1b49-4f0f-87b0-8449cbcb1ba4", "Pode realizar todas as ações/operações em todos as roles/permissões", "CanRoleAll", "CANROLEALL", "ac-role-page" },
                    { "fe8b1c90-8d16-414f-a749-daff85a61f07", new[] { 1 }, "45a40863-9f17-4c45-9c93-69cee1aa6031", "Pode listar o título dos negócios", "CanTitleBussinesList", "CANTITLEBUSSINESLIST", "ac-titleBussines-page" }
                });

            migrationBuilder.UpdateData(
                table: "Tenants",
                keyColumn: "Id",
                keyValue: new Guid("d8fe3845-3f2e-4b4e-aeb6-53222d60ff45"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 1, 8, 56, 14, 936, DateTimeKind.Unspecified).AddTicks(990), new TimeSpan(0, -3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 2, 1, 8, 56, 14, 936, DateTimeKind.Unspecified).AddTicks(1014), new TimeSpan(0, -3, 0, 0, 0)) });
        }
    }
}
