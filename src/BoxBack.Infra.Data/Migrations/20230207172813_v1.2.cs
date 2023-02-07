using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BoxBack.Infra.Data.Migrations
{
    public partial class v12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<Guid>(
                name: "PessoaId",
                table: "Despesas",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "Pessoas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    NomeFantasia = table.Column<string>(type: "text", nullable: true),
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
                    table.PrimaryKey("PK_Pessoas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pessoas_Tenants_TenantId",
                        column: x => x.TenantId,
                        principalTable: "Tenants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetGroups",
                keyColumn: "Id",
                keyValue: new Guid("23e63d9c-283b-496b-b7d8-7dac2ef7a822"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 7, 14, 28, 12, 878, DateTimeKind.Unspecified).AddTicks(2580), new TimeSpan(0, -3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 2, 7, 14, 28, 12, 878, DateTimeKind.Unspecified).AddTicks(2639), new TimeSpan(0, -3, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "Actions", "ConcurrencyStamp", "Description", "Name", "NormalizedName", "Subject" },
                values: new object[,]
                {
                    { "00b8d2af-4208-4a40-bb6c-137d624bd4cf", new[] { 5 }, "42fa0a37-77ee-41cf-ae0e-1acbff894ca2", "Pode deletar um grupo", "CanGroupDelete", "CANGROUPDELETE", "ac-group-page" },
                    { "01a45822-8a86-40a7-9fba-ac2832e07c8a", new[] { 2 }, "5fcde7a9-70de-43fa-8173-350fd3111243", "Pode listar os dado de um cliente", "CanClienteRead", "CANCLIENTEREAD", "ac-cliente-page" },
                    { "07e2cb13-b024-4f22-b1c3-cdb442c206ea", new[] { 5 }, "500a86e4-6086-4d35-a161-3a5079214504", "Pode deletar um usuário", "CanUserDelete", "CANUSERDELETE", "ac-user-page" },
                    { "082e597d-b800-4fb8-a1f1-4510f21bfde4", new[] { 5 }, "554900b6-1055-4020-9ae2-3c20cd1e24ed", "Pode deletar um cliente", "CanClienteDelete", "CANCLIENTEDELETE", "ac-cliente-page" },
                    { "0a249490-6061-49bf-9b01-004b334e07dd", new[] { 4 }, "69222a60-abcd-402f-b3a4-dbd3004c327a", "Pode atualizar os dados de um cliente", "CanClienteUpdate", "CANCLIENTEUPDATE", "ac-cliente-page" },
                    { "151441de-b9cb-41ee-802f-112ee5c4b7f8", new[] { 4 }, "65f6e7ab-6880-42d7-8423-fbb511a54889", "Pode atualizar os dados de uma roles/permissão", "CanRoleUpdate", "CANROLEUPDATE", "ac-role-page" },
                    { "1a041e1b-bf34-4716-bc1a-07779e21f500", new[] { 1, 2, 3, 4, 5 }, "2135201c-6c2e-47dd-9365-7ff984c9ec1c", "Pode realizar todas as ações/operações em todas as despesas", "CanDespesaAll", "CANDESPESAALL", "ac-despesa-page" },
                    { "1db6b8cb-c077-48ec-8bb1-e17f664b5d32", new[] { 1 }, "53e39d47-ff02-4ee8-80a4-b7d11be7d8d9", "Pode listar os dados de todas as despesas", "CanDespesaList", "CANDESPESALIST", "ac-despesa-page" },
                    { "2112483e-6e6e-40da-b754-7935f4465a35", new[] { 1 }, "394f5b0f-c2ce-4386-b89c-f210c9565bdf", "Pode listar os dados de todas as roles/permissões", "CanRoleList", "CANROLELIST", "ac-role-page" },
                    { "24047791-d3b6-4fc9-8832-d058c5d49635", new[] { 1 }, "c5ac4805-bc82-4c9a-9aaa-b96b4ff31df2", "Pode listar os dados de todos os clientes", "CanClienteList", "CANCLIENTELIST", "ac-cliente-page" },
                    { "2aea49cc-07de-4fff-9aad-23a9d5241cb9", new[] { 1, 2, 3, 4, 5 }, "de27d936-dc13-4411-a82f-1d2a2d40c931", "Pode realizar todas as ações/operações em todos os clientes", "CanClienteAll", "CANCLIENTEALL", "ac-cliente-page" },
                    { "36b11e8f-fc9b-4974-85d8-15936731f67a", new[] { 1, 2, 3, 4, 5 }, "d0c025a1-1fd9-4b25-9e5c-d81ade989200", "Pode realizar todas as ações/operações em todos as roles/permissões", "CanRoleAll", "CANROLEALL", "ac-role-page" },
                    { "387d8f0d-884b-48e8-95a3-d297ee6e404e", new[] { 4 }, "6045045a-d066-4961-b429-b0d9ce2620e3", "Pode atualizar os dados de um usuário", "CanUserUpdate", "CANUSERUPDATE", "ac-user-page" },
                    { "388fad2e-3baa-40bf-8f20-9697d818f360", new[] { 3 }, "90454517-dda8-42b0-8c1c-b2b2c6793ea2", "Pode criar um cliente", "CanClienteCreate", "CANCLIENTECREATE", "ac-cliente-page" },
                    { "38feb468-0f31-4741-8c94-dcc621b88843", new[] { 1 }, "06db1d40-3463-4cab-ba4a-d0ab0c31f637", "Pode listar o título dos negócios", "CanTitleBussinesList", "CANTITLEBUSSINESLIST", "ac-titleBussines-page" },
                    { "3cf8b154-30f7-476e-adbe-1eaa94b210a8", new[] { 1 }, "fb4c2f1a-3c4c-41d3-9fc0-b26d53178d63", "Pode listar os dados de todos os grupos", "CanGroupList", "CANGROUPLIST", "ac-group-page" },
                    { "4a674bf0-f8c9-48ec-b71b-b248e7deff39", new[] { 2 }, "6a70b865-7827-4cd4-89be-5e3eeb0253ff", "Pode listar os dado de um grupo", "CanGroupRead", "CANGROUPREAD", "ac-group-page" },
                    { "4ff2ee7c-79f2-42e9-8252-901446cee4ed", new[] { 2 }, "998cc883-32c5-462c-8c43-5a29f10c604a", "Pode listar os dados de uma roles/permissão", "CanRoleRead", "CANROLEREAD", "ac-role-page" },
                    { "51f1fcc8-00e5-46de-93aa-31eef21a7c53", new[] { 1 }, "55a3114a-0f5e-480c-9110-9fe6e4d10c9b", "Pode listar os dados de todos os usuários", "CanUserList", "CANUSERLIST", "ac-user-page" },
                    { "62d84746-d1e2-45ae-89b4-14c23d345d6d", new[] { 3 }, "f8eb8e69-0f4f-44d6-a365-812886c91fd3", "Pode criar um grupo", "CanGroupCreate", "CANGROUPCREATE", "ac-group-page" },
                    { "66e14553-b41c-4903-8f97-cecfa900c324", new[] { 1, 2, 3, 4, 5 }, "6ba10531-cbc1-439f-93f2-7279d491cca1", "Pode realizar todas as ações/operações em todas as dashboards", "CanDashboardAll", "CANDASHBOARDALL", "ac-dashboard-page" },
                    { "7818e3cb-325c-4fcc-8566-bb3cc8667236", new[] { 3 }, "c2d8e0ec-0841-4639-9e4a-4fbfeac41cb3", "Pode criar um usuário", "CanUserCreate", "CANUSERCREATE", "ac-user-page" },
                    { "8596f748-a4ec-4464-86b0-ea635739c66a", new[] { 2 }, "7e5afda9-9a4b-47cf-a1c4-51d95b71cfba", "Pode listar os dados de uma despesa", "CanDespesaRead", "CANDESPESAREAD", "ac-despesa-page" },
                    { "8f370c6f-2914-4b5b-b3ad-953df9ba8eba", new[] { 3 }, "e6cb8c54-c1dd-4160-b831-163a1917680b", "Pode criar uma role/permissão", "CanRoleCreate", "CANROLECREATE", "ac-role-page" },
                    { "979bcfa1-50e0-4e84-b122-e00b0c41c17b", new[] { 1 }, "310edb66-da36-48d8-a3de-cf817815584c", "Pode listar o título do sistema", "CanTitleSystemList", "CANTITLESYSTEMLIST", "ac-titleSystem-page" },
                    { "9b94820d-91f5-4e66-a083-7ac600b5461d", new[] { 3 }, "57cb7fa8-e352-40f3-910f-3b921eba4d7c", "Pode criar uma despesa", "CanDespesaCreate", "CANDESPESACREATE", "ac-despesa-page" },
                    { "9c4c83e0-8b8e-4f14-956d-e89b0d525b57", new[] { 4 }, "89d7bbb4-9c92-4182-8a1a-595d203fa51d", "Pode atualizar os dados de um grupo", "CanGroupUpdate", "CANGROUPUPDATE", "ac-group-page" },
                    { "a6365a4a-c173-40e8-8fd1-c4c0b108e882", new[] { 5 }, "45afaac9-ddce-47ca-b868-55136fd0830b", "Pode deletar uma despesa", "CanDespesaDelete", "CANDESPESADELETE", "ac-despesa-page" },
                    { "a78fe174-e2f3-48c9-b4b8-d2070d8a1c89", new[] { 5 }, "8d6eb61e-3125-4f7d-b6a2-05540753b442", "Pode deletar uma role/permissão", "CanRoleDelete", "CANROLEDELETE", "ac-role-page" },
                    { "af13ab9d-d6b0-49bb-86d6-303bb4ce74cf", new[] { 1, 2, 3, 4, 5 }, "efb1233b-6e7a-436c-9b6d-26fb3b7619e3", "Pode realizar todas as ações/operações em todos os grupos", "CanGroupAll", "CANGROUPALL", "ac-group-page" },
                    { "bf69d5fb-3c23-421e-8f46-7669ce51152f", new[] { 1, 2, 3, 4, 5 }, "9b92e7df-50a5-43a2-9130-ffd9ef762d00", "Pode realizar todas as ações/operações em dashboard publica", "CanDashboardPublicaAll", "CANDASHBOARDPUBLICAALL", "ac-dashboardPublica-page" },
                    { "d03c95e7-dc5f-4c8b-9863-da4f822e00e6", new[] { 2 }, "387bcd2c-85b5-4755-ab15-06fddcfb4b1e", "Pode listar os dados de um usuários", "CanUserRead", "CANUSERREAD", "ac-user-page" },
                    { "eb976af7-d115-41fb-8a02-83556aaccf33", new[] { 1, 2, 3, 4, 5 }, "77624b84-6d15-493d-850f-472ee193b419", "Pode realizar todas as ações/operações em todos os usuários", "CanUserAll", "CANUSERALL", "ac-user-page" },
                    { "f719b3c6-3c71-4696-89b8-af4b4d8999da", new[] { 4 }, "bde4c6ef-bbc0-4aec-945e-2f0af6ca1310", "Pode atualizar os dados de uma despesa", "CanDespesaUpdate", "CANDESPESAUPDATE", "ac-despesa-page" }
                });

            migrationBuilder.UpdateData(
                table: "Tenants",
                keyColumn: "Id",
                keyValue: new Guid("d8fe3845-3f2e-4b4e-aeb6-53222d60ff45"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 7, 14, 28, 12, 876, DateTimeKind.Unspecified).AddTicks(6728), new TimeSpan(0, -3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 2, 7, 14, 28, 12, 876, DateTimeKind.Unspecified).AddTicks(6757), new TimeSpan(0, -3, 0, 0, 0)) });

            migrationBuilder.CreateIndex(
                name: "IX_Despesas_PessoaId",
                table: "Despesas",
                column: "PessoaId");

            migrationBuilder.CreateIndex(
                name: "IX_Pessoas_TenantId",
                table: "Pessoas",
                column: "TenantId");

            migrationBuilder.AddForeignKey(
                name: "FK_Despesas_Pessoas_PessoaId",
                table: "Despesas",
                column: "PessoaId",
                principalTable: "Pessoas",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Despesas_Pessoas_PessoaId",
                table: "Despesas");

            migrationBuilder.DropTable(
                name: "Pessoas");

            migrationBuilder.DropIndex(
                name: "IX_Despesas_PessoaId",
                table: "Despesas");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00b8d2af-4208-4a40-bb6c-137d624bd4cf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "01a45822-8a86-40a7-9fba-ac2832e07c8a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "07e2cb13-b024-4f22-b1c3-cdb442c206ea");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "082e597d-b800-4fb8-a1f1-4510f21bfde4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0a249490-6061-49bf-9b01-004b334e07dd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "151441de-b9cb-41ee-802f-112ee5c4b7f8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1a041e1b-bf34-4716-bc1a-07779e21f500");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1db6b8cb-c077-48ec-8bb1-e17f664b5d32");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2112483e-6e6e-40da-b754-7935f4465a35");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "24047791-d3b6-4fc9-8832-d058c5d49635");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2aea49cc-07de-4fff-9aad-23a9d5241cb9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "36b11e8f-fc9b-4974-85d8-15936731f67a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "387d8f0d-884b-48e8-95a3-d297ee6e404e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "388fad2e-3baa-40bf-8f20-9697d818f360");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "38feb468-0f31-4741-8c94-dcc621b88843");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3cf8b154-30f7-476e-adbe-1eaa94b210a8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4a674bf0-f8c9-48ec-b71b-b248e7deff39");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4ff2ee7c-79f2-42e9-8252-901446cee4ed");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "51f1fcc8-00e5-46de-93aa-31eef21a7c53");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "62d84746-d1e2-45ae-89b4-14c23d345d6d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "66e14553-b41c-4903-8f97-cecfa900c324");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7818e3cb-325c-4fcc-8566-bb3cc8667236");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8596f748-a4ec-4464-86b0-ea635739c66a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8f370c6f-2914-4b5b-b3ad-953df9ba8eba");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "979bcfa1-50e0-4e84-b122-e00b0c41c17b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9b94820d-91f5-4e66-a083-7ac600b5461d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9c4c83e0-8b8e-4f14-956d-e89b0d525b57");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a6365a4a-c173-40e8-8fd1-c4c0b108e882");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a78fe174-e2f3-48c9-b4b8-d2070d8a1c89");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "af13ab9d-d6b0-49bb-86d6-303bb4ce74cf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bf69d5fb-3c23-421e-8f46-7669ce51152f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d03c95e7-dc5f-4c8b-9863-da4f822e00e6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eb976af7-d115-41fb-8a02-83556aaccf33");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f719b3c6-3c71-4696-89b8-af4b4d8999da");

            migrationBuilder.DropColumn(
                name: "PessoaId",
                table: "Despesas");

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
        }
    }
}
