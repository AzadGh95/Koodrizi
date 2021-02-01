namespace WindowsFormsApp_Koodrizi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EmptyMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Bars", "PistachioName", c => c.String());
            AddColumn("dbo.Bars", "PistachioType", c => c.Boolean(nullable: false));
            AddColumn("dbo.Bars", "Gram", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Bars", "Gram");
            DropColumn("dbo.Bars", "PistachioType");
            DropColumn("dbo.Bars", "PistachioName");
        }
    }
}
