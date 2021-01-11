namespace WindowsFormsApp_Koodrizi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Adlrem : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.BarModels", "AdlRem", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.BarModels", "AdlRem");
        }
    }
}
