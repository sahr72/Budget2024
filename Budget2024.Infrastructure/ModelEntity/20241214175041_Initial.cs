using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Budget2024.Infrastructure.ModelEntity
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.EnsureSchema(
            //    name: "budget");

            //migrationBuilder.EnsureSchema(
            //    name: "grille");

            //migrationBuilder.EnsureSchema(
            //    name: "statutPartic");

            //migrationBuilder.EnsureSchema(
            //    name: "Reference");

            //migrationBuilder.EnsureSchema(
            //    name: "parametre");

            //migrationBuilder.EnsureSchema(
            //    name: "engagement");

            //migrationBuilder.CreateTable(
            //    name: "Bonifications",
            //    schema: "grille",
            //    columns: table => new
            //    {
            //        BonificationID = table.Column<int>(type: "int", nullable: false),
            //        INDICE = table.Column<int>(type: "int", nullable: false),
            //        BON = table.Column<decimal>(type: "money", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Bonifications", x => x.BonificationID);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Budgets",
            //    schema: "budget",
            //    columns: table => new
            //    {
            //        BudgetID = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        CODE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
            //        Budget = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
            //        Obs = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Budgets", x => x.BudgetID);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Corps",
            //    schema: "statutPartic",
            //    columns: table => new
            //    {
            //        CleCorps = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        CodeCorps = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
            //        Corps = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Corps", x => x.CleCorps);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "CorpsPrincipals",
            //    schema: "statutPartic",
            //    columns: table => new
            //    {
            //        CorpsPrincipalID = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        CorpsPr = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_CorpsPrincipals", x => x.CorpsPrincipalID);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Exercice",
            //    schema: "Reference",
            //    columns: table => new
            //    {
            //        EXE = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //    });

            //migrationBuilder.CreateTable(
            //    name: "GrilleIEP1s",
            //    schema: "grille",
            //    columns: table => new
            //    {
            //        CODEGRAD = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
            //        ECHELON = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
            //        IEP = table.Column<decimal>(type: "money", nullable: true),
            //        NOTE = table.Column<int>(type: "int", nullable: true),
            //        IEPP = table.Column<decimal>(type: "money", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_GrilleIEP1s", x => new { x.CODEGRAD, x.ECHELON });
            //    });

            //migrationBuilder.CreateTable(
            //    name: "GrilleSBs",
            //    schema: "grille",
            //    columns: table => new
            //    {
            //        CODEGRAD = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
            //        CAT = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
            //        SEC = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
            //        INDICE = table.Column<int>(type: "int", nullable: false),
            //        SB = table.Column<decimal>(type: "money", nullable: false),
            //        ICR = table.Column<decimal>(type: "money", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_GrilleSBs", x => x.CODEGRAD);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "LigneMatCorpsRet",
            //    schema: "parametre",
            //    columns: table => new
            //    {
            //        CleMat = table.Column<int>(type: "int", nullable: true),
            //        CleCorps = table.Column<int>(type: "int", nullable: true),
            //        CleRet = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Mois",
            //    schema: "Reference",
            //    columns: table => new
            //    {
            //        CodeMois = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
            //        Mois = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Periode",
            //    schema: "Reference",
            //    columns: table => new
            //    {
            //        CodeMois = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
            //        Exe = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
            //        Design = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //    });

            //migrationBuilder.CreateTable(
            //    name: "PeriodeEngMat",
            //    schema: "Reference",
            //    columns: table => new
            //    {
            //        PeriodeID = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        AAAA = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
            //        Du = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Au = table.Column<DateTime>(type: "datetime", nullable: true),
            //        NbrMois = table.Column<int>(type: "int", nullable: true),
            //        Obs = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_PeriodeEngMat", x => x.PeriodeID);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "TypeMatrices",
            //    schema: "engagement",
            //    columns: table => new
            //    {
            //        TypeMatriceID = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        CodeMat = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
            //        Matrice = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        Beneficiaire = table.Column<int>(type: "int", nullable: false),
            //        CodChapSal = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
            //        CodChapInd = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
            //        CodChapAF = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
            //        Budget = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
            //        SoumisTitrePer = table.Column<bool>(type: "bit", nullable: false),
            //        CalcAbsBrutNetTitre = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
            //        NbJourHeureMois = table.Column<float>(type: "real", nullable: true),
            //        CotImp = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
            //        GroupePayePar = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
            //        ExeAct = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
            //        OrdreAct = table.Column<short>(type: "smallint", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_TypeMatrices", x => x.TypeMatriceID);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Chapitres",
            //    schema: "budget",
            //    columns: table => new
            //    {
            //        ChapitreID = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        CodeChap = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
            //        Chapitre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        BudgetID = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Chapitres", x => x.ChapitreID);
            //        table.ForeignKey(
            //            name: "FK_Chapitres_Budgets",
            //            column: x => x.BudgetID,
            //            principalSchema: "budget",
            //            principalTable: "Budgets",
            //            principalColumn: "BudgetID");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Filieres",
            //    schema: "statutPartic",
            //    columns: table => new
            //    {
            //        FiliereID = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Filiere = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        CorpsPincipalID = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Filieres", x => x.FiliereID);
            //        table.ForeignKey(
            //            name: "FK_Filieres_CorpsPrincipals",
            //            column: x => x.CorpsPincipalID,
            //            principalSchema: "statutPartic",
            //            principalTable: "CorpsPrincipals",
            //            principalColumn: "CorpsPrincipalID");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "FoncSups",
            //    schema: "statutPartic",
            //    columns: table => new
            //    {
            //        FoncSupID = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        FoncSup = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        CodeGrad = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
            //        Ordre = table.Column<short>(type: "smallint", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_FoncSups", x => x.FoncSupID);
            //        table.ForeignKey(
            //            name: "FK_FoncSups_GrilleSBs",
            //            column: x => x.CodeGrad,
            //            principalSchema: "grille",
            //            principalTable: "GrilleSBs",
            //            principalColumn: "CODEGRAD");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "GrilleIEPs",
            //    schema: "grille",
            //    columns: table => new
            //    {
            //        CODEGRAD = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
            //        ECHELON = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
            //        IEP = table.Column<decimal>(type: "money", nullable: false),
            //        NOTE = table.Column<int>(type: "int", nullable: true),
            //        IEPP = table.Column<decimal>(type: "money", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_GrilleIEPs", x => new { x.CODEGRAD, x.ECHELON });
            //        table.ForeignKey(
            //            name: "FK_GrilleIEPs_GrilleSBs",
            //            column: x => x.CODEGRAD,
            //            principalSchema: "grille",
            //            principalTable: "GrilleSBs",
            //            principalColumn: "CODEGRAD");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Articles",
            //    schema: "budget",
            //    columns: table => new
            //    {
            //        ArticleID = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        CodeArt = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
            //        Article = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        ChapitreID = table.Column<int>(type: "int", nullable: false),
            //        EngIni = table.Column<decimal>(type: "money", nullable: false),
            //        Rattachement = table.Column<decimal>(type: "money", nullable: false),
            //        Reste = table.Column<decimal>(type: "money", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Articles", x => x.ArticleID);
            //        table.ForeignKey(
            //            name: "FK_Articles_Chapitres",
            //            column: x => x.ChapitreID,
            //            principalSchema: "budget",
            //            principalTable: "Chapitres",
            //            principalColumn: "ChapitreID");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "LigneMatChap",
            //    schema: "parametre",
            //    columns: table => new
            //    {
            //        TypeMatriceID = table.Column<int>(type: "int", nullable: false),
            //        ChapitreID = table.Column<int>(type: "int", nullable: false),
            //        OrdChap = table.Column<int>(type: "int", nullable: true),
            //        TypeChap = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true),
            //        MtEngag = table.Column<decimal>(type: "money", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_LigneMatChap", x => new { x.TypeMatriceID, x.ChapitreID });
            //        table.ForeignKey(
            //            name: "FK_LigneMatChap_Chapitres",
            //            column: x => x.ChapitreID,
            //            principalSchema: "budget",
            //            principalTable: "Chapitres",
            //            principalColumn: "ChapitreID");
            //        table.ForeignKey(
            //            name: "FK_LigneMatChap_TypeMatrices",
            //            column: x => x.TypeMatriceID,
            //            principalSchema: "engagement",
            //            principalTable: "TypeMatrices",
            //            principalColumn: "TypeMatriceID");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Corps1s",
            //    schema: "statutPartic",
            //    columns: table => new
            //    {
            //        Corps1ID = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Corps = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        FiliereID = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Corps1s", x => x.Corps1ID);
            //        table.ForeignKey(
            //            name: "FK_Corps1s_Filieres",
            //            column: x => x.FiliereID,
            //            principalSchema: "statutPartic",
            //            principalTable: "Filieres",
            //            principalColumn: "FiliereID");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "PosteSups",
            //    schema: "statutPartic",
            //    columns: table => new
            //    {
            //        PosteSupID = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        PosteSup = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
            //        FiliereID = table.Column<int>(type: "int", nullable: false),
            //        BonificationID = table.Column<int>(type: "int", nullable: false),
            //        TypePoste = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true),
            //        Ordre = table.Column<short>(type: "smallint", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_PosteSups", x => x.PosteSupID);
            //        table.ForeignKey(
            //            name: "FK_PosteSups_Filieres",
            //            column: x => x.FiliereID,
            //            principalSchema: "statutPartic",
            //            principalTable: "Filieres",
            //            principalColumn: "FiliereID");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Indemnites",
            //    schema: "budget",
            //    columns: table => new
            //    {
            //        IndemniteID = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        ArticleID = table.Column<int>(type: "int", nullable: false),
            //        SIG = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
            //        IND = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
            //        TYP = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true),
            //        MVT = table.Column<short>(type: "smallint", nullable: false),
            //        CAL = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
            //        COIM = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
            //        ORDRE = table.Column<int>(type: "int", nullable: true),
            //        TAUX = table.Column<decimal>(type: "money", nullable: false),
            //        Beneficiaire = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
            //        Mt = table.Column<decimal>(type: "money", nullable: false),
            //        SoumisAbs = table.Column<bool>(type: "bit", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Indemnites", x => x.IndemniteID);
            //        table.ForeignKey(
            //            name: "FK_Indemnites_Articles",
            //            column: x => x.ArticleID,
            //            principalSchema: "budget",
            //            principalTable: "Articles",
            //            principalColumn: "ArticleID");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Grades",
            //    schema: "statutPartic",
            //    columns: table => new
            //    {
            //        GradeID = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        CodeGrad = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
            //        Ordre = table.Column<short>(type: "smallint", nullable: false),
            //        Grade = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        Corps1ID = table.Column<int>(type: "int", nullable: false),
            //        Cat = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
            //        Sec = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        IndiceMin = table.Column<int>(type: "int", nullable: false),
            //        Cat311207 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Sec311207 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        IndiceMin311207 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Grades", x => x.GradeID);
            //        table.ForeignKey(
            //            name: "FK_Grades_Corps1s",
            //            column: x => x.Corps1ID,
            //            principalSchema: "statutPartic",
            //            principalTable: "Corps1s",
            //            principalColumn: "Corps1ID");
            //        table.ForeignKey(
            //            name: "FK_Grades_GrilleSBs",
            //            column: x => x.CodeGrad,
            //            principalSchema: "grille",
            //            principalTable: "GrilleSBs",
            //            principalColumn: "CODEGRAD");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "LigneCorpsInd",
            //    schema: "parametre",
            //    columns: table => new
            //    {
            //        IndemniteID = table.Column<int>(type: "int", nullable: false),
            //        Corps1ID = table.Column<int>(type: "int", nullable: false),
            //        NatJurRelTrav = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_LigneCorpsInd", x => new { x.IndemniteID, x.Corps1ID, x.NatJurRelTrav });
            //        table.ForeignKey(
            //            name: "FK_LigneCorpsInd_Corps1s",
            //            column: x => x.Corps1ID,
            //            principalSchema: "statutPartic",
            //            principalTable: "Corps1s",
            //            principalColumn: "Corps1ID");
            //        table.ForeignKey(
            //            name: "FK_LigneCorpsInd_Indemnites",
            //            column: x => x.IndemniteID,
            //            principalSchema: "budget",
            //            principalTable: "Indemnites",
            //            principalColumn: "IndemniteID");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "LigneIndFil",
            //    schema: "parametre",
            //    columns: table => new
            //    {
            //        IndemniteID = table.Column<int>(type: "int", nullable: false),
            //        FiliereID = table.Column<int>(type: "int", nullable: false),
            //        NatJurRelTrav = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_LigneIndFil", x => new { x.IndemniteID, x.FiliereID, x.NatJurRelTrav });
            //        table.ForeignKey(
            //            name: "FK_LigneIndFil_Filieres",
            //            column: x => x.FiliereID,
            //            principalSchema: "statutPartic",
            //            principalTable: "Filieres",
            //            principalColumn: "FiliereID");
            //        table.ForeignKey(
            //            name: "FK_LigneIndFil_Indemnites",
            //            column: x => x.IndemniteID,
            //            principalSchema: "budget",
            //            principalTable: "Indemnites",
            //            principalColumn: "IndemniteID");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "LigneIndGrade",
            //    schema: "parametre",
            //    columns: table => new
            //    {
            //        IndemniteID = table.Column<int>(type: "int", nullable: false),
            //        GradeID = table.Column<int>(type: "int", nullable: false),
            //        NatJurRelTrav = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_LigneIndGrade", x => new { x.IndemniteID, x.GradeID, x.NatJurRelTrav });
            //        table.ForeignKey(
            //            name: "FK_LigneIndGrade_Indemnites",
            //            column: x => x.IndemniteID,
            //            principalSchema: "budget",
            //            principalTable: "Indemnites",
            //            principalColumn: "IndemniteID");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "LigneIndSB",
            //    schema: "parametre",
            //    columns: table => new
            //    {
            //        IndemniteID = table.Column<int>(type: "int", nullable: false),
            //        CodeGrad = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
            //        NatJurRelTrav = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_LigneIndSB", x => new { x.IndemniteID, x.CodeGrad, x.NatJurRelTrav });
            //        table.ForeignKey(
            //            name: "FK_LigneIndSB_Indemnites",
            //            column: x => x.IndemniteID,
            //            principalSchema: "budget",
            //            principalTable: "Indemnites",
            //            principalColumn: "IndemniteID");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "LigneMatCorpsInd",
            //    schema: "parametre",
            //    columns: table => new
            //    {
            //        CleMat = table.Column<int>(type: "int", nullable: false),
            //        CleCorps = table.Column<int>(type: "int", nullable: false),
            //        CleInd = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_LigneMatCorpsInd", x => new { x.CleMat, x.CleCorps, x.CleInd });
            //        table.ForeignKey(
            //            name: "FK_LigneMatCorpsInd_Indemnites",
            //            column: x => x.CleInd,
            //            principalSchema: "budget",
            //            principalTable: "Indemnites",
            //            principalColumn: "IndemniteID");
            //        table.ForeignKey(
            //            name: "FK_LigneMatCorpsInd_TypeMatrices",
            //            column: x => x.CleMat,
            //            principalSchema: "engagement",
            //            principalTable: "TypeMatrices",
            //            principalColumn: "TypeMatriceID");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "LigneMatInd",
            //    schema: "parametre",
            //    columns: table => new
            //    {
            //        IndemniteID = table.Column<int>(type: "int", nullable: false),
            //        TypeMatriceID = table.Column<int>(type: "int", nullable: false),
            //        OrdInd = table.Column<int>(type: "int", nullable: true),
            //        Page = table.Column<int>(type: "int", nullable: true),
            //        Ind = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
            //        Mat = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        CodeChap = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
            //        CodArt = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: true),
            //        Taux = table.Column<decimal>(type: "money", nullable: true),
            //        Mt = table.Column<decimal>(type: "money", nullable: true),
            //        Mvt = table.Column<short>(type: "smallint", nullable: true),
            //        COIM = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
            //        CAL = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: true),
            //        Beneficiaire = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
            //        SoumisAbs = table.Column<bool>(type: "bit", nullable: false),
            //        CleArt = table.Column<int>(type: "int", nullable: true),
            //        CleChap = table.Column<int>(type: "int", nullable: true),
            //        CleBudget = table.Column<float>(type: "real", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_LigneMatInd", x => new { x.IndemniteID, x.TypeMatriceID });
            //        table.ForeignKey(
            //            name: "FK_LigneMatInd_Indemnites",
            //            column: x => x.IndemniteID,
            //            principalSchema: "budget",
            //            principalTable: "Indemnites",
            //            principalColumn: "IndemniteID");
            //        table.ForeignKey(
            //            name: "FK_LigneMatInd_TypeMatrices",
            //            column: x => x.TypeMatriceID,
            //            principalSchema: "engagement",
            //            principalTable: "TypeMatrices",
            //            principalColumn: "TypeMatriceID");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "LigneMatIndPeriode",
            //    schema: "parametre",
            //    columns: table => new
            //    {
            //        IndemniteID = table.Column<int>(type: "int", nullable: false),
            //        TypeMatriceID = table.Column<int>(type: "int", nullable: false),
            //        PeriodeID = table.Column<int>(type: "int", nullable: false),
            //        OrdInd = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_LigneMatIndPeriode", x => new { x.IndemniteID, x.TypeMatriceID, x.PeriodeID });
            //        table.ForeignKey(
            //            name: "FK_LigneMatIndPeriode_Indemnites",
            //            column: x => x.IndemniteID,
            //            principalSchema: "budget",
            //            principalTable: "Indemnites",
            //            principalColumn: "IndemniteID");
            //        table.ForeignKey(
            //            name: "FK_LigneMatIndPeriode_PeriodeEngMat",
            //            column: x => x.PeriodeID,
            //            principalSchema: "Reference",
            //            principalTable: "PeriodeEngMat",
            //            principalColumn: "PeriodeID");
            //        table.ForeignKey(
            //            name: "FK_LigneMatIndPeriode_TypeMatrices",
            //            column: x => x.TypeMatriceID,
            //            principalSchema: "engagement",
            //            principalTable: "TypeMatrices",
            //            principalColumn: "TypeMatriceID");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "LigneGradeMat",
            //    schema: "parametre",
            //    columns: table => new
            //    {
            //        GradeID = table.Column<int>(type: "int", nullable: false),
            //        TypeMatriceID = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_LigneGradeMat", x => new { x.GradeID, x.TypeMatriceID });
            //        table.ForeignKey(
            //            name: "FK_LigneGradeMat_Grades",
            //            column: x => x.GradeID,
            //            principalSchema: "statutPartic",
            //            principalTable: "Grades",
            //            principalColumn: "GradeID");
            //        table.ForeignKey(
            //            name: "FK_LigneGradeMat_TypeMatrices",
            //            column: x => x.TypeMatriceID,
            //            principalSchema: "engagement",
            //            principalTable: "TypeMatrices",
            //            principalColumn: "TypeMatriceID");
            //    });

            //migrationBuilder.CreateIndex(
            //    name: "IX_Articles_ChapitreID",
            //    schema: "budget",
            //    table: "Articles",
            //    column: "ChapitreID");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Chapitres_BudgetID",
            //    schema: "budget",
            //    table: "Chapitres",
            //    column: "BudgetID");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Corps1s_FiliereID",
            //    schema: "statutPartic",
            //    table: "Corps1s",
            //    column: "FiliereID");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Filieres_CorpsPincipalID",
            //    schema: "statutPartic",
            //    table: "Filieres",
            //    column: "CorpsPincipalID");

            //migrationBuilder.CreateIndex(
            //    name: "IX_FoncSups_CodeGrad",
            //    schema: "statutPartic",
            //    table: "FoncSups",
            //    column: "CodeGrad");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Grades_CodeGrad",
            //    schema: "statutPartic",
            //    table: "Grades",
            //    column: "CodeGrad");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Grades_Corps1ID",
            //    schema: "statutPartic",
            //    table: "Grades",
            //    column: "Corps1ID");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Indemnites_ArticleID",
            //    schema: "budget",
            //    table: "Indemnites",
            //    column: "ArticleID");

            //migrationBuilder.CreateIndex(
            //    name: "IX_LigneCorpsInd_Corps1ID",
            //    schema: "parametre",
            //    table: "LigneCorpsInd",
            //    column: "Corps1ID");

            //migrationBuilder.CreateIndex(
            //    name: "IX_LigneGradeMat_TypeMatriceID",
            //    schema: "parametre",
            //    table: "LigneGradeMat",
            //    column: "TypeMatriceID");

            //migrationBuilder.CreateIndex(
            //    name: "IX_LigneIndFil_FiliereID",
            //    schema: "parametre",
            //    table: "LigneIndFil",
            //    column: "FiliereID");

            //migrationBuilder.CreateIndex(
            //    name: "IX_LigneMatChap_ChapitreID",
            //    schema: "parametre",
            //    table: "LigneMatChap",
            //    column: "ChapitreID");

            //migrationBuilder.CreateIndex(
            //    name: "IX_LigneMatCorpsInd_CleInd",
            //    schema: "parametre",
            //    table: "LigneMatCorpsInd",
            //    column: "CleInd");

            //migrationBuilder.CreateIndex(
            //    name: "IX_LigneMatInd_TypeMatriceID",
            //    schema: "parametre",
            //    table: "LigneMatInd",
            //    column: "TypeMatriceID");

            //migrationBuilder.CreateIndex(
            //    name: "IX_LigneMatIndPeriode_PeriodeID",
            //    schema: "parametre",
            //    table: "LigneMatIndPeriode",
            //    column: "PeriodeID");

            //migrationBuilder.CreateIndex(
            //    name: "IX_LigneMatIndPeriode_TypeMatriceID",
            //    schema: "parametre",
            //    table: "LigneMatIndPeriode",
            //    column: "TypeMatriceID");

            //migrationBuilder.CreateIndex(
            //    name: "IX_PosteSups_FiliereID",
            //    schema: "statutPartic",
            //    table: "PosteSups",
            //    column: "FiliereID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
          /*  migrationBuilder.DropTable(
                name: "Bonifications",
                schema: "grille");

            migrationBuilder.DropTable(
                name: "Corps",
                schema: "statutPartic");

            migrationBuilder.DropTable(
                name: "Exercice",
                schema: "Reference");

            migrationBuilder.DropTable(
                name: "FoncSups",
                schema: "statutPartic");

            migrationBuilder.DropTable(
                name: "GrilleIEP1s",
                schema: "grille");

            migrationBuilder.DropTable(
                name: "GrilleIEPs",
                schema: "grille");

            migrationBuilder.DropTable(
                name: "LigneCorpsInd",
                schema: "parametre");

            migrationBuilder.DropTable(
                name: "LigneGradeMat",
                schema: "parametre");

            migrationBuilder.DropTable(
                name: "LigneIndFil",
                schema: "parametre");

            migrationBuilder.DropTable(
                name: "LigneIndGrade",
                schema: "parametre");

            migrationBuilder.DropTable(
                name: "LigneIndSB",
                schema: "parametre");

            migrationBuilder.DropTable(
                name: "LigneMatChap",
                schema: "parametre");

            migrationBuilder.DropTable(
                name: "LigneMatCorpsInd",
                schema: "parametre");

            migrationBuilder.DropTable(
                name: "LigneMatCorpsRet",
                schema: "parametre");

            migrationBuilder.DropTable(
                name: "LigneMatInd",
                schema: "parametre");

            migrationBuilder.DropTable(
                name: "LigneMatIndPeriode",
                schema: "parametre");

            migrationBuilder.DropTable(
                name: "Mois",
                schema: "Reference");

            migrationBuilder.DropTable(
                name: "Periode",
                schema: "Reference");

            migrationBuilder.DropTable(
                name: "PosteSups",
                schema: "statutPartic");

            migrationBuilder.DropTable(
                name: "Grades",
                schema: "statutPartic");

            migrationBuilder.DropTable(
                name: "Indemnites",
                schema: "budget");

            migrationBuilder.DropTable(
                name: "PeriodeEngMat",
                schema: "Reference");

            migrationBuilder.DropTable(
                name: "TypeMatrices",
                schema: "engagement");

            migrationBuilder.DropTable(
                name: "Corps1s",
                schema: "statutPartic");

            migrationBuilder.DropTable(
                name: "GrilleSBs",
                schema: "grille");

            migrationBuilder.DropTable(
                name: "Articles",
                schema: "budget");

            migrationBuilder.DropTable(
                name: "Filieres",
                schema: "statutPartic");

            migrationBuilder.DropTable(
                name: "Chapitres",
                schema: "budget");

            migrationBuilder.DropTable(
                name: "CorpsPrincipals",
                schema: "statutPartic");

            migrationBuilder.DropTable(
                name: "Budgets",
                schema: "budget");
          */
        }
          
    }
}
