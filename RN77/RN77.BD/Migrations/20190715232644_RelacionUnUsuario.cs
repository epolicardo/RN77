using Microsoft.EntityFrameworkCore.Migrations;

namespace RN77.BD.Migrations
{
    public partial class RelacionUnUsuario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UsuarioId",
                table: "TTels",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UsuarioId",
                table: "TNotas",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UsuarioId",
                table: "TMails",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UsuarioId",
                table: "Tels",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UsuarioId",
                table: "TDomicilios",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UsuarioId",
                table: "TDocumentos",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UsuarioId",
                table: "TCharlas",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UsuarioId",
                table: "PersonaTels",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UsuarioId",
                table: "Personas",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UsuarioId",
                table: "PersonaMails",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UsuarioId",
                table: "PersonaDomicilios",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UsuarioId",
                table: "PersonaDocumentos",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UsuarioId",
                table: "Materias",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UsuarioId",
                table: "Mails",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UsuarioId",
                table: "InstitucionTels",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UsuarioId",
                table: "InstitucionMails",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UsuarioId",
                table: "Instituciones",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UsuarioId",
                table: "InstitucionDomicilios",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UsuarioId",
                table: "InstitucionDocumentos",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UsuarioId",
                table: "Domicilios",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UsuarioId",
                table: "Documentos",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UsuarioId",
                table: "Charlas",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UsuarioId",
                table: "CharlaPersonas",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UsuarioId",
                table: "CharlaLeeDigos",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UsuarioId",
                table: "CharlaDigos",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UsuarioId",
                table: "CharlaDigoLinks",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UsuarioId",
                table: "CharlaDigoArchivos",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UsuarioId",
                table: "Carreras",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UsuarioId",
                table: "CarreraMaterias",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UsuarioId",
                table: "AulaTemaClases",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UsuarioId",
                table: "Aulas",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UsuarioId",
                table: "AulaNotas",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UsuarioId",
                table: "AulaGrupos",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UsuarioId",
                table: "AulaGrupoAlumnos",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UsuarioId",
                table: "AulaEvaluaciones",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UsuarioId",
                table: "AulaDocentes",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UsuarioId",
                table: "AulaAsistencias",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UsuarioId",
                table: "AulaAlumnos",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_TTels_UsuarioId",
                table: "TTels",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_TNotas_UsuarioId",
                table: "TNotas",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_TMails_UsuarioId",
                table: "TMails",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Tels_UsuarioId",
                table: "Tels",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_TDomicilios_UsuarioId",
                table: "TDomicilios",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_TDocumentos_UsuarioId",
                table: "TDocumentos",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_TCharlas_UsuarioId",
                table: "TCharlas",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonaTels_UsuarioId",
                table: "PersonaTels",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_UsuarioId",
                table: "Personas",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonaMails_UsuarioId",
                table: "PersonaMails",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonaDomicilios_UsuarioId",
                table: "PersonaDomicilios",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonaDocumentos_UsuarioId",
                table: "PersonaDocumentos",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Materias_UsuarioId",
                table: "Materias",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Mails_UsuarioId",
                table: "Mails",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_InstitucionTels_UsuarioId",
                table: "InstitucionTels",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_InstitucionMails_UsuarioId",
                table: "InstitucionMails",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Instituciones_UsuarioId",
                table: "Instituciones",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_InstitucionDomicilios_UsuarioId",
                table: "InstitucionDomicilios",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_InstitucionDocumentos_UsuarioId",
                table: "InstitucionDocumentos",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Domicilios_UsuarioId",
                table: "Domicilios",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Documentos_UsuarioId",
                table: "Documentos",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Charlas_UsuarioId",
                table: "Charlas",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_CharlaPersonas_UsuarioId",
                table: "CharlaPersonas",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_CharlaLeeDigos_UsuarioId",
                table: "CharlaLeeDigos",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_CharlaDigos_UsuarioId",
                table: "CharlaDigos",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_CharlaDigoLinks_UsuarioId",
                table: "CharlaDigoLinks",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_CharlaDigoArchivos_UsuarioId",
                table: "CharlaDigoArchivos",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Carreras_UsuarioId",
                table: "Carreras",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_CarreraMaterias_UsuarioId",
                table: "CarreraMaterias",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_AulaTemaClases_UsuarioId",
                table: "AulaTemaClases",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Aulas_UsuarioId",
                table: "Aulas",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_AulaNotas_UsuarioId",
                table: "AulaNotas",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_AulaGrupos_UsuarioId",
                table: "AulaGrupos",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_AulaGrupoAlumnos_UsuarioId",
                table: "AulaGrupoAlumnos",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_AulaEvaluaciones_UsuarioId",
                table: "AulaEvaluaciones",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_AulaDocentes_UsuarioId",
                table: "AulaDocentes",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_AulaAsistencias_UsuarioId",
                table: "AulaAsistencias",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_AulaAlumnos_UsuarioId",
                table: "AulaAlumnos",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_AulaAlumnos_AspNetUsers_UsuarioId",
                table: "AulaAlumnos",
                column: "UsuarioId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AulaAsistencias_AspNetUsers_UsuarioId",
                table: "AulaAsistencias",
                column: "UsuarioId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AulaDocentes_AspNetUsers_UsuarioId",
                table: "AulaDocentes",
                column: "UsuarioId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AulaEvaluaciones_AspNetUsers_UsuarioId",
                table: "AulaEvaluaciones",
                column: "UsuarioId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AulaGrupoAlumnos_AspNetUsers_UsuarioId",
                table: "AulaGrupoAlumnos",
                column: "UsuarioId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AulaGrupos_AspNetUsers_UsuarioId",
                table: "AulaGrupos",
                column: "UsuarioId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AulaNotas_AspNetUsers_UsuarioId",
                table: "AulaNotas",
                column: "UsuarioId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Aulas_AspNetUsers_UsuarioId",
                table: "Aulas",
                column: "UsuarioId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AulaTemaClases_AspNetUsers_UsuarioId",
                table: "AulaTemaClases",
                column: "UsuarioId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CarreraMaterias_AspNetUsers_UsuarioId",
                table: "CarreraMaterias",
                column: "UsuarioId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Carreras_AspNetUsers_UsuarioId",
                table: "Carreras",
                column: "UsuarioId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CharlaDigoArchivos_AspNetUsers_UsuarioId",
                table: "CharlaDigoArchivos",
                column: "UsuarioId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CharlaDigoLinks_AspNetUsers_UsuarioId",
                table: "CharlaDigoLinks",
                column: "UsuarioId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CharlaDigos_AspNetUsers_UsuarioId",
                table: "CharlaDigos",
                column: "UsuarioId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CharlaLeeDigos_AspNetUsers_UsuarioId",
                table: "CharlaLeeDigos",
                column: "UsuarioId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CharlaPersonas_AspNetUsers_UsuarioId",
                table: "CharlaPersonas",
                column: "UsuarioId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Charlas_AspNetUsers_UsuarioId",
                table: "Charlas",
                column: "UsuarioId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Documentos_AspNetUsers_UsuarioId",
                table: "Documentos",
                column: "UsuarioId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Domicilios_AspNetUsers_UsuarioId",
                table: "Domicilios",
                column: "UsuarioId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_InstitucionDocumentos_AspNetUsers_UsuarioId",
                table: "InstitucionDocumentos",
                column: "UsuarioId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_InstitucionDomicilios_AspNetUsers_UsuarioId",
                table: "InstitucionDomicilios",
                column: "UsuarioId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Instituciones_AspNetUsers_UsuarioId",
                table: "Instituciones",
                column: "UsuarioId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_InstitucionMails_AspNetUsers_UsuarioId",
                table: "InstitucionMails",
                column: "UsuarioId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_InstitucionTels_AspNetUsers_UsuarioId",
                table: "InstitucionTels",
                column: "UsuarioId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Mails_AspNetUsers_UsuarioId",
                table: "Mails",
                column: "UsuarioId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Materias_AspNetUsers_UsuarioId",
                table: "Materias",
                column: "UsuarioId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PersonaDocumentos_AspNetUsers_UsuarioId",
                table: "PersonaDocumentos",
                column: "UsuarioId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PersonaDomicilios_AspNetUsers_UsuarioId",
                table: "PersonaDomicilios",
                column: "UsuarioId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PersonaMails_AspNetUsers_UsuarioId",
                table: "PersonaMails",
                column: "UsuarioId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Personas_AspNetUsers_UsuarioId",
                table: "Personas",
                column: "UsuarioId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PersonaTels_AspNetUsers_UsuarioId",
                table: "PersonaTels",
                column: "UsuarioId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TCharlas_AspNetUsers_UsuarioId",
                table: "TCharlas",
                column: "UsuarioId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TDocumentos_AspNetUsers_UsuarioId",
                table: "TDocumentos",
                column: "UsuarioId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TDomicilios_AspNetUsers_UsuarioId",
                table: "TDomicilios",
                column: "UsuarioId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tels_AspNetUsers_UsuarioId",
                table: "Tels",
                column: "UsuarioId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TMails_AspNetUsers_UsuarioId",
                table: "TMails",
                column: "UsuarioId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TNotas_AspNetUsers_UsuarioId",
                table: "TNotas",
                column: "UsuarioId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TTels_AspNetUsers_UsuarioId",
                table: "TTels",
                column: "UsuarioId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AulaAlumnos_AspNetUsers_UsuarioId",
                table: "AulaAlumnos");

            migrationBuilder.DropForeignKey(
                name: "FK_AulaAsistencias_AspNetUsers_UsuarioId",
                table: "AulaAsistencias");

            migrationBuilder.DropForeignKey(
                name: "FK_AulaDocentes_AspNetUsers_UsuarioId",
                table: "AulaDocentes");

            migrationBuilder.DropForeignKey(
                name: "FK_AulaEvaluaciones_AspNetUsers_UsuarioId",
                table: "AulaEvaluaciones");

            migrationBuilder.DropForeignKey(
                name: "FK_AulaGrupoAlumnos_AspNetUsers_UsuarioId",
                table: "AulaGrupoAlumnos");

            migrationBuilder.DropForeignKey(
                name: "FK_AulaGrupos_AspNetUsers_UsuarioId",
                table: "AulaGrupos");

            migrationBuilder.DropForeignKey(
                name: "FK_AulaNotas_AspNetUsers_UsuarioId",
                table: "AulaNotas");

            migrationBuilder.DropForeignKey(
                name: "FK_Aulas_AspNetUsers_UsuarioId",
                table: "Aulas");

            migrationBuilder.DropForeignKey(
                name: "FK_AulaTemaClases_AspNetUsers_UsuarioId",
                table: "AulaTemaClases");

            migrationBuilder.DropForeignKey(
                name: "FK_CarreraMaterias_AspNetUsers_UsuarioId",
                table: "CarreraMaterias");

            migrationBuilder.DropForeignKey(
                name: "FK_Carreras_AspNetUsers_UsuarioId",
                table: "Carreras");

            migrationBuilder.DropForeignKey(
                name: "FK_CharlaDigoArchivos_AspNetUsers_UsuarioId",
                table: "CharlaDigoArchivos");

            migrationBuilder.DropForeignKey(
                name: "FK_CharlaDigoLinks_AspNetUsers_UsuarioId",
                table: "CharlaDigoLinks");

            migrationBuilder.DropForeignKey(
                name: "FK_CharlaDigos_AspNetUsers_UsuarioId",
                table: "CharlaDigos");

            migrationBuilder.DropForeignKey(
                name: "FK_CharlaLeeDigos_AspNetUsers_UsuarioId",
                table: "CharlaLeeDigos");

            migrationBuilder.DropForeignKey(
                name: "FK_CharlaPersonas_AspNetUsers_UsuarioId",
                table: "CharlaPersonas");

            migrationBuilder.DropForeignKey(
                name: "FK_Charlas_AspNetUsers_UsuarioId",
                table: "Charlas");

            migrationBuilder.DropForeignKey(
                name: "FK_Documentos_AspNetUsers_UsuarioId",
                table: "Documentos");

            migrationBuilder.DropForeignKey(
                name: "FK_Domicilios_AspNetUsers_UsuarioId",
                table: "Domicilios");

            migrationBuilder.DropForeignKey(
                name: "FK_InstitucionDocumentos_AspNetUsers_UsuarioId",
                table: "InstitucionDocumentos");

            migrationBuilder.DropForeignKey(
                name: "FK_InstitucionDomicilios_AspNetUsers_UsuarioId",
                table: "InstitucionDomicilios");

            migrationBuilder.DropForeignKey(
                name: "FK_Instituciones_AspNetUsers_UsuarioId",
                table: "Instituciones");

            migrationBuilder.DropForeignKey(
                name: "FK_InstitucionMails_AspNetUsers_UsuarioId",
                table: "InstitucionMails");

            migrationBuilder.DropForeignKey(
                name: "FK_InstitucionTels_AspNetUsers_UsuarioId",
                table: "InstitucionTels");

            migrationBuilder.DropForeignKey(
                name: "FK_Mails_AspNetUsers_UsuarioId",
                table: "Mails");

            migrationBuilder.DropForeignKey(
                name: "FK_Materias_AspNetUsers_UsuarioId",
                table: "Materias");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonaDocumentos_AspNetUsers_UsuarioId",
                table: "PersonaDocumentos");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonaDomicilios_AspNetUsers_UsuarioId",
                table: "PersonaDomicilios");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonaMails_AspNetUsers_UsuarioId",
                table: "PersonaMails");

            migrationBuilder.DropForeignKey(
                name: "FK_Personas_AspNetUsers_UsuarioId",
                table: "Personas");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonaTels_AspNetUsers_UsuarioId",
                table: "PersonaTels");

            migrationBuilder.DropForeignKey(
                name: "FK_TCharlas_AspNetUsers_UsuarioId",
                table: "TCharlas");

            migrationBuilder.DropForeignKey(
                name: "FK_TDocumentos_AspNetUsers_UsuarioId",
                table: "TDocumentos");

            migrationBuilder.DropForeignKey(
                name: "FK_TDomicilios_AspNetUsers_UsuarioId",
                table: "TDomicilios");

            migrationBuilder.DropForeignKey(
                name: "FK_Tels_AspNetUsers_UsuarioId",
                table: "Tels");

            migrationBuilder.DropForeignKey(
                name: "FK_TMails_AspNetUsers_UsuarioId",
                table: "TMails");

            migrationBuilder.DropForeignKey(
                name: "FK_TNotas_AspNetUsers_UsuarioId",
                table: "TNotas");

            migrationBuilder.DropForeignKey(
                name: "FK_TTels_AspNetUsers_UsuarioId",
                table: "TTels");

            migrationBuilder.DropIndex(
                name: "IX_TTels_UsuarioId",
                table: "TTels");

            migrationBuilder.DropIndex(
                name: "IX_TNotas_UsuarioId",
                table: "TNotas");

            migrationBuilder.DropIndex(
                name: "IX_TMails_UsuarioId",
                table: "TMails");

            migrationBuilder.DropIndex(
                name: "IX_Tels_UsuarioId",
                table: "Tels");

            migrationBuilder.DropIndex(
                name: "IX_TDomicilios_UsuarioId",
                table: "TDomicilios");

            migrationBuilder.DropIndex(
                name: "IX_TDocumentos_UsuarioId",
                table: "TDocumentos");

            migrationBuilder.DropIndex(
                name: "IX_TCharlas_UsuarioId",
                table: "TCharlas");

            migrationBuilder.DropIndex(
                name: "IX_PersonaTels_UsuarioId",
                table: "PersonaTels");

            migrationBuilder.DropIndex(
                name: "IX_Personas_UsuarioId",
                table: "Personas");

            migrationBuilder.DropIndex(
                name: "IX_PersonaMails_UsuarioId",
                table: "PersonaMails");

            migrationBuilder.DropIndex(
                name: "IX_PersonaDomicilios_UsuarioId",
                table: "PersonaDomicilios");

            migrationBuilder.DropIndex(
                name: "IX_PersonaDocumentos_UsuarioId",
                table: "PersonaDocumentos");

            migrationBuilder.DropIndex(
                name: "IX_Materias_UsuarioId",
                table: "Materias");

            migrationBuilder.DropIndex(
                name: "IX_Mails_UsuarioId",
                table: "Mails");

            migrationBuilder.DropIndex(
                name: "IX_InstitucionTels_UsuarioId",
                table: "InstitucionTels");

            migrationBuilder.DropIndex(
                name: "IX_InstitucionMails_UsuarioId",
                table: "InstitucionMails");

            migrationBuilder.DropIndex(
                name: "IX_Instituciones_UsuarioId",
                table: "Instituciones");

            migrationBuilder.DropIndex(
                name: "IX_InstitucionDomicilios_UsuarioId",
                table: "InstitucionDomicilios");

            migrationBuilder.DropIndex(
                name: "IX_InstitucionDocumentos_UsuarioId",
                table: "InstitucionDocumentos");

            migrationBuilder.DropIndex(
                name: "IX_Domicilios_UsuarioId",
                table: "Domicilios");

            migrationBuilder.DropIndex(
                name: "IX_Documentos_UsuarioId",
                table: "Documentos");

            migrationBuilder.DropIndex(
                name: "IX_Charlas_UsuarioId",
                table: "Charlas");

            migrationBuilder.DropIndex(
                name: "IX_CharlaPersonas_UsuarioId",
                table: "CharlaPersonas");

            migrationBuilder.DropIndex(
                name: "IX_CharlaLeeDigos_UsuarioId",
                table: "CharlaLeeDigos");

            migrationBuilder.DropIndex(
                name: "IX_CharlaDigos_UsuarioId",
                table: "CharlaDigos");

            migrationBuilder.DropIndex(
                name: "IX_CharlaDigoLinks_UsuarioId",
                table: "CharlaDigoLinks");

            migrationBuilder.DropIndex(
                name: "IX_CharlaDigoArchivos_UsuarioId",
                table: "CharlaDigoArchivos");

            migrationBuilder.DropIndex(
                name: "IX_Carreras_UsuarioId",
                table: "Carreras");

            migrationBuilder.DropIndex(
                name: "IX_CarreraMaterias_UsuarioId",
                table: "CarreraMaterias");

            migrationBuilder.DropIndex(
                name: "IX_AulaTemaClases_UsuarioId",
                table: "AulaTemaClases");

            migrationBuilder.DropIndex(
                name: "IX_Aulas_UsuarioId",
                table: "Aulas");

            migrationBuilder.DropIndex(
                name: "IX_AulaNotas_UsuarioId",
                table: "AulaNotas");

            migrationBuilder.DropIndex(
                name: "IX_AulaGrupos_UsuarioId",
                table: "AulaGrupos");

            migrationBuilder.DropIndex(
                name: "IX_AulaGrupoAlumnos_UsuarioId",
                table: "AulaGrupoAlumnos");

            migrationBuilder.DropIndex(
                name: "IX_AulaEvaluaciones_UsuarioId",
                table: "AulaEvaluaciones");

            migrationBuilder.DropIndex(
                name: "IX_AulaDocentes_UsuarioId",
                table: "AulaDocentes");

            migrationBuilder.DropIndex(
                name: "IX_AulaAsistencias_UsuarioId",
                table: "AulaAsistencias");

            migrationBuilder.DropIndex(
                name: "IX_AulaAlumnos_UsuarioId",
                table: "AulaAlumnos");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "TTels");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "TNotas");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "TMails");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Tels");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "TDomicilios");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "TDocumentos");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "TCharlas");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "PersonaTels");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "PersonaMails");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "PersonaDomicilios");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "PersonaDocumentos");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Materias");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Mails");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "InstitucionTels");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "InstitucionMails");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Instituciones");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "InstitucionDomicilios");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "InstitucionDocumentos");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Domicilios");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Documentos");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Charlas");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "CharlaPersonas");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "CharlaLeeDigos");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "CharlaDigos");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "CharlaDigoLinks");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "CharlaDigoArchivos");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Carreras");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "CarreraMaterias");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "AulaTemaClases");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Aulas");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "AulaNotas");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "AulaGrupos");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "AulaGrupoAlumnos");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "AulaEvaluaciones");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "AulaDocentes");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "AulaAsistencias");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "AulaAlumnos");
        }
    }
}
