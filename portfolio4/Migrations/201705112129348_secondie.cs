namespace portfolio4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class secondie : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Projects", "projectImage", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Projects", "projectImage");
        }
    }
}
