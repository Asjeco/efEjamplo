namespace ejercicio01.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class otro : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Empleadoes", "Nombre", c => c.String());
            DropColumn("dbo.Empleadoes", "nommbre");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Empleadoes", "nommbre", c => c.String());
            DropColumn("dbo.Empleadoes", "Nombre");
        }
    }
}
