namespace CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Players",
                c => new
                    {
                        IdP = c.Int(nullable: false, identity: true),
                        NameP = c.String(),
                        Number = c.Int(nullable: false),
                        pos = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdP);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Players");
        }
    }
}
