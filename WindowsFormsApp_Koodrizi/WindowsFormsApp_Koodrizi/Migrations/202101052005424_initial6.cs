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
                "dbo.Bars",
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
                .ForeignKey("dbo.People", t => t.IdPerson, cascadeDelete: true)
                .Index(t => t.IdPerson);
            
            CreateTable(
                "dbo.People",
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
                "dbo.DetailsKoods",
                c => new
                    {
                        DetailId = c.Int(nullable: false, identity: true),
                        KoodId = c.Int(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Weight = c.Double(nullable: false),
                        SellDate = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        ArrivedDate = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        CreateDate = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        PercentRoyat = c.Double(nullable: false),
                        BarId = c.Int(nullable: false),
                        FinalKoodId = c.Int(nullable: false),
                        zarib = c.Double(nullable: false),
                        baseOunce = c.Double(nullable: false),
                        baseDahanBast = c.Double(nullable: false),
                        basePercentRoyat = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.DetailId)
                .ForeignKey("dbo.Bars", t => t.BarId, cascadeDelete: true)
                .ForeignKey("dbo.FinalKoodrizis", t => t.FinalKoodId, cascadeDelete: true)
                .Index(t => t.BarId)
                .Index(t => t.FinalKoodId);
            
            CreateTable(
                "dbo.FinalKoodrizis",
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
            
            CreateTable(
                "dbo.DKoods",
                c => new
                    {
                        DId = c.Int(nullable: false, identity: true),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Weight = c.Double(nullable: false),
                        SellDate = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        ArrivedDate = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        CreateDate = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        PercentRoyat = c.Double(nullable: false),
                        BarId = c.Int(nullable: false),
                        FinalKoodId = c.Int(nullable: false),
                        Zarib = c.Double(nullable: false),
                        BaseOunce = c.Double(nullable: false),
                        BaseDahanBast = c.Double(nullable: false),
                        BasePercentRoyat = c.Double(nullable: false),
                        extra = c.String(),
                    })
                .PrimaryKey(t => t.DId)
                .ForeignKey("dbo.BarModels", t => t.BarId, cascadeDelete: true)
                .ForeignKey("dbo.FinalKoodriziModels", t => t.FinalKoodId, cascadeDelete: true)
                .Index(t => t.BarId)
                .Index(t => t.FinalKoodId);
            
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
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DKoods", "FinalKoodId", "dbo.FinalKoodriziModels");
            DropForeignKey("dbo.DKoods", "BarId", "dbo.BarModels");
            DropForeignKey("dbo.DetailsKoods", "FinalKoodId", "dbo.FinalKoodrizis");
            DropForeignKey("dbo.DetailsKoods", "BarId", "dbo.Bars");
            DropForeignKey("dbo.Bars", "IdPerson", "dbo.People");
            DropForeignKey("dbo.BarModels", "IdPerson", "dbo.PersonModels");
            DropIndex("dbo.DKoods", new[] { "FinalKoodId" });
            DropIndex("dbo.DKoods", new[] { "BarId" });
            DropIndex("dbo.DetailsKoods", new[] { "FinalKoodId" });
            DropIndex("dbo.DetailsKoods", new[] { "BarId" });
            DropIndex("dbo.Bars", new[] { "IdPerson" });
            DropIndex("dbo.BarModels", new[] { "IdPerson" });
            DropTable("dbo.FinalKoodriziModels");
            DropTable("dbo.DKoods");
            DropTable("dbo.FinalKoodrizis");
            DropTable("dbo.DetailsKoods");
            DropTable("dbo.People");
            DropTable("dbo.Bars");
            DropTable("dbo.PersonModels");
            DropTable("dbo.BarModels");
        }
    }
}
