using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RN77.BD.Migrations
{
    public partial class HerenciaEntityBase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte>(
                name: "EstadoReg",
                table: "TTels",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaCreaReg",
                table: "TTels",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaModifReg",
                table: "TTels",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ObservReg",
                table: "TTels",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<byte>(
                name: "EstadoReg",
                table: "TNotas",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaCreaReg",
                table: "TNotas",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaModifReg",
                table: "TNotas",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ObservReg",
                table: "TNotas",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<byte>(
                name: "EstadoReg",
                table: "TMails",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaCreaReg",
                table: "TMails",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaModifReg",
                table: "TMails",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ObservReg",
                table: "TMails",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<byte>(
                name: "EstadoReg",
                table: "Tels",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaCreaReg",
                table: "Tels",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaModifReg",
                table: "Tels",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ObservReg",
                table: "Tels",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<byte>(
                name: "EstadoReg",
                table: "TDomicilios",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaCreaReg",
                table: "TDomicilios",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaModifReg",
                table: "TDomicilios",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ObservReg",
                table: "TDomicilios",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<byte>(
                name: "EstadoReg",
                table: "TDocumentos",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaCreaReg",
                table: "TDocumentos",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaModifReg",
                table: "TDocumentos",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ObservReg",
                table: "TDocumentos",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<byte>(
                name: "EstadoReg",
                table: "TCharlas",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaCreaReg",
                table: "TCharlas",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaModifReg",
                table: "TCharlas",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ObservReg",
                table: "TCharlas",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<byte>(
                name: "EstadoReg",
                table: "PersonaTels",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaCreaReg",
                table: "PersonaTels",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaModifReg",
                table: "PersonaTels",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ObservReg",
                table: "PersonaTels",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<byte>(
                name: "EstadoReg",
                table: "Personas",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaCreaReg",
                table: "Personas",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaModifReg",
                table: "Personas",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ObservReg",
                table: "Personas",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<byte>(
                name: "EstadoReg",
                table: "PersonaMails",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaCreaReg",
                table: "PersonaMails",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaModifReg",
                table: "PersonaMails",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ObservReg",
                table: "PersonaMails",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<byte>(
                name: "EstadoReg",
                table: "PersonaDomicilios",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaCreaReg",
                table: "PersonaDomicilios",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaModifReg",
                table: "PersonaDomicilios",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ObservReg",
                table: "PersonaDomicilios",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<byte>(
                name: "EstadoReg",
                table: "PersonaDocumentos",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaCreaReg",
                table: "PersonaDocumentos",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaModifReg",
                table: "PersonaDocumentos",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ObservReg",
                table: "PersonaDocumentos",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<byte>(
                name: "EstadoReg",
                table: "Materias",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaCreaReg",
                table: "Materias",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaModifReg",
                table: "Materias",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ObservReg",
                table: "Materias",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<byte>(
                name: "EstadoReg",
                table: "Mails",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaCreaReg",
                table: "Mails",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaModifReg",
                table: "Mails",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ObservReg",
                table: "Mails",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<byte>(
                name: "EstadoReg",
                table: "InstitucionTels",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaCreaReg",
                table: "InstitucionTels",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaModifReg",
                table: "InstitucionTels",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ObservReg",
                table: "InstitucionTels",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<byte>(
                name: "EstadoReg",
                table: "InstitucionMails",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaCreaReg",
                table: "InstitucionMails",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaModifReg",
                table: "InstitucionMails",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ObservReg",
                table: "InstitucionMails",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<byte>(
                name: "EstadoReg",
                table: "Instituciones",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaCreaReg",
                table: "Instituciones",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaModifReg",
                table: "Instituciones",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ObservReg",
                table: "Instituciones",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<byte>(
                name: "EstadoReg",
                table: "InstitucionDomicilios",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaCreaReg",
                table: "InstitucionDomicilios",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaModifReg",
                table: "InstitucionDomicilios",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ObservReg",
                table: "InstitucionDomicilios",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<byte>(
                name: "EstadoReg",
                table: "InstitucionDocumentos",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaCreaReg",
                table: "InstitucionDocumentos",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaModifReg",
                table: "InstitucionDocumentos",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ObservReg",
                table: "InstitucionDocumentos",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<byte>(
                name: "EstadoReg",
                table: "Domicilios",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaCreaReg",
                table: "Domicilios",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaModifReg",
                table: "Domicilios",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ObservReg",
                table: "Domicilios",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<byte>(
                name: "EstadoReg",
                table: "Documentos",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaCreaReg",
                table: "Documentos",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaModifReg",
                table: "Documentos",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ObservReg",
                table: "Documentos",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<byte>(
                name: "EstadoReg",
                table: "Charlas",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaCreaReg",
                table: "Charlas",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaModifReg",
                table: "Charlas",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ObservReg",
                table: "Charlas",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<byte>(
                name: "EstadoReg",
                table: "CharlaPersonas",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaCreaReg",
                table: "CharlaPersonas",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaModifReg",
                table: "CharlaPersonas",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ObservReg",
                table: "CharlaPersonas",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<byte>(
                name: "EstadoReg",
                table: "CharlaLeeDigos",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaCreaReg",
                table: "CharlaLeeDigos",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaModifReg",
                table: "CharlaLeeDigos",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ObservReg",
                table: "CharlaLeeDigos",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<byte>(
                name: "EstadoReg",
                table: "CharlaDigos",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaCreaReg",
                table: "CharlaDigos",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaModifReg",
                table: "CharlaDigos",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ObservReg",
                table: "CharlaDigos",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<byte>(
                name: "EstadoReg",
                table: "CharlaDigoLinks",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaCreaReg",
                table: "CharlaDigoLinks",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaModifReg",
                table: "CharlaDigoLinks",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ObservReg",
                table: "CharlaDigoLinks",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<byte>(
                name: "EstadoReg",
                table: "CharlaDigoArchivos",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaCreaReg",
                table: "CharlaDigoArchivos",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaModifReg",
                table: "CharlaDigoArchivos",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ObservReg",
                table: "CharlaDigoArchivos",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<byte>(
                name: "EstadoReg",
                table: "Carreras",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaCreaReg",
                table: "Carreras",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaModifReg",
                table: "Carreras",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ObservReg",
                table: "Carreras",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<byte>(
                name: "EstadoReg",
                table: "CarreraMaterias",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaCreaReg",
                table: "CarreraMaterias",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaModifReg",
                table: "CarreraMaterias",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ObservReg",
                table: "CarreraMaterias",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<byte>(
                name: "EstadoReg",
                table: "AulaTemaClases",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaCreaReg",
                table: "AulaTemaClases",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaModifReg",
                table: "AulaTemaClases",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ObservReg",
                table: "AulaTemaClases",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<byte>(
                name: "EstadoReg",
                table: "Aulas",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaCreaReg",
                table: "Aulas",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaModifReg",
                table: "Aulas",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ObservReg",
                table: "Aulas",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<byte>(
                name: "EstadoReg",
                table: "AulaNotas",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaCreaReg",
                table: "AulaNotas",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaModifReg",
                table: "AulaNotas",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ObservReg",
                table: "AulaNotas",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<byte>(
                name: "EstadoReg",
                table: "AulaGrupos",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaCreaReg",
                table: "AulaGrupos",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaModifReg",
                table: "AulaGrupos",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ObservReg",
                table: "AulaGrupos",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<byte>(
                name: "EstadoReg",
                table: "AulaGrupoAlumnos",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaCreaReg",
                table: "AulaGrupoAlumnos",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaModifReg",
                table: "AulaGrupoAlumnos",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ObservReg",
                table: "AulaGrupoAlumnos",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<byte>(
                name: "EstadoReg",
                table: "AulaEvaluaciones",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaCreaReg",
                table: "AulaEvaluaciones",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaModifReg",
                table: "AulaEvaluaciones",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ObservReg",
                table: "AulaEvaluaciones",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<byte>(
                name: "EstadoReg",
                table: "AulaDocentes",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaCreaReg",
                table: "AulaDocentes",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaModifReg",
                table: "AulaDocentes",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ObservReg",
                table: "AulaDocentes",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<byte>(
                name: "EstadoReg",
                table: "AulaAsistencias",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaCreaReg",
                table: "AulaAsistencias",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaModifReg",
                table: "AulaAsistencias",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ObservReg",
                table: "AulaAsistencias",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<byte>(
                name: "EstadoReg",
                table: "AulaAlumnos",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaCreaReg",
                table: "AulaAlumnos",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaModifReg",
                table: "AulaAlumnos",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ObservReg",
                table: "AulaAlumnos",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EstadoReg",
                table: "TTels");

            migrationBuilder.DropColumn(
                name: "FechaCreaReg",
                table: "TTels");

            migrationBuilder.DropColumn(
                name: "FechaModifReg",
                table: "TTels");

            migrationBuilder.DropColumn(
                name: "ObservReg",
                table: "TTels");

            migrationBuilder.DropColumn(
                name: "EstadoReg",
                table: "TNotas");

            migrationBuilder.DropColumn(
                name: "FechaCreaReg",
                table: "TNotas");

            migrationBuilder.DropColumn(
                name: "FechaModifReg",
                table: "TNotas");

            migrationBuilder.DropColumn(
                name: "ObservReg",
                table: "TNotas");

            migrationBuilder.DropColumn(
                name: "EstadoReg",
                table: "TMails");

            migrationBuilder.DropColumn(
                name: "FechaCreaReg",
                table: "TMails");

            migrationBuilder.DropColumn(
                name: "FechaModifReg",
                table: "TMails");

            migrationBuilder.DropColumn(
                name: "ObservReg",
                table: "TMails");

            migrationBuilder.DropColumn(
                name: "EstadoReg",
                table: "Tels");

            migrationBuilder.DropColumn(
                name: "FechaCreaReg",
                table: "Tels");

            migrationBuilder.DropColumn(
                name: "FechaModifReg",
                table: "Tels");

            migrationBuilder.DropColumn(
                name: "ObservReg",
                table: "Tels");

            migrationBuilder.DropColumn(
                name: "EstadoReg",
                table: "TDomicilios");

            migrationBuilder.DropColumn(
                name: "FechaCreaReg",
                table: "TDomicilios");

            migrationBuilder.DropColumn(
                name: "FechaModifReg",
                table: "TDomicilios");

            migrationBuilder.DropColumn(
                name: "ObservReg",
                table: "TDomicilios");

            migrationBuilder.DropColumn(
                name: "EstadoReg",
                table: "TDocumentos");

            migrationBuilder.DropColumn(
                name: "FechaCreaReg",
                table: "TDocumentos");

            migrationBuilder.DropColumn(
                name: "FechaModifReg",
                table: "TDocumentos");

            migrationBuilder.DropColumn(
                name: "ObservReg",
                table: "TDocumentos");

            migrationBuilder.DropColumn(
                name: "EstadoReg",
                table: "TCharlas");

            migrationBuilder.DropColumn(
                name: "FechaCreaReg",
                table: "TCharlas");

            migrationBuilder.DropColumn(
                name: "FechaModifReg",
                table: "TCharlas");

            migrationBuilder.DropColumn(
                name: "ObservReg",
                table: "TCharlas");

            migrationBuilder.DropColumn(
                name: "EstadoReg",
                table: "PersonaTels");

            migrationBuilder.DropColumn(
                name: "FechaCreaReg",
                table: "PersonaTels");

            migrationBuilder.DropColumn(
                name: "FechaModifReg",
                table: "PersonaTels");

            migrationBuilder.DropColumn(
                name: "ObservReg",
                table: "PersonaTels");

            migrationBuilder.DropColumn(
                name: "EstadoReg",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "FechaCreaReg",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "FechaModifReg",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "ObservReg",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "EstadoReg",
                table: "PersonaMails");

            migrationBuilder.DropColumn(
                name: "FechaCreaReg",
                table: "PersonaMails");

            migrationBuilder.DropColumn(
                name: "FechaModifReg",
                table: "PersonaMails");

            migrationBuilder.DropColumn(
                name: "ObservReg",
                table: "PersonaMails");

            migrationBuilder.DropColumn(
                name: "EstadoReg",
                table: "PersonaDomicilios");

            migrationBuilder.DropColumn(
                name: "FechaCreaReg",
                table: "PersonaDomicilios");

            migrationBuilder.DropColumn(
                name: "FechaModifReg",
                table: "PersonaDomicilios");

            migrationBuilder.DropColumn(
                name: "ObservReg",
                table: "PersonaDomicilios");

            migrationBuilder.DropColumn(
                name: "EstadoReg",
                table: "PersonaDocumentos");

            migrationBuilder.DropColumn(
                name: "FechaCreaReg",
                table: "PersonaDocumentos");

            migrationBuilder.DropColumn(
                name: "FechaModifReg",
                table: "PersonaDocumentos");

            migrationBuilder.DropColumn(
                name: "ObservReg",
                table: "PersonaDocumentos");

            migrationBuilder.DropColumn(
                name: "EstadoReg",
                table: "Materias");

            migrationBuilder.DropColumn(
                name: "FechaCreaReg",
                table: "Materias");

            migrationBuilder.DropColumn(
                name: "FechaModifReg",
                table: "Materias");

            migrationBuilder.DropColumn(
                name: "ObservReg",
                table: "Materias");

            migrationBuilder.DropColumn(
                name: "EstadoReg",
                table: "Mails");

            migrationBuilder.DropColumn(
                name: "FechaCreaReg",
                table: "Mails");

            migrationBuilder.DropColumn(
                name: "FechaModifReg",
                table: "Mails");

            migrationBuilder.DropColumn(
                name: "ObservReg",
                table: "Mails");

            migrationBuilder.DropColumn(
                name: "EstadoReg",
                table: "InstitucionTels");

            migrationBuilder.DropColumn(
                name: "FechaCreaReg",
                table: "InstitucionTels");

            migrationBuilder.DropColumn(
                name: "FechaModifReg",
                table: "InstitucionTels");

            migrationBuilder.DropColumn(
                name: "ObservReg",
                table: "InstitucionTels");

            migrationBuilder.DropColumn(
                name: "EstadoReg",
                table: "InstitucionMails");

            migrationBuilder.DropColumn(
                name: "FechaCreaReg",
                table: "InstitucionMails");

            migrationBuilder.DropColumn(
                name: "FechaModifReg",
                table: "InstitucionMails");

            migrationBuilder.DropColumn(
                name: "ObservReg",
                table: "InstitucionMails");

            migrationBuilder.DropColumn(
                name: "EstadoReg",
                table: "Instituciones");

            migrationBuilder.DropColumn(
                name: "FechaCreaReg",
                table: "Instituciones");

            migrationBuilder.DropColumn(
                name: "FechaModifReg",
                table: "Instituciones");

            migrationBuilder.DropColumn(
                name: "ObservReg",
                table: "Instituciones");

            migrationBuilder.DropColumn(
                name: "EstadoReg",
                table: "InstitucionDomicilios");

            migrationBuilder.DropColumn(
                name: "FechaCreaReg",
                table: "InstitucionDomicilios");

            migrationBuilder.DropColumn(
                name: "FechaModifReg",
                table: "InstitucionDomicilios");

            migrationBuilder.DropColumn(
                name: "ObservReg",
                table: "InstitucionDomicilios");

            migrationBuilder.DropColumn(
                name: "EstadoReg",
                table: "InstitucionDocumentos");

            migrationBuilder.DropColumn(
                name: "FechaCreaReg",
                table: "InstitucionDocumentos");

            migrationBuilder.DropColumn(
                name: "FechaModifReg",
                table: "InstitucionDocumentos");

            migrationBuilder.DropColumn(
                name: "ObservReg",
                table: "InstitucionDocumentos");

            migrationBuilder.DropColumn(
                name: "EstadoReg",
                table: "Domicilios");

            migrationBuilder.DropColumn(
                name: "FechaCreaReg",
                table: "Domicilios");

            migrationBuilder.DropColumn(
                name: "FechaModifReg",
                table: "Domicilios");

            migrationBuilder.DropColumn(
                name: "ObservReg",
                table: "Domicilios");

            migrationBuilder.DropColumn(
                name: "EstadoReg",
                table: "Documentos");

            migrationBuilder.DropColumn(
                name: "FechaCreaReg",
                table: "Documentos");

            migrationBuilder.DropColumn(
                name: "FechaModifReg",
                table: "Documentos");

            migrationBuilder.DropColumn(
                name: "ObservReg",
                table: "Documentos");

            migrationBuilder.DropColumn(
                name: "EstadoReg",
                table: "Charlas");

            migrationBuilder.DropColumn(
                name: "FechaCreaReg",
                table: "Charlas");

            migrationBuilder.DropColumn(
                name: "FechaModifReg",
                table: "Charlas");

            migrationBuilder.DropColumn(
                name: "ObservReg",
                table: "Charlas");

            migrationBuilder.DropColumn(
                name: "EstadoReg",
                table: "CharlaPersonas");

            migrationBuilder.DropColumn(
                name: "FechaCreaReg",
                table: "CharlaPersonas");

            migrationBuilder.DropColumn(
                name: "FechaModifReg",
                table: "CharlaPersonas");

            migrationBuilder.DropColumn(
                name: "ObservReg",
                table: "CharlaPersonas");

            migrationBuilder.DropColumn(
                name: "EstadoReg",
                table: "CharlaLeeDigos");

            migrationBuilder.DropColumn(
                name: "FechaCreaReg",
                table: "CharlaLeeDigos");

            migrationBuilder.DropColumn(
                name: "FechaModifReg",
                table: "CharlaLeeDigos");

            migrationBuilder.DropColumn(
                name: "ObservReg",
                table: "CharlaLeeDigos");

            migrationBuilder.DropColumn(
                name: "EstadoReg",
                table: "CharlaDigos");

            migrationBuilder.DropColumn(
                name: "FechaCreaReg",
                table: "CharlaDigos");

            migrationBuilder.DropColumn(
                name: "FechaModifReg",
                table: "CharlaDigos");

            migrationBuilder.DropColumn(
                name: "ObservReg",
                table: "CharlaDigos");

            migrationBuilder.DropColumn(
                name: "EstadoReg",
                table: "CharlaDigoLinks");

            migrationBuilder.DropColumn(
                name: "FechaCreaReg",
                table: "CharlaDigoLinks");

            migrationBuilder.DropColumn(
                name: "FechaModifReg",
                table: "CharlaDigoLinks");

            migrationBuilder.DropColumn(
                name: "ObservReg",
                table: "CharlaDigoLinks");

            migrationBuilder.DropColumn(
                name: "EstadoReg",
                table: "CharlaDigoArchivos");

            migrationBuilder.DropColumn(
                name: "FechaCreaReg",
                table: "CharlaDigoArchivos");

            migrationBuilder.DropColumn(
                name: "FechaModifReg",
                table: "CharlaDigoArchivos");

            migrationBuilder.DropColumn(
                name: "ObservReg",
                table: "CharlaDigoArchivos");

            migrationBuilder.DropColumn(
                name: "EstadoReg",
                table: "Carreras");

            migrationBuilder.DropColumn(
                name: "FechaCreaReg",
                table: "Carreras");

            migrationBuilder.DropColumn(
                name: "FechaModifReg",
                table: "Carreras");

            migrationBuilder.DropColumn(
                name: "ObservReg",
                table: "Carreras");

            migrationBuilder.DropColumn(
                name: "EstadoReg",
                table: "CarreraMaterias");

            migrationBuilder.DropColumn(
                name: "FechaCreaReg",
                table: "CarreraMaterias");

            migrationBuilder.DropColumn(
                name: "FechaModifReg",
                table: "CarreraMaterias");

            migrationBuilder.DropColumn(
                name: "ObservReg",
                table: "CarreraMaterias");

            migrationBuilder.DropColumn(
                name: "EstadoReg",
                table: "AulaTemaClases");

            migrationBuilder.DropColumn(
                name: "FechaCreaReg",
                table: "AulaTemaClases");

            migrationBuilder.DropColumn(
                name: "FechaModifReg",
                table: "AulaTemaClases");

            migrationBuilder.DropColumn(
                name: "ObservReg",
                table: "AulaTemaClases");

            migrationBuilder.DropColumn(
                name: "EstadoReg",
                table: "Aulas");

            migrationBuilder.DropColumn(
                name: "FechaCreaReg",
                table: "Aulas");

            migrationBuilder.DropColumn(
                name: "FechaModifReg",
                table: "Aulas");

            migrationBuilder.DropColumn(
                name: "ObservReg",
                table: "Aulas");

            migrationBuilder.DropColumn(
                name: "EstadoReg",
                table: "AulaNotas");

            migrationBuilder.DropColumn(
                name: "FechaCreaReg",
                table: "AulaNotas");

            migrationBuilder.DropColumn(
                name: "FechaModifReg",
                table: "AulaNotas");

            migrationBuilder.DropColumn(
                name: "ObservReg",
                table: "AulaNotas");

            migrationBuilder.DropColumn(
                name: "EstadoReg",
                table: "AulaGrupos");

            migrationBuilder.DropColumn(
                name: "FechaCreaReg",
                table: "AulaGrupos");

            migrationBuilder.DropColumn(
                name: "FechaModifReg",
                table: "AulaGrupos");

            migrationBuilder.DropColumn(
                name: "ObservReg",
                table: "AulaGrupos");

            migrationBuilder.DropColumn(
                name: "EstadoReg",
                table: "AulaGrupoAlumnos");

            migrationBuilder.DropColumn(
                name: "FechaCreaReg",
                table: "AulaGrupoAlumnos");

            migrationBuilder.DropColumn(
                name: "FechaModifReg",
                table: "AulaGrupoAlumnos");

            migrationBuilder.DropColumn(
                name: "ObservReg",
                table: "AulaGrupoAlumnos");

            migrationBuilder.DropColumn(
                name: "EstadoReg",
                table: "AulaEvaluaciones");

            migrationBuilder.DropColumn(
                name: "FechaCreaReg",
                table: "AulaEvaluaciones");

            migrationBuilder.DropColumn(
                name: "FechaModifReg",
                table: "AulaEvaluaciones");

            migrationBuilder.DropColumn(
                name: "ObservReg",
                table: "AulaEvaluaciones");

            migrationBuilder.DropColumn(
                name: "EstadoReg",
                table: "AulaDocentes");

            migrationBuilder.DropColumn(
                name: "FechaCreaReg",
                table: "AulaDocentes");

            migrationBuilder.DropColumn(
                name: "FechaModifReg",
                table: "AulaDocentes");

            migrationBuilder.DropColumn(
                name: "ObservReg",
                table: "AulaDocentes");

            migrationBuilder.DropColumn(
                name: "EstadoReg",
                table: "AulaAsistencias");

            migrationBuilder.DropColumn(
                name: "FechaCreaReg",
                table: "AulaAsistencias");

            migrationBuilder.DropColumn(
                name: "FechaModifReg",
                table: "AulaAsistencias");

            migrationBuilder.DropColumn(
                name: "ObservReg",
                table: "AulaAsistencias");

            migrationBuilder.DropColumn(
                name: "EstadoReg",
                table: "AulaAlumnos");

            migrationBuilder.DropColumn(
                name: "FechaCreaReg",
                table: "AulaAlumnos");

            migrationBuilder.DropColumn(
                name: "FechaModifReg",
                table: "AulaAlumnos");

            migrationBuilder.DropColumn(
                name: "ObservReg",
                table: "AulaAlumnos");
        }
    }
}
