﻿namespace CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Country : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Players", "Country", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Players", "Country");
        }
    }
}
