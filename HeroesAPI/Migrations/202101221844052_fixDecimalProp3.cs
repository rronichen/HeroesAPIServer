namespace HeroesAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fixDecimalProp3 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Heroes", "CurrentPower", c => c.Decimal(precision: 12, scale: 5));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Heroes", "CurrentPower", c => c.Decimal(precision: 18, scale: 2));
        }
    }
}
