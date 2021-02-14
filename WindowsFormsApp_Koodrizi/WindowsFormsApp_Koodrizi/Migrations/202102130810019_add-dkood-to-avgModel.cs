namespace WindowsFormsApp_Koodrizi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class adddkoodtoavgModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DKoods", "AvgPersonModel_Id", c => c.Int());
            CreateIndex("dbo.DKoods", "AvgPersonModel_Id");
            AddForeignKey("dbo.DKoods", "AvgPersonModel_Id", "dbo.AvgPersonModels", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DKoods", "AvgPersonModel_Id", "dbo.AvgPersonModels");
            DropIndex("dbo.DKoods", new[] { "AvgPersonModel_Id" });
            DropColumn("dbo.DKoods", "AvgPersonModel_Id");
        }
    }
}
