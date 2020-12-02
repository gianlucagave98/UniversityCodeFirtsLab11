namespace UniversityCodeFirts.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.People", "Enable", c => c.Boolean());
            AddColumn("dbo.OfficeAssignments", "Enabled", c => c.Boolean());
        }
        
        public override void Down()
        {
            DropColumn("dbo.OfficeAssignments", "Enabled");
            DropColumn("dbo.People", "Enable");
        }
    }
}
