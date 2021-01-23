namespace HeroesAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addData : DbMigration
    {
        public override void Up()
        {
        }
        
        public override void Down()
        {
            Sql("INSERT INTO herows (name, ability, guidId,  SuitColor, StartingPower) " +
                "VALUES(ssss, hhhh, 555, bbb, 5.55); ");
        }
    }
}
