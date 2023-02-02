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
                table: "AspNetGroups",
                keyColumn: "Id",
                keyValue: new Guid("23e63d9c-283b-496b-b7d8-7dac2ef7a822"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 2, 11, 50, 1, 523, DateTimeKind.Unspecified).AddTicks(652), new TimeSpan(0, -3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 2, 2, 11, 50, 1, 523, DateTimeKind.Unspecified).AddTicks(674), new TimeSpan(0, -3, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "Actions", "ConcurrencyStamp", "Description", "Name", "NormalizedName", "Subject" },
                values: new object[,]
                {
                    { "0bef74fc-6a96-4425-8957-92238777f105", new[] { 1 }, "bde7645d-292a-429c-b482-f2c0c1d13d09", "Pode listar os dados de todos os usuários", "CanUserList", "CANUSERLIST", "ac-user-page" },
                    { "1aa11dc6-98b2-4a16-9908-238d1cedf152", new[] { 5 }, "1314a66f-9241-451c-aad7-9283803ad5e9", "Pode deletar um usuário", "CanUserDelete", "CANUSERDELETE", "ac-user-page" },
                    { "1d849f58-c8d0-4477-a5d0-928bfb73ce21", new[] { 3 }, "68d270c9-c308-406e-b124-655f72919ef6", "Pode criar uma despesa", "CanDespesaCreate", "CANDESPESACREATE", "ac-despesa-page" },
                    { "206eac4d-1b8f-49ec-9dd4-92836842fb55", new[] { 1, 2, 3, 4, 5 }, "e8b17802-df7e-4f1f-a54c-a16663d5ecf4", "Pode realizar todas as ações/operações em todos os grupos", "CanGroupAll", "CANGROUPALL", "ac-group-page" },
                    { "2273b4d9-3739-4e44-aa6a-c20907415543", new[] { 1 }, "9f81ad08-efea-4a97-aa10-c65079acf68d", "Pode listar o título dos negócios", "CanTitleBussinesList", "CANTITLEBUSSINESLIST", "ac-titleBussines-page" },
                    { "22d6b356-e131-4971-bbcf-cd1e9292aea9", new[] { 1, 2, 3, 4, 5 }, "a51c354a-59ff-48a9-8d6a-2f60d9139696", "Pode realizar todas as ações/operações em todas as dashboards", "CanDashboardAll", "CANDASHBOARDALL", "ac-dashboard-page" },
                    { "25ae6f96-76d5-40a7-bbbb-a65f76c10619", new[] { 1 }, "9701c7da-a7cc-4a11-956a-62e8c4c0f9dd", "Pode listar os dados de todas as despesas", "CanDespesaList", "CANDESPESALIST", "ac-despesa-page" },
                    { "28ca3f22-dde6-4480-8a0b-3b4908ea93c3", new[] { 5 }, "15de51d3-9286-41d9-86d2-9a57a12f0622", "Pode deletar um grupo", "CanGroupDelete", "CANGROUPDELETE", "ac-group-page" },
                    { "292f6078-8810-4865-a51a-bfc1e3c91ff0", new[] { 4 }, "f3177ffa-9895-4039-a9fa-c167068b9889", "Pode atualizar os dados de um usuário", "CanUserUpdate", "CANUSERUPDATE", "ac-user-page" },
                    { "2bab5374-f11e-4c4f-9101-a3b8f79b126f", new[] { 2 }, "5c9a2fa9-02c1-473c-a88c-1113ca3516ca", "Pode listar os dado de um grupo", "CanGroupRead", "CANGROUPREAD", "ac-group-page" },
                    { "2fb29f71-0b8f-48eb-892e-42fbbc0dcf1c", new[] { 2 }, "8545c92d-db66-4053-92e9-db2209868358", "Pode listar os dados de um usuários", "CanUserRead", "CANUSERREAD", "ac-user-page" },
                    { "36405791-37cb-4946-99f9-ec7ecb8201a7", new[] { 2 }, "a2dab7bc-cc74-4b7c-a9f5-1643ad6ef667", "Pode listar os dado de um cliente", "CanClienteRead", "CANCLIENTEREAD", "ac-cliente-page" },
                    { "3cb9899a-4fd4-4599-8b49-00966f7aa8f9", new[] { 2 }, "16b6849d-d07b-4236-94ed-51005d4c974d", "Pode listar os dados de uma despesa", "CanDespesaRead", "CANDESPESAREAD", "ac-despesa-page" },
                    { "46a8c774-1095-4b3d-9a8b-88b55713c614", new[] { 5 }, "354693c6-71dd-40c9-9a5d-44591699d45d", "Pode deletar uma despesa", "CanDespesaDelete", "CANDESPESADELETE", "ac-despesa-page" },
                    { "477cb8da-0366-49fb-8466-2f0565d41114", new[] { 3 }, "f1007b96-7974-437e-b868-daf3508171be", "Pode criar uma role/permissão", "CanRoleCreate", "CANROLECREATE", "ac-role-page" },
                    { "492c007f-bdd5-4aef-a3eb-20778d3a269f", new[] { 4 }, "441042e1-f9c6-4385-ada1-e9054dff7060", "Pode atualizar os dados de um cliente", "CanClienteUpdate", "CANCLIENTEUPDATE", "ac-cliente-page" },
                    { "4b646b8a-eba2-45c5-8133-5a3cbf690117", new[] { 2 }, "e4a333f0-6f8b-42ae-8d5a-4cb9ecdef2d0", "Pode listar os dados de uma roles/permissão", "CanRoleRead", "CANROLEREAD", "ac-role-page" },
                    { "4c324b77-950a-49ef-97f3-721ec153e2f5", new[] { 1, 2, 3, 4, 5 }, "65c3309a-010d-4bd6-bebe-c54fab13e94c", "Pode realizar todas as ações/operações em todos as roles/permissões", "CanRoleAll", "CANROLEALL", "ac-role-page" },
                    { "4f70900d-4a81-401d-b7bc-fa0823e38e7d", new[] { 4 }, "d98ec714-11bc-4514-a567-214f508c2930", "Pode atualizar os dados de um grupo", "CanGroupUpdate", "CANGROUPUPDATE", "ac-group-page" },
                    { "59a4f5a2-fbee-42d7-a226-cea3d057e079", new[] { 1 }, "a8b6932f-4bfc-4f88-9636-9db79d3be120", "Pode listar os dados de todos os grupos", "CanGroupList", "CANGROUPLIST", "ac-group-page" },
                    { "6026db88-6583-4dcc-9198-435519e2bd34", new[] { 1 }, "88504a0a-11e0-47bf-9c13-4015aa55f03b", "Pode listar o título do sistema", "CanTitleSystemList", "CANTITLESYSTEMLIST", "ac-titleSystem-page" },
                    { "7d0cf997-4965-400a-b81e-616c9c15526e", new[] { 1 }, "80d7e843-7a96-4c04-a164-baa45d4dbfa7", "Pode listar os dados de todas as roles/permissões", "CanRoleList", "CANROLELIST", "ac-role-page" },
                    { "82ce7c15-5d9d-4b29-9f01-59cabdf0239e", new[] { 5 }, "73392a23-7d30-4646-b46f-b6543a4ba7fe", "Pode deletar uma role/permissão", "CanRoleDelete", "CANROLEDELETE", "ac-role-page" },
                    { "85b55b24-3a8e-498d-a60e-a13c33c0b925", new[] { 1 }, "6cb24c3b-88cd-424a-9be4-07dbe8d9920e", "Pode listar os dados de todos os clientes", "CanClienteList", "CANCLIENTELIST", "ac-cliente-page" },
                    { "9088ff5d-1090-423b-8311-81438bab2f71", new[] { 1, 2, 3, 4, 5 }, "18289e49-1741-4576-b328-b1da67662f2e", "Pode realizar todas as ações/operações em todos os clientes", "CanClienteAll", "CANCLIENTEALL", "ac-cliente-page" },
                    { "94cac223-5abd-4bac-8223-3cc6ae171906", new[] { 4 }, "535053f6-9f19-4420-b5e7-ce7736bb67ac", "Pode atualizar os dados de uma despesa", "CanDespesaUpdate", "CANDESPESAUPDATE", "ac-despesa-page" },
                    { "9efcb441-34b0-4ca9-bd17-89c2256ba15f", new[] { 4 }, "f86e475a-241c-41c9-bc3b-c565f0257bcb", "Pode atualizar os dados de uma roles/permissão", "CanRoleUpdate", "CANROLEUPDATE", "ac-role-page" },
                    { "a591d88e-951d-4781-a83b-42aa6bc49578", new[] { 1, 2, 3, 4, 5 }, "b69ea726-beac-4ef7-be7b-2b9fd93d5510", "Pode realizar todas as ações/operações em dashboard publica", "CanDashboardPublicaAll", "CANDASHBOARDPUBLICAALL", "ac-dashboardPublica-page" },
                    { "add6aa62-88b2-406a-9ad2-10fdab522e26", new[] { 1, 2, 3, 4, 5 }, "8bb993ab-4995-40ee-bb45-a6c8384e8cdc", "Pode realizar todas as ações/operações em todos os usuários", "CanUserAll", "CANUSERALL", "ac-user-page" },
                    { "c5cc44d9-fdaf-4432-9673-41525d501fc5", new[] { 1, 2, 3, 4, 5 }, "4a05a846-6133-43a6-8118-f9a7b0c2338c", "Pode realizar todas as ações/operações em todas as despesas", "CanDespesaAll", "CANDESPESAALL", "ac-despesa-page" },
                    { "d8c3c38b-fa99-4b01-87c9-1c7965fbe6f3", new[] { 5 }, "f40167c4-ff8d-4dbb-88eb-ce9dc2be87c4", "Pode deletar um cliente", "CanClienteDelete", "CANCLIENTEDELETE", "ac-cliente-page" },
                    { "f5ccd8b1-26f9-4d1b-8e77-d49e84d4465f", new[] { 3 }, "a737315f-9a21-4510-90ac-229c25ee592a", "Pode criar um cliente", "CanClienteCreate", "CANCLIENTECREATE", "ac-cliente-page" },
                    { "fa5c6799-56f8-4ad2-8e73-f67134d0f6d4", new[] { 3 }, "54397aee-1e45-459f-a0e7-2af3fc38b0a0", "Pode criar um grupo", "CanGroupCreate", "CANGROUPCREATE", "ac-group-page" },
                    { "ff9f8f14-8e11-4bd6-b220-a8fa02379b25", new[] { 3 }, "c1e1e2a2-439b-4409-b160-5bcc59c7bc8f", "Pode criar um usuário", "CanUserCreate", "CANUSERCREATE", "ac-user-page" }
                });

            migrationBuilder.UpdateData(
                table: "Tenants",
                keyColumn: "Id",
                keyValue: new Guid("d8fe3845-3f2e-4b4e-aeb6-53222d60ff45"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 2, 11, 50, 1, 521, DateTimeKind.Unspecified).AddTicks(4685), new TimeSpan(0, -3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 2, 2, 11, 50, 1, 521, DateTimeKind.Unspecified).AddTicks(4722), new TimeSpan(0, -3, 0, 0, 0)) });

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
                keyValue: "0bef74fc-6a96-4425-8957-92238777f105");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1aa11dc6-98b2-4a16-9908-238d1cedf152");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1d849f58-c8d0-4477-a5d0-928bfb73ce21");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "206eac4d-1b8f-49ec-9dd4-92836842fb55");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2273b4d9-3739-4e44-aa6a-c20907415543");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "22d6b356-e131-4971-bbcf-cd1e9292aea9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "25ae6f96-76d5-40a7-bbbb-a65f76c10619");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "28ca3f22-dde6-4480-8a0b-3b4908ea93c3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "292f6078-8810-4865-a51a-bfc1e3c91ff0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2bab5374-f11e-4c4f-9101-a3b8f79b126f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2fb29f71-0b8f-48eb-892e-42fbbc0dcf1c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "36405791-37cb-4946-99f9-ec7ecb8201a7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3cb9899a-4fd4-4599-8b49-00966f7aa8f9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "46a8c774-1095-4b3d-9a8b-88b55713c614");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "477cb8da-0366-49fb-8466-2f0565d41114");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "492c007f-bdd5-4aef-a3eb-20778d3a269f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4b646b8a-eba2-45c5-8133-5a3cbf690117");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4c324b77-950a-49ef-97f3-721ec153e2f5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4f70900d-4a81-401d-b7bc-fa0823e38e7d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "59a4f5a2-fbee-42d7-a226-cea3d057e079");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6026db88-6583-4dcc-9198-435519e2bd34");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7d0cf997-4965-400a-b81e-616c9c15526e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "82ce7c15-5d9d-4b29-9f01-59cabdf0239e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "85b55b24-3a8e-498d-a60e-a13c33c0b925");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9088ff5d-1090-423b-8311-81438bab2f71");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "94cac223-5abd-4bac-8223-3cc6ae171906");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9efcb441-34b0-4ca9-bd17-89c2256ba15f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a591d88e-951d-4781-a83b-42aa6bc49578");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "add6aa62-88b2-406a-9ad2-10fdab522e26");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c5cc44d9-fdaf-4432-9673-41525d501fc5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d8c3c38b-fa99-4b01-87c9-1c7965fbe6f3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f5ccd8b1-26f9-4d1b-8e77-d49e84d4465f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fa5c6799-56f8-4ad2-8e73-f67134d0f6d4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ff9f8f14-8e11-4bd6-b220-a8fa02379b25");

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
