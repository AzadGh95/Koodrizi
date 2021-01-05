namespace WindowsFormsApp_Koodrizi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deletemigration : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Koodrizis", "KoodId", "dbo.FinalKoodrizis");
            DropIndex("dbo.Koodrizis", new[] { "KoodId" });
            DropPrimaryKey("dbo.Koodrizis");
            AddColumn("dbo.Koodrizis", "FinalKoodId", c => c.Int(nullable: false));
            AlterColumn("dbo.Koodrizis", "KoodId", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Koodrizis", "KoodId");
            CreateIndex("dbo.Koodrizis", "FinalKoodId");
            AddForeignKey("dbo.Koodrizis", "FinalKoodId", "dbo.FinalKoodrizis", "FinalKoodId", cascadeDelete: true);
            DropColumn("dbo.FinalKoodrizis", "Remining");
            DropColumn("dbo.FinalKoodrizis", "KoodId");
            DropColumn("dbo.Koodrizis", "Remining");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Koodrizis", "Remining", c => c.Double(nullable: false));
            AddColumn("dbo.FinalKoodrizis", "KoodId", c => c.Int(nullable: false));
            AddColumn("dbo.FinalKoodrizis", "Remining", c => c.Double(nullable: false));
            DropForeignKey("dbo.Koodrizis", "FinalKoodId", "dbo.FinalKoodrizis");
            DropIndex("dbo.Koodrizis", new[] { "FinalKoodId" });
            DropPrimaryKey("dbo.Koodrizis");
            AlterColumn("dbo.Koodrizis", "KoodId", c => c.Int(nullable: false));
            DropColumn("dbo.Koodrizis", "FinalKoodId");
            AddPrimaryKey("dbo.Koodrizis", "KoodId");
            CreateIndex("dbo.Koodrizis", "KoodId");
            AddForeignKey("dbo.Koodrizis", "KoodId", "dbo.FinalKoodrizis", "FinalKoodId");
        }
    }
}
