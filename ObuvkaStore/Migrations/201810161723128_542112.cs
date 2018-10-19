namespace ObuvkaStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _542112 : DbMigration
    {
        public override void Up()
        {
            //AddColumn("dbo.Shoes", "name", c => c.String());
            //AddColumn("dbo.Shoes", "description", c => c.String());
            //DropColumn("dbo.Shoes", "Name_ru");
            //DropColumn("dbo.Shoes", "description_ru");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Shoes", "description_ru", c => c.String());
            AddColumn("dbo.Shoes", "Name_ru", c => c.String());
            DropColumn("dbo.Shoes", "description");
            DropColumn("dbo.Shoes", "name");
        }
    }
}
