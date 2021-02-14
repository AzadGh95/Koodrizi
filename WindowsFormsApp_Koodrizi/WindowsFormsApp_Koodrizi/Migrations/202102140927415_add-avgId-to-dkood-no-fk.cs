namespace WindowsFormsApp_Koodrizi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addavgIdtodkoodnofk : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DKoods", "AvgId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.DKoods", "AvgId");
        }
    }
}
