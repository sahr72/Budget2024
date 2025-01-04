using System;
using System.Collections.Generic;
using Budget2024.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Budget2024.Infrastructure.ModelEntity;

public partial class AppDbContext : DbContext
{
    public AppDbContext()
    {
    }

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Article> Articles { get; set; }

    public virtual DbSet<Bonification> Bonifications { get; set; }

    public virtual DbSet<Budget2024.Infrastructure.Data.Budget> Budgets { get; set; }

    public virtual DbSet<Chapitre> Chapitres { get; set; }

    public virtual DbSet<Corps> Corps { get; set; }

    public virtual DbSet<Corps1> Corps1s { get; set; }

    public virtual DbSet<CorpsPrincipal> CorpsPrincipals { get; set; }

    public virtual DbSet<Exercice> Exercices { get; set; }

    public virtual DbSet<Filiere> Filieres { get; set; }

    public virtual DbSet<FoncSup> FoncSups { get; set; }

    public virtual DbSet<Grade> Grades { get; set; }

    public virtual DbSet<GrilleIep> GrilleIeps { get; set; }

    public virtual DbSet<GrilleIep1> GrilleIep1s { get; set; }

    public virtual DbSet<GrilleSb> GrilleSbs { get; set; }

    public virtual DbSet<Indemnite> Indemnites { get; set; }

    public virtual DbSet<LigneCorpsInd> LigneCorpsInds { get; set; }

    public virtual DbSet<LigneIndFil> LigneIndFils { get; set; }

    public virtual DbSet<LigneIndGrade> LigneIndGrades { get; set; }

    public virtual DbSet<LigneIndSb> LigneIndSbs { get; set; }

    public virtual DbSet<LigneMatChap> LigneMatChaps { get; set; }

    public virtual DbSet<LigneMatCorpsInd> LigneMatCorpsInds { get; set; }

    public virtual DbSet<LigneMatCorpsRet> LigneMatCorpsRets { get; set; }

    public virtual DbSet<LigneMatInd> LigneMatInds { get; set; }

    public virtual DbSet<LigneMatIndPeriode> LigneMatIndPeriodes { get; set; }

    public virtual DbSet<Moi> Mois { get; set; }

    public virtual DbSet<Periode> Periodes { get; set; }

    public virtual DbSet<PeriodeEngMat> PeriodeEngMats { get; set; }

    public virtual DbSet<PosteSup> PosteSups { get; set; }

