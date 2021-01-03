namespace WindowsFormsApp_Koodrizi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addnew : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Koodrizis", "PercentRoyat", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Koodrizis", "PercentRoyat");
        }
    }
}
