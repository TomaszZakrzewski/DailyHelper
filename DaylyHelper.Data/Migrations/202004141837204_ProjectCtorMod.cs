namespace DaylyHelper.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProjectCtorMod : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Projects", "Created", c => c.DateTime());
            AlterColumn("dbo.Projects", "Modified", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Projects", "Modified", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Projects", "Created", c => c.DateTime(nullable: false));
        }
    }
}
