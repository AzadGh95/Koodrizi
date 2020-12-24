namespace WindowsFormsApp_Koodrizi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class edit1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.FinalKoodrizis", "TotalOunce", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.FinalKoodrizis", "TotalOunce");
        }
    }
}
