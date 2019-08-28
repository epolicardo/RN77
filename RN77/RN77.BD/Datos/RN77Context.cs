namespace RN77.BD.Datos
{
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using RN77.BD.Datos.Entities;

    public partial class RN77Context : IdentityDbContext<Usuarios>
    {
        private readonly IConfiguration configuration;

        //
        // Scaffold-DbContext "Server=DESKTOP-US7V3RT;Database=RN77;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Datos/Entities
        //

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

        public RN77Context()
        {
        }

        public RN77Context(DbContextOptions<RN77Context> options, IConfiguration configuration) : base(options)
        {
            this.configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<AulaAlumnos>(entity =>
            {
                entity.HasOne(d => d.Aula)
                    .WithMany(p => p.AulaAlumnos)
                    .HasForeignKey(d => d.AulaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AulaAlumnos_Aulas");

                entity.HasOne(d => d.Persona)
                    .WithMany(p => p.AulaAlumnos)
                    .HasForeignKey(d => d.PersonaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AulaAlumnos_Personas");
            });

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
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AulaAsistencias_AulaAlumnos");

                entity.HasOne(d => d.AulaTemaClase)
                    .WithMany(p => p.AulaAsistencias)
                    .HasForeignKey(d => d.AulaTemaClaseId)
                    .HasConstraintName("FK_AulaAsistencias_AulaTemaClases");
            });

            modelBuilder.Entity<AulaDocentes>(entity =>
            {
                entity.HasOne(d => d.Aula)
                    .WithMany(p => p.AulaDocentes)
                    .HasForeignKey(d => d.AulaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AulaDocentes_Aulas");

                entity.HasOne(d => d.Persona)
                    .WithMany(p => p.AulaDocentes)
                    .HasForeignKey(d => d.PersonaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AulaDocentes_Personas");
            });

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
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AulaEvaluaciones_Aulas");
            });

            modelBuilder.Entity<AulaGrupoAlumnos>(entity =>
            {
                entity.HasOne(d => d.AulaAlumno)
                    .WithMany(p => p.AulaGrupoAlumnos)
                    .HasForeignKey(d => d.AulaAlumnoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AulaGrupoAlumnos_AulaAlumnos");

                entity.HasOne(d => d.AulaGrupo)
                    .WithMany(p => p.AulaGrupoAlumnos)
                    .HasForeignKey(d => d.AulaGrupoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AulaGrupoAlumnos_AulaGrupos");
            });

            modelBuilder.Entity<AulaGrupos>(entity =>
            {
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
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AulaGrupos_Aulas");

                entity.HasOne(d => d.Charla)
                    .WithMany(p => p.AulaGrupos)
                    .HasForeignKey(d => d.CharlaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AulaGrupos_Charlas");
            });

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
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AulaNotas_AulaAlumnos");

                entity.HasOne(d => d.AulaEvaluacion)
                    .WithMany(p => p.AulaNotas)
                    .HasForeignKey(d => d.AulaEvaluacionId)
                    .HasConstraintName("FK_AulaNotas_AulaEvaluaciones");
            });

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
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AulaTemaClases_Aulas");
            });

            modelBuilder.Entity<Aulas>(entity =>
            {
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
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Aulas_Charlas");
            });

            modelBuilder.Entity<CarreraMaterias>(entity =>
            {
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
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CarreraMaterias_Carreras");

                entity.HasOne(d => d.CarreraMateria)
                    .WithMany(p => p.CarreraMaterias)
                    .HasForeignKey(d => d.CarreraMateriaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CarreraMaterias_Materias");
            });

            modelBuilder.Entity<Carreras>(entity =>
            {
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
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Carreras_Instituciones");
            });

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
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CharlaDigos_Charlas");

                entity.HasOne(d => d.CharlaPersona)
                    .WithMany(p => p.CharlaDigos)
                    .HasForeignKey(d => d.CharlaPersonaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CharlaDigos_CharlaPersonas");
            });

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
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CharlaLeeDigos_CharlaPersonas");
            });

            modelBuilder.Entity<CharlaPersonas>(entity =>
            {
                entity.HasOne(d => d.Charla)
                    .WithMany(p => p.CharlaPersonas)
                    .HasForeignKey(d => d.CharlaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CharlaPersonas_Charlas");

                entity.HasOne(d => d.Persona)
                    .WithMany(p => p.CharlaPersonas)
                    .HasForeignKey(d => d.PersonaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CharlaPersonas_Personas");
            });

            modelBuilder.Entity<Charlas>(entity =>
            {
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
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Charlas_TCharlas");
            });

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
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Documentos_TDocumentos");
            });

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
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Domicilios_TDomicilios");
            });

            modelBuilder.Entity<InstitucionDocumentos>(entity =>
            {
                entity.HasOne(d => d.Documento)
                    .WithMany(p => p.InstitucionDocumentos)
                    .HasForeignKey(d => d.DocumentoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InstitucionDocumentos_Documentos");

                entity.HasOne(d => d.Institucion)
                    .WithMany(p => p.InstitucionDocumentos)
                    .HasForeignKey(d => d.InstitucionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InstitucionDocumentos_Instituciones");
            });

            modelBuilder.Entity<InstitucionDomicilios>(entity =>
            {
                entity.HasOne(d => d.Domicilio)
                    .WithMany(p => p.InstitucionDomicilios)
                    .HasForeignKey(d => d.DomicilioId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InstitucionDomicilios_Domicilios");

                entity.HasOne(d => d.Institucion)
                    .WithMany(p => p.InstitucionDomicilios)
                    .HasForeignKey(d => d.InstitucionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InstitucionDomicilios_Instituciones");
            });

            modelBuilder.Entity<InstitucionMails>(entity =>
            {
                entity.HasOne(d => d.Institucion)
                    .WithMany(p => p.InstitucionMails)
                    .HasForeignKey(d => d.InstitucionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InstitucionMails_Instituciones");

                entity.HasOne(d => d.Mail)
                    .WithMany(p => p.InstitucionMails)
                    .HasForeignKey(d => d.MailId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InstitucionMails_Mails");
            });

            modelBuilder.Entity<InstitucionTels>(entity =>
            {
                entity.HasOne(d => d.Institucion)
                    .WithMany(p => p.InstitucionTels)
                    .HasForeignKey(d => d.InstitucionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InstitucionTels_Instituciones");

                entity.HasOne(d => d.Tel)
                    .WithMany(p => p.InstitucionTels)
                    .HasForeignKey(d => d.TelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InstitucionTels_Tels");
            });

            modelBuilder.Entity<Instituciones>(entity =>
            {
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
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Instituciones_TNotas");
            });

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
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Mails_TMails");
            });

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

            modelBuilder.Entity<PersonaDocumentos>(entity =>
            {
                entity.HasOne(d => d.Documento)
                    .WithMany(p => p.PersonaDocumentos)
                    .HasForeignKey(d => d.DocumentoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PersonaDocumentos_Documentos");

                entity.HasOne(d => d.Persona)
                    .WithMany(p => p.PersonaDocumentos)
                    .HasForeignKey(d => d.PersonaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PersonaDocumentos_Personas");
            });

            modelBuilder.Entity<PersonaDomicilios>(entity =>
            {
                entity.HasOne(d => d.Domicilio)
                    .WithMany(p => p.PersonaDomicilios)
                    .HasForeignKey(d => d.DomicilioId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PersonaDomicilios_Domicilios");

                entity.HasOne(d => d.Persona)
                    .WithMany(p => p.PersonaDomicilios)
                    .HasForeignKey(d => d.PersonaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PersonaDomicilios_Personas");
            });

            modelBuilder.Entity<PersonaMails>(entity =>
            {
                entity.HasOne(d => d.Mail)
                    .WithMany(p => p.PersonaMails)
                    .HasForeignKey(d => d.MailId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PersonaMails_Mails");

                entity.HasOne(d => d.Persona)
                    .WithMany(p => p.PersonaMails)
                    .HasForeignKey(d => d.PersonaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PersonaMails_Personas");
            });

            modelBuilder.Entity<PersonaTels>(entity =>
            {
                entity.HasOne(d => d.Persona)
                    .WithMany(p => p.PersonaTels)
                    .HasForeignKey(d => d.PersonaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PersonaTels_Personas");

                entity.HasOne(d => d.Tel)
                    .WithMany(p => p.PersonaTels)
                    .HasForeignKey(d => d.TelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PersonaTels_Tels");
            });

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

            modelBuilder.Entity<Tcharlas>(entity =>
            {
                entity.ToTable("TCharlas");

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

            modelBuilder.Entity<Tdocumentos>(entity =>
            {
                entity.ToTable("TDocumentos");

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

            modelBuilder.Entity<Tdomicilios>(entity =>
            {
                entity.ToTable("TDomicilios");

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
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tels_TTels");
            });

            modelBuilder.Entity<Tmails>(entity =>
            {
                entity.ToTable("TMails");

                entity.HasIndex(e => e.Codigo)
                    .HasName("IX_TMails")
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

            modelBuilder.Entity<Tnotas>(entity =>
            {
                entity.ToTable("TNotas");

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

            modelBuilder.Entity<Ttels>(entity =>
            {
                entity.ToTable("TTels");

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            base.OnModelCreating(modelBuilder);

        }
    }
}
