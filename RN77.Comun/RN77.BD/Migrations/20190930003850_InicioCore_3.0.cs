using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RN77.BD.Migrations
{
    public partial class InicioCore_30 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    FechaCreaReg = table.Column<DateTime>(nullable: false),
                    FechaModifReg = table.Column<DateTime>(nullable: false),
                    FechaBajaReg = table.Column<DateTime>(nullable: true),
                    PersonaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
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
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
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
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Materias",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaCreaReg = table.Column<DateTime>(nullable: false),
                    FechaModifReg = table.Column<DateTime>(nullable: false),
                    FechaBajaReg = table.Column<DateTime>(nullable: true),
                    ObservReg = table.Column<string>(nullable: false),
                    UsuarioId = table.Column<string>(nullable: false),
                    EstadoReg = table.Column<byte>(nullable: false),
                    Nombre = table.Column<string>(unicode: false, maxLength: 300, nullable: false),
                    Descripcion = table.Column<string>(unicode: false, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Materias_AspNetUsers_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Paises",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaCreaReg = table.Column<DateTime>(nullable: false),
                    FechaModifReg = table.Column<DateTime>(nullable: false),
                    FechaBajaReg = table.Column<DateTime>(nullable: true),
                    ObservReg = table.Column<string>(nullable: false),
                    UsuarioId = table.Column<string>(nullable: false),
                    EstadoReg = table.Column<byte>(nullable: false),
                    CodigoPais = table.Column<string>(maxLength: 2, nullable: false),
                    NombrePais = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paises", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Paises_AspNetUsers_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Personas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaCreaReg = table.Column<DateTime>(nullable: false),
                    FechaModifReg = table.Column<DateTime>(nullable: false),
                    FechaBajaReg = table.Column<DateTime>(nullable: true),
                    ObservReg = table.Column<string>(nullable: false),
                    UsuarioId = table.Column<string>(nullable: false),
                    EstadoReg = table.Column<byte>(nullable: false),
                    Nombre = table.Column<string>(unicode: false, maxLength: 200, nullable: false),
                    Apellido = table.Column<string>(unicode: false, maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Personas_AspNetUsers_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tcharlas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaCreaReg = table.Column<DateTime>(nullable: false),
                    FechaModifReg = table.Column<DateTime>(nullable: false),
                    FechaBajaReg = table.Column<DateTime>(nullable: true),
                    ObservReg = table.Column<string>(nullable: false),
                    UsuarioId = table.Column<string>(nullable: false),
                    EstadoReg = table.Column<byte>(nullable: false),
                    Codigo = table.Column<string>(unicode: false, maxLength: 2, nullable: false),
                    Nombre = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    Descripcion = table.Column<string>(unicode: false, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tcharlas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tcharlas_AspNetUsers_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tdocumentos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaCreaReg = table.Column<DateTime>(nullable: false),
                    FechaModifReg = table.Column<DateTime>(nullable: false),
                    FechaBajaReg = table.Column<DateTime>(nullable: true),
                    ObservReg = table.Column<string>(nullable: false),
                    UsuarioId = table.Column<string>(nullable: false),
                    EstadoReg = table.Column<byte>(nullable: false),
                    Codigo = table.Column<string>(unicode: false, maxLength: 4, nullable: false),
                    Nombre = table.Column<string>(unicode: false, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tdocumentos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tdocumentos_AspNetUsers_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tdomicilios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaCreaReg = table.Column<DateTime>(nullable: false),
                    FechaModifReg = table.Column<DateTime>(nullable: false),
                    FechaBajaReg = table.Column<DateTime>(nullable: true),
                    ObservReg = table.Column<string>(nullable: false),
                    UsuarioId = table.Column<string>(nullable: false),
                    EstadoReg = table.Column<byte>(nullable: false),
                    Codigo = table.Column<string>(unicode: false, maxLength: 2, nullable: false),
                    Nombre = table.Column<string>(unicode: false, maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tdomicilios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tdomicilios_AspNetUsers_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tmails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaCreaReg = table.Column<DateTime>(nullable: false),
                    FechaModifReg = table.Column<DateTime>(nullable: false),
                    FechaBajaReg = table.Column<DateTime>(nullable: true),
                    ObservReg = table.Column<string>(nullable: false),
                    UsuarioId = table.Column<string>(nullable: false),
                    EstadoReg = table.Column<byte>(nullable: false),
                    Codigo = table.Column<string>(unicode: false, maxLength: 2, nullable: false),
                    Nombre = table.Column<string>(unicode: false, maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tmails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tmails_AspNetUsers_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tnotas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaCreaReg = table.Column<DateTime>(nullable: false),
                    FechaModifReg = table.Column<DateTime>(nullable: false),
                    FechaBajaReg = table.Column<DateTime>(nullable: true),
                    ObservReg = table.Column<string>(nullable: false),
                    UsuarioId = table.Column<string>(nullable: false),
                    EstadoReg = table.Column<byte>(nullable: false),
                    Codigo = table.Column<string>(unicode: false, maxLength: 2, nullable: false),
                    Nombre = table.Column<string>(unicode: false, maxLength: 20, nullable: false),
                    ValorMin = table.Column<string>(unicode: false, maxLength: 3, nullable: false),
                    ValorMax = table.Column<string>(unicode: false, maxLength: 3, nullable: false),
                    Paso = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tnotas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tnotas_AspNetUsers_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Ttels",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaCreaReg = table.Column<DateTime>(nullable: false),
                    FechaModifReg = table.Column<DateTime>(nullable: false),
                    FechaBajaReg = table.Column<DateTime>(nullable: true),
                    ObservReg = table.Column<string>(nullable: false),
                    UsuarioId = table.Column<string>(nullable: false),
                    EstadoReg = table.Column<byte>(nullable: false),
                    Codigo = table.Column<string>(unicode: false, maxLength: 2, nullable: false),
                    Nombre = table.Column<string>(unicode: false, maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ttels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ttels_AspNetUsers_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Provincias",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaCreaReg = table.Column<DateTime>(nullable: false),
                    FechaModifReg = table.Column<DateTime>(nullable: false),
                    FechaBajaReg = table.Column<DateTime>(nullable: true),
                    ObservReg = table.Column<string>(nullable: false),
                    UsuarioId = table.Column<string>(nullable: false),
                    EstadoReg = table.Column<byte>(nullable: false),
                    PaisId = table.Column<int>(nullable: false),
                    NombreProvincia = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Provincias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Provincias_Paises",
                        column: x => x.PaisId,
                        principalTable: "Paises",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Provincias_AspNetUsers_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Charlas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaCreaReg = table.Column<DateTime>(nullable: false),
                    FechaModifReg = table.Column<DateTime>(nullable: false),
                    FechaBajaReg = table.Column<DateTime>(nullable: true),
                    ObservReg = table.Column<string>(nullable: false),
                    UsuarioId = table.Column<string>(nullable: false),
                    EstadoReg = table.Column<byte>(nullable: false),
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
                        principalTable: "Tcharlas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Charlas_AspNetUsers_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Documentos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaCreaReg = table.Column<DateTime>(nullable: false),
                    FechaModifReg = table.Column<DateTime>(nullable: false),
                    FechaBajaReg = table.Column<DateTime>(nullable: true),
                    ObservReg = table.Column<string>(nullable: false),
                    UsuarioId = table.Column<string>(nullable: false),
                    EstadoReg = table.Column<byte>(nullable: false),
                    TDocumentoId = table.Column<int>(nullable: false),
                    Documento = table.Column<string>(unicode: false, maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Documentos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Documentos_TDocumentos",
                        column: x => x.TDocumentoId,
                        principalTable: "Tdocumentos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Documentos_AspNetUsers_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Mails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaCreaReg = table.Column<DateTime>(nullable: false),
                    FechaModifReg = table.Column<DateTime>(nullable: false),
                    FechaBajaReg = table.Column<DateTime>(nullable: true),
                    ObservReg = table.Column<string>(nullable: false),
                    UsuarioId = table.Column<string>(nullable: false),
                    EstadoReg = table.Column<byte>(nullable: false),
                    TMailId = table.Column<int>(nullable: false),
                    Mail = table.Column<string>(unicode: false, maxLength: 300, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Mails_TMails",
                        column: x => x.TMailId,
                        principalTable: "Tmails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Mails_AspNetUsers_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Instituciones",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaCreaReg = table.Column<DateTime>(nullable: false),
                    FechaModifReg = table.Column<DateTime>(nullable: false),
                    FechaBajaReg = table.Column<DateTime>(nullable: true),
                    ObservReg = table.Column<string>(nullable: false),
                    UsuarioId = table.Column<string>(nullable: false),
                    EstadoReg = table.Column<byte>(nullable: false),
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
                        principalTable: "Tnotas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Instituciones_AspNetUsers_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tels",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaCreaReg = table.Column<DateTime>(nullable: false),
                    FechaModifReg = table.Column<DateTime>(nullable: false),
                    FechaBajaReg = table.Column<DateTime>(nullable: true),
                    ObservReg = table.Column<string>(nullable: false),
                    UsuarioId = table.Column<string>(nullable: false),
                    EstadoReg = table.Column<byte>(nullable: false),
                    TTelId = table.Column<int>(nullable: false),
                    Tel = table.Column<string>(unicode: false, maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tels_TTels",
                        column: x => x.TTelId,
                        principalTable: "Ttels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tels_AspNetUsers_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Ciudades",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaCreaReg = table.Column<DateTime>(nullable: false),
                    FechaModifReg = table.Column<DateTime>(nullable: false),
                    FechaBajaReg = table.Column<DateTime>(nullable: true),
                    ObservReg = table.Column<string>(nullable: false),
                    UsuarioId = table.Column<string>(nullable: false),
                    EstadoReg = table.Column<byte>(nullable: false),
                    ProvinciaId = table.Column<int>(nullable: false),
                    NombreCiudad = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ciudades", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ciudades_Provincias",
                        column: x => x.ProvinciaId,
                        principalTable: "Provincias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ciudades_AspNetUsers_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CharlaPersonas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaCreaReg = table.Column<DateTime>(nullable: false),
                    FechaModifReg = table.Column<DateTime>(nullable: false),
                    FechaBajaReg = table.Column<DateTime>(nullable: true),
                    ObservReg = table.Column<string>(nullable: false),
                    UsuarioId = table.Column<string>(nullable: false),
                    EstadoReg = table.Column<byte>(nullable: false),
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
                    table.ForeignKey(
                        name: "FK_CharlaPersonas_AspNetUsers_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PersonaDocumentos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaCreaReg = table.Column<DateTime>(nullable: false),
                    FechaModifReg = table.Column<DateTime>(nullable: false),
                    FechaBajaReg = table.Column<DateTime>(nullable: true),
                    ObservReg = table.Column<string>(nullable: false),
                    UsuarioId = table.Column<string>(nullable: false),
                    EstadoReg = table.Column<byte>(nullable: false),
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
                    table.ForeignKey(
                        name: "FK_PersonaDocumentos_AspNetUsers_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PersonaMails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaCreaReg = table.Column<DateTime>(nullable: false),
                    FechaModifReg = table.Column<DateTime>(nullable: false),
                    FechaBajaReg = table.Column<DateTime>(nullable: true),
                    ObservReg = table.Column<string>(nullable: false),
                    UsuarioId = table.Column<string>(nullable: false),
                    EstadoReg = table.Column<byte>(nullable: false),
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
                    table.ForeignKey(
                        name: "FK_PersonaMails_AspNetUsers_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Carreras",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaCreaReg = table.Column<DateTime>(nullable: false),
                    FechaModifReg = table.Column<DateTime>(nullable: false),
                    FechaBajaReg = table.Column<DateTime>(nullable: true),
                    ObservReg = table.Column<string>(nullable: false),
                    UsuarioId = table.Column<string>(nullable: false),
                    EstadoReg = table.Column<byte>(nullable: false),
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
                    table.ForeignKey(
                        name: "FK_Carreras_AspNetUsers_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "InstitucionDocumentos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaCreaReg = table.Column<DateTime>(nullable: false),
                    FechaModifReg = table.Column<DateTime>(nullable: false),
                    FechaBajaReg = table.Column<DateTime>(nullable: true),
                    ObservReg = table.Column<string>(nullable: false),
                    UsuarioId = table.Column<string>(nullable: false),
                    EstadoReg = table.Column<byte>(nullable: false),
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
                    table.ForeignKey(
                        name: "FK_InstitucionDocumentos_AspNetUsers_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "InstitucionMails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaCreaReg = table.Column<DateTime>(nullable: false),
                    FechaModifReg = table.Column<DateTime>(nullable: false),
                    FechaBajaReg = table.Column<DateTime>(nullable: true),
                    ObservReg = table.Column<string>(nullable: false),
                    UsuarioId = table.Column<string>(nullable: false),
                    EstadoReg = table.Column<byte>(nullable: false),
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
                    table.ForeignKey(
                        name: "FK_InstitucionMails_AspNetUsers_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "InstitucionTels",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaCreaReg = table.Column<DateTime>(nullable: false),
                    FechaModifReg = table.Column<DateTime>(nullable: false),
                    FechaBajaReg = table.Column<DateTime>(nullable: true),
                    ObservReg = table.Column<string>(nullable: false),
                    UsuarioId = table.Column<string>(nullable: false),
                    EstadoReg = table.Column<byte>(nullable: false),
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
                    table.ForeignKey(
                        name: "FK_InstitucionTels_AspNetUsers_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PersonaTels",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaCreaReg = table.Column<DateTime>(nullable: false),
                    FechaModifReg = table.Column<DateTime>(nullable: false),
                    FechaBajaReg = table.Column<DateTime>(nullable: true),
                    ObservReg = table.Column<string>(nullable: false),
                    UsuarioId = table.Column<string>(nullable: false),
                    EstadoReg = table.Column<byte>(nullable: false),
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
                    table.ForeignKey(
                        name: "FK_PersonaTels_AspNetUsers_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Domicilios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaCreaReg = table.Column<DateTime>(nullable: false),
                    FechaModifReg = table.Column<DateTime>(nullable: false),
                    FechaBajaReg = table.Column<DateTime>(nullable: true),
                    ObservReg = table.Column<string>(nullable: false),
                    UsuarioId = table.Column<string>(nullable: false),
                    EstadoReg = table.Column<byte>(nullable: false),
                    TDomicilioId = table.Column<int>(nullable: false),
                    CiudadId = table.Column<int>(nullable: false),
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
                        name: "FK_Domicilios_Ciudades",
                        column: x => x.CiudadId,
                        principalTable: "Ciudades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Domicilios_TDomicilios",
                        column: x => x.TDomicilioId,
                        principalTable: "Tdomicilios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Domicilios_AspNetUsers_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CharlaDigos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaCreaReg = table.Column<DateTime>(nullable: false),
                    FechaModifReg = table.Column<DateTime>(nullable: false),
                    FechaBajaReg = table.Column<DateTime>(nullable: true),
                    ObservReg = table.Column<string>(nullable: false),
                    UsuarioId = table.Column<string>(nullable: false),
                    EstadoReg = table.Column<byte>(nullable: false),
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
                    table.ForeignKey(
                        name: "FK_CharlaDigos_AspNetUsers_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CarreraMaterias",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaCreaReg = table.Column<DateTime>(nullable: false),
                    FechaModifReg = table.Column<DateTime>(nullable: false),
                    FechaBajaReg = table.Column<DateTime>(nullable: true),
                    ObservReg = table.Column<string>(nullable: false),
                    UsuarioId = table.Column<string>(nullable: false),
                    EstadoReg = table.Column<byte>(nullable: false),
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
                    table.ForeignKey(
                        name: "FK_CarreraMaterias_AspNetUsers_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "InstitucionDomicilios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaCreaReg = table.Column<DateTime>(nullable: false),
                    FechaModifReg = table.Column<DateTime>(nullable: false),
                    FechaBajaReg = table.Column<DateTime>(nullable: true),
                    ObservReg = table.Column<string>(nullable: false),
                    UsuarioId = table.Column<string>(nullable: false),
                    EstadoReg = table.Column<byte>(nullable: false),
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
                    table.ForeignKey(
                        name: "FK_InstitucionDomicilios_AspNetUsers_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PersonaDomicilios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaCreaReg = table.Column<DateTime>(nullable: false),
                    FechaModifReg = table.Column<DateTime>(nullable: false),
                    FechaBajaReg = table.Column<DateTime>(nullable: true),
                    ObservReg = table.Column<string>(nullable: false),
                    UsuarioId = table.Column<string>(nullable: false),
                    EstadoReg = table.Column<byte>(nullable: false),
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
                    table.ForeignKey(
                        name: "FK_PersonaDomicilios_AspNetUsers_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CharlaDigoArchivos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaCreaReg = table.Column<DateTime>(nullable: false),
                    FechaModifReg = table.Column<DateTime>(nullable: false),
                    FechaBajaReg = table.Column<DateTime>(nullable: true),
                    ObservReg = table.Column<string>(nullable: false),
                    UsuarioId = table.Column<string>(nullable: false),
                    EstadoReg = table.Column<byte>(nullable: false),
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
                    table.ForeignKey(
                        name: "FK_CharlaDigoArchivos_AspNetUsers_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CharlaDigoLinks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaCreaReg = table.Column<DateTime>(nullable: false),
                    FechaModifReg = table.Column<DateTime>(nullable: false),
                    FechaBajaReg = table.Column<DateTime>(nullable: true),
                    ObservReg = table.Column<string>(nullable: false),
                    UsuarioId = table.Column<string>(nullable: false),
                    EstadoReg = table.Column<byte>(nullable: false),
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
                    table.ForeignKey(
                        name: "FK_CharlaDigoLinks_AspNetUsers_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CharlaLeeDigos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaCreaReg = table.Column<DateTime>(nullable: false),
                    FechaModifReg = table.Column<DateTime>(nullable: false),
                    FechaBajaReg = table.Column<DateTime>(nullable: true),
                    ObservReg = table.Column<string>(nullable: false),
                    UsuarioId = table.Column<string>(nullable: false),
                    EstadoReg = table.Column<byte>(nullable: false),
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
                    table.ForeignKey(
                        name: "FK_CharlaLeeDigos_AspNetUsers_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Aulas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaCreaReg = table.Column<DateTime>(nullable: false),
                    FechaModifReg = table.Column<DateTime>(nullable: false),
                    FechaBajaReg = table.Column<DateTime>(nullable: true),
                    ObservReg = table.Column<string>(nullable: false),
                    UsuarioId = table.Column<string>(nullable: false),
                    EstadoReg = table.Column<byte>(nullable: false),
                    NotasValidaId = table.Column<int>(nullable: true),
                    AsistenciaValidaId = table.Column<int>(nullable: true),
                    CharlaId = table.Column<int>(nullable: true),
                    CarreraId = table.Column<int>(nullable: true),
                    CarreraMateriaId = table.Column<int>(nullable: true),
                    CodigoAula = table.Column<string>(unicode: false, maxLength: 20, nullable: false),
                    Nombre = table.Column<string>(unicode: false, maxLength: 200, nullable: false),
                    Descripcion = table.Column<string>(unicode: false, nullable: false),
                    AnoLectivo = table.Column<int>(nullable: false),
                    Periodo = table.Column<string>(unicode: false, maxLength: 2, nullable: false),
                    Desde = table.Column<DateTime>(type: "date", nullable: true),
                    Hasta = table.Column<DateTime>(type: "date", nullable: true)
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
                    table.ForeignKey(
                        name: "FK_Aulas_AspNetUsers_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AulaAlumnos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaCreaReg = table.Column<DateTime>(nullable: false),
                    FechaModifReg = table.Column<DateTime>(nullable: false),
                    FechaBajaReg = table.Column<DateTime>(nullable: true),
                    ObservReg = table.Column<string>(nullable: false),
                    UsuarioId = table.Column<string>(nullable: false),
                    EstadoReg = table.Column<byte>(nullable: false),
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
                    table.ForeignKey(
                        name: "FK_AulaAlumnos_AspNetUsers_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AulaDocentes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaCreaReg = table.Column<DateTime>(nullable: false),
                    FechaModifReg = table.Column<DateTime>(nullable: false),
                    FechaBajaReg = table.Column<DateTime>(nullable: true),
                    ObservReg = table.Column<string>(nullable: false),
                    UsuarioId = table.Column<string>(nullable: false),
                    EstadoReg = table.Column<byte>(nullable: false),
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
                    table.ForeignKey(
                        name: "FK_AulaDocentes_AspNetUsers_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AulaEvaluaciones",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaCreaReg = table.Column<DateTime>(nullable: false),
                    FechaModifReg = table.Column<DateTime>(nullable: false),
                    FechaBajaReg = table.Column<DateTime>(nullable: true),
                    ObservReg = table.Column<string>(nullable: false),
                    UsuarioId = table.Column<string>(nullable: false),
                    EstadoReg = table.Column<byte>(nullable: false),
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
                    table.ForeignKey(
                        name: "FK_AulaEvaluaciones_AspNetUsers_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AulaGrupos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaCreaReg = table.Column<DateTime>(nullable: false),
                    FechaModifReg = table.Column<DateTime>(nullable: false),
                    FechaBajaReg = table.Column<DateTime>(nullable: true),
                    ObservReg = table.Column<string>(nullable: false),
                    UsuarioId = table.Column<string>(nullable: false),
                    EstadoReg = table.Column<byte>(nullable: false),
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
                    table.ForeignKey(
                        name: "FK_AulaGrupos_AspNetUsers_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AulaTemaClases",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaCreaReg = table.Column<DateTime>(nullable: false),
                    FechaModifReg = table.Column<DateTime>(nullable: false),
                    FechaBajaReg = table.Column<DateTime>(nullable: true),
                    ObservReg = table.Column<string>(nullable: false),
                    UsuarioId = table.Column<string>(nullable: false),
                    EstadoReg = table.Column<byte>(nullable: false),
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
                    table.ForeignKey(
                        name: "FK_AulaTemaClases_AspNetUsers_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AulaNotas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaCreaReg = table.Column<DateTime>(nullable: false),
                    FechaModifReg = table.Column<DateTime>(nullable: false),
                    FechaBajaReg = table.Column<DateTime>(nullable: true),
                    ObservReg = table.Column<string>(nullable: false),
                    UsuarioId = table.Column<string>(nullable: false),
                    EstadoReg = table.Column<byte>(nullable: false),
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
                    table.ForeignKey(
                        name: "FK_AulaNotas_AspNetUsers_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AulaGrupoAlumnos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaCreaReg = table.Column<DateTime>(nullable: false),
                    FechaModifReg = table.Column<DateTime>(nullable: false),
                    FechaBajaReg = table.Column<DateTime>(nullable: true),
                    ObservReg = table.Column<string>(nullable: false),
                    UsuarioId = table.Column<string>(nullable: false),
                    EstadoReg = table.Column<byte>(nullable: false),
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
                    table.ForeignKey(
                        name: "FK_AulaGrupoAlumnos_AspNetUsers_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AulaAsistencias",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaCreaReg = table.Column<DateTime>(nullable: false),
                    FechaModifReg = table.Column<DateTime>(nullable: false),
                    FechaBajaReg = table.Column<DateTime>(nullable: true),
                    ObservReg = table.Column<string>(nullable: false),
                    UsuarioId = table.Column<string>(nullable: false),
                    EstadoReg = table.Column<byte>(nullable: false),
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
                    table.ForeignKey(
                        name: "FK_AulaAsistencias_AspNetUsers_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

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
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AulaAlumnos_AulaId",
                table: "AulaAlumnos",
                column: "AulaId");

            migrationBuilder.CreateIndex(
                name: "IX_AulaAlumnos_PersonaId",
                table: "AulaAlumnos",
                column: "PersonaId");

            migrationBuilder.CreateIndex(
                name: "IX_AulaAlumnos_UsuarioId",
                table: "AulaAlumnos",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_AulaAsistencias_AulaAlumnoId",
                table: "AulaAsistencias",
                column: "AulaAlumnoId");

            migrationBuilder.CreateIndex(
                name: "IX_AulaAsistencias_AulaTemaClaseId",
                table: "AulaAsistencias",
                column: "AulaTemaClaseId");

            migrationBuilder.CreateIndex(
                name: "IX_AulaAsistencias_UsuarioId",
                table: "AulaAsistencias",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_AulaDocentes_AulaId",
                table: "AulaDocentes",
                column: "AulaId");

            migrationBuilder.CreateIndex(
                name: "IX_AulaDocentes_PersonaId",
                table: "AulaDocentes",
                column: "PersonaId");

            migrationBuilder.CreateIndex(
                name: "IX_AulaDocentes_UsuarioId",
                table: "AulaDocentes",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_AulaEvaluaciones_AulaId",
                table: "AulaEvaluaciones",
                column: "AulaId");

            migrationBuilder.CreateIndex(
                name: "IX_AulaEvaluaciones_UsuarioId",
                table: "AulaEvaluaciones",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_AulaGrupoAlumnos_AulaAlumnoId",
                table: "AulaGrupoAlumnos",
                column: "AulaAlumnoId");

            migrationBuilder.CreateIndex(
                name: "IX_AulaGrupoAlumnos_AulaGrupoId",
                table: "AulaGrupoAlumnos",
                column: "AulaGrupoId");

            migrationBuilder.CreateIndex(
                name: "IX_AulaGrupoAlumnos_UsuarioId",
                table: "AulaGrupoAlumnos",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_AulaGrupos_AulaId",
                table: "AulaGrupos",
                column: "AulaId");

            migrationBuilder.CreateIndex(
                name: "IX_AulaGrupos_CharlaId",
                table: "AulaGrupos",
                column: "CharlaId");

            migrationBuilder.CreateIndex(
                name: "IQ_AulaGrupos",
                table: "AulaGrupos",
                column: "CodigoGrupo",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AulaGrupos_UsuarioId",
                table: "AulaGrupos",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_AulaNotas_AulaAlumnoId",
                table: "AulaNotas",
                column: "AulaAlumnoId");

            migrationBuilder.CreateIndex(
                name: "IX_AulaNotas_AulaEvaluacionId",
                table: "AulaNotas",
                column: "AulaEvaluacionId");

            migrationBuilder.CreateIndex(
                name: "IX_AulaNotas_UsuarioId",
                table: "AulaNotas",
                column: "UsuarioId");

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
                name: "IQ_Aulas",
                table: "Aulas",
                column: "CodigoAula",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Aulas_UsuarioId",
                table: "Aulas",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_AulaTemaClases_AulaId",
                table: "AulaTemaClases",
                column: "AulaId");

            migrationBuilder.CreateIndex(
                name: "IX_AulaTemaClases_UsuarioId",
                table: "AulaTemaClases",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_CarreraMaterias_CarreraId",
                table: "CarreraMaterias",
                column: "CarreraId");

            migrationBuilder.CreateIndex(
                name: "IX_CarreraMaterias_CarreraMateriaId",
                table: "CarreraMaterias",
                column: "CarreraMateriaId");

            migrationBuilder.CreateIndex(
                name: "IQ_CarreraMaterias",
                table: "CarreraMaterias",
                column: "CodigoMateria",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CarreraMaterias_UsuarioId",
                table: "CarreraMaterias",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IQ_Carreras",
                table: "Carreras",
                column: "CodigoCarrera",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Carreras_InstitucionId",
                table: "Carreras",
                column: "InstitucionId");

            migrationBuilder.CreateIndex(
                name: "IX_Carreras_UsuarioId",
                table: "Carreras",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_CharlaDigoArchivos_CharlaDigoId",
                table: "CharlaDigoArchivos",
                column: "CharlaDigoId");

            migrationBuilder.CreateIndex(
                name: "IX_CharlaDigoArchivos_UsuarioId",
                table: "CharlaDigoArchivos",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_CharlaDigoLinks_CharlaDigoId",
                table: "CharlaDigoLinks",
                column: "CharlaDigoId");

            migrationBuilder.CreateIndex(
                name: "IX_CharlaDigoLinks_UsuarioId",
                table: "CharlaDigoLinks",
                column: "UsuarioId");

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
                name: "IX_CharlaDigos_UsuarioId",
                table: "CharlaDigos",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_CharlaLeeDigos_CharlaDigoId",
                table: "CharlaLeeDigos",
                column: "CharlaDigoId");

            migrationBuilder.CreateIndex(
                name: "IX_CharlaLeeDigos_CharlaPersonaId",
                table: "CharlaLeeDigos",
                column: "CharlaPersonaId");

            migrationBuilder.CreateIndex(
                name: "IX_CharlaLeeDigos_UsuarioId",
                table: "CharlaLeeDigos",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_CharlaPersonas_CharlaId",
                table: "CharlaPersonas",
                column: "CharlaId");

            migrationBuilder.CreateIndex(
                name: "IX_CharlaPersonas_PersonaId",
                table: "CharlaPersonas",
                column: "PersonaId");

            migrationBuilder.CreateIndex(
                name: "IX_CharlaPersonas_UsuarioId",
                table: "CharlaPersonas",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IQ_Charlas",
                table: "Charlas",
                column: "CodigoCharla",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Charlas_TCharlaId",
                table: "Charlas",
                column: "TCharlaId");

            migrationBuilder.CreateIndex(
                name: "IX_Charlas_UsuarioId",
                table: "Charlas",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IQ_NombreCiudad",
                table: "Ciudades",
                column: "NombreCiudad",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ciudades_ProvinciaId",
                table: "Ciudades",
                column: "ProvinciaId");

            migrationBuilder.CreateIndex(
                name: "IX_Ciudades_UsuarioId",
                table: "Ciudades",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Documentos_TDocumentoId",
                table: "Documentos",
                column: "TDocumentoId");

            migrationBuilder.CreateIndex(
                name: "IX_Documentos_UsuarioId",
                table: "Documentos",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Domicilios_CiudadId",
                table: "Domicilios",
                column: "CiudadId");

            migrationBuilder.CreateIndex(
                name: "IX_Domicilios_TDomicilioId",
                table: "Domicilios",
                column: "TDomicilioId");

            migrationBuilder.CreateIndex(
                name: "IX_Domicilios_UsuarioId",
                table: "Domicilios",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_InstitucionDocumentos_DocumentoId",
                table: "InstitucionDocumentos",
                column: "DocumentoId");

            migrationBuilder.CreateIndex(
                name: "IX_InstitucionDocumentos_InstitucionId",
                table: "InstitucionDocumentos",
                column: "InstitucionId");

            migrationBuilder.CreateIndex(
                name: "IX_InstitucionDocumentos_UsuarioId",
                table: "InstitucionDocumentos",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_InstitucionDomicilios_DomicilioId",
                table: "InstitucionDomicilios",
                column: "DomicilioId");

            migrationBuilder.CreateIndex(
                name: "IX_InstitucionDomicilios_InstitucionId",
                table: "InstitucionDomicilios",
                column: "InstitucionId");

            migrationBuilder.CreateIndex(
                name: "IX_InstitucionDomicilios_UsuarioId",
                table: "InstitucionDomicilios",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IQ_Instituciones",
                table: "Instituciones",
                column: "CodigoInstitucion",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Instituciones_TNotaId",
                table: "Instituciones",
                column: "TNotaId");

            migrationBuilder.CreateIndex(
                name: "IX_Instituciones_UsuarioId",
                table: "Instituciones",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_InstitucionMails_InstitucionId",
                table: "InstitucionMails",
                column: "InstitucionId");

            migrationBuilder.CreateIndex(
                name: "IX_InstitucionMails_MailId",
                table: "InstitucionMails",
                column: "MailId");

            migrationBuilder.CreateIndex(
                name: "IX_InstitucionMails_UsuarioId",
                table: "InstitucionMails",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_InstitucionTels_InstitucionId",
                table: "InstitucionTels",
                column: "InstitucionId");

            migrationBuilder.CreateIndex(
                name: "IX_InstitucionTels_TelId",
                table: "InstitucionTels",
                column: "TelId");

            migrationBuilder.CreateIndex(
                name: "IX_InstitucionTels_UsuarioId",
                table: "InstitucionTels",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Mails_TMailId",
                table: "Mails",
                column: "TMailId");

            migrationBuilder.CreateIndex(
                name: "IX_Mails_UsuarioId",
                table: "Mails",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Materias_UsuarioId",
                table: "Materias",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IQ_CodigoPais",
                table: "Paises",
                column: "CodigoPais",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IQ_NombrePais",
                table: "Paises",
                column: "NombrePais",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Paises_UsuarioId",
                table: "Paises",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonaDocumentos_DocumentoId",
                table: "PersonaDocumentos",
                column: "DocumentoId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonaDocumentos_PersonaId",
                table: "PersonaDocumentos",
                column: "PersonaId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonaDocumentos_UsuarioId",
                table: "PersonaDocumentos",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonaDomicilios_DomicilioId",
                table: "PersonaDomicilios",
                column: "DomicilioId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonaDomicilios_PersonaId",
                table: "PersonaDomicilios",
                column: "PersonaId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonaDomicilios_UsuarioId",
                table: "PersonaDomicilios",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonaMails_MailId",
                table: "PersonaMails",
                column: "MailId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonaMails_PersonaId",
                table: "PersonaMails",
                column: "PersonaId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonaMails_UsuarioId",
                table: "PersonaMails",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_UsuarioId",
                table: "Personas",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonaTels_PersonaId",
                table: "PersonaTels",
                column: "PersonaId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonaTels_TelId",
                table: "PersonaTels",
                column: "TelId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonaTels_UsuarioId",
                table: "PersonaTels",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IQ_NombreProvincia",
                table: "Provincias",
                column: "NombreProvincia",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Provincias_PaisId",
                table: "Provincias",
                column: "PaisId");

            migrationBuilder.CreateIndex(
                name: "IX_Provincias_UsuarioId",
                table: "Provincias",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IQ_Tcharlas",
                table: "Tcharlas",
                column: "Codigo",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tcharlas_UsuarioId",
                table: "Tcharlas",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IQ_TDocCodigo",
                table: "Tdocumentos",
                column: "Codigo",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IQ_TDocNombre",
                table: "Tdocumentos",
                column: "Nombre",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tdocumentos_UsuarioId",
                table: "Tdocumentos",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_TDomicilio",
                table: "Tdomicilios",
                column: "Codigo",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tdomicilios_UsuarioId",
                table: "Tdomicilios",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Tels_TTelId",
                table: "Tels",
                column: "TTelId");

            migrationBuilder.CreateIndex(
                name: "IX_Tels_UsuarioId",
                table: "Tels",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IQ_TMails",
                table: "Tmails",
                column: "Codigo",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tmails_UsuarioId",
                table: "Tmails",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IQ_Tnotas",
                table: "Tnotas",
                column: "Codigo",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tnotas_UsuarioId",
                table: "Tnotas",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IQ_Ttels",
                table: "Ttels",
                column: "Codigo",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ttels_UsuarioId",
                table: "Ttels",
                column: "UsuarioId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

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
                name: "AspNetRoles");

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
                name: "Tdocumentos");

            migrationBuilder.DropTable(
                name: "Ciudades");

            migrationBuilder.DropTable(
                name: "Tdomicilios");

            migrationBuilder.DropTable(
                name: "Tmails");

            migrationBuilder.DropTable(
                name: "Ttels");

            migrationBuilder.DropTable(
                name: "CarreraMaterias");

            migrationBuilder.DropTable(
                name: "Charlas");

            migrationBuilder.DropTable(
                name: "Personas");

            migrationBuilder.DropTable(
                name: "Provincias");

            migrationBuilder.DropTable(
                name: "Carreras");

            migrationBuilder.DropTable(
                name: "Materias");

            migrationBuilder.DropTable(
                name: "Tcharlas");

            migrationBuilder.DropTable(
                name: "Paises");

            migrationBuilder.DropTable(
                name: "Instituciones");

            migrationBuilder.DropTable(
                name: "Tnotas");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
