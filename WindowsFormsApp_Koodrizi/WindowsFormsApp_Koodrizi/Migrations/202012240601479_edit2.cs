namespace WindowsFormsApp_Koodrizi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class edit2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.People", "Code", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            DropColumn("dbo.People", "Code");
        }
    }
}
