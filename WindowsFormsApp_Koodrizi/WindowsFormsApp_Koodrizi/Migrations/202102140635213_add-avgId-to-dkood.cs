namespace WindowsFormsApp_Koodrizi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addavgIdtodkood : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DKoods", "AvgPersonId", c => c.Int(nullable: true));
            CreateIndex("dbo.DKoods", "AvgPersonId");
            AddForeignKey("dbo.DKoods", "AvgPersonId", "dbo.AvgPersonModels", "Id", cascadeDelete: false);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DKoods", "AvgPersonId", "dbo.AvgPersonModels");
            DropIndex("dbo.DKoods", new[] { "AvgPersonId" });
            DropColumn("dbo.DKoods", "AvgPersonId");
        }
    }
}
