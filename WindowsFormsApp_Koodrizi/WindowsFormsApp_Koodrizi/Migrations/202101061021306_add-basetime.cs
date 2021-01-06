namespace WindowsFormsApp_Koodrizi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addbasetime : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PersonModels", "BaseDate", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
        }
        
        public override void Down()
        {
            DropColumn("dbo.PersonModels", "BaseDate");
        }
    }
}
