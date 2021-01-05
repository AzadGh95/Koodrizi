namespace WindowsFormsApp_Koodrizi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addtofinalkood : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.FinalKoodrizis", "PriceDahanBast", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.FinalKoodrizis", "PriceOunce", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.FinalKoodrizis", "BasePrice", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.FinalKoodrizis", "BasePrice");
            DropColumn("dbo.FinalKoodrizis", "PriceOunce");
            DropColumn("dbo.FinalKoodrizis", "PriceDahanBast");
        }
    }
}
