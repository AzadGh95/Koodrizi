namespace WindowsFormsApp_Koodrizi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deaddavgIdtodkood : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.DKoods", "AvgPersonId", "dbo.AvgPersonModels");
            DropIndex("dbo.DKoods", new[] { "AvgPersonId" });
            DropColumn("dbo.DKoods", "AvgPersonId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.DKoods", "AvgPersonId", c => c.Int(nullable: false));
            CreateIndex("dbo.DKoods", "AvgPersonId");
            AddForeignKey("dbo.DKoods", "AvgPersonId", "dbo.AvgPersonModels", "Id", cascadeDelete: true);
        }
    }
}
