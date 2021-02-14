namespace WindowsFormsApp_Koodrizi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dellavgModel : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.DKoods", "AvgPersonModel_Id", "dbo.AvgPersonModels");
            DropIndex("dbo.DKoods", new[] { "AvgPersonModel_Id" });
            DropColumn("dbo.DKoods", "AvgPersonModel_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.DKoods", "AvgPersonModel_Id", c => c.Int());
            CreateIndex("dbo.DKoods", "AvgPersonModel_Id");
            AddForeignKey("dbo.DKoods", "AvgPersonModel_Id", "dbo.AvgPersonModels", "Id");
        }
    }
}
