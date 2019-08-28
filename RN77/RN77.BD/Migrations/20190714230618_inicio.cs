using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RN77.BD.Migrations
{
    public partial class inicio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Materias",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(unicode: false, maxLength: 300, nullable: false),
                    Descripcion = table.Column<string>(unicode: false, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Personas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(unicode: false, maxLength: 200, nullable: false),
                    Apellido = table.Column<string>(unicode: false, maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TCharlas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Codigo = table.Column<string>(unicode: false, maxLength: 2, nullable: false),
                    Nombre = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    Descripcion = table.Column<string>(unicode: false, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TCharlas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TDocumentos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Codigo = table.Column<string>(unicode: false, maxLength: 4, nullable: false),
                    Nombre = table.Column<string>(unicode: false, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TDocumentos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TDomicilios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Codigo = table.Column<string>(unicode: false, maxLength: 2, nullable: false),
                    Nombre = table.Column<string>(unicode: false, maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TDomicilios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TMails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Codigo = table.Column<string>(unicode: false, maxLength: 2, nullable: false),
                    Nombre = table.Column<string>(unicode: false, maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TMails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TNotas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Codigo = table.Column<string>(unicode: false, maxLength: 2, nullable: false),
                    Nombre = table.Column<string>(unicode: false, maxLength: 20, nullable: false),
                    ValorMin = table.Column<string>(unicode: false, maxLength: 3, nullable: false),
                    ValorMax = table.Column<string>(unicode: false, maxLength: 3, nullable: false),
                    Paso = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TNotas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TTels",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Codigo = table.Column<string>(unicode: false, maxLength: 2, nullable: false),
                    Nombre = table.Column<string>(unicode: false, maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TTels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Charlas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TCharlaId = table.Column<int>(nullable: false),
                    CodigoCharla = table.Column<string>(unicode: false, maxLength: 20, nullable: false),
                    Nombre = table.Column<string>(unicode: false, maxLength: 400, nullable: false),
                    Descripcion = table.Column<string>(unicode: false, nullable: true),
                    PathLogo = table.Column<string>(unicode: false, maxLength: 300, nullable: false),
                    FechaInicio = table.Column<DateTime>(type: "datetime", nullable: false),
                    FechaFin = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Charlas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Charlas_TCharlas",
                        column: x => x.TCharlaId,
                        principalTable: "TCharlas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Documentos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TDocumentoId = table.Column<int>(nullable: false),
                    Documento = table.Column<string>(unicode: false, maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Documentos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Documentos_TDocumentos",
                        column: x => x.TDocumentoId,
                        principalTable: "TDocumentos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Domicilios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TDomicilioId = table.Column<int>(nullable: false),
                    Calle = table.Column<string>(unicode: false, maxLength: 200, nullable: false),
                    Numero = table.Column<string>(unicode: false, maxLength: 4, nullable: false),
                    Piso = table.Column<string>(unicode: false, maxLength: 2, nullable: false),
                    Dpto = table.Column<string>(unicode: false, maxLength: 2, nullable: false),
                    Barrio = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    CP = table.Column<string>(unicode: false, maxLength: 15, nullable: false),
                    X = table.Column<int>(nullable: false),
                    Y = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Domicilios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Domicilios_TDomicilios",
                        column: x => x.TDomicilioId,
                        principalTable: "TDomicilios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Mails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TMailId = table.Column<int>(nullable: false),
                    Mail = table.Column<string>(unicode: false, maxLength: 300, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Mails_TMails",
                        column: x => x.TMailId,
                        principalTable: "TMails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Instituciones",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TNotaId = table.Column<int>(nullable: false),
                    CodigoInstitucion = table.Column<string>(unicode: false, maxLength: 20, nullable: false),
                    Nombre = table.Column<string>(unicode: false, maxLength: 300, nullable: false),
                    Descripcion = table.Column<string>(unicode: false, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instituciones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Instituciones_TNotas",
                        column: x => x.TNotaId,
                        principalTable: "TNotas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tels",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TTelId = table.Column<int>(nullable: false),
                    Tel = table.Column<string>(unicode: false, maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tels_TTels",
                        column: x => x.TTelId,
                        principalTable: "TTels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CharlaPersonas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CharlaId = table.Column<int>(nullable: false),
                    PersonaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharlaPersonas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CharlaPersonas_Charlas",
                        column: x => x.CharlaId,
                        principalTable: "Charlas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CharlaPersonas_Personas",
                        column: x => x.PersonaId,
                        principalTable: "Personas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PersonaDocumentos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PersonaId = table.Column<int>(nullable: false),
                    DocumentoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonaDocumentos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PersonaDocumentos_Documentos",
                        column: x => x.DocumentoId,
                        principalTable: "Documentos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PersonaDocumentos_Personas",
                        column: x => x.PersonaId,
                        principalTable: "Personas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PersonaDomicilios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PersonaId = table.Column<int>(nullable: false),
                    DomicilioId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonaDomicilios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PersonaDomicilios_Domicilios",
                        column: x => x.DomicilioId,
                        principalTable: "Domicilios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PersonaDomicilios_Personas",
                        column: x => x.PersonaId,
                        principalTable: "Personas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PersonaMails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PersonaId = table.Column<int>(nullable: false),
                    MailId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonaMails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PersonaMails_Mails",
                        column: x => x.MailId,
                        principalTable: "Mails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PersonaMails_Personas",
                        column: x => x.PersonaId,
                        principalTable: "Personas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Carreras",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    InstitucionId = table.Column<int>(nullable: false),
                    CodigoCarrera = table.Column<string>(unicode: false, maxLength: 20, nullable: false),
                    Nombre = table.Column<string>(unicode: false, maxLength: 200, nullable: false),
                    Descripcion = table.Column<string>(unicode: false, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carreras", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Carreras_Instituciones",
                        column: x => x.InstitucionId,
                        principalTable: "Instituciones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "InstitucionDocumentos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    InstitucionId = table.Column<int>(nullable: false),
                    DocumentoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InstitucionDocumentos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InstitucionDocumentos_Documentos",
                        column: x => x.DocumentoId,
                        principalTable: "Documentos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InstitucionDocumentos_Instituciones",
                        column: x => x.InstitucionId,
                        principalTable: "Instituciones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "InstitucionDomicilios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    InstitucionId = table.Column<int>(nullable: false),
                    DomicilioId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InstitucionDomicilios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InstitucionDomicilios_Domicilios",
                        column: x => x.DomicilioId,
                        principalTable: "Domicilios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InstitucionDomicilios_Instituciones",
                        column: x => x.InstitucionId,
                        principalTable: "Instituciones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "InstitucionMails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    InstitucionId = table.Column<int>(nullable: false),
                    MailId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InstitucionMails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InstitucionMails_Instituciones",
                        column: x => x.InstitucionId,
                        principalTable: "Instituciones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InstitucionMails_Mails",
                        column: x => x.MailId,
                        principalTable: "Mails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "InstitucionTels",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    InstitucionId = table.Column<int>(nullable: false),
                    TelId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InstitucionTels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InstitucionTels_Instituciones",
                        column: x => x.InstitucionId,
                        principalTable: "Instituciones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InstitucionTels_Tels",
                        column: x => x.TelId,
                        principalTable: "Tels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PersonaTels",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PersonaId = table.Column<int>(nullable: false),
                    TelId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonaTels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PersonaTels_Personas",
                        column: x => x.PersonaId,
                        principalTable: "Personas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PersonaTels_Tels",
                        column: x => x.TelId,
                        principalTable: "Tels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CharlaDigos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CharlaId = table.Column<int>(nullable: false),
                    CharlaPersonaId = table.Column<int>(nullable: false),
                    CharlaDigoDeDigoId = table.Column<int>(nullable: true),
                    Digo = table.Column<string>(unicode: false, nullable: false),
                    FechaDigo = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharlaDigos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CharlaDigos_CharlaDigos",
                        column: x => x.CharlaDigoDeDigoId,
                        principalTable: "CharlaDigos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CharlaDigos_Charlas",
                        column: x => x.CharlaId,
                        principalTable: "Charlas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CharlaDigos_CharlaPersonas",
                        column: x => x.CharlaPersonaId,
                        principalTable: "CharlaPersonas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CarreraMaterias",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CarreraId = table.Column<int>(nullable: false),
                    CarreraMateriaId = table.Column<int>(nullable: false),
                    CodigoMateria = table.Column<string>(unicode: false, maxLength: 20, nullable: false),
                    Nombre = table.Column<string>(unicode: false, maxLength: 400, nullable: false),
                    Descripcion = table.Column<string>(unicode: false, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarreraMaterias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CarreraMaterias_Carreras",
                        column: x => x.CarreraId,
                        principalTable: "Carreras",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CarreraMaterias_Materias",
                        column: x => x.CarreraMateriaId,
                        principalTable: "Materias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CharlaDigoArchivos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CharlaDigoId = table.Column<int>(nullable: true),
                    Path = table.Column<string>(unicode: false, nullable: false),
                    Comentario = table.Column<string>(unicode: false, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharlaDigoArchivos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CharlaDigoArchivoss_CharlaDigos",
                        column: x => x.CharlaDigoId,
                        principalTable: "CharlaDigos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CharlaDigoLinks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CharlaDigoId = table.Column<int>(nullable: true),
                    Link = table.Column<string>(unicode: false, nullable: false),
                    Comentario = table.Column<string>(unicode: false, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharlaDigoLinks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CharlaDigoLinks_CharlaDigos",
                        column: x => x.CharlaDigoId,
                        principalTable: "CharlaDigos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CharlaLeeDigos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CharlaDigoId = table.Column<int>(nullable: true),
                    CharlaPersonaId = table.Column<int>(nullable: false),
                    FechaNotifico = table.Column<DateTime>(type: "datetime", nullable: false),
                    FechaRecibe = table.Column<DateTime>(type: "datetime", nullable: true),
                    FechaLeo = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharlaLeeDigos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CharlaLeeDigos_CharlaDigos",
                        column: x => x.CharlaDigoId,
                        principalTable: "CharlaDigos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CharlaLeeDigos_CharlaPersonas",
                        column: x => x.CharlaPersonaId,
                        principalTable: "CharlaPersonas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Aulas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NotasValidaId = table.Column<int>(nullable: false),
                    AsistenciaValidaId = table.Column<int>(nullable: false),
                    CharlaId = table.Column<int>(nullable: false),
                    CarreraId = table.Column<int>(nullable: true),
                    CarreraMateriaId = table.Column<int>(nullable: true),
                    CodigoAula = table.Column<string>(unicode: false, maxLength: 20, nullable: false),
                    Nombre = table.Column<string>(unicode: false, maxLength: 200, nullable: false),
                    Descripcion = table.Column<string>(unicode: false, nullable: false),
                    AnoLectivo = table.Column<int>(nullable: false),
                    Periodo = table.Column<string>(unicode: false, maxLength: 2, nullable: false),
                    Desde = table.Column<DateTime>(type: "date", nullable: false),
                    Hasta = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aulas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Aulas_Carreras",
                        column: x => x.CarreraId,
                        principalTable: "Carreras",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Aulas_CarreraMaterias",
                        column: x => x.CarreraMateriaId,
                        principalTable: "CarreraMaterias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Aulas_Charlas",
                        column: x => x.CharlaId,
                        principalTable: "Charlas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AulaAlumnos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AulaId = table.Column<int>(nullable: false),
                    PersonaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AulaAlumnos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AulaAlumnos_Aulas",
                        column: x => x.AulaId,
                        principalTable: "Aulas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AulaAlumnos_Personas",
                        column: x => x.PersonaId,
                        principalTable: "Personas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AulaDocentes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AulaId = table.Column<int>(nullable: false),
                    PersonaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AulaDocentes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AulaDocentes_Aulas",
                        column: x => x.AulaId,
                        principalTable: "Aulas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AulaDocentes_Personas",
                        column: x => x.PersonaId,
                        principalTable: "Personas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AulaEvaluaciones",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AulaId = table.Column<int>(nullable: false),
                    Fecha = table.Column<DateTime>(type: "date", nullable: false),
                    TipoEvaluacion = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    SePromedia = table.Column<byte>(nullable: false),
                    Descripcion = table.Column<string>(unicode: false, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AulaEvaluaciones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AulaEvaluaciones_Aulas",
                        column: x => x.AulaId,
                        principalTable: "Aulas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AulaGrupos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AulaId = table.Column<int>(nullable: false),
                    CharlaId = table.Column<int>(nullable: false),
                    CodigoGrupo = table.Column<string>(unicode: false, maxLength: 20, nullable: false),
                    Nombre = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    Descripcion = table.Column<string>(unicode: false, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AulaGrupos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AulaGrupos_Aulas",
                        column: x => x.AulaId,
                        principalTable: "Aulas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AulaGrupos_Charlas",
                        column: x => x.CharlaId,
                        principalTable: "Charlas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AulaTemaClases",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AulaId = table.Column<int>(nullable: false),
                    Fecha = table.Column<DateTime>(type: "date", nullable: false),
                    NumUnidad = table.Column<string>(unicode: false, maxLength: 2, nullable: false),
                    Unidad = table.Column<string>(unicode: false, maxLength: 200, nullable: false),
                    TipoClase = table.Column<string>(unicode: false, maxLength: 200, nullable: false),
                    Contenido = table.Column<string>(unicode: false, nullable: false),
                    Actividades = table.Column<string>(unicode: false, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AulaTemaClases", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AulaTemaClases_Aulas",
                        column: x => x.AulaId,
                        principalTable: "Aulas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AulaNotas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AulaEvaluacionId = table.Column<int>(nullable: true),
                    AulaAlumnoId = table.Column<int>(nullable: false),
                    Fecha = table.Column<DateTime>(type: "date", nullable: false),
                    Valor = table.Column<string>(unicode: false, maxLength: 3, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AulaNotas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AulaNotas_AulaAlumnos",
                        column: x => x.AulaAlumnoId,
                        principalTable: "AulaAlumnos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AulaNotas_AulaEvaluaciones",
                        column: x => x.AulaEvaluacionId,
                        principalTable: "AulaEvaluaciones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AulaGrupoAlumnos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AulaGrupoId = table.Column<int>(nullable: false),
                    AulaAlumnoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AulaGrupoAlumnos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AulaGrupoAlumnos_AulaAlumnos",
                        column: x => x.AulaAlumnoId,
                        principalTable: "AulaAlumnos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AulaGrupoAlumnos_AulaGrupos",
                        column: x => x.AulaGrupoId,
                        principalTable: "AulaGrupos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AulaAsistencias",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AulaTemaClaseId = table.Column<int>(nullable: true),
                    AulaAlumnoId = table.Column<int>(nullable: false),
                    Fecha = table.Column<DateTime>(type: "date", nullable: false),
                    NumUnidad = table.Column<string>(unicode: false, maxLength: 2, nullable: false),
                    Unidad = table.Column<string>(unicode: false, maxLength: 200, nullable: false),
                    TipoClase = table.Column<string>(unicode: false, maxLength: 200, nullable: false),
                    Contenido = table.Column<string>(unicode: false, nullable: false),
                    Actividades = table.Column<string>(unicode: false, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AulaAsistencias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AulaAsistencias_AulaAlumnos",
                        column: x => x.AulaAlumnoId,
                        principalTable: "AulaAlumnos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AulaAsistencias_AulaTemaClases",
                        column: x => x.AulaTemaClaseId,
                        principalTable: "AulaTemaClases",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AulaAlumnos_AulaId",
                table: "AulaAlumnos",
                column: "AulaId");

            migrationBuilder.CreateIndex(
                name: "IX_AulaAlumnos_PersonaId",
                table: "AulaAlumnos",
                column: "PersonaId");

            migrationBuilder.CreateIndex(
                name: "IX_AulaAsistencias_AulaAlumnoId",
                table: "AulaAsistencias",
                column: "AulaAlumnoId");

            migrationBuilder.CreateIndex(
                name: "IX_AulaAsistencias_AulaTemaClaseId",
                table: "AulaAsistencias",
                column: "AulaTemaClaseId");

            migrationBuilder.CreateIndex(
                name: "IX_AulaDocentes_AulaId",
                table: "AulaDocentes",
                column: "AulaId");

            migrationBuilder.CreateIndex(
                name: "IX_AulaDocentes_PersonaId",
                table: "AulaDocentes",
                column: "PersonaId");

            migrationBuilder.CreateIndex(
                name: "IX_AulaEvaluaciones_AulaId",
                table: "AulaEvaluaciones",
                column: "AulaId");

            migrationBuilder.CreateIndex(
                name: "IX_AulaGrupoAlumnos_AulaAlumnoId",
                table: "AulaGrupoAlumnos",
                column: "AulaAlumnoId");

            migrationBuilder.CreateIndex(
                name: "IX_AulaGrupoAlumnos_AulaGrupoId",
                table: "AulaGrupoAlumnos",
                column: "AulaGrupoId");

            migrationBuilder.CreateIndex(
                name: "IX_AulaGrupos_AulaId",
                table: "AulaGrupos",
                column: "AulaId");

            migrationBuilder.CreateIndex(
                name: "IX_AulaGrupos_CharlaId",
                table: "AulaGrupos",
                column: "CharlaId");

            migrationBuilder.CreateIndex(
                name: "IX_AulaNotas_AulaAlumnoId",
                table: "AulaNotas",
                column: "AulaAlumnoId");

            migrationBuilder.CreateIndex(
                name: "IX_AulaNotas_AulaEvaluacionId",
                table: "AulaNotas",
                column: "AulaEvaluacionId");

            migrationBuilder.CreateIndex(
                name: "IX_Aulas_CarreraId",
                table: "Aulas",
                column: "CarreraId");

            migrationBuilder.CreateIndex(
                name: "IX_Aulas_CarreraMateriaId",
                table: "Aulas",
                column: "CarreraMateriaId");

            migrationBuilder.CreateIndex(
                name: "IX_Aulas_CharlaId",
                table: "Aulas",
                column: "CharlaId");

            migrationBuilder.CreateIndex(
                name: "IX_AulaTemaClases_AulaId",
                table: "AulaTemaClases",
                column: "AulaId");

            migrationBuilder.CreateIndex(
                name: "IX_CarreraMaterias_CarreraId",
                table: "CarreraMaterias",
                column: "CarreraId");

            migrationBuilder.CreateIndex(
                name: "IX_CarreraMaterias_CarreraMateriaId",
                table: "CarreraMaterias",
                column: "CarreraMateriaId");

            migrationBuilder.CreateIndex(
                name: "IX_Carreras_InstitucionId",
                table: "Carreras",
                column: "InstitucionId");

            migrationBuilder.CreateIndex(
                name: "IX_CharlaDigoArchivos_CharlaDigoId",
                table: "CharlaDigoArchivos",
                column: "CharlaDigoId");

            migrationBuilder.CreateIndex(
                name: "IX_CharlaDigoLinks_CharlaDigoId",
                table: "CharlaDigoLinks",
                column: "CharlaDigoId");

            migrationBuilder.CreateIndex(
                name: "IX_CharlaDigos_CharlaDigoDeDigoId",
                table: "CharlaDigos",
                column: "CharlaDigoDeDigoId");

            migrationBuilder.CreateIndex(
                name: "IX_CharlaDigos_CharlaId",
                table: "CharlaDigos",
                column: "CharlaId");

            migrationBuilder.CreateIndex(
                name: "IX_CharlaDigos_CharlaPersonaId",
                table: "CharlaDigos",
                column: "CharlaPersonaId");

            migrationBuilder.CreateIndex(
                name: "IX_CharlaLeeDigos_CharlaDigoId",
                table: "CharlaLeeDigos",
                column: "CharlaDigoId");

            migrationBuilder.CreateIndex(
                name: "IX_CharlaLeeDigos_CharlaPersonaId",
                table: "CharlaLeeDigos",
                column: "CharlaPersonaId");

            migrationBuilder.CreateIndex(
                name: "IX_CharlaPersonas_CharlaId",
                table: "CharlaPersonas",
                column: "CharlaId");

            migrationBuilder.CreateIndex(
                name: "IX_CharlaPersonas_PersonaId",
                table: "CharlaPersonas",
                column: "PersonaId");

            migrationBuilder.CreateIndex(
                name: "IX_Charlas_TCharlaId",
                table: "Charlas",
                column: "TCharlaId");

            migrationBuilder.CreateIndex(
                name: "IX_Documentos_TDocumentoId",
                table: "Documentos",
                column: "TDocumentoId");

            migrationBuilder.CreateIndex(
                name: "IX_Domicilios_TDomicilioId",
                table: "Domicilios",
                column: "TDomicilioId");

            migrationBuilder.CreateIndex(
                name: "IX_InstitucionDocumentos_DocumentoId",
                table: "InstitucionDocumentos",
                column: "DocumentoId");

            migrationBuilder.CreateIndex(
                name: "IX_InstitucionDocumentos_InstitucionId",
                table: "InstitucionDocumentos",
                column: "InstitucionId");

            migrationBuilder.CreateIndex(
                name: "IX_InstitucionDomicilios_DomicilioId",
                table: "InstitucionDomicilios",
                column: "DomicilioId");

            migrationBuilder.CreateIndex(
                name: "IX_InstitucionDomicilios_InstitucionId",
                table: "InstitucionDomicilios",
                column: "InstitucionId");

            migrationBuilder.CreateIndex(
                name: "IX_Instituciones_TNotaId",
                table: "Instituciones",
                column: "TNotaId");

            migrationBuilder.CreateIndex(
                name: "IX_InstitucionMails_InstitucionId",
                table: "InstitucionMails",
                column: "InstitucionId");

            migrationBuilder.CreateIndex(
                name: "IX_InstitucionMails_MailId",
                table: "InstitucionMails",
                column: "MailId");

            migrationBuilder.CreateIndex(
                name: "IX_InstitucionTels_InstitucionId",
                table: "InstitucionTels",
                column: "InstitucionId");

            migrationBuilder.CreateIndex(
                name: "IX_InstitucionTels_TelId",
                table: "InstitucionTels",
                column: "TelId");

            migrationBuilder.CreateIndex(
                name: "IX_Mails_TMailId",
                table: "Mails",
                column: "TMailId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonaDocumentos_DocumentoId",
                table: "PersonaDocumentos",
                column: "DocumentoId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonaDocumentos_PersonaId",
                table: "PersonaDocumentos",
                column: "PersonaId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonaDomicilios_DomicilioId",
                table: "PersonaDomicilios",
                column: "DomicilioId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonaDomicilios_PersonaId",
                table: "PersonaDomicilios",
                column: "PersonaId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonaMails_MailId",
                table: "PersonaMails",
                column: "MailId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonaMails_PersonaId",
                table: "PersonaMails",
                column: "PersonaId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonaTels_PersonaId",
                table: "PersonaTels",
                column: "PersonaId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonaTels_TelId",
                table: "PersonaTels",
                column: "TelId");

            migrationBuilder.CreateIndex(
                name: "IX_TDocumentos",
                table: "TDocumentos",
                column: "Codigo",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TDomicilio",
                table: "TDomicilios",
                column: "Codigo",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tels_TTelId",
                table: "Tels",
                column: "TTelId");

            migrationBuilder.CreateIndex(
                name: "IX_TMails",
                table: "TMails",
                column: "Codigo",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AulaAsistencias");

            migrationBuilder.DropTable(
                name: "AulaDocentes");

            migrationBuilder.DropTable(
                name: "AulaGrupoAlumnos");

            migrationBuilder.DropTable(
                name: "AulaNotas");

            migrationBuilder.DropTable(
                name: "CharlaDigoArchivos");

            migrationBuilder.DropTable(
                name: "CharlaDigoLinks");

            migrationBuilder.DropTable(
                name: "CharlaLeeDigos");

            migrationBuilder.DropTable(
                name: "InstitucionDocumentos");

            migrationBuilder.DropTable(
                name: "InstitucionDomicilios");

            migrationBuilder.DropTable(
                name: "InstitucionMails");

            migrationBuilder.DropTable(
                name: "InstitucionTels");

            migrationBuilder.DropTable(
                name: "PersonaDocumentos");

            migrationBuilder.DropTable(
                name: "PersonaDomicilios");

            migrationBuilder.DropTable(
                name: "PersonaMails");

            migrationBuilder.DropTable(
                name: "PersonaTels");

            migrationBuilder.DropTable(
                name: "AulaTemaClases");

            migrationBuilder.DropTable(
                name: "AulaGrupos");

            migrationBuilder.DropTable(
                name: "AulaAlumnos");

            migrationBuilder.DropTable(
                name: "AulaEvaluaciones");

            migrationBuilder.DropTable(
                name: "CharlaDigos");

            migrationBuilder.DropTable(
                name: "Documentos");

            migrationBuilder.DropTable(
                name: "Domicilios");

            migrationBuilder.DropTable(
                name: "Mails");

            migrationBuilder.DropTable(
                name: "Tels");

            migrationBuilder.DropTable(
                name: "Aulas");

            migrationBuilder.DropTable(
                name: "CharlaPersonas");

            migrationBuilder.DropTable(
                name: "TDocumentos");

            migrationBuilder.DropTable(
                name: "TDomicilios");

            migrationBuilder.DropTable(
                name: "TMails");

            migrationBuilder.DropTable(
                name: "TTels");

            migrationBuilder.DropTable(
                name: "CarreraMaterias");

            migrationBuilder.DropTable(
                name: "Charlas");

            migrationBuilder.DropTable(
                name: "Personas");

            migrationBuilder.DropTable(
                name: "Carreras");

            migrationBuilder.DropTable(
                name: "Materias");

            migrationBuilder.DropTable(
                name: "TCharlas");

            migrationBuilder.DropTable(
                name: "Instituciones");

            migrationBuilder.DropTable(
                name: "TNotas");
        }
    }
}
