namespace HeroesAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add2PropertiesToHero : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Heroes", "dateLastTrain", c => c.DateTime());
            AddColumn("dbo.Heroes", "timesTrainsToday", c => c.Short());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Heroes", "timesTrainsToday");
            DropColumn("dbo.Heroes", "dateLastTrain");
        }
    }
}
