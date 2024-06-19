namespace iCantina.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeSaldoTypeToFloat : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Utilizadors", "Saldo", c => c.Single());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Utilizadors", "Saldo", c => c.Int());
        }
    }
}
