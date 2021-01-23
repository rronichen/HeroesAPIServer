namespace HeroesAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removePropertiyFromHero : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Heroes", "DateTimeStartTrain");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Heroes", "DateTimeStartTrain", c => c.DateTime());
        }
    }
}
