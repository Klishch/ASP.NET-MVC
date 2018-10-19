namespace ObuvkaStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _54454545 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Products", "name", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Products", "name", c => c.String(nullable: false, maxLength: 50, unicode: true));
        }
    }
}
