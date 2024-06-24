namespace iCantina.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddEstadoReserva : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Reservas", "estado", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Reservas", "estado");
        }
    }
}
