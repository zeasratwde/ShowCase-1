namespace AsratShowCase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.StateInfoes",
                c => new
                    {
                        stateID = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        abbreviation = c.String(),
                        capital = c.String(),
                        mostPopulousCity = c.String(),
                        population = c.String(),
                        squareMiles = c.String(),
                        timeZone1 = c.String(),
                        timeZone2 = c.String(),
                        dst = c.String(),
                        stateFlag = c.Binary(),
                        stateSymbol = c.Binary(),
                    })
                .PrimaryKey(t => t.stateID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.StateInfoes");
        }
    }
}
