namespace HeroesAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fixDecimalProp : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Heroes", "StartingPower", c => c.Decimal(precision: 18, scale: 6));
            AlterColumn("dbo.Heroes", "CurrentPower", c => c.Decimal(precision: 18, scale: 6));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Heroes", "CurrentPower", c => c.Int());
            AlterColumn("dbo.Heroes", "StartingPower", c => c.Int());
        }
    }
}
