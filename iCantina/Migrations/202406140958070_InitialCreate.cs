namespace iCantina.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Utilizadors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        NIF = c.Int(nullable: false),
                        Saldo = c.Int(),
                        NumEstudante = c.Int(),
                        Email = c.String(),
                        Username = c.String(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Faturas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Cliente_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Utilizadors", t => t.Cliente_Id)
                .Index(t => t.Cliente_Id);
            
            CreateTable(
                "dbo.ItemFaturas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                        Preco = c.Single(nullable: false),
                        Fatura_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Faturas", t => t.Fatura_Id)
                .Index(t => t.Fatura_Id);
            
            CreateTable(
                "dbo.Reservas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Cliente_Id = c.Int(),
                        Prato_Id = c.Int(),
                        Menu_Id = c.Int(),
                        Multa_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Utilizadors", t => t.Cliente_Id)
                .ForeignKey("dbo.Pratoes", t => t.Prato_Id)
                .ForeignKey("dbo.Menus", t => t.Menu_Id)
                .ForeignKey("dbo.Multas", t => t.Multa_Id)
                .Index(t => t.Cliente_Id)
                .Index(t => t.Prato_Id)
                .Index(t => t.Menu_Id)
                .Index(t => t.Multa_Id);
            
            CreateTable(
                "dbo.Extras",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                        Preco = c.Single(nullable: false),
                        Ativo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Menus",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DataHora = c.DateTime(nullable: false),
                        QtdDisponivel = c.Int(nullable: false),
                        PrecoEstudante = c.Single(nullable: false),
                        PrecoProfessor = c.Single(nullable: false),
                        Prato_Id = c.Int(),
                        Extra_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Pratoes", t => t.Prato_Id)
                .ForeignKey("dbo.Extras", t => t.Extra_Id)
                .Index(t => t.Prato_Id)
                .Index(t => t.Extra_Id);
            
            CreateTable(
                "dbo.QuantidadeExtras",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Quantidade = c.Int(nullable: false),
                        Extra_Id = c.Int(),
                        Menu_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Extras", t => t.Extra_Id)
                .ForeignKey("dbo.Menus", t => t.Menu_Id)
                .Index(t => t.Extra_Id)
                .Index(t => t.Menu_Id);
            
            CreateTable(
                "dbo.QuantidadePratoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Quantidade = c.Int(nullable: false),
                        Menu_Id = c.Int(),
                        Prato_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Menus", t => t.Menu_Id)
                .ForeignKey("dbo.Pratoes", t => t.Prato_Id)
                .Index(t => t.Menu_Id)
                .Index(t => t.Prato_Id);
            
            CreateTable(
                "dbo.Pratoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                        Tipo = c.String(),
                        Ativo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Multas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Valor = c.Single(nullable: false),
                        NumHoras = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ExtraReservas",
                c => new
                    {
                        Extra_Id = c.Int(nullable: false),
                        Reserva_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Extra_Id, t.Reserva_Id })
                .ForeignKey("dbo.Extras", t => t.Extra_Id, cascadeDelete: true)
                .ForeignKey("dbo.Reservas", t => t.Reserva_Id, cascadeDelete: true)
                .Index(t => t.Extra_Id)
                .Index(t => t.Reserva_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reservas", "Multa_Id", "dbo.Multas");
            DropForeignKey("dbo.ExtraReservas", "Reserva_Id", "dbo.Reservas");
            DropForeignKey("dbo.ExtraReservas", "Extra_Id", "dbo.Extras");
            DropForeignKey("dbo.Menus", "Extra_Id", "dbo.Extras");
            DropForeignKey("dbo.Reservas", "Menu_Id", "dbo.Menus");
            DropForeignKey("dbo.QuantidadePratoes", "Prato_Id", "dbo.Pratoes");
            DropForeignKey("dbo.Reservas", "Prato_Id", "dbo.Pratoes");
            DropForeignKey("dbo.Menus", "Prato_Id", "dbo.Pratoes");
            DropForeignKey("dbo.QuantidadePratoes", "Menu_Id", "dbo.Menus");
            DropForeignKey("dbo.QuantidadeExtras", "Menu_Id", "dbo.Menus");
            DropForeignKey("dbo.QuantidadeExtras", "Extra_Id", "dbo.Extras");
            DropForeignKey("dbo.Reservas", "Cliente_Id", "dbo.Utilizadors");
            DropForeignKey("dbo.Faturas", "Cliente_Id", "dbo.Utilizadors");
            DropForeignKey("dbo.ItemFaturas", "Fatura_Id", "dbo.Faturas");
            DropIndex("dbo.ExtraReservas", new[] { "Reserva_Id" });
            DropIndex("dbo.ExtraReservas", new[] { "Extra_Id" });
            DropIndex("dbo.QuantidadePratoes", new[] { "Prato_Id" });
            DropIndex("dbo.QuantidadePratoes", new[] { "Menu_Id" });
            DropIndex("dbo.QuantidadeExtras", new[] { "Menu_Id" });
            DropIndex("dbo.QuantidadeExtras", new[] { "Extra_Id" });
            DropIndex("dbo.Menus", new[] { "Extra_Id" });
            DropIndex("dbo.Menus", new[] { "Prato_Id" });
            DropIndex("dbo.Reservas", new[] { "Multa_Id" });
            DropIndex("dbo.Reservas", new[] { "Menu_Id" });
            DropIndex("dbo.Reservas", new[] { "Prato_Id" });
            DropIndex("dbo.Reservas", new[] { "Cliente_Id" });
            DropIndex("dbo.ItemFaturas", new[] { "Fatura_Id" });
            DropIndex("dbo.Faturas", new[] { "Cliente_Id" });
            DropTable("dbo.ExtraReservas");
            DropTable("dbo.Multas");
            DropTable("dbo.Pratoes");
            DropTable("dbo.QuantidadePratoes");
            DropTable("dbo.QuantidadeExtras");
            DropTable("dbo.Menus");
            DropTable("dbo.Extras");
            DropTable("dbo.Reservas");
            DropTable("dbo.ItemFaturas");
            DropTable("dbo.Faturas");
            DropTable("dbo.Utilizadors");
        }
    }
}
