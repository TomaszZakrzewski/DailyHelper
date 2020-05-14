namespace DaylyHelper.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modification : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Notes", "MainTask", c => c.String(nullable: false));
            AlterColumn("dbo.Projects", "Title", c => c.String(nullable: false));
            DropColumn("dbo.Projects", "Created");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Projects", "Created", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Projects", "Title", c => c.String());
            AlterColumn("dbo.Notes", "MainTask", c => c.String());
        }
    }
}
