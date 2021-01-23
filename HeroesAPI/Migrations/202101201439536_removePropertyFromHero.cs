namespace HeroesAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removePropertyFromHero : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Heroes", "guidId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Heroes", "guidId", c => c.Int(nullable: false));
        }
    }
}
