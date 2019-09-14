namespace RN77.BD.Datos
{
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using RN77.BD.Datos.Entities;
    using System.Linq;

    public partial class RN77Context : IdentityDbContext<Usuarios>
    {
        private readonly IConfiguration configuration;
        // Scaffold-DbContext "Server=DESKTOP-US7V3RT;Database=RN77;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Datos/Entities

        #region DBSET
        public virtual DbSet<AulaAlumnos> AulaAlumnos { get; set; }
        public virtual DbSet<AulaAsistencias> AulaAsistencias { get; set; }
        public virtual DbSet<AulaDocentes> AulaDocentes { get; set; }
        public virtual DbSet<AulaEvaluaciones> AulaEvaluaciones { get; set; }
        public virtual DbSet<AulaGrupoAlumnos> AulaGrupoAlumnos { get; set; }
        public virtual DbSet<AulaGrupos> AulaGrupos { get; set; }
        public virtual DbSet<AulaNotas> AulaNotas { get; set; }
        public virtual DbSet<AulaTemaClases> AulaTemaClases { get; set; }
        public virtual DbSet<Aulas> Aulas { get; set; }
        public virtual DbSet<CarreraMaterias> CarreraMaterias { get; set; }
        public virtual DbSet<Carreras> Carreras { get; set; }
        public virtual DbSet<CharlaDigoArchivos> CharlaDigoArchivos { get; set; }
        public virtual DbSet<CharlaDigoLinks> CharlaDigoLinks { get; set; }
        public virtual DbSet<CharlaDigos> CharlaDigos { get; set; }
        public virtual DbSet<CharlaLeeDigos> CharlaLeeDigos { get; set; }
        public virtual DbSet<CharlaPersonas> CharlaPersonas { get; set; }
        public virtual DbSet<Charlas> Charlas { get; set; }
        public virtual DbSet<Ciudades> Ciudades { get; set; }
        public virtual DbSet<Documentos> Documentos { get; set; }
        public virtual DbSet<Domicilios> Domicilios { get; set; }
        public virtual DbSet<InstitucionDocumentos> InstitucionDocumentos { get; set; }
        public virtual DbSet<InstitucionDomicilios> InstitucionDomicilios { get; set; }
        public virtual DbSet<InstitucionMails> InstitucionMails { get; set; }
        public virtual DbSet<InstitucionTels> InstitucionTels { get; set; }
        public virtual DbSet<Instituciones> Instituciones { get; set; }
        public virtual DbSet<Mails> Mails { get; set; }
        public virtual DbSet<Materias> Materias { get; set; }
        public virtual DbSet<Paises> Paises { get; set; }
        public virtual DbSet<PersonaDocumentos> PersonaDocumentos { get; set; }
        public virtual DbSet<PersonaDomicilios> PersonaDomicilios { get; set; }
        public virtual DbSet<PersonaMails> PersonaMails { get; set; }
        public virtual DbSet<PersonaTels> PersonaTels { get; set; }
        public virtual DbSet<Personas> Personas { get; set; }
        public virtual DbSet<Provincias> Provincias { get; set; }
        public virtual DbSet<Tcharlas> Tcharlas { get; set; }
        public virtual DbSet<Tdocumentos> Tdocumentos { get; set; }
        public virtual DbSet<Tdomicilios> Tdomicilios { get; set; }
        public virtual DbSet<Tels> Tels { get; set; }
        public virtual DbSet<Tmails> Tmails { get; set; }
        public virtual DbSet<Tnotas> Tnotas { get; set; }
        public virtual DbSet<Ttels> Ttels { get; set; }
        #endregion

        #region CONSTRUCTOR
        public RN77Context()
        {
        }

        public RN77Context(DbContextOptions<RN77Context> options, IConfiguration configuration) : base(options)
        {
            this.configuration = configuration;
        }

        #endregion

        #region METODOS
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=RN77;Trusted_Connection=True;MultipleActiveResultSets=true;");
                optionsBuilder.UseSqlServer(this.configuration.GetConnectionString("RN77Connection"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            #region AULAS
            #region AulaAlumnos
            modelBuilder.Entity<AulaAlumnos>(entity =>
            {
                entity.HasOne(d => d.Aula)
                    .WithMany(p => p.AulaAlumnos)
                    .HasForeignKey(d => d.AulaId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AulaAlumnos_Aulas");
                
                entity.HasOne(d => d.Persona)
                    .WithMany(p => p.AulaAlumnos)
                    .HasForeignKey(d => d.PersonaId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AulaAlumnos_Personas");
            });
            #endregion

            #region AulaAsistencias
            modelBuilder.Entity<AulaAsistencias>(entity =>
            {
                entity.Property(e => e.Actividades)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Contenido)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.NumUnidad)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.TipoClase)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Unidad)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.AulaAlumno)
                    .WithMany(p => p.AulaAsistencias)
                    .HasForeignKey(d => d.AulaAlumnoId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AulaAsistencias_AulaAlumnos");

                entity.HasOne(d => d.AulaTemaClase)
                    .WithMany(p => p.AulaAsistencias)
                    .HasForeignKey(d => d.AulaTemaClaseId)
                    .HasConstraintName("FK_AulaAsistencias_AulaTemaClases");
            });
            #endregion

            #region AulaDocentes
            modelBuilder.Entity<AulaDocentes>(entity =>
            {
                entity.HasOne(d => d.Aula)
                    .WithMany(p => p.AulaDocentes)
                    .HasForeignKey(d => d.AulaId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AulaDocentes_Aulas");

                entity.HasOne(d => d.Persona)
                    .WithMany(p => p.AulaDocentes)
                    .HasForeignKey(d => d.PersonaId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AulaDocentes_Personas");
            });
            #endregion

            #region AulaEvaluaciones
            modelBuilder.Entity<AulaEvaluaciones>(entity =>
    {
        entity.Property(e => e.Descripcion)
            .IsRequired()
            .IsUnicode(false);

        entity.Property(e => e.Fecha).HasColumnType("date");

        entity.Property(e => e.TipoEvaluacion)
            .IsRequired()
            .HasMaxLength(50)
            .IsUnicode(false);

        entity.HasOne(d => d.Aula)
            .WithMany(p => p.AulaEvaluaciones)
            .HasForeignKey(d => d.AulaId)
            .OnDelete(DeleteBehavior.Restrict)
            .HasConstraintName("FK_AulaEvaluaciones_Aulas");
    });
            #endregion

            #region AulaGrupoAlumnos
            modelBuilder.Entity<AulaGrupoAlumnos>(entity =>
    {
        entity.HasOne(d => d.AulaAlumno)
            .WithMany(p => p.AulaGrupoAlumnos)
            .HasForeignKey(d => d.AulaAlumnoId)
            .OnDelete(DeleteBehavior.Restrict)
            .HasConstraintName("FK_AulaGrupoAlumnos_AulaAlumnos");

        entity.HasOne(d => d.AulaGrupo)
            .WithMany(p => p.AulaGrupoAlumnos)
            .HasForeignKey(d => d.AulaGrupoId)
            .OnDelete(DeleteBehavior.Restrict)
            .HasConstraintName("FK_AulaGrupoAlumnos_AulaGrupos");
    });
            #endregion

            #region AulaGrupos
            modelBuilder.Entity<AulaGrupos>(entity =>
            {
                entity.HasIndex(e => e.CodigoGrupo)
                .HasName("IQ_AulaGrupos")
                .IsUnique();

                entity.Property(e => e.CodigoGrupo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Aula)
                    .WithMany(p => p.AulaGrupos)
                    .HasForeignKey(d => d.AulaId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AulaGrupos_Aulas");

                entity.HasOne(d => d.Charla)
                    .WithMany(p => p.AulaGrupos)
                    .HasForeignKey(d => d.CharlaId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AulaGrupos_Charlas");
            });
            #endregion

            #region AulaNotas
            modelBuilder.Entity<AulaNotas>(entity =>
    {
        entity.Property(e => e.Fecha).HasColumnType("date");

        entity.Property(e => e.Valor)
            .IsRequired()
            .HasMaxLength(3)
            .IsUnicode(false);

        entity.HasOne(d => d.AulaAlumno)
            .WithMany(p => p.AulaNotas)
            .HasForeignKey(d => d.AulaAlumnoId)
            .OnDelete(DeleteBehavior.Restrict)
            .HasConstraintName("FK_AulaNotas_AulaAlumnos");

        entity.HasOne(d => d.AulaEvaluacion)
            .WithMany(p => p.AulaNotas)
            .HasForeignKey(d => d.AulaEvaluacionId)
            .HasConstraintName("FK_AulaNotas_AulaEvaluaciones");
    });
            #endregion

            #region AulaTemaClases
            modelBuilder.Entity<AulaTemaClases>(entity =>
    {
        entity.Property(e => e.Actividades)
            .IsRequired()
            .IsUnicode(false);

        entity.Property(e => e.Contenido)
            .IsRequired()
            .IsUnicode(false);

        entity.Property(e => e.Fecha).HasColumnType("date");

        entity.Property(e => e.NumUnidad)
            .IsRequired()
            .HasMaxLength(2)
            .IsUnicode(false);

        entity.Property(e => e.TipoClase)
            .IsRequired()
            .HasMaxLength(200)
            .IsUnicode(false);

        entity.Property(e => e.Unidad)
            .IsRequired()
            .HasMaxLength(200)
            .IsUnicode(false);

        entity.HasOne(d => d.Aula)
            .WithMany(p => p.AulaTemaClases)
            .HasForeignKey(d => d.AulaId)
            .OnDelete(DeleteBehavior.Restrict)
            .HasConstraintName("FK_AulaTemaClases_Aulas");
    });
            #endregion

            #region Aulas
            modelBuilder.Entity<Aulas>(entity =>
            {
                entity.HasIndex(e => e.CodigoAula)
                .HasName("IQ_Aulas")
                .IsUnique();

                entity.Property(e => e.CodigoAula)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Desde).HasColumnType("date");

                entity.Property(e => e.Hasta).HasColumnType("date");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Periodo)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.HasOne(d => d.Carrera)
                    .WithMany(p => p.Aulas)
                    .HasForeignKey(d => d.CarreraId)
                    .HasConstraintName("FK_Aulas_Carreras");

                entity.HasOne(d => d.CarreraMateria)
                    .WithMany(p => p.Aulas)
                    .HasForeignKey(d => d.CarreraMateriaId)
                    .HasConstraintName("FK_Aulas_CarreraMaterias");

                entity.HasOne(d => d.Charla)
                    .WithMany(p => p.Aulas)
                    .HasForeignKey(d => d.CharlaId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Aulas_Charlas");
            });
            #endregion

            #region CarreraMaterias
            modelBuilder.Entity<CarreraMaterias>(entity =>
            {
                entity.HasIndex(e => e.CodigoMateria)
                .HasName("IQ_CarreraMaterias")
                .IsUnique();

                entity.Property(e => e.CodigoMateria)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.HasOne(d => d.Carrera)
                    .WithMany(p => p.CarreraMaterias)
                    .HasForeignKey(d => d.CarreraId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CarreraMaterias_Carreras");

                entity.HasOne(d => d.CarreraMateria)
                    .WithMany(p => p.CarreraMaterias)
                    .HasForeignKey(d => d.CarreraMateriaId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CarreraMaterias_Materias");
            });
            #endregion

            #region Carreras
            modelBuilder.Entity<Carreras>(entity =>
            {
                entity.HasIndex(e => e.CodigoCarrera)
                .HasName("IQ_Carreras")
                .IsUnique();

                entity.Property(e => e.CodigoCarrera)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.Institucion)
                    .WithMany(p => p.Carreras)
                    .HasForeignKey(d => d.InstitucionId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Carreras_Instituciones");
            });
            #endregion

            #region Materias
            modelBuilder.Entity<Materias>(entity =>
            {
                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false);
            });
            #endregion
            #endregion

            #region CHARLA
            #region CharlaDigoArchivos
            modelBuilder.Entity<CharlaDigoArchivos>(entity =>
    {
        entity.Property(e => e.Comentario)
            .IsRequired()
            .IsUnicode(false);

        entity.Property(e => e.Path)
            .IsRequired()
            .IsUnicode(false);

        entity.HasOne(d => d.CharlaDigo)
            .WithMany(p => p.CharlaDigoArchivos)
            .HasForeignKey(d => d.CharlaDigoId)
            .HasConstraintName("FK_CharlaDigoArchivoss_CharlaDigos");
    });
            #endregion

            #region CharlaDigoLinks
            modelBuilder.Entity<CharlaDigoLinks>(entity =>
    {
        entity.Property(e => e.Comentario)
            .IsRequired()
            .IsUnicode(false);

        entity.Property(e => e.Link)
            .IsRequired()
            .IsUnicode(false);

        entity.HasOne(d => d.CharlaDigo)
            .WithMany(p => p.CharlaDigoLinks)
            .HasForeignKey(d => d.CharlaDigoId)
            .HasConstraintName("FK_CharlaDigoLinks_CharlaDigos");
    });
            #endregion

            #region CharlaDigos
            modelBuilder.Entity<CharlaDigos>(entity =>
    {
        entity.Property(e => e.Digo)
            .IsRequired()
            .IsUnicode(false);

        entity.Property(e => e.FechaDigo).HasColumnType("datetime");

        entity.HasOne(d => d.CharlaDigoDeDigo)
            .WithMany(p => p.InverseCharlaDigoDeDigo)
            .HasForeignKey(d => d.CharlaDigoDeDigoId)
            .HasConstraintName("FK_CharlaDigos_CharlaDigos");

        entity.HasOne(d => d.Charla)
            .WithMany(p => p.CharlaDigos)
            .HasForeignKey(d => d.CharlaId)
            .OnDelete(DeleteBehavior.Restrict)
            .HasConstraintName("FK_CharlaDigos_Charlas");

        entity.HasOne(d => d.CharlaPersona)
            .WithMany(p => p.CharlaDigos)
            .HasForeignKey(d => d.CharlaPersonaId)
            .OnDelete(DeleteBehavior.Restrict)
            .HasConstraintName("FK_CharlaDigos_CharlaPersonas");
    });
            #endregion

            #region CharlaLeeDigos
            modelBuilder.Entity<CharlaLeeDigos>(entity =>
    {
        entity.Property(e => e.FechaLeo).HasColumnType("datetime");

        entity.Property(e => e.FechaNotifico).HasColumnType("datetime");

        entity.Property(e => e.FechaRecibe).HasColumnType("datetime");

        entity.HasOne(d => d.CharlaDigo)
            .WithMany(p => p.CharlaLeeDigos)
            .HasForeignKey(d => d.CharlaDigoId)
            .HasConstraintName("FK_CharlaLeeDigos_CharlaDigos");

        entity.HasOne(d => d.CharlaPersona)
            .WithMany(p => p.CharlaLeeDigos)
            .HasForeignKey(d => d.CharlaPersonaId)
            .OnDelete(DeleteBehavior.Restrict)
            .HasConstraintName("FK_CharlaLeeDigos_CharlaPersonas");
    });
            #endregion

            #region CharlaPersonas
            modelBuilder.Entity<CharlaPersonas>(entity =>
    {
        entity.HasOne(d => d.Charla)
            .WithMany(p => p.CharlaPersonas)
            .HasForeignKey(d => d.CharlaId)
            .OnDelete(DeleteBehavior.Restrict)
            .HasConstraintName("FK_CharlaPersonas_Charlas");

        entity.HasOne(d => d.Persona)
            .WithMany(p => p.CharlaPersonas)
            .HasForeignKey(d => d.PersonaId)
            .OnDelete(DeleteBehavior.Restrict)
            .HasConstraintName("FK_CharlaPersonas_Personas");
    });
            #endregion

            #region Charlas
            modelBuilder.Entity<Charlas>(entity =>
            {
                entity.HasIndex(e => e.CodigoCharla)
                .HasName("IQ_Charlas")
                .IsUnique();

                entity.Property(e => e.CodigoCharla)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion).IsUnicode(false);

                entity.Property(e => e.FechaFin).HasColumnType("datetime");

                entity.Property(e => e.FechaInicio).HasColumnType("datetime");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.PathLogo)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.TcharlaId).HasColumnName("TCharlaId");

                entity.HasOne(d => d.Tcharla)
                    .WithMany(p => p.Charlas)
                    .HasForeignKey(d => d.TcharlaId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Charlas_TCharlas");
            });
            #endregion
            #endregion

            #region DOMICILIO
            #region Ciudades
            modelBuilder.Entity<Ciudades>(entity =>
            {
                entity.HasOne(d => d.Provincia)
                    .WithMany(p => p.Ciudades)
                    .HasForeignKey(d => d.ProvinciaId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Ciudades_Provincias");

                entity.HasIndex(e => e.NombreCiudad)
                    .HasName("IQ_NombreCiudad")
                    .IsUnique();
            });
            #endregion

            #region Domicilios
            modelBuilder.Entity<Domicilios>(entity =>
    {
        entity.Property(e => e.Barrio)
            .IsRequired()
            .HasMaxLength(100)
            .IsUnicode(false);

        entity.Property(e => e.Calle)
            .IsRequired()
            .HasMaxLength(200)
            .IsUnicode(false);

        entity.Property(e => e.Cp)
            .IsRequired()
            .HasColumnName("CP")
            .HasMaxLength(15)
            .IsUnicode(false);

        entity.Property(e => e.Dpto)
            .IsRequired()
            .HasMaxLength(2)
            .IsUnicode(false);

        entity.Property(e => e.Numero)
            .IsRequired()
            .HasMaxLength(4)
            .IsUnicode(false);

        entity.Property(e => e.Piso)
            .IsRequired()
            .HasMaxLength(2)
            .IsUnicode(false);

        entity.Property(e => e.TdomicilioId).HasColumnName("TDomicilioId");

        entity.HasOne(d => d.Tdomicilio)
            .WithMany(p => p.Domicilios)
            .HasForeignKey(d => d.TdomicilioId)
            .OnDelete(DeleteBehavior.Restrict)
            .HasConstraintName("FK_Domicilios_TDomicilios");

        entity.Property(e => e.CiudadId).HasColumnName("CiudadId");

        entity.HasOne(d => d.Ciudad)
            .WithMany(p => p.Domicilios)
            .HasForeignKey(d => d.CiudadId)
            .OnDelete(DeleteBehavior.Restrict)
            .HasConstraintName("FK_Domicilios_Ciudades");
    });
            #endregion

            #region Mails
            modelBuilder.Entity<Mails>(entity =>
            {
                entity.Property(e => e.Mail)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.TmailId).HasColumnName("TMailId");

                entity.HasOne(d => d.Tmail)
                    .WithMany(p => p.Mails)
                    .HasForeignKey(d => d.TmailId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Mails_TMails");
            });
            #endregion

            #region Provincias
            modelBuilder.Entity<Provincias>(entity =>
            {
                entity.HasOne(d => d.Pais)
                    .WithMany(p => p.Provincias)
                    .HasForeignKey(d => d.PaisId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Provincias_Paises");

                entity.HasIndex(e => e.NombreProvincia)
                    .HasName("IQ_NombreProvincia")
                    .IsUnique();
            });
            #endregion

            #region Paises
            modelBuilder.Entity<Paises>(entity =>
            {
                entity.HasIndex(e => e.NombrePais)
                    .HasName("IQ_NombrePais")
                    .IsUnique();
            });
            #endregion

            #region Tels
            modelBuilder.Entity<Tels>(entity =>
            {
                entity.Property(e => e.Tel)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.TtelId).HasColumnName("TTelId");

                entity.HasOne(d => d.Ttel)
                    .WithMany(p => p.Tels)
                    .HasForeignKey(d => d.TtelId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Tels_TTels");
            });
            #endregion
            #endregion

            #region INSTITUCIONES
            #region InstitucionDocumentos
            modelBuilder.Entity<InstitucionDocumentos>(entity =>
    {
        entity.HasOne(d => d.Documento)
            .WithMany(p => p.InstitucionDocumentos)
            .HasForeignKey(d => d.DocumentoId)
            .OnDelete(DeleteBehavior.Restrict)
            .HasConstraintName("FK_InstitucionDocumentos_Documentos");

        entity.HasOne(d => d.Institucion)
            .WithMany(p => p.InstitucionDocumentos)
            .HasForeignKey(d => d.InstitucionId)
            .OnDelete(DeleteBehavior.Restrict)
            .HasConstraintName("FK_InstitucionDocumentos_Instituciones");
    });
            #endregion

            #region InstitucionDomicilios
            modelBuilder.Entity<InstitucionDomicilios>(entity =>
    {
        entity.HasOne(d => d.Domicilio)
            .WithMany(p => p.InstitucionDomicilios)
            .HasForeignKey(d => d.DomicilioId)
            .OnDelete(DeleteBehavior.Restrict)
            .HasConstraintName("FK_InstitucionDomicilios_Domicilios");

        entity.HasOne(d => d.Institucion)
            .WithMany(p => p.InstitucionDomicilios)
            .HasForeignKey(d => d.InstitucionId)
            .OnDelete(DeleteBehavior.Restrict)
            .HasConstraintName("FK_InstitucionDomicilios_Instituciones");
    });
            #endregion

            #region InstitucionMails
            modelBuilder.Entity<InstitucionMails>(entity =>
    {
        entity.HasOne(d => d.Institucion)
            .WithMany(p => p.InstitucionMails)
            .HasForeignKey(d => d.InstitucionId)
            .OnDelete(DeleteBehavior.Restrict)
            .HasConstraintName("FK_InstitucionMails_Instituciones");

        entity.HasOne(d => d.Mail)
            .WithMany(p => p.InstitucionMails)
            .HasForeignKey(d => d.MailId)
            .OnDelete(DeleteBehavior.Restrict)
            .HasConstraintName("FK_InstitucionMails_Mails");
    });
            #endregion

            #region InstitucionTels
            modelBuilder.Entity<InstitucionTels>(entity =>
    {
        entity.HasOne(d => d.Institucion)
            .WithMany(p => p.InstitucionTels)
            .HasForeignKey(d => d.InstitucionId)
            .OnDelete(DeleteBehavior.Restrict)
            .HasConstraintName("FK_InstitucionTels_Instituciones");

        entity.HasOne(d => d.Tel)
            .WithMany(p => p.InstitucionTels)
            .HasForeignKey(d => d.TelId)
            .OnDelete(DeleteBehavior.Restrict)
            .HasConstraintName("FK_InstitucionTels_Tels");
    });
            #endregion

            #region Instituciones
            modelBuilder.Entity<Instituciones>(entity =>
            {
                entity.HasIndex(e => e.CodigoInstitucion)
                .HasName("IQ_Instituciones")
                .IsUnique();

                entity.Property(e => e.CodigoInstitucion)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.TnotaId).HasColumnName("TNotaId");

                entity.HasOne(d => d.Tnota)
                    .WithMany(p => p.Instituciones)
                    .HasForeignKey(d => d.TnotaId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Instituciones_TNotas");
            });
            #endregion
            #endregion

            #region Documentos
            modelBuilder.Entity<Documentos>(entity =>
            {
                entity.Property(e => e.Documento)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TdocumentoId).HasColumnName("TDocumentoId");

                entity.HasOne(d => d.Tdocumento)
                    .WithMany(p => p.Documentos)
                    .HasForeignKey(d => d.TdocumentoId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Documentos_TDocumentos");
            });
            #endregion

            #region PERSONAS
            #region PersonaDocumentos
            modelBuilder.Entity<PersonaDocumentos>(entity =>
    {
        entity.HasOne(d => d.Documento)
            .WithMany(p => p.PersonaDocumentos)
            .HasForeignKey(d => d.DocumentoId)
            .OnDelete(DeleteBehavior.Restrict)
            .HasConstraintName("FK_PersonaDocumentos_Documentos");

        entity.HasOne(d => d.Persona)
            .WithMany(p => p.PersonaDocumentos)
            .HasForeignKey(d => d.PersonaId)
            .OnDelete(DeleteBehavior.Restrict)
            .HasConstraintName("FK_PersonaDocumentos_Personas");
    });
            #endregion

            #region PersonaDomicilios
            modelBuilder.Entity<PersonaDomicilios>(entity =>
    {
        entity.HasOne(d => d.Domicilio)
            .WithMany(p => p.PersonaDomicilios)
            .HasForeignKey(d => d.DomicilioId)
            .OnDelete(DeleteBehavior.Restrict)
            .HasConstraintName("FK_PersonaDomicilios_Domicilios");

        entity.HasOne(d => d.Persona)
            .WithMany(p => p.PersonaDomicilios)
            .HasForeignKey(d => d.PersonaId)
            .OnDelete(DeleteBehavior.Restrict)
            .HasConstraintName("FK_PersonaDomicilios_Personas");
    });
            #endregion

            #region PersonaMails
            modelBuilder.Entity<PersonaMails>(entity =>
    {
        entity.HasOne(d => d.Mail)
            .WithMany(p => p.PersonaMails)
            .HasForeignKey(d => d.MailId)
            .OnDelete(DeleteBehavior.Restrict)
            .HasConstraintName("FK_PersonaMails_Mails");

        entity.HasOne(d => d.Persona)
            .WithMany(p => p.PersonaMails)
            .HasForeignKey(d => d.PersonaId)
            .OnDelete(DeleteBehavior.Restrict)
            .HasConstraintName("FK_PersonaMails_Personas");
    });
            #endregion

            #region PersonaTels
            modelBuilder.Entity<PersonaTels>(entity =>
    {
        entity.HasOne(d => d.Persona)
            .WithMany(p => p.PersonaTels)
            .HasForeignKey(d => d.PersonaId)
            .OnDelete(DeleteBehavior.Restrict)
            .HasConstraintName("FK_PersonaTels_Personas");

        entity.HasOne(d => d.Tel)
            .WithMany(p => p.PersonaTels)
            .HasForeignKey(d => d.TelId)
            .OnDelete(DeleteBehavior.Restrict)
            .HasConstraintName("FK_PersonaTels_Tels");
    });
            #endregion

            #region Personas
            modelBuilder.Entity<Personas>(entity =>
    {
        entity.Property(e => e.Apellido)
            .IsRequired()
            .HasMaxLength(200)
            .IsUnicode(false);

        entity.Property(e => e.Nombre)
            .IsRequired()
            .HasMaxLength(200)
            .IsUnicode(false);
    });
            #endregion
            #endregion

            #region TABLAS TIPOS
            #region Tcharlas
            modelBuilder.Entity<Tcharlas>(entity =>
            {
                entity.HasIndex(e => e.Codigo)
                .HasName("IQ_Tcharlas")
                .IsUnique();

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });
            #endregion

            #region Tdocumentos
            modelBuilder.Entity<Tdocumentos>(entity =>
            {
                entity.HasIndex(e => e.Codigo)
                    .HasName("IX_TDocumentos")
                    .IsUnique();

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .IsUnicode(false);
            });
            #endregion

            #region Tdomicilios
            modelBuilder.Entity<Tdomicilios>(entity =>
            {
                entity.HasIndex(e => e.Codigo)
                    .HasName("IX_TDomicilio")
                    .IsUnique();

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });
            #endregion

            #region Tmails
            modelBuilder.Entity<Tmails>(entity =>
            {
                entity.HasIndex(e => e.Codigo)
                    .HasName("IQ_TMails")
                    .IsUnique();

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });
            #endregion

            #region Tnotas
            modelBuilder.Entity<Tnotas>(entity =>
            {
                entity.HasIndex(e => e.Codigo)
                .HasName("IQ_Tnotas")
                .IsUnique();

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ValorMax)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ValorMin)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);
            });
            #endregion

            #region Ttels
            modelBuilder.Entity<Ttels>(entity =>
            {
                entity.HasIndex(e => e.Codigo)
                .HasName("IQ_Ttels")
                .IsUnique();

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });
            #endregion
            #endregion

            var cascadeFKs = modelBuilder.Model
                            .G­etEntityTypes()
                            .SelectMany(t => t.GetForeignKeys())
                            .Where(fk => !fk.IsOwnership 
                                         && (fk.DeleteBehavior == DeleteBehavior.Casca­de
                                         || fk.DeleteBehavior == DeleteBehavior.SetNull
                                         || fk.DeleteBehavior == DeleteBehavior.SetNull));
            foreach (var fk in cascadeFKs)
            {
                fk.DeleteBehavior = DeleteBehavior.Restr­ict;
            }

            base.OnModelCreating(modelBuilder);

			//OnModelCreatingExtension.Seed(modelBuilder); //uses the extension class to seed the db
        }
        #endregion
    }
}
