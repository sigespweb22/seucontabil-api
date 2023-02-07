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
                    NaturezaPessoa = table.Column<int>(type: "integer", nullable: true),
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
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 7, 14, 47, 15, 126, DateTimeKind.Unspecified).AddTicks(9613), new TimeSpan(0, -3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 2, 7, 14, 47, 15, 126, DateTimeKind.Unspecified).AddTicks(9638), new TimeSpan(0, -3, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "Actions", "ConcurrencyStamp", "Description", "Name", "NormalizedName", "Subject" },
                values: new object[,]
                {
                    { "0fafd1b0-dd7b-413b-8840-8dc1e1970ac0", new[] { 5 }, "c0ec27c9-28eb-4db0-ad3c-70340b386c05", "Pode deletar um usuário", "CanUserDelete", "CANUSERDELETE", "ac-user-page" },
                    { "131186c9-5e41-4309-9ade-af8711d1c502", new[] { 4 }, "863f67dd-61c8-43d4-8cb8-41677788d84b", "Pode atualizar os dados de uma roles/permissão", "CanRoleUpdate", "CANROLEUPDATE", "ac-role-page" },
                    { "1b77c372-fe50-480d-9a42-437a153e1da3", new[] { 5 }, "d5d886eb-9914-4b95-911e-596953119530", "Pode deletar uma role/permissão", "CanRoleDelete", "CANROLEDELETE", "ac-role-page" },
                    { "35fb2fed-ebde-4844-80d6-e4b33811fd41", new[] { 1, 2, 3, 4, 5 }, "29fe22e2-77de-48c4-951f-c159cc57decb", "Pode realizar todas as ações/operações em dashboard publica", "CanDashboardPublicaAll", "CANDASHBOARDPUBLICAALL", "ac-dashboardPublica-page" },
                    { "3eafc6b4-afcd-4179-914e-8f281a188fe5", new[] { 5 }, "4875ffc4-e97e-4e1c-90fb-01da6d9c00ef", "Pode deletar uma despesa", "CanDespesaDelete", "CANDESPESADELETE", "ac-despesa-page" },
                    { "405c9e0b-5119-4186-8c12-f2ca57818b7e", new[] { 1 }, "03db8363-2254-441f-8055-e0176eebcf50", "Pode listar os dados de todas as despesas", "CanDespesaList", "CANDESPESALIST", "ac-despesa-page" },
                    { "41f844bb-b636-4a30-9055-3a06c1a73fe2", new[] { 4 }, "95ac8ce2-19ef-4eba-b8ac-f71f21db3c5c", "Pode atualizar os dados de um grupo", "CanGroupUpdate", "CANGROUPUPDATE", "ac-group-page" },
                    { "4a219d4d-c8c1-48c1-b8e6-163fd82868bf", new[] { 1, 2, 3, 4, 5 }, "c6a02730-a3f8-46d7-8a1c-a84f048b64cf", "Pode realizar todas as ações/operações em todas as despesas", "CanDespesaAll", "CANDESPESAALL", "ac-despesa-page" },
                    { "4f084469-45c3-435b-bd80-2a1249a14414", new[] { 1, 2, 3, 4, 5 }, "fbe6e26e-1293-4d0d-91dc-c9f6a1d13573", "Pode realizar todas as ações/operações em todos os clientes", "CanClienteAll", "CANCLIENTEALL", "ac-cliente-page" },
                    { "501714ad-c893-49fb-b7f5-65108d344720", new[] { 5 }, "234988d3-36e1-4766-a073-963194c8fa1b", "Pode deletar um grupo", "CanGroupDelete", "CANGROUPDELETE", "ac-group-page" },
                    { "5224c4d3-0cce-41f9-a66e-c341145c0733", new[] { 1 }, "80f24ebb-39b2-427f-a2e8-5a327e9b509c", "Pode listar os dados de todas as roles/permissões", "CanRoleList", "CANROLELIST", "ac-role-page" },
                    { "56028427-b01d-4be5-bd71-63c11b2523e7", new[] { 4 }, "dc98df87-441c-427c-ad4f-c4563bbbb3ae", "Pode atualizar os dados de uma despesa", "CanDespesaUpdate", "CANDESPESAUPDATE", "ac-despesa-page" },
                    { "6049a46c-31c1-4390-b6e6-93b667a9ef1c", new[] { 1 }, "37bd488b-1fb7-435e-9b7a-bb604421d4a5", "Pode listar os dados de todos os grupos", "CanGroupList", "CANGROUPLIST", "ac-group-page" },
                    { "74671286-67a0-43c2-9fe2-6668009441c4", new[] { 4 }, "7bd0a3e7-4755-4060-a9df-7cedaf55d250", "Pode atualizar os dados de um cliente", "CanClienteUpdate", "CANCLIENTEUPDATE", "ac-cliente-page" },
                    { "76098d24-666f-4ef2-8b7a-3ef425f58c42", new[] { 3 }, "61408a68-dea3-490a-b025-3f702fb1566e", "Pode criar uma role/permissão", "CanRoleCreate", "CANROLECREATE", "ac-role-page" },
                    { "76a868d7-eca3-4153-a425-46b0c9cdf257", new[] { 2 }, "2771ce4e-d94a-41cf-8a09-b8a32a467b49", "Pode listar os dado de um grupo", "CanGroupRead", "CANGROUPREAD", "ac-group-page" },
                    { "80b38e61-90dd-41aa-9f82-8f4c20a1e87c", new[] { 3 }, "3ba401b9-8a2c-46ae-8dd6-ffe1591822b6", "Pode criar um usuário", "CanUserCreate", "CANUSERCREATE", "ac-user-page" },
                    { "8453d396-9b3a-4300-ac4d-027a0fd64db5", new[] { 2 }, "2dc7202b-1177-47db-ae19-901a7115a4de", "Pode listar os dados de um usuários", "CanUserRead", "CANUSERREAD", "ac-user-page" },
                    { "86660719-cc7a-414e-9a69-0407b5cea790", new[] { 2 }, "4ab6730e-8b0e-4d13-9a29-9d33e50d5831", "Pode listar os dados de uma despesa", "CanDespesaRead", "CANDESPESAREAD", "ac-despesa-page" },
                    { "8c98fe87-0082-44b3-a5c0-a6b39a8e56f7", new[] { 1 }, "879b1a92-b07b-4ffe-8b3a-c574383e0b09", "Pode listar os dados de todos os clientes", "CanClienteList", "CANCLIENTELIST", "ac-cliente-page" },
                    { "8d31cf7a-97b9-41ff-ae70-c03ced212c37", new[] { 4 }, "8ecba72c-8c8d-46c6-b742-f95680484004", "Pode atualizar os dados de um usuário", "CanUserUpdate", "CANUSERUPDATE", "ac-user-page" },
                    { "94cbf0c9-1ba2-46be-aab6-0372cb357ad1", new[] { 1, 2, 3, 4, 5 }, "af63fd31-1fa3-48c0-8bff-b667c0cc2bde", "Pode realizar todas as ações/operações em todas as dashboards", "CanDashboardAll", "CANDASHBOARDALL", "ac-dashboard-page" },
                    { "96639b1f-74d3-44f0-b623-f44e00a3c4a2", new[] { 2 }, "fa1d861c-2c50-4ab4-af6a-93bd75b10ffc", "Pode listar os dado de um cliente", "CanClienteRead", "CANCLIENTEREAD", "ac-cliente-page" },
                    { "99cbc3dc-3fd3-47a8-9933-2f368a851f3c", new[] { 1 }, "3372b96f-a0cb-477c-a1ae-e834bbe99f7d", "Pode listar o título do sistema", "CanTitleSystemList", "CANTITLESYSTEMLIST", "ac-titleSystem-page" },
                    { "aaed25e4-8b5e-427a-b1a0-19353ca89998", new[] { 2 }, "5f5e369b-7964-4c02-87ba-71bffc06001a", "Pode listar os dados de uma roles/permissão", "CanRoleRead", "CANROLEREAD", "ac-role-page" },
                    { "ac8dc43b-b039-4f6f-b66b-ff7a26440d34", new[] { 1, 2, 3, 4, 5 }, "7d6a9e1e-edd8-4bb2-942b-6e9c600b200e", "Pode realizar todas as ações/operações em todos os grupos", "CanGroupAll", "CANGROUPALL", "ac-group-page" },
                    { "bee09b99-5697-429a-bee8-c3f5a15abf71", new[] { 3 }, "e1b6a971-5945-40f8-9098-e2d18e9f6d25", "Pode criar uma despesa", "CanDespesaCreate", "CANDESPESACREATE", "ac-despesa-page" },
                    { "cc8645fa-14f9-4aca-93d5-0ce5d8ee0f8c", new[] { 3 }, "1adeaaec-f09d-4224-95a0-5c671f042994", "Pode criar um cliente", "CanClienteCreate", "CANCLIENTECREATE", "ac-cliente-page" },
                    { "cf2d6fe5-4c8d-403e-98be-7f7ecdd2d515", new[] { 1 }, "b806d4b3-c8bd-4981-9f33-0035fda697cc", "Pode listar o título dos negócios", "CanTitleBussinesList", "CANTITLEBUSSINESLIST", "ac-titleBussines-page" },
                    { "d28aa94e-4292-48a0-889a-1c496d8f59c8", new[] { 3 }, "6a78922b-f311-49f5-84b5-6280fdad319b", "Pode criar um grupo", "CanGroupCreate", "CANGROUPCREATE", "ac-group-page" },
                    { "dd1add10-403b-42cc-b002-3fd17f345bbd", new[] { 1, 2, 3, 4, 5 }, "3cb5eede-2c12-4aa1-bd5a-86355f1917e8", "Pode realizar todas as ações/operações em todos os usuários", "CanUserAll", "CANUSERALL", "ac-user-page" },
                    { "e55bebb9-f5b5-49f5-b21e-82629ca8d2d7", new[] { 1 }, "0964b237-8ea8-4d00-9ac4-89b05a042a2b", "Pode listar os dados de todos os usuários", "CanUserList", "CANUSERLIST", "ac-user-page" },
                    { "fb2d8740-1ece-4979-841e-8603b623f537", new[] { 1, 2, 3, 4, 5 }, "ce32e29b-2c7f-4cb7-ab2d-721d3aedd801", "Pode realizar todas as ações/operações em todos as roles/permissões", "CanRoleAll", "CANROLEALL", "ac-role-page" },
                    { "fc913346-eb42-4fc7-9808-8d739c578d17", new[] { 5 }, "217a2c26-01ff-4941-92f0-cc1bdd8d493c", "Pode deletar um cliente", "CanClienteDelete", "CANCLIENTEDELETE", "ac-cliente-page" }
                });

            migrationBuilder.UpdateData(
                table: "Tenants",
                keyColumn: "Id",
                keyValue: new Guid("d8fe3845-3f2e-4b4e-aeb6-53222d60ff45"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 7, 14, 47, 15, 125, DateTimeKind.Unspecified).AddTicks(5553), new TimeSpan(0, -3, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 2, 7, 14, 47, 15, 125, DateTimeKind.Unspecified).AddTicks(5588), new TimeSpan(0, -3, 0, 0, 0)) });

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
                keyValue: "0fafd1b0-dd7b-413b-8840-8dc1e1970ac0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "131186c9-5e41-4309-9ade-af8711d1c502");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1b77c372-fe50-480d-9a42-437a153e1da3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "35fb2fed-ebde-4844-80d6-e4b33811fd41");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3eafc6b4-afcd-4179-914e-8f281a188fe5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "405c9e0b-5119-4186-8c12-f2ca57818b7e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "41f844bb-b636-4a30-9055-3a06c1a73fe2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4a219d4d-c8c1-48c1-b8e6-163fd82868bf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4f084469-45c3-435b-bd80-2a1249a14414");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "501714ad-c893-49fb-b7f5-65108d344720");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5224c4d3-0cce-41f9-a66e-c341145c0733");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "56028427-b01d-4be5-bd71-63c11b2523e7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6049a46c-31c1-4390-b6e6-93b667a9ef1c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "74671286-67a0-43c2-9fe2-6668009441c4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "76098d24-666f-4ef2-8b7a-3ef425f58c42");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "76a868d7-eca3-4153-a425-46b0c9cdf257");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "80b38e61-90dd-41aa-9f82-8f4c20a1e87c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8453d396-9b3a-4300-ac4d-027a0fd64db5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "86660719-cc7a-414e-9a69-0407b5cea790");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8c98fe87-0082-44b3-a5c0-a6b39a8e56f7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8d31cf7a-97b9-41ff-ae70-c03ced212c37");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "94cbf0c9-1ba2-46be-aab6-0372cb357ad1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "96639b1f-74d3-44f0-b623-f44e00a3c4a2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "99cbc3dc-3fd3-47a8-9933-2f368a851f3c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aaed25e4-8b5e-427a-b1a0-19353ca89998");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ac8dc43b-b039-4f6f-b66b-ff7a26440d34");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bee09b99-5697-429a-bee8-c3f5a15abf71");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cc8645fa-14f9-4aca-93d5-0ce5d8ee0f8c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cf2d6fe5-4c8d-403e-98be-7f7ecdd2d515");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d28aa94e-4292-48a0-889a-1c496d8f59c8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dd1add10-403b-42cc-b002-3fd17f345bbd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e55bebb9-f5b5-49f5-b21e-82629ca8d2d7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fb2d8740-1ece-4979-841e-8603b623f537");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fc913346-eb42-4fc7-9808-8d739c578d17");

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
