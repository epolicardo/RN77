using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RN77.BD.Migrations
{
    public partial class Usuario2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "FechaBajaReg",
                table: "TTels",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaBajaReg",
                table: "TNotas",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaBajaReg",
                table: "TMails",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaBajaReg",
                table: "Tels",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaBajaReg",
                table: "TDomicilios",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaBajaReg",
                table: "TDocumentos",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaBajaReg",
                table: "TCharlas",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaBajaReg",
                table: "PersonaTels",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaBajaReg",
                table: "Personas",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaBajaReg",
                table: "PersonaMails",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaBajaReg",
                table: "PersonaDomicilios",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaBajaReg",
                table: "PersonaDocumentos",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaBajaReg",
                table: "Materias",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaBajaReg",
                table: "Mails",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaBajaReg",
                table: "InstitucionTels",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaBajaReg",
                table: "InstitucionMails",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaBajaReg",
                table: "Instituciones",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaBajaReg",
                table: "InstitucionDomicilios",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaBajaReg",
                table: "InstitucionDocumentos",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaBajaReg",
                table: "Domicilios",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaBajaReg",
                table: "Documentos",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaBajaReg",
                table: "Charlas",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaBajaReg",
                table: "CharlaPersonas",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaBajaReg",
                table: "CharlaLeeDigos",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaBajaReg",
                table: "CharlaDigos",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaBajaReg",
                table: "CharlaDigoLinks",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaBajaReg",
                table: "CharlaDigoArchivos",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaBajaReg",
                table: "Carreras",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaBajaReg",
                table: "CarreraMaterias",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaBajaReg",
                table: "AulaTemaClases",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaBajaReg",
                table: "Aulas",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaBajaReg",
                table: "AulaNotas",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaBajaReg",
                table: "AulaGrupos",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaBajaReg",
                table: "AulaGrupoAlumnos",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaBajaReg",
                table: "AulaEvaluaciones",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaBajaReg",
                table: "AulaDocentes",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaBajaReg",
                table: "AulaAsistencias",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaBajaReg",
                table: "AulaAlumnos",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FechaBajaReg",
                table: "TTels");

            migrationBuilder.DropColumn(
                name: "FechaBajaReg",
                table: "TNotas");

            migrationBuilder.DropColumn(
                name: "FechaBajaReg",
                table: "TMails");

            migrationBuilder.DropColumn(
                name: "FechaBajaReg",
                table: "Tels");

            migrationBuilder.DropColumn(
                name: "FechaBajaReg",
                table: "TDomicilios");

            migrationBuilder.DropColumn(
                name: "FechaBajaReg",
                table: "TDocumentos");

            migrationBuilder.DropColumn(
                name: "FechaBajaReg",
                table: "TCharlas");

            migrationBuilder.DropColumn(
                name: "FechaBajaReg",
                table: "PersonaTels");

            migrationBuilder.DropColumn(
                name: "FechaBajaReg",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "FechaBajaReg",
                table: "PersonaMails");

            migrationBuilder.DropColumn(
                name: "FechaBajaReg",
                table: "PersonaDomicilios");

            migrationBuilder.DropColumn(
                name: "FechaBajaReg",
                table: "PersonaDocumentos");

            migrationBuilder.DropColumn(
                name: "FechaBajaReg",
                table: "Materias");

            migrationBuilder.DropColumn(
                name: "FechaBajaReg",
                table: "Mails");

            migrationBuilder.DropColumn(
                name: "FechaBajaReg",
                table: "InstitucionTels");

            migrationBuilder.DropColumn(
                name: "FechaBajaReg",
                table: "InstitucionMails");

            migrationBuilder.DropColumn(
                name: "FechaBajaReg",
                table: "Instituciones");

            migrationBuilder.DropColumn(
                name: "FechaBajaReg",
                table: "InstitucionDomicilios");

            migrationBuilder.DropColumn(
                name: "FechaBajaReg",
                table: "InstitucionDocumentos");

            migrationBuilder.DropColumn(
                name: "FechaBajaReg",
                table: "Domicilios");

            migrationBuilder.DropColumn(
                name: "FechaBajaReg",
                table: "Documentos");

            migrationBuilder.DropColumn(
                name: "FechaBajaReg",
                table: "Charlas");

            migrationBuilder.DropColumn(
                name: "FechaBajaReg",
                table: "CharlaPersonas");

            migrationBuilder.DropColumn(
                name: "FechaBajaReg",
                table: "CharlaLeeDigos");

            migrationBuilder.DropColumn(
                name: "FechaBajaReg",
                table: "CharlaDigos");

            migrationBuilder.DropColumn(
                name: "FechaBajaReg",
                table: "CharlaDigoLinks");

            migrationBuilder.DropColumn(
                name: "FechaBajaReg",
                table: "CharlaDigoArchivos");

            migrationBuilder.DropColumn(
                name: "FechaBajaReg",
                table: "Carreras");

            migrationBuilder.DropColumn(
                name: "FechaBajaReg",
                table: "CarreraMaterias");

            migrationBuilder.DropColumn(
                name: "FechaBajaReg",
                table: "AulaTemaClases");

            migrationBuilder.DropColumn(
                name: "FechaBajaReg",
                table: "Aulas");

            migrationBuilder.DropColumn(
                name: "FechaBajaReg",
                table: "AulaNotas");

            migrationBuilder.DropColumn(
                name: "FechaBajaReg",
                table: "AulaGrupos");

            migrationBuilder.DropColumn(
                name: "FechaBajaReg",
                table: "AulaGrupoAlumnos");

            migrationBuilder.DropColumn(
                name: "FechaBajaReg",
                table: "AulaEvaluaciones");

            migrationBuilder.DropColumn(
                name: "FechaBajaReg",
                table: "AulaDocentes");

            migrationBuilder.DropColumn(
                name: "FechaBajaReg",
                table: "AulaAsistencias");

            migrationBuilder.DropColumn(
                name: "FechaBajaReg",
                table: "AulaAlumnos");
        }
    }
}
