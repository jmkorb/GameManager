namespace GameManager.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AnotherMigration1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.GameSystem", "OwnerId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.GameSystem", "OwnerId", c => c.Guid(nullable: false));
        }
    }
}