    public virtual DbSet<TypeMatrix> TypeMatrices { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=ASRINP3022-BSI\\SQL_LOCAL23;Database=Budget2024;Integrated Security=true;MultipleActiveResultSets=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Article>(entity =>
        {
            entity.ToTable("Articles", "budget");

            entity.Property(e => e.ArticleId).HasColumnName("ArticleID");
            entity.Property(e => e.Article1)
                .HasMaxLength(50)
                .HasColumnName("Article");
            entity.Property(e => e.ChapitreId).HasColumnName("ChapitreID");
            entity.Property(e => e.CodeArt).HasMaxLength(6);
            entity.Property(e => e.EngIni).HasColumnType("money");
            entity.Property(e => e.Rattachement).HasColumnType("money");
            entity.Property(e => e.Reste).HasColumnType("money");

            entity.HasOne(d => d.Chapitre).WithMany(p => p.Articles)
                .HasForeignKey(d => d.ChapitreId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Articles_Chapitres");
        });

        modelBuilder.Entity<Bonification>(entity =>
        {
            entity.ToTable("Bonifications", "grille");

            entity.Property(e => e.BonificationId)
                .ValueGeneratedNever()
                .HasColumnName("BonificationID");
            entity.Property(e => e.Bon)
                .HasColumnType("money")
                .HasColumnName("BON");
            entity.Property(e => e.Indice).HasColumnName("INDICE");
        });

        modelBuilder.Entity<Budget2024.Infrastructure.Data.Budget>(entity =>
        {
            entity.ToTable("Budgets", "budget");

            entity.Property(e => e.BudgetId).HasColumnName("BudgetID");
            entity.Property(e => e.Budget1)
                .HasMaxLength(100)
                .HasColumnName("Budget");
            entity.Property(e => e.Code)
                .HasMaxLength(10)
                .HasColumnName("CODE");
            entity.Property(e => e.Obs).HasMaxLength(100);
        });

        modelBuilder.Entity<Chapitre>(entity =>
        {
            entity.ToTable("Chapitres", "budget");

            entity.Property(e => e.ChapitreId).HasColumnName("ChapitreID");
            entity.Property(e => e.BudgetId).HasColumnName("BudgetID");
            entity.Property(e => e.Chapitre1)
                .HasMaxLength(50)
                .HasColumnName("Chapitre");
            entity.Property(e => e.CodeChap).HasMaxLength(12);

            entity.HasOne(d => d.Budget).WithMany(p => p.Chapitres)
                .HasForeignKey(d => d.BudgetId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Chapitres_Budgets");
        });

        modelBuilder.Entity<Corps>(entity =>
        {
            entity.HasKey(e => e.CleCorps);

            entity.ToTable("Corps", "statutPartic");

            entity.Property(e => e.CodeCorps).HasMaxLength(5);
            entity.Property(e => e.Corps1)
                .HasMaxLength(50)
                .HasColumnName("Corps");
        });

        modelBuilder.Entity<Corps1>(entity =>
        {
            entity.ToTable("Corps1s", "statutPartic");

            entity.Property(e => e.Corps1Id).HasColumnName("Corps1ID");
            entity.Property(e => e.Description).HasMaxLength(50);
            entity.Property(e => e.FiliereId).HasColumnName("FiliereID");

            entity.HasOne(d => d.Filiere).WithMany(p => p.Corps1s)
                .HasForeignKey(d => d.FiliereId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Corps1s_Filieres");
        });

        modelBuilder.Entity<CorpsPrincipal>(entity =>
        {
            entity.ToTable("CorpsPrincipals", "statutPartic");

            entity.Property(e => e.CorpsPrincipalId).HasColumnName("CorpsPrincipalID");
            entity.Property(e => e.Description).HasMaxLength(50);
        });

        modelBuilder.Entity<Exercice>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Exercice", "Reference");

            entity.Property(e => e.Exe)
                .HasMaxLength(4)
                .HasColumnName("EXE");
        });

        modelBuilder.Entity<Filiere>(entity =>
        {
            entity.ToTable("Filieres", "statutPartic");

            entity.Property(e => e.FiliereId).HasColumnName("FiliereID");
            entity.Property(e => e.CorpsPincipalId).HasColumnName("CorpsPincipalID");
            entity.Property(e => e.Filiere1)
                .HasMaxLength(50)
                .HasColumnName("Filiere");

            entity.HasOne(d => d.CorpsPincipal).WithMany(p => p.Filieres)
                .HasForeignKey(d => d.CorpsPincipalId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Filieres_CorpsPrincipals");
        });

        modelBuilder.Entity<FoncSup>(entity =>
        {
            entity.ToTable("FoncSups", "statutPartic");

            entity.Property(e => e.FoncSupId).HasColumnName("FoncSupID");
            entity.Property(e => e.CodeGrad).HasMaxLength(4);
            entity.Property(e => e.FoncSup1)
                .HasMaxLength(50)
                .HasColumnName("FoncSup");

            entity.HasOne(d => d.CodeGradNavigation).WithMany(p => p.FoncSups)
                .HasForeignKey(d => d.CodeGrad)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FoncSups_GrilleSBs");
        });

        modelBuilder.Entity<Grade>(entity =>
        {
            entity.ToTable("Grades", "statutPartic");

            entity.Property(e => e.GradeId).HasColumnName("GradeID");
            entity.Property(e => e.Cat).HasMaxLength(3);
            entity.Property(e => e.Cat311207).HasMaxLength(50);
            entity.Property(e => e.CodeGrad).HasMaxLength(4);
            entity.Property(e => e.Corps1Id).HasColumnName("Corps1ID");
            entity.Property(e => e.Grade1)
                .HasMaxLength(50)
                .HasColumnName("Grade");
            entity.Property(e => e.IndiceMin311207).HasMaxLength(50);
            entity.Property(e => e.Sec).HasMaxLength(50);
            entity.Property(e => e.Sec311207).HasMaxLength(50);

            entity.HasOne(d => d.CodeGradNavigation).WithMany(p => p.Grades)
                .HasForeignKey(d => d.CodeGrad)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Grades_GrilleSBs");

            entity.HasOne(d => d.Corps1).WithMany(p => p.Grades)
                .HasForeignKey(d => d.Corps1Id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Grades_Corps1s");

            entity.HasMany(d => d.TypeMatrices).WithMany(p => p.Grades)
                .UsingEntity<Dictionary<string, object>>(
                    "LigneGradeMat",
                    r => r.HasOne<TypeMatrix>().WithMany()
                        .HasForeignKey("TypeMatriceId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_LigneGradeMat_TypeMatrices"),
                    l => l.HasOne<Grade>().WithMany()
                        .HasForeignKey("GradeId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_LigneGradeMat_Grades"),
                    j =>
                    {
                        j.HasKey("GradeId", "TypeMatriceId");
                        j.ToTable("LigneGradeMat", "parametre");
                        j.IndexerProperty<int>("GradeId").HasColumnName("GradeID");
                        j.IndexerProperty<int>("TypeMatriceId").HasColumnName("TypeMatriceID");
                    });
        });

        modelBuilder.Entity<GrilleIep>(entity =>
        {
            entity.HasKey(e => new { e.Codegrad, e.Echelon });

            entity.ToTable("GrilleIEPs", "grille");

            entity.Property(e => e.Codegrad)
                .HasMaxLength(4)
                .HasColumnName("CODEGRAD");
            entity.Property(e => e.Echelon)
                .HasMaxLength(2)
                .HasColumnName("ECHELON");
            entity.Property(e => e.Iep)
                .HasColumnType("money")
                .HasColumnName("IEP");
            entity.Property(e => e.Iepp)
                .HasColumnType("money")
                .HasColumnName("IEPP");
            entity.Property(e => e.Note).HasColumnName("NOTE");

            entity.HasOne(d => d.CodegradNavigation).WithMany(p => p.GrilleIeps)
                .HasForeignKey(d => d.Codegrad)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GrilleIEPs_GrilleSBs");
        });

        modelBuilder.Entity<GrilleIep1>(entity =>
        {
            entity.HasKey(e => new { e.Codegrad, e.Echelon });

            entity.ToTable("GrilleIEP1s", "grille");

            entity.Property(e => e.Codegrad)
                .HasMaxLength(4)
                .HasColumnName("CODEGRAD");
            entity.Property(e => e.Echelon)
                .HasMaxLength(2)
                .HasColumnName("ECHELON");
            entity.Property(e => e.Iep)
                .HasColumnType("money")
                .HasColumnName("IEP");
            entity.Property(e => e.Iepp)
                .HasColumnType("money")
                .HasColumnName("IEPP");
            entity.Property(e => e.Note).HasColumnName("NOTE");
        });

        modelBuilder.Entity<GrilleSb>(entity =>
        {
            entity.HasKey(e => e.Codegrad);

            entity.ToTable("GrilleSBs", "grille");

            entity.Property(e => e.Codegrad)
                .HasMaxLength(4)
                .HasColumnName("CODEGRAD");
            entity.Property(e => e.Cat)
                .HasMaxLength(2)
                .HasColumnName("CAT");
            entity.Property(e => e.Icr)
                .HasColumnType("money")
                .HasColumnName("ICR");
            entity.Property(e => e.Indice).HasColumnName("INDICE");
            entity.Property(e => e.Sb)
                .HasColumnType("money")
                .HasColumnName("SB");
            entity.Property(e => e.Sec)
                .HasMaxLength(1)
                .HasColumnName("SEC");
        });

        modelBuilder.Entity<Indemnite>(entity =>
        {
            entity.ToTable("Indemnites", "budget");

            entity.Property(e => e.IndemniteId).HasColumnName("IndemniteID");
            entity.Property(e => e.ArticleId).HasColumnName("ArticleID");
            entity.Property(e => e.Beneficiaire).HasMaxLength(2);
            entity.Property(e => e.Cal)
                .HasMaxLength(6)
                .HasColumnName("CAL");
            entity.Property(e => e.Coim)
                .HasMaxLength(4)
                .HasColumnName("COIM");
            entity.Property(e => e.Ind)
                .HasMaxLength(60)
                .HasColumnName("IND");
            entity.Property(e => e.Mt).HasColumnType("money");
            entity.Property(e => e.Mvt).HasColumnName("MVT");
            entity.Property(e => e.Ordre).HasColumnName("ORDRE");
            entity.Property(e => e.Sig)
                .HasMaxLength(20)
                .HasColumnName("SIG");
            entity.Property(e => e.Taux)
                .HasColumnType("money")
                .HasColumnName("TAUX");
            entity.Property(e => e.Typ)
                .HasMaxLength(1)
                .HasColumnName("TYP");

            entity.HasOne(d => d.Article).WithMany(p => p.Indemnites)
                .HasForeignKey(d => d.ArticleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Indemnites_Articles");
        });

        modelBuilder.Entity<LigneCorpsInd>(entity =>
        {
            entity.HasKey(e => new { e.IndemniteId, e.Corps1Id, e.NatJurRelTrav });

            entity.ToTable("LigneCorpsInd", "parametre");

            entity.Property(e => e.IndemniteId).HasColumnName("IndemniteID");
            entity.Property(e => e.Corps1Id).HasColumnName("Corps1ID");
            entity.Property(e => e.NatJurRelTrav).HasMaxLength(3);

            entity.HasOne(d => d.Corps1).WithMany(p => p.LigneCorpsInds)
                .HasForeignKey(d => d.Corps1Id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LigneCorpsInd_Corps1s");

            entity.HasOne(d => d.Indemnite).WithMany(p => p.LigneCorpsInds)
                .HasForeignKey(d => d.IndemniteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LigneCorpsInd_Indemnites");
        });

        modelBuilder.Entity<LigneIndFil>(entity =>
        {
            entity.HasKey(e => new { e.IndemniteId, e.FiliereId, e.NatJurRelTrav });

            entity.ToTable("LigneIndFil", "parametre");

            entity.Property(e => e.IndemniteId).HasColumnName("IndemniteID");
            entity.Property(e => e.FiliereId).HasColumnName("FiliereID");
            entity.Property(e => e.NatJurRelTrav).HasMaxLength(3);

            entity.HasOne(d => d.Filiere).WithMany(p => p.LigneIndFils)
                .HasForeignKey(d => d.FiliereId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LigneIndFil_Filieres");

            entity.HasOne(d => d.Indemnite).WithMany(p => p.LigneIndFils)
                .HasForeignKey(d => d.IndemniteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LigneIndFil_Indemnites");
        });

        modelBuilder.Entity<LigneIndGrade>(entity =>
        {
            entity.HasKey(e => new { e.IndemniteId, e.GradeId, e.NatJurRelTrav });

            entity.ToTable("LigneIndGrade", "parametre");

            entity.Property(e => e.IndemniteId).HasColumnName("IndemniteID");
            entity.Property(e => e.GradeId).HasColumnName("GradeID");
            entity.Property(e => e.NatJurRelTrav).HasMaxLength(3);

            entity.HasOne(d => d.Indemnite).WithMany(p => p.LigneIndGrades)
                .HasForeignKey(d => d.IndemniteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LigneIndGrade_Indemnites");
        });

        modelBuilder.Entity<LigneIndSb>(entity =>
        {
            entity.HasKey(e => new { e.IndemniteId, e.CodeGrad, e.NatJurRelTrav });

            entity.ToTable("LigneIndSB", "parametre");

            entity.Property(e => e.IndemniteId).HasColumnName("IndemniteID");
            entity.Property(e => e.CodeGrad).HasMaxLength(4);
            entity.Property(e => e.NatJurRelTrav).HasMaxLength(3);

            entity.HasOne(d => d.Indemnite).WithMany(p => p.LigneIndSbs)
                .HasForeignKey(d => d.IndemniteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LigneIndSB_Indemnites");
        });

        modelBuilder.Entity<LigneMatChap>(entity =>
        {
            entity.HasKey(e => new { e.TypeMatriceId, e.ChapitreId });

            entity.ToTable("LigneMatChap", "parametre");

            entity.Property(e => e.TypeMatriceId).HasColumnName("TypeMatriceID");
            entity.Property(e => e.ChapitreId).HasColumnName("ChapitreID");
            entity.Property(e => e.MtEngag).HasColumnType("money");
            entity.Property(e => e.TypeChap).HasMaxLength(1);

            entity.HasOne(d => d.Chapitre).WithMany(p => p.LigneMatChaps)
                .HasForeignKey(d => d.ChapitreId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LigneMatChap_Chapitres");

            entity.HasOne(d => d.TypeMatrice).WithMany(p => p.LigneMatChaps)
                .HasForeignKey(d => d.TypeMatriceId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LigneMatChap_TypeMatrices");
        });

        modelBuilder.Entity<LigneMatCorpsInd>(entity =>
        {
            entity.HasKey(e => new { e.CleMat, e.CleCorps, e.CleInd });

            entity.ToTable("LigneMatCorpsInd", "parametre");

            entity.HasOne(d => d.CleIndNavigation).WithMany(p => p.LigneMatCorpsInds)
                .HasForeignKey(d => d.CleInd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LigneMatCorpsInd_Indemnites");

            entity.HasOne(d => d.CleMatNavigation).WithMany(p => p.LigneMatCorpsInds)
                .HasForeignKey(d => d.CleMat)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LigneMatCorpsInd_TypeMatrices");
        });

        modelBuilder.Entity<LigneMatCorpsRet>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("LigneMatCorpsRet", "parametre");
        });

        modelBuilder.Entity<LigneMatInd>(entity =>
        {
            entity.HasKey(e => new { e.IndemniteId, e.TypeMatriceId });

            entity.ToTable("LigneMatInd", "parametre");

            entity.Property(e => e.IndemniteId).HasColumnName("IndemniteID");
            entity.Property(e => e.TypeMatriceId).HasColumnName("TypeMatriceID");
            entity.Property(e => e.Beneficiaire).HasMaxLength(2);
            entity.Property(e => e.Cal)
                .HasMaxLength(6)
                .HasColumnName("CAL");
            entity.Property(e => e.CodArt).HasMaxLength(6);
            entity.Property(e => e.CodeChap).HasMaxLength(12);
            entity.Property(e => e.Coim)
                .HasMaxLength(4)
                .HasColumnName("COIM");
            entity.Property(e => e.Ind).HasMaxLength(60);
            entity.Property(e => e.Mat).HasMaxLength(50);
            entity.Property(e => e.Mt).HasColumnType("money");
            entity.Property(e => e.Taux).HasColumnType("money");

            entity.HasOne(d => d.Indemnite).WithMany(p => p.LigneMatInds)
                .HasForeignKey(d => d.IndemniteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LigneMatInd_Indemnites");

            entity.HasOne(d => d.TypeMatrice).WithMany(p => p.LigneMatInds)
                .HasForeignKey(d => d.TypeMatriceId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LigneMatInd_TypeMatrices");
        });

        modelBuilder.Entity<LigneMatIndPeriode>(entity =>
        {
            entity.HasKey(e => new { e.IndemniteId, e.TypeMatriceId, e.PeriodeId });

            entity.ToTable("LigneMatIndPeriode", "parametre");

            entity.Property(e => e.IndemniteId).HasColumnName("IndemniteID");
            entity.Property(e => e.TypeMatriceId).HasColumnName("TypeMatriceID");
            entity.Property(e => e.PeriodeId).HasColumnName("PeriodeID");

            entity.HasOne(d => d.Indemnite).WithMany(p => p.LigneMatIndPeriodes)
                .HasForeignKey(d => d.IndemniteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LigneMatIndPeriode_Indemnites");

            entity.HasOne(d => d.Periode).WithMany(p => p.LigneMatIndPeriodes)
                .HasForeignKey(d => d.PeriodeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LigneMatIndPeriode_PeriodeEngMat");

            entity.HasOne(d => d.TypeMatrice).WithMany(p => p.LigneMatIndPeriodes)
                .HasForeignKey(d => d.TypeMatriceId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LigneMatIndPeriode_TypeMatrices");
        });

        modelBuilder.Entity<Moi>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Mois", "Reference");

            entity.Property(e => e.CodeMois).HasMaxLength(2);
            entity.Property(e => e.Mois).HasMaxLength(15);
        });

        modelBuilder.Entity<Periode>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Periode", "Reference");

            entity.Property(e => e.CodeMois).HasMaxLength(2);
            entity.Property(e => e.Design).HasMaxLength(30);
            entity.Property(e => e.Exe).HasMaxLength(4);
        });

        modelBuilder.Entity<PeriodeEngMat>(entity =>
        {
            entity.HasKey(e => e.PeriodeId);

            entity.ToTable("PeriodeEngMat", "Reference");

            entity.Property(e => e.PeriodeId).HasColumnName("PeriodeID");
            entity.Property(e => e.Aaaa)
                .HasMaxLength(4)
                .HasColumnName("AAAA");
            entity.Property(e => e.Au).HasColumnType("datetime");
            entity.Property(e => e.Du).HasColumnType("datetime");
            entity.Property(e => e.Obs).HasMaxLength(50);
        });

        modelBuilder.Entity<PosteSup>(entity =>
        {
            entity.ToTable("PosteSups", "statutPartic");

            entity.Property(e => e.PosteSupId).HasColumnName("PosteSupID");
            entity.Property(e => e.BonificationId).HasColumnName("BonificationID");
            entity.Property(e => e.FiliereId).HasColumnName("FiliereID");
            entity.Property(e => e.PosteSup1)
                .HasMaxLength(100)
                .HasColumnName("PosteSup");
            entity.Property(e => e.TypePoste).HasMaxLength(1);

            entity.HasOne(d => d.Filiere).WithMany(p => p.PosteSups)
                .HasForeignKey(d => d.FiliereId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PosteSups_Filieres");
        });

        modelBuilder.Entity<TypeMatrix>(entity =>
        {
            entity.HasKey(e => e.TypeMatriceId);

            entity.ToTable("TypeMatrices", "engagement");

            entity.Property(e => e.TypeMatriceId).HasColumnName("TypeMatriceID");
            entity.Property(e => e.Budget).HasMaxLength(100);
            entity.Property(e => e.CalcAbsBrutNetTitre).HasMaxLength(1);
            entity.Property(e => e.CodChapAf)
                .HasMaxLength(12)
                .HasColumnName("CodChapAF");
            entity.Property(e => e.CodChapInd).HasMaxLength(12);
            entity.Property(e => e.CodChapSal).HasMaxLength(12);
            entity.Property(e => e.CodeMat).HasMaxLength(5);
            entity.Property(e => e.CotImp).HasMaxLength(1);
            entity.Property(e => e.ExeAct).HasMaxLength(4);
            entity.Property(e => e.GroupePayePar).HasMaxLength(1);
            entity.Property(e => e.Matrice).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
