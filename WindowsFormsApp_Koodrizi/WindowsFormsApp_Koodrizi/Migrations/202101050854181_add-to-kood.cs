namespace WindowsFormsApp_Koodrizi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addtokood : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Koodrizis", "zarib", c => c.Double(nullable: false));
            AddColumn("dbo.Koodrizis", "baseOunce", c => c.Double(nullable: false));
            AddColumn("dbo.Koodrizis", "baseDahanBast", c => c.Double(nullable: false));
            AddColumn("dbo.Koodrizis", "basePercentRoyat", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Koodrizis", "basePercentRoyat");
            DropColumn("dbo.Koodrizis", "baseDahanBast");
            DropColumn("dbo.Koodrizis", "baseOunce");
            DropColumn("dbo.Koodrizis", "zarib");
        }
    }
}
