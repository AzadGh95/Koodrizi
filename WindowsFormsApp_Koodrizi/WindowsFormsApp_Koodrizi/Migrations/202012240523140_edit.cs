namespace WindowsFormsApp_Koodrizi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class edit : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.FinalKoodrizis", "TotalOunce");
        }
        
        public override void Down()
        {
            AddColumn("dbo.FinalKoodrizis", "TotalOnce", c => c.String());
            AddColumn("dbo.FinalKoodrizis", "TotalOunce", c => c.Double(nullable: false));
        }
    }
}
