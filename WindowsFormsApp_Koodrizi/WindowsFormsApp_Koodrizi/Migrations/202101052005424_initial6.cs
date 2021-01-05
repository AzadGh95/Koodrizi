namespace WindowsFormsApp_Koodrizi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial6 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BarModels",
                c => new
                    {
                        BarId = c.Int(nullable: false, identity: true),
                        CreateDate = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        TotalWeight = c.Double(nullable: false),
                        Remaining = c.Double(nullable: false),
                        Ounce = c.Double(nullable: false),
                        IsLock = c.Boolean(nullable: false),
                        IdPerson = c.Int(nullable: false),
                        Adl = c.Double(nullable: false),
                        DhanBast = c.Double(nullable: false),
                        PistachioName = c.String(),
                        PistachioType = c.Boolean(nullable: false),
                        Gram = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.BarId)
                .ForeignKey("dbo.PersonModels", t => t.IdPerson, cascadeDelete: true)
                .Index(t => t.IdPerson);
            
            CreateTable(
                "dbo.PersonModels",
                c => new
                    {
                        PersonId = c.Int(nullable: false, identity: true),
                        Code = c.String(maxLength: 50),
                        Name = c.String(maxLength: 300),
                        PhoneNumber = c.String(maxLength: 50),
                        Total = c.Decimal(nullable: false, precision: 18, scale: 2),
                        AvgDate = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        CreateDate = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        Bedehi = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.PersonId);
            
            CreateTable(
                "dbo.FinalKoodriziModels",
                c => new
                    {
                        FinalKoodId = c.Int(nullable: false, identity: true),
                        KoodName = c.String(),
                        KoodNumber = c.String(),
                        TotalPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TotalOunce = c.String(),
                        CreateDate = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        TotalWeight = c.Double(nullable: false),
                        PriceDahanBast = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PriceOunce = c.Decimal(nullable: false, precision: 18, scale: 2),
                        BasePrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.FinalKoodId);
            
            AddColumn("dbo.DKoods", "BarId", c => c.Int(nullable: false));
            AddColumn("dbo.DKoods", "FinalKoodId", c => c.Int(nullable: false));
            CreateIndex("dbo.DKoods", "BarId");
            CreateIndex("dbo.DKoods", "FinalKoodId");
            AddForeignKey("dbo.DKoods", "BarId", "dbo.BarModels", "BarId", cascadeDelete: true);
            AddForeignKey("dbo.DKoods", "FinalKoodId", "dbo.FinalKoodriziModels", "FinalKoodId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DKoods", "FinalKoodId", "dbo.FinalKoodriziModels");
            DropForeignKey("dbo.DKoods", "BarId", "dbo.BarModels");
            DropForeignKey("dbo.BarModels", "IdPerson", "dbo.PersonModels");
            DropIndex("dbo.DKoods", new[] { "FinalKoodId" });
            DropIndex("dbo.DKoods", new[] { "BarId" });
            DropIndex("dbo.BarModels", new[] { "IdPerson" });
            DropColumn("dbo.DKoods", "FinalKoodId");
            DropColumn("dbo.DKoods", "BarId");
            DropTable("dbo.FinalKoodriziModels");
            DropTable("dbo.PersonModels");
            DropTable("dbo.BarModels");
        }
    }
}
