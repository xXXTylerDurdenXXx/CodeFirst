namespace CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class team : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Teams",
                c => new
                    {
                        IdT = c.Int(nullable: false, identity: true),
                        NameT = c.String(),
                        IdP = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdT)
                .ForeignKey("dbo.Players", t => t.IdP, cascadeDelete: true)
                .Index(t => t.IdP);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Teams", "IdP", "dbo.Players");
            DropIndex("dbo.Teams", new[] { "IdP" });
            DropTable("dbo.Teams");
        }
    }
}
