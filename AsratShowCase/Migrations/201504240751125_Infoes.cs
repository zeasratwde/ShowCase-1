namespace AsratShowCase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Infoes : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.StateInfoes", "population", c => c.Int(nullable: false));
            AlterColumn("dbo.StateInfoes", "squareMiles", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.StateInfoes", "squareMiles", c => c.String());
            AlterColumn("dbo.StateInfoes", "population", c => c.String());
        }
    }
}
