namespace HeroesAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeDateType : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Heroes", "DateTimeStartTrain", c => c.DateTime());
            AlterColumn("dbo.Heroes", "StartingPower", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.Heroes", "CurrentPower", c => c.Decimal(precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Heroes", "CurrentPower", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Heroes", "StartingPower", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Heroes", "DateTimeStartTrain", c => c.DateTime(nullable: false));
        }
    }
}
