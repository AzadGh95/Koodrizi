namespace WindowsFormsApp_Koodrizi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class edit1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Bars", "DhanBast", c => c.Double(nullable: false));
            AlterColumn("dbo.Bars", "Ounce", c => c.Double(nullable: false));
            DropColumn("dbo.Bars", "Extra");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Bars", "Extra", c => c.Double(nullable: false));
            AlterColumn("dbo.Bars", "Ounce", c => c.String());
            DropColumn("dbo.Bars", "DhanBast");
        }
    }
}
