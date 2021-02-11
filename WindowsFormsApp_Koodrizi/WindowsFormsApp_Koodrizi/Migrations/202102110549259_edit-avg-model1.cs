namespace WindowsFormsApp_Koodrizi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class editavgmodel1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AvgPersonModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdPerson = c.Int(nullable: false),
                        Bedehi = c.Decimal(nullable: false, precision: 18, scale: 2),
                        AvgDate = c.DateTime(nullable: false),
                        CreatDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.People", t => t.IdPerson, cascadeDelete: true)
                .Index(t => t.IdPerson);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AvgPersonModels", "IdPerson", "dbo.People");
            DropIndex("dbo.AvgPersonModels", new[] { "IdPerson" });
            DropTable("dbo.AvgPersonModels");
        }
    }
}
