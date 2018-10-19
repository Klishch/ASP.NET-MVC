namespace ObuvkaStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeTableDBAddProdInfoinProducts : DbMigration
    {
        public override void Up()
        {
            //AddColumn("dbo.Products", "idProductInfo", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            //DropColumn("dbo.Products", "idProductInfo");
        }
    }
}
