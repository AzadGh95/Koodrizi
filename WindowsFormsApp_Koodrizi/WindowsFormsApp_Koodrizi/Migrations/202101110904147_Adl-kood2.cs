namespace WindowsFormsApp_Koodrizi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Adlkood2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DKoods", "Adl", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.DKoods", "Adl");
        }
    }
}
