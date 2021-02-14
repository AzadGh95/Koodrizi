namespace WindowsFormsApp_Koodrizi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.AvgPersonModels", "IdPerson", "dbo.People");
            DropIndex("dbo.AvgPersonModels", new[] { "IdPerson" });
            DropColumn("dbo.AvgPersonModels", "IdPerson");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AvgPersonModels", "IdPerson", c => c.Int(nullable: false));
            CreateIndex("dbo.AvgPersonModels", "IdPerson");
            AddForeignKey("dbo.AvgPersonModels", "IdPerson", "dbo.People", "PersonId", cascadeDelete: true);
        }
    }
}
