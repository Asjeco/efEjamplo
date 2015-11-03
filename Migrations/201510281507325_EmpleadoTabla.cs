namespace ejercicio01.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EmpleadoTabla : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Empleadoes",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        nommbre = c.String(),
                        sueldo = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Empleadoes");
        }
    }
}
