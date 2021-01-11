namespace WindowsFormsApp_Koodrizi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Adlkood : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DetailsKoods", "Adl", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.DetailsKoods", "Adl");
        }
    }
}
