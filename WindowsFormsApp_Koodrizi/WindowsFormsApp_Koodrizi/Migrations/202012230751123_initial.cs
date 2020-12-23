namespace WindowsFormsApp_Koodrizi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bars",
                c => new
                    {
                        BarId = c.Int(nullable: false, identity: true),
                        CreateDate = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        TotalWeight = c.Double(nullable: false),
                        Remaining = c.Double(nullable: false),
                        Ounce = c.String(),
                        IsLock = c.Boolean(nullable: false),
                        IdPerson = c.Int(nullable: false),
                        Adl = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.BarId)
                .ForeignKey("dbo.People", t => t.IdPerson, cascadeDelete: true)
                .Index(t => t.IdPerson);
            
            CreateTable(
                "dbo.People",
                c => new
                    {
                        PersonId = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 300),
                        PhoneNumber = c.String(maxLength: 50),
                        Total = c.Decimal(nullable: false, precision: 18, scale: 2),
                        AvgDate = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        CreateDate = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                    })
                .PrimaryKey(t => t.PersonId);
            
            CreateTable(
                "dbo.FinalKoodrizis",
                c => new
                    {
                        FinalKoodId = c.Int(nullable: false, identity: true),
                        KoodName = c.String(),
                        KoodNumber = c.String(),
                        TotalPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TotalOunce = c.Double(nullable: false),
                        CreateDate = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        TotalWeight = c.Double(nullable: false),
                        KoodId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.FinalKoodId);
            
            CreateTable(
                "dbo.Koodrizis",
                c => new
                    {
                        KoodId = c.Int(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Weight = c.Double(nullable: false),
                        SellDate = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        ArrivedDate = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        CreateDate = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        BarId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.KoodId)
                .ForeignKey("dbo.Bars", t => t.BarId, cascadeDelete: true)
                .ForeignKey("dbo.FinalKoodrizis", t => t.KoodId)
                .Index(t => t.KoodId)
                .Index(t => t.BarId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Koodrizis", "KoodId", "dbo.FinalKoodrizis");
            DropForeignKey("dbo.Koodrizis", "BarId", "dbo.Bars");
            DropForeignKey("dbo.Bars", "IdPerson", "dbo.People");
            DropIndex("dbo.Koodrizis", new[] { "BarId" });
            DropIndex("dbo.Koodrizis", new[] { "KoodId" });
            DropIndex("dbo.Bars", new[] { "IdPerson" });
            DropTable("dbo.Koodrizis");
            DropTable("dbo.FinalKoodrizis");
            DropTable("dbo.People");
            DropTable("dbo.Bars");
        }
    }
}
